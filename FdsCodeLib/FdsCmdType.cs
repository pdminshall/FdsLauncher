using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{
    /// <summary>
    /// List of FDS commands.
    /// </summary>
    public enum FdsCmdType
    {
        /// <summary>
        /// Null command.
        /// </summary>
        NONE,
        
        /// <summary>
        /// File header.
        /// </summary>
        HEAD,

        /// <summary>
        /// Miscellaneous settings.
        /// </summary>
        MISC,

        /// <summary>
        /// Mesh object.
        /// </summary>
        MESH
    }
}
