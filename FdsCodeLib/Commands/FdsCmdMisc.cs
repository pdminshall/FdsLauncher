using System;
using System.Collections.Generic;
using System.Linq;
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
        public bool AllowSurfaceParticles { get; private set; }

        /// <summary>
        /// MISC ALLOW_UNDERSIDE_PARTICLES
        /// </summary>
        public bool AllowUndersideParticles { get; private set; }

        /// <summary>
        /// MISC ASSUMED_GAS_TEMPERATURE
        /// </summary>
        public double? AssumedGasTemperature { get; private set; }

        /// <summary>
        /// MISC ASSUMED_GAS_TEMPERATURE_RAMP
        /// </summary>
        public string AssumedGasTemperatureRamp { get; private set; }

        /// <summary>
        /// MISC BAROCLINIC
        /// </summary>
        public bool Baroclinic { get; private set; }

        /// <summary>
        /// MISC BNDF_DEFAULT
        /// </summary>
        public bool BndfDefault { get; private set; }

        /// <summary>
        /// MISC C_DEARDORFF
        /// </summary>
        public double CDeardorff { get; private set; }

        // TODO: C_SMAGORINSKY Real 0.20
        // TODO: C_VREMAN Real 0.07
        // TODO: C_WALE Real Section 6.4.7 0.60
        // TODO: CFL_MAX Real Section 6.4.8 1.0
        // TODO: CFL_MIN Real Section 6.4.8 0.8
        // TODO: CFL_VELOCITY_NORM Integer Section 6.4.8 0 (LES), 1 (DNS)
        // TODO: CHECK_HT Logical Section 6.4.8 .FALSE.
        // TODO: CHECK_VN Logical Section 6.4.8 .FALSE.
        // TODO: CLIP_MASS_FRACTION Logical Section 6.7 .FALSE.
        // TODO: CNF_CUTOFF Real Section 15.3.3 0.005
        // TODO: CONSTANT_SPECIFIC_HEAT_RATIO Logical Section 12.1.3 .FALSE.
        // TODO: DNS Logical Section 6.4.1 .FALSE.
        // TODO: DRIFT_FLUX Logical Section 13.5 .TRUE.
        // TODO: DT_HVAC Real Section 9.2 s
        // TODO: EVACUATION_DRILL Logical Reference[64] .FALSE.
        // TODO: EVACUATION_MC_MODE Logical Reference[64] .FALSE.
        // TODO: EVAC_PRESSURE_ITERATIONS Integer Reference[64] 50
        // TODO: EVAC_TIME_ITERATIONS Integer Reference[64] 50
        // TODO: FLUX_LIMITER Integer Section 6.4.9 2
        // TODO: FREEZE_VELOCITY Logical Section 6.4.4 .FALSE.
        // TODO: GAMMA Real Section 12.1.2 1.4
        // TODO: GRAVITATIONAL_DEPOSITION Logical Section 13.5 .TRUE.
        // TODO: GRAVITATIONAL_SETTLING Logical Section 13.5 .TRUE.
        // TODO: GVEC Real triplet Section 6.4.5 m/s2 0,0,-9.81
        // TODO: H_F_REFERENCE_TEMPERATURE Real Section 17.10.20 °C 25.
        // TODO: HVAC_MASS_TRANSPORT Logical Section 9.2.8 .FALSE.
        // TODO: HVAC_PRES_RELAX Real Section 9.2 0.5
        // TODO: HUMIDITY Real Section 12.1.1 % 40.
        // TODO: IBLANK_SMV Logical Section 17.4 .TRUE.
        // TODO: INITIAL_UNMIXED_FRACTION Real Section 13.1.3 1.0
        // TODO: MAX_CHEMISTRY_ITERATIONS Integer Section 13.4 1000
        // TODO: MAX_LEAK_PATHS Integer Section 9.3.2 200
        // TODO: MAXIMUM_VISIBILITY Real Section 17.10.4 m 30
        // TODO: MPI_TIMEOUT Real Section 17.10.21 s 10.
        // TODO: NEAR_WALL_TURBULENCE_MODEL Character Section 6.4.7
        // TODO: NOISE Logical Section 6.4.1 .TRUE.
        // TODO: NOISE_VELOCITY Real Section 6.4.1 m/s 0.005
        // TODO: NO_EVACUATION Logical Reference[64] .FALSE.
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
        // TODO: RESTART Logical Section 6.4.2 .FALSE.
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
        /// Constructor with arguments.
        /// </summary>
        /// <param name="originalLines">Original lines from data file.</param>
        /// <param name="startLineNum">Start line number of command.</param>
        /// <param name="endLineNum">End line number of command.</param>
        /// <param name="commandNum">Sequential number of command.</param>
        public FdsCmdMisc(List<string> originalLines, int startLineNum, int endLineNum, int commandNum) :
               base(originalLines, startLineNum, endLineNum, commandNum)
        {
            AllowSurfaceParticles = CommonFunctions.GetBoolPar(CommandLine, "ALLOW_SURFACE_PARTICLES", true);
            AllowUndersideParticles = CommonFunctions.GetBoolPar(CommandLine, "ALLOW_UNDERSIDE_PARTICLES", false);
            AssumedGasTemperature = CommonFunctions.GetNDoublePar(CommandLine, "ASSUMED_GAS_TEMPERATURE", null);
            AssumedGasTemperatureRamp = CommonFunctions.GetStringPar(CommandLine, "ASSUMED_GAS_TEMPERATURE_RAMP", "");
            Baroclinic = CommonFunctions.GetBoolPar(CommandLine, "BAROCLINIC", true);
            BndfDefault = CommonFunctions.GetBoolPar(CommandLine, "BNDF_DEFAULT", true);
            CDeardorff = CommonFunctions.GetDoublePar(CommandLine, "C_DEARDORFF", 0.1);
        }
    }
}
