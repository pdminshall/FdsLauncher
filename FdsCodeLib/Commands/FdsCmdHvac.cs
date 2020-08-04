using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FdsCodeLib
{
    /// <summary>
    /// HEAD command class.
    /// </summary>
    public class FdsCmdHvac : FdsCmd
    {

        /// <summary>
        /// AIRCOIL_ID
        /// </summary>
        public string AIRCOIL_ID = "";

        /// <summary>
        /// AMBIENT
        /// </summary>
        public bool AMBIENT = false;

        /// <summary>
        /// AREA
        /// </summary>
        public NDouble AREA = new NDouble(false, 0);

        /// <summary>
        /// CLEAN_LOSS
        /// </summary>
        public NDouble CLEAN_LOSS = new NDouble(false, 0);

        /// <summary>
        /// COOLANT_MASS_FLOW
        /// </summary>
        public NDouble COOLANT_MASS_FLOW = new NDouble(false, 0);

        /// <summary>
        /// COOLANT_SPECIFIC_HEAT
        /// </summary>
        public NDouble COOLANT_SPECIFIC_HEAT = new NDouble(false, 0);

        /// <summary>
        /// COOLANT_TEMPERATURE
        /// </summary>
        public NDouble COOLANT_TEMPERATURE = new NDouble(false, 0);

        /// <summary>
        /// CTRL_ID
        /// </summary>
        public string CTRL_ID = "";

        /// <summary>
        /// DAMPER
        /// </summary>
        public bool DAMPER = false;

        /// <summary>
        /// DEVC_ID
        /// </summary>
        public string DEVC_ID = "";

        /// <summary>
        /// DIAMETER
        /// </summary>
        public NDouble DIAMETER = new NDouble(false, 0);

        /// <summary>
        /// DUCT_ID
        /// </summary>
        public string[] DUCT_ID = new string[0];

        /// <summary>
        /// DUCT_INTERP_TYPE
        /// </summary>
        public string DUCT_INTERP_TYPE = "";

        /// <summary>
        /// EFFICIENCY
        /// </summary>
        public double[] EFFICIENCY = new double[] { 1.0 };

        /// <summary>
        /// FAN_ID
        /// </summary>
        public string FAN_ID = "";

        /// <summary>
        /// FILTER_ID
        /// </summary>
        public string FILTER_ID = "";

        /// <summary>
        /// FIXED_Q
        /// </summary>
        public NDouble FIXED_Q = new NDouble(false, 0);

        /// <summary>
        /// ID
        /// </summary>
        public string ID = "";

        /// <summary>
        /// LEAK_ENTHALPY
        /// </summary>
        public bool LEAK_ENTHALPY = false;

        /// <summary>
        /// LENGTH
        /// </summary>
        public NDouble LENGTH = new NDouble(false, 0);

        /// <summary>
        /// LOADING
        /// </summary>
        public double[] LOADING = new double[] { 0.0 };

        /// <summary>
        /// LOADING_MULTIPLIER
        /// </summary>
        public double[] LOADING_MULTIPLIER = new double[] { 1.0 };

        /// <summary>
        /// LOSS
        /// </summary>
        public double[] LOSS = new double[] { 0.0 };

        /// <summary>
        /// MASS_FLOW
        /// </summary>
        public NDouble MASS_FLOW = new NDouble(false, 0);

        /// <summary>
        /// MAX_FLOW
        /// </summary>
        public NDouble MAX_FLOW = new NDouble(false, 0);

        /// <summary>
        /// MAX_PRESSURE
        /// </summary>
        public NDouble MAX_PRESSURE = new NDouble(false, 0);

        private NInt pN_CELLS = new NInt(false, 0);
        /// <summary>
        /// N_CELLS
        /// </summary>
        public NInt N_CELLS
        {
            get
            {
                if (pN_CELLS.HasValue) { return pN_CELLS; }
                if (LENGTH.HasValue) { return new NInt(true, (int)(LENGTH.Value / 0.1)); }
                return new NInt(false, 0);
            }
            set
            {
                pN_CELLS = value;
            }
        }

        /// <summary>
        /// NODE_ID
        /// </summary>
        public StringDoublet NODE_ID = new StringDoublet("", "");

        /// <summary>
        /// PERIMETER
        /// </summary>
        public NDouble PERIMETER = new NDouble(false, 0);

        /// <summary>
        /// RAMP_ID
        /// </summary>
        public string RAMP_ID = "";

        /// <summary>
        /// RAMP_LOSS
        /// </summary>
        public string RAMP_LOSS = "";

        /// <summary>
        /// REVERSE
        /// </summary>
        public bool REVERSE = false;

        /// <summary>
        /// ROUGHNESS
        /// </summary>
        public double ROUGHNESS = 0.0;

        /// <summary>
        /// SPEC_ID
        /// </summary>
        public string[] SPEC_ID = new string[0];

        /// <summary>
        /// TAU_AC
        /// </summary>
        public double TAU_AC = 1.0;

        /// <summary>
        /// TAU_FAN
        /// </summary>
        public double TAU_FAN = 1.0;

        /// <summary>
        /// TAU_VF
        /// </summary>
        public double TAU_VF = 1.0;

        /// <summary>
        /// TYPE_ID
        /// </summary>
        public string TYPE_ID = "";

        /// <summary>
        /// VENT_ID
        /// </summary>
        public string VENT_ID = "";

        /// <summary>
        /// VENT2_ID
        /// </summary>
        public string VENT2_ID = "";

        /// <summary>
        /// VOLUME_FLOW
        /// </summary>
        public NDouble VOLUME_FLOW = new NDouble(false, 0);

        /// <summary>
        /// XYZ
        /// </summary>
        public RealTriplet XYZ = new RealTriplet(0.0, 0.0, 0.0);

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdHvac(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
