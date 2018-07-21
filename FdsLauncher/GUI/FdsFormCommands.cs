using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FdsLauncher.Properties;
using System.Diagnostics;
using System.Threading;

namespace FdsLauncher
{
    // Methods for processing command buttons
    public partial class FdsForm : Form
    {

        // Test FDS executable
        private void BtnTestFds_Click(object sender, EventArgs e)
        {

            // Disable all buttons
            DisableAllMenus();
            DisableAllButtons();
            Application.DoEvents();

            // Console output object
            List<string> strOutput = new List<string>();

            // Write header to console
            ClearConsole();
            AddConsoleLines("----------------------");
            AddConsoleLines("Testing FCM executable");
            AddConsoleLines("----------------------");

            // Create process object
            Process fcmProcess = new Process();
            fcmProcess.StartInfo.CreateNoWindow = true;
            fcmProcess.StartInfo.LoadUserProfile = true;
            fcmProcess.StartInfo.UseShellExecute = false;
            fcmProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(Settings.Default.FdsExe);
            fcmProcess.StartInfo.FileName = Settings.Default.FdsExe;
            fcmProcess.StartInfo.RedirectStandardOutput = true;
            fcmProcess.StartInfo.RedirectStandardError = true;
            fcmProcess.StartInfo.RedirectStandardInput = true;
            fcmProcess.OutputDataReceived += (send, args) => { strOutput.Add(args.Data); };
            fcmProcess.ErrorDataReceived += (send, args) => { strOutput.Add(args.Data); };
            fcmProcess.StartInfo.Arguments = "";

            // Try running process
            try
            {
                // Start process
                fcmProcess.Start();
                fcmProcess.BeginOutputReadLine();
                fcmProcess.BeginErrorReadLine();
                fcmProcess.StandardInput.WriteLine("");
                fcmProcess.WaitForExit();
                fcmProcess.CancelErrorRead();
                fcmProcess.CancelOutputRead();
                AddConsoleLines(strOutput.ToArray<string>());
            }
            catch (Exception ex)
            {
                // Some problem with executable
                AddConsoleLines("ERROR: Some problem running FDS");
                AddConsoleLines(ex.Message);

            }
            finally
            {
                if (fcmProcess != null)
                {
                    fcmProcess.Dispose();
                }
            }

            // Refresh console
            AddConsoleLines("--------");
            AddConsoleLines("Finished");
            AddConsoleLines("--------");
            RefreshConsole();

            // Refresh all buttons
            EnableAllMenus();
            EnableAllButtons();

        }

        private void DisableAllButtons()
        {
            BtnPickFile.Enabled = false;
            BtnTestFds.Enabled = false;
        }
        private void EnableAllButtons()
        {
            BtnPickFile.Enabled = true;
            BtnTestFds.Enabled = true;
        }
    }

}
