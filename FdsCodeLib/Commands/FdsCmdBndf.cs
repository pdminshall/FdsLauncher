using System.Collections.Generic;

namespace FdsCodeLib
{
    /// <summary>
    /// BNDF command class.
    /// </summary>
    public class FdsCmdBndf : FdsCmd
    {

        /// <summary>
        /// BNDF CELL_CENTRED
        /// </summary>
        public bool CELL_CENTRED = false;

        /// <summary>
        /// BNDF PART_ID
        /// </summary>
        public string PART_ID = "";

        /// <summary>
        /// BNDF PROP_ID
        /// </summary>
        public string PROP_ID = "";

        /// <summary>
        /// BNDF QUANTITY
        /// </summary>
        public string QUANTITY = "";

        /// <summary>
        /// BNDF SPEC_ID
        /// </summary>
        public string SPEC_ID = "";

        /// <summary>
        /// BNDF STATISTICS
        /// </summary>
        public string STATISTICS = "";

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdBndf(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
