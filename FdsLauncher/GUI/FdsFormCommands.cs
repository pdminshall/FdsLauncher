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

        // Test routine for FDS
        private void BtnTestFds_Click(object sender, EventArgs e)
        {

            // TODO: Disable all buttons
            DisableAllMenus();
            DisableAllButtons();
            Application.DoEvents();

            // Write header to console
            ClearConsole();
            AddConsoleLines("----------------------");
            AddConsoleLines("Testing FCM executable");
            AddConsoleLines("----------------------");

            // Create process object
            Process fcmProcess = new Process();
            fcmProcess.StartInfo.CreateNoWindow = false;
            fcmProcess.StartInfo.LoadUserProfile = true;
            fcmProcess.StartInfo.UseShellExecute = true;
            fcmProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(Settings.Default.FdsExe);
            fcmProcess.StartInfo.FileName = Settings.Default.FdsExe;
            fcmProcess.StartInfo.Arguments = "";

            // Try running process
            try
            {
                // Start process
                fcmProcess.Start();

                // Wait for exit
                fcmProcess.WaitForExit();
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
            AddConsoleLines("OK");
            RefreshConsole();

            // TODO: Refresh all buttons
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
