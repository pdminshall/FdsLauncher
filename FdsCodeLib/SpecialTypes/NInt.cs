namespace FdsCodeLib
{
    /// <summary>
    /// Structure to store nullable int.
    /// </summary>
    public struct NInt
    {
        /// <summary>
        /// Flag to indicate if value is set.
        /// </summary>
        public bool HasValue;

        /// <summary>
        /// Underlying int value.
        /// </summary>
        public int Value;

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="hasValue">Existence flag.</param>
        /// <param name="value">Underlying value.</param>
        public NInt(bool hasValue, int value)
        {
            HasValue = hasValue;
            Value = value;
        }
    }
}
