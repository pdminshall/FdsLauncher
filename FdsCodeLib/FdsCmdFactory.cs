﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdsCodeLib
{

    /// <summary>
    /// Factory class for all FDS commands.
    /// </summary>
    public static class FdsCmdFactory
    {

        /// <summary>
        /// Create new sub-classed FdsCmd object.
        /// </summary>
        /// <param name="originalLines">Original data lines for command.</param>
        /// <param name="startLineNum">Start line number for command.</param>
        /// <param name="endLineNum">End line number for command.</param>
        /// <param name="commandNum">Sequential command number.</param>
        /// <returns></returns>
        public static FdsCmd Create(List<string> originalLines, int startLineNum, int endLineNum, int commandNum)
        {
            FdsCmd newFdsCmd = new FdsCmd(originalLines, startLineNum, endLineNum, commandNum);

            return newFdsCmd;
        }
    }
}
