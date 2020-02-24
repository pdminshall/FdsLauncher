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

        /// <summary>
        /// Original code lines from FDS data file.
        /// </summary>
        public string OriginalLines { get; private set; } = "";

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
        public FdsCmd(string originalLines, int startLineNum, int endLineNum, int commandNum)
        {
            OriginalLines = originalLines;
            StartLineNum = startLineNum;
            EndLineNum = endLineNum;
            CommandNum = commandNum;
        }

    }
}
