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
        /// <returns></returns>
        public static FdsCmd Create(List<string> originalLines, int startLineNum, int endLineNum, int commandNum)
        {

            // Make base object first to calculate command type
            FdsCmd newFdsCmd = new FdsCmd(originalLines, startLineNum, endLineNum, commandNum);

            // Make sub class object for each command type
            switch (newFdsCmd.CommandType)
            {
                case FdsCmdType.BNDF:
                    {
                        newFdsCmd = new FdsCmdBndf(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
                case FdsCmdType.CLIP:
                    {
                        newFdsCmd = new FdsCmdClip(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
                case FdsCmdType.CSVF:
                    {
                        newFdsCmd = new FdsCmdCsvf(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
                case FdsCmdType.CTRL:
                    {
                        newFdsCmd = new FdsCmdCtrl(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
                case FdsCmdType.DEVC:
                    {
                        newFdsCmd = new FdsCmdDevc(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
                case FdsCmdType.HEAD:
                    {
                        newFdsCmd = new FdsCmdHead(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
                case FdsCmdType.MISC:
                    {
                        newFdsCmd = new FdsCmdMisc(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
                case FdsCmdType.MESH:
                    {
                        newFdsCmd = new FdsCmdMesh(originalLines, startLineNum, endLineNum, commandNum);
                        break;
                    }
            }

            return newFdsCmd;
        }
    }
}
