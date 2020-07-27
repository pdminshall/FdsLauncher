using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// HEAD command class.
    /// </summary>
    public class FdsCmdIsof : FdsCmd
    {

        /// <summary>
        /// QUANTITY.
        /// </summary>
        public string QUANTITY = "";

        /// <summary>
        /// REDUCE_TRIANGLES.
        /// </summary>
        public int REDUCE_TRIANGLES = 1;

        /// <summary>
        /// SPEC_ID.
        /// </summary>
        public string SPEC_ID = "";

        /// <summary>
        /// VALUE.
        /// </summary>
        public Dictionary<string, double> VALUE = new Dictionary<string, double>();

        /// <summary>
        /// VELO_INDEX.
        /// </summary>
        public int VELO_INDEX = 0;

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdIsof(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
