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
        /// Boundary File Parameters.
        /// </summary>
        BNDF,

        /// <summary>
        /// Clipping parameters.
        /// </summary>
        CLIP,

        /// <summary>
        /// CSV File parameter.
        /// </summary>
        CSVF,

        /// <summary>
        /// Control object.
        /// </summary>
        CTRL,

        /// <summary>
        /// Device parameters.
        /// </summary>
        DEVC,

        /// <summary>
        /// Dump command.
        /// </summary>
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
