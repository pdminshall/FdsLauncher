using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// Function types for CTRL objects.
    /// </summary>
    public enum FunctionTypeEnum
    {
        /// <summary>
        /// Default value.
        /// </summary>
        NONE,

        /// <summary>
        /// Change state if any inputs are true.
        /// </summary>
        ANY,

        /// <summary>
        /// Change state if all inputs are true.
        /// </summary>
        ALL,

        /// <summary>
        /// Change state if only N inputs are true.
        /// </summary>
        ONLY,

        /// <summary>
        /// Change state if at least N inputs are true.
        /// </summary>
        AT_LEAST,

        /// <summary>
        /// Change state DELAY seconds after input becomes true.
        /// </summary>
        TIME_DELAY,

        /// <summary>
        /// Change state based on ramp of input.
        /// </summary>
        CUSTOM,

        /// <summary>
        /// Behave like a thermostat.
        /// </summary>
        DEADBAND,

        /// <summary>
        /// Terminate execution if input is true.
        /// </summary>
        KILL,

        /// <summary>
        /// Dump restart files if input is true.
        /// </summary>
        RESTART,

        /// <summary>
        /// Sum all inputs.
        /// </summary>
        SUM,

        /// <summary>
        /// Subtract second input from first.
        /// </summary>
        SUBTRACT,

        /// <summary>
        /// Multiply all inputs.
        /// </summary>
        MULTIPLY,

        /// <summary>
        /// Divide first input by second.
        /// </summary>
        DIVIDE,

        /// <summary>
        /// First input to power of second.
        /// </summary>
        POWER,

        /// <summary>
        /// Exponential of input.
        /// </summary>
        EXP,

        /// <summary>
        /// Natural log of input.
        /// </summary>
        LOG,

        /// <summary>
        /// Cosine of input.
        /// </summary>
        COS,

        /// <summary>
        /// Sine of input.
        /// </summary>
        SIN,

        /// <summary>
        /// Arccosine of input.
        /// </summary>
        ACOS,

        /// <summary>
        /// Arcine of input.
        /// </summary>
        ASIN,

        /// <summary>
        /// Proportional-Integral-Derivative control function.
        /// </summary>
        PID
    }
}
