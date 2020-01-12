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

            // TODO: Parse file for parameters
            foreach (string line in FileContents)
            {
                // Look for HEAD, CHID and TITLE
                if (line.StartsWith("&HEAD"))
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

    }
}
