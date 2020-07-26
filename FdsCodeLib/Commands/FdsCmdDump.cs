using System;
using System.Collections.Generic;
using System.Linq;

namespace FdsCodeLib
{
    /// <summary>
    /// DUMP command class.
    /// </summary>
    public class FdsCmdDump : FdsCmd
    {

        /// <summary>
        /// CLIP_RESTART_FILES
        /// </summary>
        public bool CLIP_RESTART_FILES = true;

        /// <summary>
        /// COLUMN_DUMP_LIMIT
        /// </summary>
        public bool COLUMN_DUMP_LIMIT = false;

        /// <summary>
        /// CTRL_COLUMN_LIMIT
        /// </summary>
        public int CTRL_COLUMN_LIMIT = 253;

        /// <summary>
        /// DEVC_COLUMN_LIMIT
        /// </summary>
        public int DEVC_COLUMN_LIMIT = 253;

        private double? pDT_BNDF = null;
        /// <summary>
        /// DT_BNDF
        /// </summary>
        public double DT_BNDF
        {
            get
            {
                return TimeIntervalGetter(pDT_BNDF, 2.0);
            }
            set
            {
                pDT_BNDF = value;
            }
        }

        /// <summary>
        /// DT_CPU
        /// </summary>
        public double DT_CPU = 1000000;

        private double? pDT_CTRL = null;
        /// <summary>
        /// DT_CTRL
        /// </summary>
        public double DT_CTRL
        {
            get
            {
                return TimeIntervalGetter(pDT_CTRL, 1.0);
            }
            set
            {
                pDT_CTRL = value;
            }
        }

        private double? pDT_DEVC = null;
        /// <summary>
        /// DT_DEVC
        /// </summary>
        public double DT_DEVC
        {
            get
            {
                return TimeIntervalGetter(pDT_DEVC, 1.0);
            }
            set
            {
                pDT_DEVC = value;
            }
        }

        private double? pDT_DEVC_LINE = null;
        /// <summary>
        /// DT_DEVC_LINE
        /// </summary>
        public double DT_DEVC_LINE
        {
            get
            {
                return TimeIntervalGetter(pDT_DEVC_LINE, 1.0, 2);
            }
            set
            {
                pDT_DEVC_LINE = value;
            }
        }

        private double? pDT_FLUSH = null;
        /// <summary>
        /// DT_FLUSH
        /// </summary>
        public double DT_FLUSH
        {
            get
            {
                return TimeIntervalGetter(pDT_FLUSH, 1.0);
            }
            set
            {
                pDT_FLUSH = value;
            }
        }

        private double? pDT_HRR = null;
        /// <summary>
        /// DT_HRR
        /// </summary>
        public double DT_HRR
        {
            get
            {
                return TimeIntervalGetter(pDT_HRR, 1.0);
            }
            set
            {
                pDT_HRR = value;
            }
        }

        private double? pDT_ISOF = null;
        /// <summary>
        /// DT_ISOF
        /// </summary>
        public double DT_ISOF
        {
            get
            {
                return TimeIntervalGetter(pDT_ISOF, 1.0);
            }
            set
            {
                pDT_ISOF = value;
            }
        }

        private double? pDT_MASS = null;
        /// <summary>
        /// DT_MASS
        /// </summary>
        public double DT_MASS
        {
            get
            {
                return TimeIntervalGetter(pDT_MASS, 1.0);
            }
            set
            {
                pDT_MASS = value;
            }
        }

        /// <summary>
        /// DT_PL3D
        /// </summary>
        public double DT_PL3D = 1E10;

        private double? pDT_PROF = null;
        /// <summary>
        /// DT_PROF
        /// </summary>
        public double DT_PROF
        {
            get
            {
                return TimeIntervalGetter(pDT_PROF, 1.0);
            }
            set
            {
                pDT_PROF = value;
            }
        }

        /// <summary>
        /// DT_RESTART
        /// </summary>
        public double DT_RESTART = 1000000;

        private double? pDT_SL3D = null;
        /// <summary>
        /// DT_SL3D
        /// </summary>
        public double DT_SL3D
        {
            get
            {
                return TimeIntervalGetter(pDT_SL3D, 1.0, 5);
            }
            set
            {
                pDT_SL3D = value;
            }
        }

        private double? pDT_SLCF = null;
        /// <summary>
        /// DT_SLCF
        /// </summary>
        public double DT_SLCF
        {
            get
            {
                return TimeIntervalGetter(pDT_SLCF, 1.0);
            }
            set
            {
                pDT_SLCF = value;
            }
        }

        /// <summary>
        /// EB_PART_FILE
        /// </summary>
        public bool EB_PART_FILE = false;

        /// <summary>
        /// FLUSH_FILE_BUFFERS
        /// </summary>
        public bool FLUSH_FILE_BUFFERS = true;

        /// <summary>
        /// MASS_FILE
        /// </summary>
        public bool MASS_FILE = false;

        /// <summary>
        /// MAXIMUM_PARTICLES
        /// </summary>
        public int MAXIMUM_PARTICLES = 1000000;

        /// <summary>
        /// NFRAMES
        /// </summary>
        public int NFRAMES = 1000;

        /// <summary>
        /// PLOT3D_PART_ID
        /// </summary>
        public StringQuintet PLOT3D_PART_ID = new StringQuintet("", "", "", "", "");

        /// <summary>
        /// PLOT3D_QUANTITY
        /// </summary>
        public StringQuintet PLOT3D_QUANTITY = new StringQuintet("", "", "", "", "");

        /// <summary>
        /// PLOT3D_SPEC_ID
        /// </summary>
        public StringQuintet PLOT3D_SPEC_ID = new StringQuintet("", "", "", "", "");

        /// <summary>
        /// PLOT3D_VELO_INDEX
        /// </summary>
        public Dictionary<string, int> PLOT3D_VELO_INDEX = new Dictionary<string, int>();

        /// <summary>
        /// RENDER_FILE
        /// </summary>
        public string RENDER_FILE = "";

        /// <summary>
        /// SIG_FIGS
        /// </summary>
        public int SIG_FIGS = 8;

        /// <summary>
        /// SMOKE_3D
        /// </summary>
        public bool SMOKE_3D = true;

        /// <summary>
        /// SMOKE_3D_QUANTITY
        /// </summary>
        public string SMOKE_3D_QUANTITY = "";

        /// <summary>
        /// STATUS_FILES
        /// </summary>
        public bool STATUS_FILES = false;

        /// <summary>
        /// SUPPRESS_DIAGNOSTICS
        /// </summary>
        public bool SUPPRESS_DIAGNOSTICS = false;

        /// <summary>
        /// UVW_TIMER
        /// </summary>
        public Dictionary<string, int> UVW_TIMER = new Dictionary<string, int>();

        /// <summary>
        /// VELOCITY_ERROR_FILE
        /// </summary>
        public bool VELOCITY_ERROR_FILE = false;

        /// <summary>
        /// WRITE_XYZ
        /// </summary>
        public bool WRITE_XYZ = false;

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdDump(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }

        /// <summary>
        /// Custom function to get default time interval for some properties.
        /// </summary>
        /// <param name="srcValue">Private double? variable for property</param>
        /// <param name="multFactor">Multiplication factor.</param>
        /// <returns>Double value for property.</returns>
        private double TimeIntervalGetter(double? srcValue, double multFactor)
        {
            return TimeIntervalGetter(srcValue, multFactor, NFRAMES);
        }

        /// <summary>
        /// Custom function to get default time interval for some properties.
        /// </summary>
        /// <param name="srcValue">Private double? variable for property</param>
        /// <param name="multFactor">Multiplication factor.</param>
        /// <param name="nframes">Number of frames.</param>
        /// <returns>Double value for property.</returns>
        private double TimeIntervalGetter(double? srcValue, double multFactor, int nframes)
        {
            if (srcValue.HasValue && srcValue != -1)
            {
                return srcValue.Value;
            }

            // Look for file object
            if (FileReference != null)
            {
                // Look for TIME object
                FdsCmdTime time = FileReference.TimeSection;
                if (time != null)
                {
                    try
                    {
                        return multFactor * (time.T_END - time.T_BEGIN) / nframes;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return -1;
        }

    }
}
