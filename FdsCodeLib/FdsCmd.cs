using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Command name as string
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

    }
}
