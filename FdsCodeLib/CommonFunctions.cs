using System;
using System.Text.RegularExpressions;

namespace FdsCodeLib
{
    /// <summary>
    /// Common functions for parsing commands.
    /// </summary>
    public static class CommonFunctions
    {

        /// <summary>
        /// Generic value getter. This detects the object type and calls the appropriate routine.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="property">Reference to property in command object.</param>
        public static dynamic GetValue(string commandString, string parameterName, dynamic property)
        {
            Type objType = property.GetType();

            // String property
            if (objType == typeof(string))
            {
                return GetStringPar(commandString, parameterName, (string)property);
            }

            // Boolean property
            if (objType == typeof(bool))
            {
                return GetBoolPar(commandString, parameterName, (bool)property);
            }

            // Double property
            if (objType == typeof(double))
            {
                return GetDoublePar(commandString, parameterName, (double)property);
            }

            // Int property
            if (objType == typeof(int))
            {
                return GetIntPar(commandString, parameterName, (int)property);
            }

            // RealTriplet property
            if (objType == typeof(RealTriplet))
            {
                return GetRealTripletPar(commandString, parameterName, (RealTriplet)property);
            }

            return null;
        }

        /// <summary>
        /// Get string parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static string GetStringPar(string commandString, string parameterName, string defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *'([^']*)'");
            Match match = filter.Match(commandString);

            if (match.Groups.Count > 1)
            {
                return match.Groups[1].Value;
            }

            return defaultVal;
        }

        /// <summary>
        /// Get boolean parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static bool GetBoolPar(string commandString, string parameterName, bool defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *\.([^\.]*)\.");
            Match match = filter.Match(commandString);

            if (match.Groups.Count > 1)
            {
                if (match.Groups[1].Value == "TRUE") { return true; }
                if (match.Groups[1].Value == "FALSE") { return false; }
            }

            return defaultVal;
        }

        /// <summary>
        /// Get double parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static double GetDoublePar(string commandString, string parameterName, double defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *(-?[0-9]+\.?[0-9]*)");
            Match match = filter.Match(commandString);

            if (match.Groups.Count > 1)
            {
                double tmpDbl;
                if (double.TryParse(match.Groups[1].Value, out tmpDbl))
                {
                    return tmpDbl;
                }
            }

            return defaultVal;
        }

        /// <summary>
        /// Get int parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static int GetIntPar(string commandString, string parameterName, int defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *(-?[0-9]+\.?)");
            Match match = filter.Match(commandString);

            if (match.Groups.Count > 1)
            {
                int tmpInt;
                if (int.TryParse(match.Groups[1].Value.Trim('.'), out tmpInt))
                {
                    return tmpInt;
                }
            }

            return defaultVal;
        }

        /// <summary>
        /// Get RealTriplet parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static RealTriplet GetRealTripletPar(string commandString, string parameterName, RealTriplet defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*)");
            Match match = filter.Match(commandString);

            if (match.Groups.Count == 4)
            {
                double tmpX;
                double tmpY;
                double tmpZ;

                if (double.TryParse(match.Groups[1].Value, out tmpX) &&
                    double.TryParse(match.Groups[2].Value, out tmpY) &&
                    double.TryParse(match.Groups[3].Value, out tmpZ))
                {
                    return new RealTriplet(tmpX, tmpY, tmpZ);
                }
            }

            return defaultVal;
        }

    }
}
