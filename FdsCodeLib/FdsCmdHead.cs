using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// HEAD command class.
    /// </summary>
    public class FdsCmdHead : FdsCmd
    {

        // TODO: Add HEAD parameters

        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        public FdsCmdHead(List<string> originalLines, int startLineNum, int endLineNum, int commandNum) :
               base(originalLines, startLineNum, endLineNum, commandNum)
        {

            // TODO: Parse arguments
        }

    }
}
