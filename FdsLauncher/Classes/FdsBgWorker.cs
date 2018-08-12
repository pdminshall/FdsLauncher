using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

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
            List<string> fdsArgs = (List<string>)e.Argument;
            string fdsExeFile = fdsArgs[0];
            string fdsDataFile = fdsArgs[1];

            // TODO: Start async process and send output to progress monitor
            string output = "";
            output = "Test 1";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            if (bgWorker.CancellationPending)
            {
                // TODO: To to this properly, write .stop file and wait for exit
                e.Cancel = true;
                return;
            }
            output = "Test 2";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            if (bgWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            output = "Test 3";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            if (bgWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            output = "Test 4";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            if (bgWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            output = "Test 5";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            if (bgWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            output = "Test 6";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);

        }

        #endregion

        // Wrapper method to check if background worker is running
        public static bool IsBgRunning()
        {
            if (bgWorker == null) { return false; }
            return bgWorker.IsBusy;
        }

        // Wrapper method to start FDS background worker
        public static void StartFds(FdsForm fdsForm, List<string> fdsArgs)
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
            myFdsForm.AddConsoleLine("Starting FDS process");
            bgWorker.ReportProgress(0, "Exe = " + fdsArgs[0]);
            bgWorker.ReportProgress(0, "Data = " + fdsArgs[1]);
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
                myFdsForm.AddConsoleLine("Processed cancelled");
            }
            else if (e.Error != null)
            {
                myFdsForm.AddConsoleLine("Error occurred:");
                myFdsForm.AddConsoleLine(e.Error.Message);
            }
            else
            {
                myFdsForm.AddConsoleLine("Exited OK");
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
