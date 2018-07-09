using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FdsLauncher.Properties;

namespace FdsLauncher
{
    // Methods for processing menu options
    public partial class FdsForm : Form
    {
        // Menu refresh method
        private void MenuRefresh()
        {
            MenuSettingsFdsFolderRefresh();
            MenuSettingsSmvFolderRefresh();

            // TODO: Use flags to determine if menus are active
            // TODO: Need to disable menus if FDS is running
        }

        // Exit menu option
        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Handle change of FDS executable folder
        private void MenuSettingsFdsFolder_Click(object sender, EventArgs e)
        {
            string oldFdsFolder = Settings.Default.FdsFolder;

            FolderBrowserDialog folderDialog = new FolderBrowserDialog
            {
                Description = "Select FDS executable folder\n" +
                              "(" + oldFdsFolder + ")",
                SelectedPath = oldFdsFolder,
                ShowNewFolderButton = false
            };
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings.Default.FdsFolder = folderDialog.SelectedPath;
                Settings.Default.Save();
            }

            MenuSettingsFdsFolderRefresh();
        }

        // Refresh FDS menu item
        private void MenuSettingsFdsFolderRefresh()
        {
            MenuSettingsFdsFolder.Text = "FDS executable folder = " + Settings.Default.FdsFolder;
        }

        // Handle change of SMV executable folder
        private void MenuSettingsSmvFolder_Click(object sender, EventArgs e)
        {
            string oldSmvFolder = Settings.Default.SmvFolder;

            FolderBrowserDialog folderDialog = new FolderBrowserDialog
            {
                Description = "Select Smokeview executable folder\n" +
                              "(" + oldSmvFolder + ")",
                SelectedPath = oldSmvFolder,
                ShowNewFolderButton = false
            };
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings.Default.SmvFolder = folderDialog.SelectedPath;
                Settings.Default.Save();
            }

            MenuSettingsSmvFolderRefresh();
        }

        // Refresh SMV menu item
        private void MenuSettingsSmvFolderRefresh()
        {
            MenuSettingsSmvFolder.Text = "Smokeview executable folder = " + Settings.Default.SmvFolder;
        }
    }
}
