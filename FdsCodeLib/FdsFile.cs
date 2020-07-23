using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        /// Reference to HEAD section.
        /// </summary>
        public FdsCmdHead HeadSection { get; private set; }

        /// <summary>
        /// Reference to MISC section.
        /// </summary>
        public FdsCmdMisc MiscSection { get; private set; }

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
        /// Dump out all errors.
        /// </summary>
        public string ErrorOutput
        {
            get
            {
                string output = "";
                foreach (FdsCmd cmd in Commands)
                {
                    output += cmd.ErrorOutput;
                }
                return output;
            }
        }

        /// <summary>
        /// Method to load file using named file path.
        /// </summary>
        /// <param name="filePath">File path.</param>
        private void LoadFile(string filePath)
        {
            // Reset parameters
            FilePath = filePath;
            IsValidFile = true;

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
                IsValidFile = false;
                ErrorMessage = "Problem reading " + FilePath + "/n" + e.Message;
                return;
            }

            FileContents = lines.ToList();

            // Parse file lines into separate commands lines
            ParseCommands();

            // Get HEAD section
            try
            {
                HeadSection = (FdsCmdHead)(Commands.Where(x => x.CommandType == FdsCmdType.HEAD).First());
            }
            catch (Exception)
            {
                IsValidFile = false;
                ErrorMessage = "No HEAD section";
                return;
            }

            // Get MISC section
            try
            {
                MiscSection = (FdsCmdMisc)(Commands.Where(x => x.CommandType == FdsCmdType.MISC).FirstOrDefault());
            }
            catch (Exception) { }

            // TODO: Run validation routines in separate class
            // Multiple misc sections
            if (Commands.Where(x => x.CommandType == FdsCmdType.MISC).Count() > 1)
            {
                foreach (FdsCmd cmd in Commands.Where(x => x.CommandType == FdsCmdType.MISC))
                {
                    cmd.ErrorMessage = "Multiple MISC sections";
                    cmd.IsValid = false;
                }
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
                    FdsCmd fdsCmd = FdsCmdFactory.Create(originalLines, startNum, endNum, commandNum, this);
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
                    FdsCmd fdsCmd = FdsCmdFactory.Create(originalLines, startNum, endNum, commandNum, this);
                    Commands.Add(fdsCmd);
                }

            }

            // TODO: Detect mismatching & and /
        }

    }
}
