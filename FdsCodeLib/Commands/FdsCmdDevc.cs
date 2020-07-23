using System.Collections.Generic;

namespace FdsCodeLib
{
    /// <summary>
    /// DEVC command class.
    /// </summary>
    public class FdsCmdDevc : FdsCmd
    {

        /// <summary>
        /// Bypass flow rate (kg/s).
        /// </summary>
        public double BYPASS_FLOWRATE = 0;

        /// <summary>
        /// Conversion factor.
        /// </summary>
        public double CONVERSION_FACTOR = 1;

        /// <summary>
        /// Coordinate factor.
        /// </summary>
        public double COORD_FACTOR = 1;

        /// <summary>
        /// Control ID.
        /// </summary>
        public string CTRL_ID = "";

        /// <summary>
        /// Delay (s).
        /// </summary>
        public double DELAY = 0;

        /// <summary>
        /// Depth (m).
        /// </summary>
        public double DEPTH = 0;

        /// <summary>
        /// Dry flag.
        /// </summary>
        public bool DRY = false;

        /// <summary>
        /// Duct ID.
        /// </summary>
        public string DUCT_ID = "";

        /// <summary>
        /// Evacuation falg.
        /// </summary>
        public bool EVACUATION = false;

        /// <summary>
        /// Flowrate (kg/s).
        /// </summary>
        public double FLOWRATE = 0;

        /// <summary>
        /// Hide coordinates flag.
        /// </summary>
        public bool HIDE_COORDINATES = false;

        /// <summary>
        /// ID.
        /// </summary>
        public string ID = "";

        /// <summary>
        /// Initial state flag.
        /// </summary>
        public bool INITIAL_STATE = false;

        /// <summary>
        /// Init ID.
        /// </summary>
        public string INIT_ID = "";

        /// <summary>
        /// IOR value.
        /// </summary>
        public NInt IOR = new NInt(false, 0);

        /// <summary>
        /// Latch flag.
        /// </summary>
        public bool LATCH = true;

        /// <summary>
        /// Material ID.
        /// </summary>
        public string MATL_ID = "";

        /// <summary>
        /// Node ID list.
        /// </summary>
        public StringDoublet NODE_ID = new StringDoublet("", "");

        /// <summary>
        /// No update DEVC ID.
        /// </summary>
        public string NO_UPDATE_DEVC_ID = "";

        /// <summary>
        /// No update CTRL ID.
        /// </summary>
        public string NO_UPDATE_CTRL_ID = "";

        /// <summary>
        /// Orientation.
        /// </summary>
        public RealTriplet ORIENTATION = new RealTriplet(0, 0, -1);

        /// <summary>
        /// Orientation number.
        /// </summary>
        public int ORIENTATION_NUMBER = 1;

        /// <summary>
        /// Output flag.
        /// </summary>
        public bool OUTPUT = true;

        /// <summary>
        /// Part ID.
        /// </summary>
        public string PART_ID = "";

        /// <summary>
        /// Pipe index.
        /// </summary>
        public int PIPE_INDEX = 1;

        /// <summary>
        /// Points.
        /// </summary>
        public int POINTS = 1;

        /// <summary>
        /// Prop ID.
        /// </summary>
        public string PROP_ID = "";

        /// <summary>
        /// Quantity.
        /// </summary>
        public string QUANTITY = "";

        /// <summary>
        /// Quantity 2.
        /// </summary>
        public string QUANTITY2 = "";

        /// <summary>
        /// Quantity range.
        /// </summary>
        public RealDoublet QUANTITY_RANGE = new RealDoublet(-1E50, 1E50);

        /// <summary>
        /// Relative flag.
        /// </summary>
        public bool RELATIVE = false;

        /// <summary>
        /// R ID.
        /// </summary>
        public string R_ID = "";

        /// <summary>
        /// Rotation.
        /// </summary>
        public double ROTATION = 0;

        /// <summary>
        /// Set point.
        /// </summary>
        public NDouble SETPOINT = new NDouble(false, 0);

        /// <summary>
        /// Statistics.
        /// </summary>
        public string STATISTICS = "";

        /// <summary>
        /// Statistics start (s).
        /// </summary>
        // TODO: Default set to T_BEGIN;
        public double STATISTICS_START = 0;

        /// <summary>
        /// Smoothing factor.
        /// </summary>
        public double SMOOTHING_FACTOR = 0;

        /// <summary>
        /// Spec ID.
        /// </summary>
        public string SPEC_ID = "";

        /// <summary>
        /// Surface ID.
        /// </summary>
        public string SURF_ID = "";

        /// <summary>
        /// Time averaged flag.
        /// </summary>
        public bool TIME_AVERAGED = true;

        /// <summary>
        /// Time history flag.
        /// </summary>
        public bool TIME_HISTORY = false;

        /// <summary>
        /// Trip direction.
        /// </summary>
        public int TRIP_DIRECTION = 1;

        /// <summary>
        /// Units.
        /// </summary>
        public string UNITS = "";

        /// <summary>
        /// Velo index.
        /// </summary>
        public int VELO_INDEX = 0;

        /// <summary>
        /// XB (m).
        /// </summary>
        public RealSextuplet XB = new RealSextuplet(0, 0, 0, 0, 0, 0);

        /// <summary>
        /// XYZ (m).
        /// </summary>
        public RealTriplet XYZ = new RealTriplet(0, 0, 0);

        private string pX_ID = "";
        /// <summary>
        /// X ID.
        /// </summary>
        public string X_ID
        {
            get
            {
                if (pX_ID == null || pX_ID == "") { return (ID ?? "") + "-x"; }
                else { return pX_ID; }
            }
            set
            {
                pX_ID = value;
            }
        }

        private string pY_ID = "";
        /// <summary>
        /// Y ID.
        /// </summary>
        public string Y_ID
        {
            get
            {
                if (pY_ID == null || pY_ID == "") { return (ID ?? "") + "-y"; }
                else { return pY_ID; }
            }
            set
            {
                pY_ID = value;
            }
        }

        private string pZ_ID = "";
        /// <summary>
        /// Z ID.
        /// </summary>
        public string Z_ID
        {
            get
            {
                if (pZ_ID == null || pZ_ID == "") { return (ID ?? "") + "-z"; }
                else { return pZ_ID; }
            }
            set
            {
                pZ_ID = value;
            }
        }

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdDevc(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
