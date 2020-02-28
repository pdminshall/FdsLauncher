using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        /// <returns>Value of parameter.</returns>
        public static string GetStringPar(string commandString, string parameterName)
        {
            Regex filter = new Regex(parameterName + @" *= *'([^']*)'");
            Match match = filter.Match(commandString);

            if (match.Groups.Count > 1)
            {
                return match.Groups[1].Value;
            }

            return "";
        }
    }
}
