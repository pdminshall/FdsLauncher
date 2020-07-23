using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store string quintet values.
    /// </summary>
    public struct StringQuintet
    {
        /// <summary>
        /// V1 value.
        /// </summary>
        public string V1;

        /// <summary>
        /// V2 value.
        /// </summary>
        public string V2;

        /// <summary>
        /// V3 value.
        /// </summary>
        public string V3;

        /// <summary>
        /// V4 value.
        /// </summary>
        public string V4;

        /// <summary>
        /// V5 value.
        /// </summary>
        public string V5;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="v1">V1 value.</param>
        /// <param name="v2">V2 value.</param>
        /// <param name="v3">V3 value.</param>
        /// <param name="v4">V4 value.</param>
        /// <param name="v5">V5 value.</param>
        public StringQuintet(string v1, string v2, string v3, string v4, string v5 )
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
        }
    }
}
