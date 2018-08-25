using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using FdsLauncher.Properties;
using System.Diagnostics;
using System.IO;

namespace FdsLauncher

{
    public static class FdsBgWorker
    {

        // Local background worker
        private static BackgroundWorker bgWorker;

        // Local reference to form
        private static FdsForm myFdsForm;

        #region Background Thread
        private static void StartBgWorker(object sender, DoWorkEventArgs e)
        {

            // Unpack arguments
            List<object> fdsArgs = (List<object>)e.Argument;
            string fdsExeFile = (string)fdsArgs[0];
            FdsFile fdsFile = (FdsFile)fdsArgs[1];
            string stopFile = Path.GetDirectoryName(fdsFile.FilePath) + @"\" + fdsFile.ChId + ".stop";

            // Create process object
            Process fdsProcess = new Process();
            fdsProcess.StartInfo.CreateNoWindow = true;
            fdsProcess.StartInfo.LoadUserProfile = true;
            fdsProcess.StartInfo.UseShellExecute = false;
            fdsProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(fdsFile.FilePath);
            fdsProcess.StartInfo.FileName = Settings.Default.FdsExe;
            fdsProcess.StartInfo.RedirectStandardOutput = true;
            fdsProcess.StartInfo.RedirectStandardError = true;
            fdsProcess.OutputDataReceived += (send, args) => { bgWorker.ReportProgress(0, args.Data); };
            fdsProcess.ErrorDataReceived += (send, args) => { bgWorker.ReportProgress(0, args.Data); };
            fdsProcess.StartInfo.Arguments = Path.GetFileName(fdsFile.FilePath);

            // Start async process
            fdsProcess.Start();
            fdsProcess.BeginOutputReadLine();
            fdsProcess.BeginErrorReadLine();

            while (!fdsProcess.HasExited)
            {
                Thread.Sleep(2000);
                if (bgWorker.CancellationPending)
                {
                    // To to this properly, write .stop file and wait for exit
                    if (fdsProcess != null)
                    {

                        // Kill FDS process
                        /*
                        fdsProcess.CancelOutputRead();
                        fdsProcess.CancelErrorRead();
                        fdsProcess.Kill();
                        fdsProcess.Dispose();
                        */
                        bgWorker.ReportProgress(0, "Sending STOP process..");
                        FileStream fileStream = File.Create(stopFile);
                        fileStream.Close();
                        fileStream.Dispose();
                    }
                    e.Cancel = true;
                    break;
                }
            }
            fdsProcess.CancelOutputRead();
            fdsProcess.CancelErrorRead();

        }

        #endregion

        // Wrapper method to check if background worker is running
        public static bool IsBgRunning()
        {
            if (bgWorker == null) { return false; }
            return bgWorker.IsBusy;
        }

        // Wrapper method to start FDS background worker
        public static void StartFds(FdsForm fdsForm, List<object> fdsArgs)
        {

            // TODO: Need to verify that RESTART is set in FDS file. This may be a restart.

            if (IsBgRunning()) { return; }

            // Get reference to form
            myFdsForm = fdsForm;

            // Initialise background worker, if not already there
            bgWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            bgWorker.DoWork += new DoWorkEventHandler(StartBgWorker);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(HandleBgProgress);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(HandleBgExit);

            // Start background worker
            myFdsForm.ClearConsole();
            myFdsForm.AddConsoleLine("--------------------");
            myFdsForm.AddConsoleLine("Starting FDS process");
            myFdsForm.AddConsoleLine("--------------------");
            bgWorker.RunWorkerAsync(fdsArgs);

        }

        // Method to handle return of FDS output
        private static void HandleBgProgress(object sender, ProgressChangedEventArgs e)
        {
            // Get output
            string output = (string)e.UserState;

            // Update console
            myFdsForm.AddConsoleLine(output);
        }

        // Method to handle background worker exit
        private static void HandleBgExit(object sender, RunWorkerCompletedEventArgs e)
        {
            // Check exit
            if (e.Cancelled == true)
            {
                myFdsForm.AddConsoleLine("-----------");
                myFdsForm.AddConsoleLine("FDS stopped");
                myFdsForm.AddConsoleLine("-----------");
            }
            else if (e.Error != null)
            {
                myFdsForm.AddConsoleLine("---------------");
                myFdsForm.AddConsoleLine("Error occurred:");
                myFdsForm.AddConsoleLine(e.Error.Message);
                myFdsForm.AddConsoleLine("---------------");
            }
            else
            {
                myFdsForm.AddConsoleLine("---------");
                myFdsForm.AddConsoleLine("Exited OK");
                myFdsForm.AddConsoleLine("---------");
            }

            // Restore buttons/menus
            myFdsForm.RefreshAllButtons();
            myFdsForm.RefreshAllMenus();
        }

        // Method to send cancel request to background worker
        public static void CancelBgWorker()
        {
            bgWorker.CancelAsync();
        }
    }
}
