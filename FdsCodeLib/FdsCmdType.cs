﻿namespace FdsCodeLib
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

        BNDF,
        CLIP,
        CSVF,
        CTRL,
        DEVC,
        DUMP,

        /// <summary>
        /// File header.
        /// </summary>
        HEAD,

        HOLE,
        HVAC,
        INIT,
        ISOF,
        MATL,

        /// <summary>
        /// Mesh object.
        /// </summary>
        MESH,

        /// <summary>
        /// Miscellaneous settings.
        /// </summary>
        MISC,

        MULT,
        OBST,
        PART,
        PRES,
        PROF,
        PROP,
        RADI,
        RAMP,
        REAC,
        SLCF,
        SPEC,
        SURF,
        TABL,
        TIME,
        TRNX,
        TRNY,
        TRNZ,
        VENT,
        WIND,
        ZONE


    }
}
