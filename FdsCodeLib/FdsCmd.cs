using System;
using System.Collections.Generic;
using System.Reflection;

namespace FdsCodeLib
{
    /// <summary>
    /// Base class for all FDS commands.
    /// </summary>
    public class FdsCmd
    {

        /// <summary>
        /// Command type, which determines which sub class to create.
        /// </summary>
        public FdsCmdType CommandType { get; private set; } = FdsCmdType.NONE;

        /// <summary>
        /// Command name as string.
        /// </summary>
        public string CommandName { get; private set; } = "";

        /// <summary>
        /// Original code lines from FDS data file.
        /// </summary>
        public List<string> OriginalLines { get; private set; } = new List<string>();

        /// <summary>
        /// Command line, parsed from original FDS data file.
        /// </summary>
        public string CommandLine { get; private set; } = "";

        /// <summary>
        /// Start line number of command from FDS data file.
        /// </summary>
        public int StartLineNum { get; private set; } = 0;

        /// <summary>
        /// End line number of command from FDS data file.
        /// </summary>
        public int EndLineNum { get; private set; } = 0;

        /// <summary>
        /// Command sequence number in original file.
        /// </summary>
        public int CommandNum { get; private set; } = 0;

        /// <summary>
        /// Validity marker.
        /// </summary>
        public bool IsValid { get; set; } = true;

        /// <summary>
        /// Error message.
        /// </summary>
        public string ErrorMessage { get; set; } = "";

        /// <summary>
        /// Show command with line numbers.
        /// </summary>
        public string DebugOutput
        {
            get
            {
                string output = "";
                if (StartLineNum == EndLineNum)
                {
                    output += "---- Line " + StartLineNum + "----\n";

                }
                else
                {
                    output += "---- Lines " + StartLineNum + " - " + EndLineNum + " ----\n";
                }

                foreach (string line in OriginalLines)
                {
                    output += line + "\n";
                }
                return output;
            }
        }

        /// <summary>
        /// Show error and lines, if invalid.
        /// </summary>
        public string ErrorOutput
        {
            get
            {
                if (IsValid) { return ""; }

                string output = "";
                output = "-------- ERROR -----------------------\n";
                output += ErrorMessage + "\n";
                output += DebugOutput;
                output += "--------------------------------------\n\n";
                return output;
            }
        }

        /// <summary>
        /// Constructor with arguments to set command line.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        public FdsCmd(List<string> originalLines, int startLineNum, int endLineNum, int commandNum)
        {
            OriginalLines = originalLines;
            StartLineNum = startLineNum;
            EndLineNum = endLineNum;
            CommandNum = commandNum;

            ParseCommand();
            LoadData();
        }

        /// <summary>
        /// Convert original code lines into single command.
        /// </summary>
        private void ParseCommand()
        {
            CommandLine = "";

            foreach (string line in OriginalLines)
            {
                string myLine = line.Trim();

                // Insert missing comma between lines
                if (CommandLine != "" && !CommandLine.EndsWith(",") &&
                    myLine != "/" && !myLine.StartsWith(","))
                {
                    CommandLine += ",";
                }

                CommandLine += myLine;
            }

            // Remove & and /
            CommandLine = CommandLine.TrimStart('&').TrimEnd('/').Trim();

            // Extract command name
            CommandName = CommandLine.Split(' ')[0];

            try
            {
                CommandType = (FdsCmdType)Enum.Parse(typeof(FdsCmdType), CommandName);
            }
            catch (ArgumentException)
            {
                CommandType = FdsCmdType.NONE;
            }

        }

        /// <summary>
        /// Load all fields with data.
        /// </summary>
        public void LoadData()
        {
            // Loop over each field and set dynamically
            foreach (FieldInfo fi in this.GetType().GetFields())
            {
                string fieldName = fi.Name;
                dynamic oldVal = fi.GetValue(this);
                dynamic newVal = CommonFunctions.GetValue(CommandLine, fieldName, oldVal);
                fi.SetValue(this, newVal);
            }
        }
    }
}
