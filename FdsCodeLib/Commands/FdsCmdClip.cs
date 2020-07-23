using System.Collections.Generic;

namespace FdsCodeLib
{
    /// <summary>
    /// CLIP command class.
    /// </summary>
    public class FdsCmdClip : FdsCmd
    {

        /// <summary>
        /// CLIP MAXIMUM_DENSITY
        /// </summary>
        public NDouble MAXIMUM_DENSITY = new NDouble(false, 0);

        /// <summary>
        /// CLIP MAXIMUM_TEMPERATURE
        /// </summary>
        public NDouble MAXIMUM_TEMPERATURE = new NDouble(false, 0);

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdClip(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
