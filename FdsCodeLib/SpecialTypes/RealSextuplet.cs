namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store real triplet values.
    /// </summary>
    public struct RealSextuplet
    {
        /// <summary>
        /// X min coord.
        /// </summary>
        public double XMin;

        /// <summary>
        /// X max coord.
        /// </summary>
        public double XMax;

        /// <summary>
        /// Y min coord.
        /// </summary>
        public double YMin;

        /// <summary>
        /// Y max coord.
        /// </summary>
        public double YMax;

        /// <summary>
        /// Z min coord.
        /// </summary>
        public double ZMin;

        /// <summary>
        /// Z max coord.
        /// </summary>
        public double ZMax;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="xMin">X min coord.</param>
        /// <param name="xMax">X max coord.</param>
        /// <param name="yMin">Y min coord.</param>
        /// <param name="yMax">Y max coord.</param>
        /// <param name="zMin">Z min coord.</param>
        /// <param name="zMax">Z max coord.</param>
        public RealSextuplet(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
        {
            XMin = xMin;
            XMax = xMax;
            YMin = yMin;
            YMax = yMax;
            ZMin = zMin;
            ZMax = zMax;
        }
    }
}
