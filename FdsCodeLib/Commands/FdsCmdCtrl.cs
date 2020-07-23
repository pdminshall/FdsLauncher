using System.Collections.Generic;

namespace FdsCodeLib
{
    /// <summary>
    /// CTRL command class.
    /// </summary>
    public class FdsCmdCtrl : FdsCmd
    {

        /// <summary>
        /// CTRL CONSTANT
        /// </summary>
        public NDouble CONSTANT = new NDouble(false, 0);

        /// <summary>
        /// CTRL DELAY
        /// </summary>
        public double DELAY = 0;

        /// <summary>
        /// CTRL DIFFERENTIAL_GAIN
        /// </summary>
        public double DIFFERENTIAL_GAIN = 0;

        /// <summary>
        /// CTRL EVACUATION
        /// </summary>
        public bool EVACUATION = false;

        /// <summary>
        /// CTRL FUNCTION_TYPE
        /// </summary>
        public FunctionTypeEnum FUNCTION_TYPE = FunctionTypeEnum.NONE;

        /// <summary>
        /// CTRL ID
        /// </summary>
        public string ID = "";

        /// <summary>
        /// CTRL INITIAL_STATE
        /// </summary>
        public bool INITIAL_STATE = false;

        /// <summary>
        /// CTRL INPUT_ID
        /// </summary>
        public List<string> INPUT_ID = new List<string>();

        /// <summary>
        /// CTRL INTEGRAL_GAIN
        /// </summary>
        public double INTEGRAL_GAIN = 0;

        /// <summary>
        /// CTRL LATCH
        /// </summary>
        public bool LATCH = true;

        /// <summary>
        /// CTRL N
        /// </summary>
        public int N = 1;

        /// <summary>
        /// CTRL ON_BOUND
        /// </summary>
        public string ON_BOUND = "LOWER";

        /// <summary>
        /// CTRL PROPORTIONAL_GAIN
        /// </summary>
        public double PROPORTIONAL_GAIN = 0;

        /// <summary>
        /// CTRL RAMP_ID
        /// </summary>
        public string RAMP_ID = "";

        /// <summary>
        /// CTRL SETPOINT
        /// </summary>
        public NDouble SETPOINT = new NDouble(false, 0);

        /// <summary>
        /// CTRL TARGET_VALUE
        /// </summary>
        public double TARGET_VALUE = 0;

        /// <summary>
        /// CTRL TRIP_DIRECTION
        /// </summary>
        public int TRIP_DIRECTION = 1;

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdCtrl(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
