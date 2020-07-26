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
    public class FdsCmdHole : FdsCmd
    {

        /// <summary>
        /// BLOCK_WIND
        /// </summary>
        public bool BLOCK_WIND = false;

        /// <summary>
        /// COLOR
        /// </summary>
        public string COLOR = "";

        /// <summary>
        /// CTRL_ID
        /// </summary>
        public string CTRL_ID = "";

        /// <summary>
        /// DEVC_ID
        /// </summary>
        public string DEVC_ID = "";

        /// <summary>
        /// EVACUATION
        /// </summary>
        public bool EVACUATION = false;

        /// <summary>
        /// ID
        /// </summary>
        public string ID = "";

        /// <summary>
        /// MESH_ID
        /// </summary>
        public string MESH_ID = "";

        /// <summary>
        /// MULT_ID
        /// </summary>
        public string MULT_ID = "";

        /// <summary>
        /// RGB
        /// </summary>
        public IntTriplet RGB = new IntTriplet();

        /// <summary>
        /// TRANSPARENCY
        /// </summary>
        public NDouble TRANSPARENCY = new NDouble(false, 0);

        /// <summary>
        /// XB
        /// </summary>
        public RealSextuplet XB = new RealSextuplet();


        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdHole(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
