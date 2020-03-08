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
        /// X coord.
        /// </summary>
        public double X;

        /// <summary>
        /// Y coord.
        /// </summary>
        public double Y;

        /// <summary>
        /// Z coord.
        /// </summary>
        public double Z;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="x">X coord.</param>
        /// <param name="y">Y coord.</param>
        /// <param name="z">Z coord.</param>
        public RealTriplet(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
