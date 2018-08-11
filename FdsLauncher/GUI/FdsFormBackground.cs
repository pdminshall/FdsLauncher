using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace FdsLauncher

{
    public partial class FdsForm : Form
    {

        #region Background Thread
        private void StartBgWorker(object sender, DoWorkEventArgs e)
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
            output = "Test 2";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            output = "Test 3";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            output = "Test 4";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            output = "Test 5";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);
            output = "Test 6";
            bgWorker.ReportProgress(0, output);
            Thread.Sleep(5000);

        }

        #endregion

        private bool IsBgRunning()
        {
            return bgWorker.IsBusy;
        }

        private void StartFds(List<string> fdsArgs)
        {
            if (IsBgRunning()) { return; }

            bgWorker.RunWorkerAsync(fdsArgs);

        }

        // TODO: Method to handle progress
        private void HandleBgProgress(object sender, ProgressChangedEventArgs e)
        {
            // Get output
            string output = (string)e.UserState;

            // Update console
            AddConsoleLines(output);
        }

        // TODO: Method to handle background worker exit
        private void HandleBgExit(object sender, RunWorkerCompletedEventArgs e)
        {
            // Check exit
            if (e.Cancelled == true)
            {
                AddConsoleLines("Processed cancelled");
            }
            else if(e.Error != null)
            {
                AddConsoleLines("Error occurred:");
                AddConsoleLines(e.Error.Message);
            }
            else
            {
                AddConsoleLines("Exited OK");
            }

            // Restore buttons/menus
            RefreshAllButtons();
            RefreshAllMenus();
        }
    }
}
