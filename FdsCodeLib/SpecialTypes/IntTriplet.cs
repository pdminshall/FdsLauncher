namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store int triplet values.
    /// </summary>
    public struct IntTriplet
    {
        /// <summary>
        /// X coord.
        /// </summary>
        public int X;

        /// <summary>
        /// Y coord.
        /// </summary>
        public int Y;

        /// <summary>
        /// Z coord.
        /// </summary>
        public int Z;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="x">X coord.</param>
        /// <param name="y">Y coord.</param>
        /// <param name="z">Z coord.</param>
        public IntTriplet(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
