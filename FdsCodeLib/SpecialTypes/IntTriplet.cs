﻿namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store int triplet values.
    /// </summary>
    public struct IntTriplet
    {
        /// <summary>
        /// V1 value.
        /// </summary>
        public int V1;

        /// <summary>
        /// V2 value.
        /// </summary>
        public int V2;

        /// <summary>
        /// V3 value.
        /// </summary>
        public int V3;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="v1">V1 value.</param>
        /// <param name="v2">V2 value.</param>
        /// <param name="v3">V3 value.</param>
        public IntTriplet(int v1, int v2, int v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }
    }
}
