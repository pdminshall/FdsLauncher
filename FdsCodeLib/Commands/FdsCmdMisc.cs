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
    /// HEAD command class.
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

        // TODO: OVERWRITE Logical Section 6.4.1 .TRUE.
        // TODO: PARTICLE_CFL Logical Section 6.4.8 .FALSE.
        // TODO: PARTICLE_CFL_MAX Real Section 6.4.8 1.0
        // TODO: POROUS_FLOOR Logical Section 16.3.1 .TRUE.
        // TODO: PR Real Section 6.4.7 0.5
        // TODO: PROCESS_ALL_MESHES Logical Section 7.3.2 .FALSE.
        // TODO: PROJECTION Logical Formal projection.FALSE.
        // TODO: P_INF Real Section 6.4.1 Pa 101325
        // TODO: RAMP_GX Character Section 6.4.5
        // TODO: RAMP_GY Character Section 6.4.5
        // TODO: RAMP_GZ Character Section 6.4.5

        /// <summary>
        /// MISC RESTART
        /// </summary>
        public bool RESTART = false;

        // TODO: RESTART_CHID Character Section 6.4.2 CHID
        // TODO: RICHARDSON_ERROR_TOLERANCE Real Section 13 1.0 E-3
        // TODO: SC Real Section 6.4.7 0.5
        // TODO: SHARED_FILE_SYSTEM Logical Section 6.3.3 .TRUE.
        // TODO: SMOKE_ALBEDO Real Reference[2] 0.3
        // TODO: SOLID_PHASE_ONLY Logical Section 8.7 .FALSE.
        // TODO: SUPPRESSION Logical Section 13.1.4 .TRUE.
        // TODO: TEXTURE_ORIGIN(3) Real Triplet Section 7.4.2 m(0.,0.,0.)
        // TODO: THERMOPHORETIC_DEPOSITION Logical Section 13.5 .TRUE.
        // TODO: THICKEN_OBSTRUCTIONS Logical Section 7.2.1 .FALSE.
        // TODO: TMPA Real Section 6.4.1 °C 20.
        // TODO: TURBULENCE_MODEL Character Section 6.4.7 ’DEARDORFF’
        // TODO: TURBULENT_DEPOSITION Logical Section 13.5 .TRUE.
        // TODO: VERBOSE Logical Section 6.3.3
        // TODO: VISIBILITY_FACTOR Real Section 17.10.4 3
        // TODO: VN_MAX Real Section 6.4.8 1.0
        // TODO: VN_MIN Real Section 6.4.8 0.8
        // TODO: Y_CO2_INFTY Real Section 13.1.1 kg/kg
        // TODO: Y_O2_INFTY Real Section 13.1.1 kg/kg

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        public FdsCmdMisc(List<string> originalLines, int startLineNum, int endLineNum, int commandNum) :
               base(originalLines, startLineNum, endLineNum, commandNum)
        { }
    }
}
