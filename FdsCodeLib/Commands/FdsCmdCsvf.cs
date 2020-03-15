using System.Collections.Generic;

namespace FdsCodeLib
{
    /// <summary>
    /// CSVF command class.
    /// </summary>
    public class FdsCmdCsvf : FdsCmd
    {

        /// <summary>
        /// CSVF UVW_FILE
        /// </summary>
        public string UVW_FILE = "";

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        public FdsCmdCsvf(List<string> originalLines, int startLineNum, int endLineNum, int commandNum) :
               base(originalLines, startLineNum, endLineNum, commandNum)
        { }
    }
}
