using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// TIME command class.
    /// </summary>
    public class FdsCmdTime : FdsCmd
    {

        /// <summary>
        /// DT
        /// </summary>
        public NDouble DT = new NDouble(false, 0);

        /// <summary>
        /// EVAC_DT_FLOWFIELD
        /// </summary>
        public double EVAC_DT_FLOWFIELD = 0.01;

        /// <summary>
        /// EVAC_DT_STEADY_STATE
        /// </summary>
        public double EVAC_DT_STEADY_STATE = 0.05;

        /// <summary>
        /// LIMITING_DT_RATIO
        /// </summary>
        public double LIMITING_DT_RATIO = 0.0001;

        /// <summary>
        /// LOCK_TIME_STEP
        /// </summary>
        public bool LOCK_TIME_STEP = false;

        /// <summary>
        /// RESTRICT_TIME_STEP
        /// </summary>
        public bool RESTRICT_TIME_STEP = true;

        /// <summary>
        /// T_BEGIN
        /// </summary>
        public double T_BEGIN = 0;

        /// <summary>
        /// T_END;
        /// </summary>
        public double T_END = 1;

        /// <summary>
        /// TIME_SHRINK_FACTOR
        /// </summary>
        public double TIME_SHRINK_FACTOR = 1;

        /// <summary>
        /// WALL_INCREMENT
        /// </summary>
        public int WALL_INCREMENT = 2;

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdTime(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
