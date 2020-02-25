using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FdsCodeLib
{
    /// <summary>
    /// Class to represent complete FDS data file.
    /// </summary>
    public class FdsFile
    {

        /// <summary>
        /// Path to file.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Master validity switch.
        /// </summary>
        public bool IsValidFile { get; private set; }

        /// <summary>
        /// Validation error.
        /// </summary>
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Original file contents.
        /// </summary>
        public List<string> FileContents { get; private set; }

        /// <summary>
        /// List of command objects.
        /// </summary>
        public List<FdsCmd> Commands { get; private set; }

        /// <summary>
        /// Unique file ID.
        /// </summary>
        public string ChId { get; private set; }

        /// <summary>
        /// Title of file.
        /// </summary>
        public string Title { get; private set; } = "";

        /// <summary>
        /// Master restart flag.
        /// </summary>
        public bool IsRestart { get; private set; }

        /// <summary>
        /// Constructor using file location.
        /// </summary>
        /// <param name="filePath">Path to FDS data file.</param>
        public FdsFile(string filePath) { LoadFile(filePath); }

        /// <summary>
        /// Method to load FDS data file into memory.
        /// </summary>
        public void LoadFile() { LoadFile(FilePath); }

        /// <summary>
        /// Method to load file using named file path.
        /// </summary>
        /// <param name="filePath">File path.</param>
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
            foreach (string line in FileContents)
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
        /// Method to group file lines into separate commands, using &amp; and / characters as
        /// start and end points.
        /// </summary>
        private void ParseCommands()
        {
            // Start state machine
            string state = "";
            int commandNum = 0;
            int lineNum = 0;
            int startNum = 0;
            int endNum = 0;
            List<string> originalLines = new List<string>();
            Commands = new List<FdsCmd>();

            foreach (string line in FileContents)
            {
                lineNum++;

                string myLine = line;

                // Remove white space from start and end of line
                myLine = myLine.Trim();

                // Single line command
                if (state == "" && myLine.StartsWith("&") && myLine.EndsWith("/"))
                {
                    startNum = lineNum;
                    endNum = lineNum;
                    originalLines = new List<string>
                    {
                        myLine
                    };
                    commandNum++;
                    FdsCmd fdsCmd = FdsCmdFactory.Create(originalLines, startNum, endNum, commandNum);
                    Commands.Add(fdsCmd);
                    continue;
                }

                // Detect start of multi-line command
                if (state == "" && myLine.StartsWith("&") && !myLine.EndsWith("/"))
                {
                    // Clear out command line and remove &
                    startNum = lineNum;
                    originalLines = new List<string>
                    {
                        myLine
                    };
                    state = "CMD";
                    continue;
                }

                // Intermediate command line
                if (state == "CMD" && !myLine.StartsWith("&") && !myLine.EndsWith("/"))
                {
                    originalLines.Add(myLine);
                }

                // End of multi-line command
                if (state == "CMD" && !myLine.StartsWith("&") && myLine.EndsWith("/"))
                {
                    originalLines.Add(myLine);
                    endNum = lineNum;
                    commandNum++;
                    state = "";
                    FdsCmd fdsCmd = FdsCmdFactory.Create(originalLines, startNum, endNum, commandNum);
                    Commands.Add(fdsCmd);
                }

            }

            // TODO: Detect mismatching & and /
        }

    }
}
