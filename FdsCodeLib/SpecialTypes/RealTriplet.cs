using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store real triplet values.
    /// </summary>
    public struct RealTriplet
    {
        /// <summary>
        /// V1 value.
        /// </summary>
        public double V1;

        /// <summary>
        /// V2 value.
        /// </summary>
        public double V2;

        /// <summary>
        /// V3 value.
        /// </summary>
        public double V3;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="v1">V1 value.</param>
        /// <param name="v2">V2 value.</param>
        /// <param name="v3">V3 value.</param>
        public RealTriplet(double v1, double v2, double v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }
    }
}
