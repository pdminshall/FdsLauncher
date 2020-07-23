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
    /// MISC command class.
    /// </summary>
    public class FdsCmdMisc : FdsCmd
    {

        /// <summary>
        /// MISC ALLOW_SURFACE_PARTICLES
        /// </summary>
        public bool ALLOW_SURFACE_PARTICLES = true;

        /// <summary>
        /// MISC ALLOW_UNDERSIDE_PARTICLES
        /// </summary>
        public bool ALLOW_UNDERSIDE_PARTICLES = false;

        /// <summary>
        /// MISC ASSUMED_GAS_TEMPERATURE
        /// </summary>
        public double ASSUMED_GAS_TEMPERATURE = 0;

        /// <summary>
        /// MISC ASSUMED_GAS_TEMPERATURE_RAMP
        /// </summary>
        public string ASSUMED_GAS_TEMPERATURE_RAMP = "";

        /// <summary>
        /// MISC BAROCLINIC
        /// </summary>
        public bool BAROCLINIC = true;

        /// <summary>
        /// MISC BNDF_DEFAULT
        /// </summary>
        public bool BNDF_DEFAULT = true;

        /// <summary>
        /// MISC C_DEARDORFF
        /// </summary>
        public double C_DEARDORFF = 0.1;

        /// <summary>
        /// MISC C_SMAGORINSKY
        /// </summary>
        public double C_SMAGORINSKY = 0.2;

        /// <summary>
        /// MISC C_VREMAN
        /// </summary>
        public double C_VREMAN = 0.07;

        /// <summary>
        /// MISC C_WALE
        /// </summary>
        public double C_WALE = 0.6;

        /// <summary>
        /// MISC CFL_MAX
        /// </summary>
        public double CFL_MAX = 1.0;

        /// <summary>
        /// MISC CFL_MIN
        /// </summary>
        public double CFL_MIN = 0.8;

        /// <summary>
        /// MISC CFL_VELOCITY_NORM
        /// </summary>
        public int CFL_VELOCITY_NORM = 0;

        /// <summary>
        /// MISC CHECK_HT
        /// </summary>
        public bool CHECK_HT = false;

        /// <summary>
        /// MISC CHECK_VN
        /// </summary>
        public bool CHECK_VN = false;

        /// <summary>
        /// MISC CLIP_MASS_FRACTION
        /// </summary>
        public bool CLIP_MASS_FRACTION = false;

        /// <summary>
        /// MISC CNF_CUTOFF
        /// </summary>
        public double CNF_CUTOFF = 0.005;

        /// <summary>
        /// MISC CONSTANT_SPECIFIC_HEAT_RATIO
        /// </summary>
        public bool CONSTANT_SPECIFIC_HEAT_RATIO = false;

        /// <summary>
        /// MISC DNS
        /// </summary>
        public bool DNS = false;

        /// <summary>
        /// MISC DRIFT_FLUX
        /// </summary>
        public bool DRIFT_FLUX = true;

        /// <summary>
        /// MISC DT_HVAC
        /// </summary>
        public double DT_HVAC = 0.0;

        /// <summary>
        /// MISC EVACUATION_DRILL
        /// </summary>
        public bool EVACUATION_DRILL = false;

        /// <summary>
        /// MISC EVACUATION_MC_MODE
        /// </summary>
        public bool EVACUATION_MC_MODE = false;

        /// <summary>
        /// MISC EVAC_PRESSURE_ITERATIONS
        /// </summary>
        public int EVAC_PRESSURE_ITERATIONS = 50;

        /// <summary>
        /// MISC EVAC_TIME_ITERATIONS
        /// </summary>
        public int EVAC_TIME_ITERATIONS = 50;

        /// <summary>
        /// MISC FLUX_LIMITER
        /// </summary>
        public int FLUX_LIMITER = 2;

        /// <summary>
        /// MISC FREEZE_VELOCITY
        /// </summary>
        public bool FREEZE_VELOCITY = false;

        /// <summary>
        /// MISC GAMMA
        /// </summary>
        public double GAMMA = 1.4;

        /// <summary>
        /// MISC GRAVITATIONAL_DEPOSITION
        /// </summary>
        public bool GRAVITATIONAL_DEPOSITION = true;

        /// <summary>
        /// MISC GRAVITATIONAL_SETTLING
        /// </summary>
        public bool GRAVITATIONAL_SETTLING = true;

        /// <summary>
        /// MISC GVEC
        /// </summary>
        public RealTriplet GVEC = new RealTriplet(0, 0, -9.81);

        /// <summary>
        /// MISC H_F_REFERENCE_TEMPERATURE
        /// </summary>
        public double H_F_REFERENCE_TEMPERATURE = 25;

        /// <summary>
        /// MISC HVAC_MASS_TRANSPORT
        /// </summary>
        public bool HVAC_MASS_TRANSPORT = false;

        /// <summary>
        /// MISC HVAC_PRES_RELAX
        /// </summary>
        public double HVAC_PRES_RELAX = 0.5;

        /// <summary>
        /// MISC HUMIDITY
        /// </summary>
        public double HUMIDITY = 40;

        /// <summary>
        /// MISC IBLANK_SMV
        /// </summary>
        public bool IBLANK_SMV = true;

        /// <summary>
        /// MISC INITIAL_UNMIXED_FRACTION
        /// </summary>
        public double INITIAL_UNMIXED_FRACTION = 1.0;

        /// <summary>
        /// MISC MAX_CHEMISTRY_ITERATIONS
        /// </summary>
        public int MAX_CHEMISTRY_ITERATIONS = 1000;

        /// <summary>
        /// MISC MAX_LEAK_PATHS
        /// </summary>
        public int MAX_LEAK_PATHS = 200;

        /// <summary>
        /// MISC MAXIMUM_VISIBILITY
        /// </summary>
        public double MAXIMUM_VISIBILITY = 30;

        /// <summary>
        /// MISC MPI_TIMEOUT
        /// </summary>
        public double MPI_TIMEOUT = 10;

        /// <summary>
        /// MISC NEAR_WALL_TURBULENCE_MODEL
        /// </summary>
        public string NEAR_WALL_TURBULENCE_MODEL = "";

        /// <summary>
        /// MISC NOISE
        /// </summary>
        public bool NOISE = true;

        /// <summary>
        /// MISC NOISE_VELOCITY
        /// </summary>
        public double NOISE_VELOCITY = 0.005;

        /// <summary>
        /// MISC NO_EVACUATION
        /// </summary>
        public bool NO_EVACUATION = false;

        /// <summary>
        /// MISC OVERWRITE
        /// </summary>
        public bool OVERWRITE = true;

        /// <summary>
        /// MISC PARTICLE_CFL
        /// </summary>
        public bool PARTICLE_CFL = false;

        /// <summary>
        /// MISC PARTICLE_CFL_MAX
        /// </summary>
        public double PARTICLE_CFL_MAX = 1.0;

        /// <summary>
        /// MISC POROUS_FLOOR
        /// </summary>
        public bool POROUS_FLOOR = true;

        /// <summary>
        /// MISC PR
        /// </summary>
        public double PR = 0.5;

        /// <summary>
        /// MISC PROCESS_ALL_MESHES
        /// </summary>
        public bool PROCESS_ALL_MESHES = false;

        /// <summary>
        /// MISC PROJECTION
        /// </summary>
        public bool PROJECTION = false;

        /// <summary>
        /// MISC PR
        /// </summary>
        public double P_INF = 101325;

        /// <summary>
        /// MISC RAMP_GX
        /// </summary>
        public string RAMP_GX = "";

        /// <summary>
        /// MISC RAMP_GY
        /// </summary>
        public string RAMP_GY = "";

        /// <summary>
        /// MISC RAMP_GZ
        /// </summary>
        public string RAMP_GZ = "";

        /// <summary>
        /// MISC RESTART
        /// </summary>
        public bool RESTART = false;

        /// <summary>
        /// MISC RESTART_CHID
        /// </summary>
        public string RESTART_CHID = "";

        /// <summary>
        /// MISC RICHARDSON_ERROR_TOLERANCE
        /// </summary>
        public double RICHARDSON_ERROR_TOLERANCE = 1.0E-3;

        /// <summary>
        /// MISC SC
        /// </summary>
        public double SC = 0.5;

        /// <summary>
        /// MISC SHARED_FILE_SYSTEM
        /// </summary>
        public bool SHARED_FILE_SYSTEM = true;

        /// <summary>
        /// MISC SMOKE_ALBEDO
        /// </summary>
        public double SMOKE_ALBEDO = 0.3;

        /// <summary>
        /// MISC SOLID_PHASE_ONLY
        /// </summary>
        public bool SOLID_PHASE_ONLY = false;

        /// <summary>
        /// MISC SUPPRESSION
        /// </summary>
        public bool SUPPRESSION = true;

        /// <summary>
        /// MISC TEXTURE_ORIGIN
        /// </summary>
        public RealTriplet TEXTURE_ORIGIN = new RealTriplet(0, 0, 0);

        /// <summary>
        /// MISC THERMOPHORETIC_DEPOSITION
        /// </summary>
        public bool THERMOPHORETIC_DEPOSITION = true;

        /// <summary>
        /// MISC THICKEN_OBSTRUCTIONS
        /// </summary>
        public bool THICKEN_OBSTRUCTIONS = false;

        /// <summary>
        /// MISC TMPA
        /// </summary>
        public double TMPA = 20;

        /// <summary>
        /// MISC TURBULENCE_MODEL
        /// </summary>
        public string TURBULENCE_MODEL = "DEARDORFF";

        /// <summary>
        /// MISC TURBULENCE_DEPOSITION
        /// </summary>
        public bool TURBULENCE_DEPOSITION = true;

        /// <summary>
        /// MISC VERBOSE
        /// </summary>
        public bool VERBOSE = false;

        /// <summary>
        /// MISC VISIBILITY_FACTOR
        /// </summary>
        public double VISIBILITY_FACTOR = 3;

        /// <summary>
        /// MISC VN_MAX
        /// </summary>
        public double VN_MAX = 1.0;

        /// <summary>
        /// MISC VN_MIN
        /// </summary>
        public double VN_MIN = 0.8;

        /// <summary>
        /// MISC Y_CO2_INFTY
        /// </summary>
        public double Y_CO2_INFTY = 0;

        /// <summary>
        /// MISC Y_O2_INFTY
        /// </summary>
        public double Y_O2_INFTY = 0;

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        /// <param name="fileReference">Reference to parent file object.</param>
        public FdsCmdMisc(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference) :
               base(originalLines, startLineNum, endLineNum, commandNum, fileReference)
        { }
    }
}
