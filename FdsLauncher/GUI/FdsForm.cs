using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FdsLauncher
{
    public partial class FdsForm : Form
    {
        #region Form Startup/Shutdown
        public FdsForm()
        {
            InitializeComponent();
        }

        // When form loaded
        private void FdsLauncherForm_Load(object sender, EventArgs e)
        {
            // Load window size and position
            this.Location = Properties.Settings.Default.WindowLocation;
            this.Size = Properties.Settings.Default.WindowSize;

            // Refresh menus
            MenuRefresh();
        }

        // When form closing
        private void FdsLauncherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask for confirmation, if user closed form
            if ((e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.UserClosing) &&
                MessageBox.Show("Are you sure you want to close this?",
                                "Close FDS Launcher",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            // Save window size and position
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.Save();
        }
        #endregion

    }
}
