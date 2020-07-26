using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store real doublet values.
    /// </summary>
    public struct RealDoublet
    {

        /// <summary>
        /// Flag to set if struct has set value.
        /// </summary>
        public readonly bool HasValue;

        /// <summary>
        /// V1 value.
        /// </summary>
        public readonly double V1;

        /// <summary>
        /// V2 value.
        /// </summary>
        public readonly double V2;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="v1">V1 value.</param>
        /// <param name="v2">V2 value.</param>
        public RealDoublet(double v1, double v2)
        {
            HasValue = true;
            V1 = v1;
            V2 = v2;
        }
    }
}
