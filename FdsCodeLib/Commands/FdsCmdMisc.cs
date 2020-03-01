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
        /// Allow surface particles.
        /// </summary>
        public bool AllowSurfaceParticles { get; private set; }

        /// <summary>
        /// Allow underside particles.
        /// </summary>
        public bool AllowUndersideParticles { get; private set; }

        /// <summary>
        /// Assumed gas temperature.
        /// </summary>
        public double? AssumedGasTemperature { get; private set; }

        /// <summary>
        /// Assumed gas temperature ramp.
        /// </summary>
        public string AssumedGasTemperatureRamp { get; private set; }

        /// <summary>
        /// Restart simulation from restart point.
        /// </summary>
        public bool Restart { get; private set; }

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
            Restart = CommonFunctions.GetBoolPar(CommandLine, "RESTART", false);
        }
    }
}
