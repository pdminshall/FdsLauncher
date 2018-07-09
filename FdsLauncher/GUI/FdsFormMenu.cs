using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FdsLauncher.Properties;

namespace FdsLauncher
{
    // Methods for processing menu options
    public partial class FdsForm : Form
    {
        // Menu refresh method
        private void MenuRefresh()
        {
            MenuSettingsFdsExeRefresh();
            MenuSettingsSmvExeRefresh();

            // TODO: Use flags to determine if menus are active
            // TODO: Need to disable menus if FDS is running
        }

        // Exit menu option
        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Handle change of FDS executable folder
        private void MenuSettingsFdsExe_Click(object sender, EventArgs e)
        {
            string oldFdsExe = Settings.Default.FdsExe;

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".exe",
                FileName = oldFdsExe,
                Title = "Select FDS executable (fds.exe)",
                InitialDirectory = Path.GetDirectoryName(oldFdsExe)
            };

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings.Default.FdsExe = fileDialog.FileName;
                Settings.Default.Save();
            }

            MenuSettingsFdsExeRefresh();
        }

        // Refresh FDS menu item
        private void MenuSettingsFdsExeRefresh()
        {
            MenuSettingsFdsExe.Text = "FDS executable file = " + Settings.Default.FdsExe;
        }

        // Handle change of SMV executable folder
        private void MenuSettingsSmvExe_Click(object sender, EventArgs e)
        {
            string oldSmvExe = Settings.Default.SmvExe;

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".exe",
                FileName = oldSmvExe,
                Title = "Select Smokeview executable (smokeview.exe)",
                InitialDirectory = Path.GetDirectoryName(oldSmvExe)
            };

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings.Default.SmvExe = fileDialog.FileName;
                Settings.Default.Save();
            }

            MenuSettingsSmvExeRefresh();
        }

        // Refresh SMV menu item
        private void MenuSettingsSmvExeRefresh()
        {
            MenuSettingsSmvExe.Text = "Smokeview executable file = " + Settings.Default.SmvExe;
        }
    }
}
