using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store string doublet values.
    /// </summary>
    public struct StringDoublet
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
        /// Constructor with parameters.
        /// </summary>
        /// <param name="v1">V1 value.</param>
        /// <param name="v2">V2 value.</param>
        public StringDoublet(string v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }
    }
}
