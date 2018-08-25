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
                // Look for HEAD and CHID
                if (line.StartsWith("&HEAD"))
                {
                    Regex filter = new Regex(@"'[^']*'");

                    Match match = filter.Match(line);
                    if (match.Success) { ChId = match.Value.Trim('\''); }
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
