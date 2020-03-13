using System.Collections.Generic;

namespace FdsCodeLib
{
    /// <summary>
    /// MESH command class.
    /// </summary>
    public class FdsCmdMesh : FdsCmd
    {

        /// <summary>
        /// MESH COLOR
        /// </summary>
        public string COLOR = "BLACK";

        /// <summary>
        /// MESH CYLINDRICAL
        /// </summary>
        public bool CYLINDRICAL = false;

        /// <summary>
        /// MESH EVACUATION
        /// </summary>
        public bool EVACUATION = false;

        /// <summary>
        /// MESH EVAC_HUMANS
        /// </summary>
        public bool EVAC_HUMANS = false;

        /// <summary>
        /// MESH EVAC_Z_OFFSET
        /// </summary>
        public double EVAC_Z_OFFSET = 1;

        /// <summary>
        /// MESH ID
        /// </summary>
        public string ID = "";

        /// <summary>
        /// MESH IJK
        /// </summary>
        public IntTriplet IJK = new IntTriplet(10, 10, 10);

        /// <summary>
        /// MESH LEVEL
        /// </summary>
        public int LEVEL = 0;

        /// <summary>
        /// MESH MPI_PROCESS
        /// </summary>
        public int MPI_PROCESS = -1;

        /// <summary>
        /// MESH N_THREADS
        /// </summary>
        public int N_THREADS = 0;

        /// <summary>
        /// MESH MULTI_ID
        /// </summary>
        public string MULT_ID = "";

        /// <summary>
        /// MESH PERIODIC_MESH_IDS
        /// </summary>
        public Dictionary<string, string> PERIODIC_MESH_IDS = new Dictionary<string, string>();

        /// <summary>
        /// MESH RGB
        /// </summary>
        public IntTriplet RGB = new IntTriplet(0, 0, 0);

        /// <summary>
        /// MESH XB
        /// </summary>
        public RealSextuplet XB = new RealSextuplet(0, 1, 0, 1, 0, 1);

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        public FdsCmdMesh(List<string> originalLines, int startLineNum, int endLineNum, int commandNum) :
               base(originalLines, startLineNum, endLineNum, commandNum)
        { }
    }
}
