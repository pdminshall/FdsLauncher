using System;
using System.Collections.Generic;
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

            // NDouble property
            if (objType == typeof(NDouble))
            {
                // Call double method with magic number for default
                double newVar = GetDoublePar(commandString, parameterName, -999999999);

                if (newVar == -999999999)
                {
                    // Send default parameter
                    return property;
                }
                else
                {
                    return new NDouble(true, newVar);
                }
            }

            // Int property
            if (objType == typeof(int))
            {
                return GetIntPar(commandString, parameterName, (int)property);
            }

            // NInt property
            if (objType == typeof(NInt))
            {
                // Call int method with magic number for default
                int newVar = GetIntPar(commandString, parameterName, -999999999);

                if (newVar == -999999999)
                {
                    // Send default parameter
                    return property;
                }
                else
                {
                    return new NInt(true, newVar);
                }
            }

            // RealTriplet property
            if (objType == typeof(RealTriplet))
            {
                return GetRealTripletPar(commandString, parameterName, (RealTriplet)property);
            }

            // RealDoublet property
            if (objType == typeof(RealDoublet))
            {
                return GetRealDoubletPar(commandString, parameterName, (RealDoublet)property);
            }

            // RealSextuplet property
            if (objType == typeof(RealSextuplet))
            {
                return GetRealSextupletPar(commandString, parameterName, (RealSextuplet)property);
            }

            // IntTriplet property
            if (objType == typeof(IntTriplet))
            {
                return GetIntTripletPar(commandString, parameterName, (IntTriplet)property);
            }

            // Dictionary<string, string> property
            if (objType == typeof(Dictionary<string, string>))
            {
                return GetStringDictPar(commandString, parameterName, (Dictionary<string, string>)property);
            }

            // Function type enum
            if (objType == typeof(FunctionTypeEnum))
            {
                string strVal = GetStringPar(commandString, parameterName, property.ToString());
                FunctionTypeEnum newVal = property;

                try
                {
                    newVal = (FunctionTypeEnum)Enum.Parse(typeof(FunctionTypeEnum), strVal);
                }
                catch (Exception) { }

                return newVal;
            }

            // List<string> property
            if (objType == typeof(List<string>))
            {
                return GetStringListPar(commandString, parameterName, (List<string>)property);
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
        /// Get string dictionary parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static Dictionary<string, string> GetStringDictPar(string commandString, string parameterName, Dictionary<string, string> defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *\( *([^\)]+) *\) *= *'([^']*)'");

            Match match = filter.Match(commandString);
            Dictionary<string, string> retVal = new Dictionary<string, string>();
            while (match.Success)
            {
                string key = match.Groups[1].Value;
                string value = match.Groups[2].Value;
                if (!retVal.ContainsKey(key)) { retVal.Add(key, value); }
                match = match.NextMatch();
            }

            return retVal;
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

            if (match.Success)
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

            if (match.Success)
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

            if (match.Success)
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

            if (match.Success)
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

        /// <summary>
        /// Get RealDoublet parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static RealDoublet GetRealDoubletPar(string commandString, string parameterName, RealDoublet defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*)");
            Match match = filter.Match(commandString);

            if (match.Success)
            {
                double tmp1;
                double tmp2;

                if (double.TryParse(match.Groups[1].Value, out tmp1) &&
                    double.TryParse(match.Groups[2].Value, out tmp2))
                {
                    return new RealDoublet(tmp1, tmp2);
                }
            }

            return defaultVal;
        }

        /// <summary>
        /// Get RealSextuplet parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static RealSextuplet GetRealSextupletPar(string commandString, string parameterName, RealSextuplet defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*) *, *(-?[0-9]+\.?[0-9]*)");
            Match match = filter.Match(commandString);

            if (match.Success)
            {
                double tmpXMin;
                double tmpXMax;
                double tmpYMin;
                double tmpYMax;
                double tmpZMin;
                double tmpZMax;

                if (double.TryParse(match.Groups[1].Value, out tmpXMin) &&
                    double.TryParse(match.Groups[2].Value, out tmpXMax) &&
                    double.TryParse(match.Groups[3].Value, out tmpYMin) &&
                    double.TryParse(match.Groups[4].Value, out tmpYMax) &&
                    double.TryParse(match.Groups[5].Value, out tmpZMin) &&
                    double.TryParse(match.Groups[6].Value, out tmpZMax))
                {
                    return new RealSextuplet(tmpXMin, tmpXMax, tmpYMin, tmpYMax, tmpZMin, tmpZMax);
                }
            }

            return defaultVal;
        }

        /// <summary>
        /// Get IntTriplet parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static IntTriplet GetIntTripletPar(string commandString, string parameterName, IntTriplet defaultVal)
        {
            Regex filter = new Regex(parameterName + @" *= *(-?[0-9]+) *, *(-?[0-9]+) *, *(-?[0-9]+)");
            Match match = filter.Match(commandString);

            if (match.Success)
            {
                int tmpX;
                int tmpY;
                int tmpZ;

                if (int.TryParse(match.Groups[1].Value, out tmpX) &&
                    int.TryParse(match.Groups[2].Value, out tmpY) &&
                    int.TryParse(match.Groups[3].Value, out tmpZ))
                {
                    return new IntTriplet(tmpX, tmpY, tmpZ);
                }
            }

            return defaultVal;
        }

        /// <summary>
        /// Get string list parameter value.
        /// </summary>
        /// <param name="commandString">Full command string.</param>
        /// <param name="parameterName">Name of parameter to fetch.</param>
        /// <param name="defaultVal">Default value if not found.</param>
        /// <returns>Value of parameter.</returns>
        public static List<string> GetStringListPar(string commandString, string parameterName, List<string> defaultVal)
        {

            List<string> retVal = defaultVal;

            Regex filter = new Regex(parameterName + @" *= *('.*)");

            Match match = filter.Match(commandString);
            if (match.Success)
            {

                // Need to move through string and parse all quoted values.
                // Make sure that next parameter is detected to end parsing.

                string line = match.Groups[1].Value;

                // State machine with states: INSIDE_QUOTE, BEFORE_COMMA, AFTER_COMMA
                string state = "AFTER_COMMA";
                string value = "";
                retVal = new List<string>();
                for (int cnt = 0; cnt < line.Length; cnt++)
                {
                    string singChar = line.Substring(cnt, 1);

                    // After comma, look for new value or end of list
                    if (state == "AFTER_COMMA")
                    {
                        // If space after commad, carry on
                        if (singChar == " ") { continue; }

                        // If quote after comma, start new value
                        if (singChar == "'")
                        {
                            state = "INSIDE_QUOTE";
                            value = "";
                            continue;
                        }
                    }

                    // Inside quotes, record value and look for end of quote
                    if (state == "INSIDE_QUOTE")
                    {
                        if (singChar == "'")
                        {
                            state = "BEFORE_COMMA";
                            retVal.Add(value);
                            continue;
                        }

                        value += singChar;
                        continue;
                    }

                    // Before comma, look for comma
                    if (state == "BEFORE_COMMA")
                    {
                        if (singChar == ",")
                        {
                            state = "AFTER_COMMA";
                        }
                    }
                }
            }

            return retVal;
        }
    }
}
