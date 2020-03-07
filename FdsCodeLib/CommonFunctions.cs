using System.Text.RegularExpressions;

namespace FdsCodeLib
{
    /// <summary>
    /// Common functions for parsing commands.
    /// </summary>
    public static class CommonFunctions
    {

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
        /// Get nullable double parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static double? GetNDoublePar(string commandString, string parameterName, double? defaultVal)
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
    }
}
