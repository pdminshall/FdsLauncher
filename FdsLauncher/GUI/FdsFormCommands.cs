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
            AddConsoleLine("----------------------");
            AddConsoleLine("Testing FCM executable");
            AddConsoleLine("----------------------");

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
                AddConsoleLine("ERROR: Some problem running FDS");
                AddConsoleLine(ex.Message);

            }
            finally
            {
                if (fcmProcess != null)
                {
                    fcmProcess.Dispose();
                }
            }

            // Refresh console
            AddConsoleLine("--------");
            AddConsoleLine("Finished");
            AddConsoleLine("--------");
            RefreshConsole();

            // Refresh all buttons
            RefreshAllButtons();
            RefreshAllMenus();

        }

        private void DisableAllButtons()
        {
            BtnPickFile.Enabled = false;
            BtnTestFds.Enabled = false;
            BtnStartFds.Enabled = false;
            BtnStopFds.Enabled = false;
        }

        public void RefreshAllButtons()
        {
            if (FdsBgWorker.IsBgRunning())
            {
                BtnPickFile.Enabled = false;
                BtnTestFds.Enabled = false;
                BtnStartFds.Enabled = false;
                BtnStopFds.Enabled = true;
            }
            else
            {
                BtnPickFile.Enabled = true;
                BtnTestFds.Enabled = true;
                if (File.Exists(LblFdsDataFile.Text))
                {
                    BtnStartFds.Enabled = true;
                }
                else
                {
                    BtnStartFds.Enabled = false;
                }
                BtnStopFds.Enabled = false;
            }
        }

        private void BtnStartFds_Click(object sender, EventArgs e)
        {

            // Disable all commands and menus and refresh GUI
            DisableAllButtons();
            DisableAllMenus();
            Application.DoEvents();

            // Make sure that process is not already running
            if (FdsBgWorker.IsBgRunning())
            {
                RefreshAllButtons();
                RefreshAllMenus();
                return;
            }

            // Check if exe and data is valid
            if (!File.Exists(LblFdsDataFile.Text) || !File.Exists(Settings.Default.FdsExe)) { return; }

            // Reload file and check restart flag
            MyFdsFile.LoadFile();
            LblRestartFlag.Text = "RESTART=." + (MyFdsFile.IsRestart ? "TRUE" : "FALSE") + ".";

            // Ask if really want to start
            if (MessageBox.Show("Are you sure?",
                                "FDS Start",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                RefreshAllButtons();
                RefreshAllMenus();
                return;
            }

            if (!MyFdsFile.IsRestart)
            {
                // No restart. Ask if really want to start
                if (MessageBox.Show("Data file has no restart flag set. Are you really sure?",
                                    "No restart flag set!",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    RefreshAllButtons();
                    RefreshAllMenus();
                    return;
                }
            }

            // Build arguments for background worker
            string fdsExeFile = Settings.Default.FdsExe;
            string fdsDataFile = LblFdsDataFile.Text;
            List<object> fdsArgs = new List<object>
            {
                fdsExeFile,
                MyFdsFile
            };

            // Run wrapper function to start background worker
            FdsBgWorker.StartFds(this, fdsArgs);

            // Refresh all buttons and menus
            RefreshAllButtons();
            RefreshAllMenus();
        }

        private void BtnStopFds_Click(object sender, EventArgs e)
        {
            // Write intention to stop process and send interrupt to background worker
            AddConsoleLine("Interrupt pending..");
            FdsBgWorker.CancelBgWorker();
        }

        // Button to select FDS data file
        private void BtnPickFile_Click(object sender, EventArgs e)
        {
            // Make sure nothing is running
            if (FdsBgWorker.IsBgRunning()) { return; }

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "FDS files (*.fds)|*.fds",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".fds",
                FileName = LblFdsDataFile.Text,
                Title = "Select FDS data file (*.fds)",
                InitialDirectory = Settings.Default.DataFolder
            };

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK && Path.GetExtension(fileDialog.FileName).ToLower() == ".fds")
            {
                LblFdsDataFile.Text = fileDialog.FileName;
            }

            // Load FDS file
            MyFdsFile = new FdsFile(LblFdsDataFile.Text);
            LblChId.Text = "CHID = '" + MyFdsFile.ChId + "'";
            LblRestartFlag.Text = "RESTART=." + (MyFdsFile.IsRestart ? "TRUE" : "FALSE") + ".";

            RefreshAllButtons();
        }
    }

}
