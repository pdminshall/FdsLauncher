namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store real triplet values.
    /// </summary>
    public struct RealSextuplet
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
        /// V4 value.
        /// </summary>
        public double V4;

        /// <summary>
        /// V5 value.
        /// </summary>
        public double V5;

        /// <summary>
        /// V6 value.
        /// </summary>
        public double V6;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="v1">V1 value.</param>
        /// <param name="v2">V2 value.</param>
        /// <param name="v3">V3 value.</param>
        /// <param name="v4">V4 value.</param>
        /// <param name="v5">V5 value.</param>
        /// <param name="v6">V6 value.</param>
        public RealSextuplet(double v1, double v2, double v3, double v4, double v5, double v6)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
        }
    }
}
