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
    // Methods for handling console output screen
    public partial class FdsForm : Form
    {

        // Clear screen
        private void ClearConsole()
        {
            ListBoxConsole.Items.Clear();
        }

        // Add multiple lines to console
        private void AddConsoleLines(string[] lines)
        {
            // Add single lines
            foreach (string line in lines)
            {
                ListBoxConsole.Items.Add(line);
            }

            // Clear lines beyond maximum
            while (ListBoxConsole.Items.Count > 1000)
            {
                ListBoxConsole.Items.RemoveAt(0);
            }

            RefreshConsole();
        }

        // Add single line to console
        private void AddConsoleLines(string line)
        {
            AddConsoleLines(new string[] { line });
        }

        // Refresh console
        private void RefreshConsole()
        {
            ListBoxConsole.TopIndex = ListBoxConsole.Items.Count - 1;
        }
    }
}
