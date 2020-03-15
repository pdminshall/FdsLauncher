namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store nullable double.
    /// </summary>
    public struct NDouble
    {
        /// <summary>
        /// Flag to indicate if value is set.
        /// </summary>
        public bool HasValue;

        /// <summary>
        /// Underlying double value.
        /// </summary>
        public double Value;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="hasValue">Existence flag.</param>
        /// <param name="value">Underlying value.</param>
        public NDouble(bool hasValue, double value)
        {
            HasValue = hasValue;
            Value = value;
        }
    }
}
