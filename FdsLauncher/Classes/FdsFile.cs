using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FdsLauncher
{
    public class FdsFile
    {

        // Parameters
        public string FilePath { get; private set; }

        public bool IsValidFile { get; private set; }

        public string ErrorMessage { get; private set; }

        public List<string> FileContents { get; private set; }

        public List<string> CommandLines { get; private set; }

        public string ChId { get; private set; }

        public string Title { get; private set; } = "";

        public bool IsRestart { get; private set; }

        // Constructor
        public FdsFile(string filePath) { LoadFile(filePath); }

        // Method to load and parse existing file
        public void LoadFile() { LoadFile(FilePath); }

        // Method to load and parse named file
        private void LoadFile(string filePath)
        {
            // Reset parameters
            FilePath = filePath;
            IsValidFile = false;
            ChId = "";
            IsRestart = false;

            // Check for file existance
            if (!File.Exists(FilePath)) { return; }

            // Load file into local collection
            FileContents = new List<string>();

            string[] lines;
            try
            {
                lines = File.ReadAllLines(FilePath);
            }
            catch (Exception e)
            {
                ErrorMessage = "Problem reading " + FilePath + "/n" + e.Message;
                return;
            }

            FileContents = lines.ToList();

            // Parse file lines into separate commands lines
            ParseCommands();

            // TODO: Parse file for parameters
            foreach (string line in CommandLines)
            {
                // Look for HEAD, CHID and TITLE
                if (line.StartsWith("HEAD"))
                {
                    Regex filter = new Regex(@"CHID='[^']*'");
                    Match match = filter.Match(line);
                    string val = match.Value.Replace("CHID=", "").Trim('\'');

                    if (match.Success) { ChId = val; }

                    Regex filter2 = new Regex(@"TITLE='[^']*'");
                    Match match2 = filter2.Match(line);
                    string val2 = match2.Value.Replace("TITLE=", "").Trim('\'');

                    if (match2.Success) { Title = val2; }
                }

                // Look for RESTART flag
                if (line.StartsWith("&MISC") && line.Contains("RESTART=.TRUE."))
                {
                    IsRestart = true;
                }

            }

            // Check file is valid
            if (ChId != "")
            {
                IsValidFile = true;
            }
        }

        /// <summary>
        /// Method to group file lines into separate commands, using & and / characters as
        /// start and end points.
        /// </summary>
        private void ParseCommands()
        {
            // Start state machine
            string commandLine = "";
            string state = "";
            CommandLines = new List<string>();

            foreach (string line in FileContents)
            {
                string myLine = line;

                // Remove white space from start and end of line
                myLine = myLine.Trim();

                // Single line command
                if (state == "" && myLine.StartsWith("&") && myLine.EndsWith("/"))
                {
                    commandLine = myLine.TrimStart('&').TrimEnd('/').Trim();
                    CommandLines.Add(commandLine);
                }

                // Detect start of multi-line command
                if (state == "" && myLine.StartsWith("&") && !myLine.EndsWith("/"))
                {
                    // Clear out command line and remove &
                    commandLine = myLine.TrimStart('&').Trim();
                    state = "CMD";
                }

                // Intermediate command line
                if (state == "CMD" && !myLine.StartsWith("&") && !myLine.EndsWith("/"))
                {
                    if (!commandLine.EndsWith(",") && !myLine.StartsWith(",") &&
                        myLine != "")
                    {
                        commandLine += ",";
                    }
                    commandLine += myLine;
                }

                // End of multi-line command
                if (state == "CMD" && !myLine.StartsWith("&") && myLine.EndsWith("/"))
                {
                    if (!commandLine.EndsWith(",") && !myLine.StartsWith(",") &&
                        !myLine.StartsWith("/"))
                    {
                        commandLine += ",";
                    }
                    commandLine += myLine.TrimEnd('/').Trim();
                    CommandLines.Add(commandLine);
                    state = "";
                }

            }

            // TODO: Detect mismatching & and /
        }

    }
}
