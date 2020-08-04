using System.Collections.Generic;

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
        /// <param name="fileReference">Reference to parent file object.</param>
        /// <returns></returns>
        public static FdsCmd Create(List<string> originalLines, int startLineNum, int endLineNum, int commandNum, FdsFile fileReference)
        {

            // Make base object first to calculate command type
            FdsCmd newFdsCmd = new FdsCmd(originalLines, startLineNum, endLineNum, commandNum, fileReference);

            // Make sub class object for each command type
            switch (newFdsCmd.CommandType)
            {
                case FdsCmdType.BNDF:
                    {
                        newFdsCmd = new FdsCmdBndf(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.CLIP:
                    {
                        newFdsCmd = new FdsCmdClip(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.CSVF:
                    {
                        newFdsCmd = new FdsCmdCsvf(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.CTRL:
                    {
                        newFdsCmd = new FdsCmdCtrl(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.DEVC:
                    {
                        newFdsCmd = new FdsCmdDevc(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.DUMP:
                    {
                        newFdsCmd = new FdsCmdDump(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.HEAD:
                    {
                        newFdsCmd = new FdsCmdHead(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.HOLE:
                    {
                        newFdsCmd = new FdsCmdHole(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.HVAC:
                    {
                        newFdsCmd = new FdsCmdHvac(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.ISOF:
                    {
                        newFdsCmd = new FdsCmdIsof(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.MISC:
                    {
                        newFdsCmd = new FdsCmdMisc(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.MESH:
                    {
                        newFdsCmd = new FdsCmdMesh(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
                case FdsCmdType.TIME:
                    {
                        newFdsCmd = new FdsCmdTime(originalLines, startLineNum, endLineNum, commandNum, fileReference);
                        break;
                    }
            }

            return newFdsCmd;
        }
    }
}
