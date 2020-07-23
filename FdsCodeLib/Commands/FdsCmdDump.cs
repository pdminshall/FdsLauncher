using System.Collections.Generic;

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

        /// <summary>
        /// DT_BNDF
        /// </summary>
        // TODO: Default to 2*delta t / nframes
        public double DT_BNDF = 0;

        /// <summary>
        /// DT_CPU
        /// </summary>
        public double DT_CPU = 1000000;

        /// <summary>
        /// DT_CTRL
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_CTRL = 0;

        /// <summary>
        /// DT_DEVC
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_DEVC = 0;

        /// <summary>
        /// DT_DEVC_LINE
        /// </summary>
        // TODO: Default to delta t / 2
        public double DT_DEVC_LINE = 0;

        /// <summary>
        /// DT_FLUSH
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_FLUSH = 0;

        /// <summary>
        /// DT_HRR
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_HRR = 0;

        /// <summary>
        /// DT_ISOF
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_ISOF = 0;

        /// <summary>
        /// DT_MASS
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_MASS = 0;

        /// <summary>
        /// DT_PL3D
        /// </summary>
        public double DT_PL3D = 1E10;

        /// <summary>
        /// DT_PROF
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_PROF = 0;

        /// <summary>
        /// DT_RESTART
        /// </summary>
        public double DT_RESTART = 1000000;

        /// <summary>
        /// DT_SL3D
        /// </summary>
        // TODO: Default to delta t / 5
        public double DT_SL3D = 0;

        /// <summary>
        /// DT_SLCF
        /// </summary>
        // TODO: Default to delta t / nframes
        public double DT_SLCF = 0;

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
        public StringQuintet PLOT3D_PART_ID = new StringQuintet("","","","","");

        /// <summary>
        /// PLOT3D_QUANTITY
        /// </summary>
        public StringQuintet PLOT3D_QUANTITY = new StringQuintet("","","","","");

        /// <summary>
        /// PLOT3D_SPEC_ID
        /// </summary>
        public StringQuintet PLOT3D_SPEC_ID = new StringQuintet("","","","","");

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

        // TODO: UVW_TIMER - Real Vector(10)

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
    }
}
