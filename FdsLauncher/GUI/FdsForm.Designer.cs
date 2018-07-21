namespace FdsLauncher
{
    partial class FdsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsFdsExe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettingsSmvExe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSettingsDataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListBoxConsole = new System.Windows.Forms.ListBox();
            this.BtnPickFile = new System.Windows.Forms.Button();
            this.LblFdsDataFile = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout,
            this.toolStripMenuItem1,
            this.MenuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(107, 22);
            this.MenuAbout.Text = "About";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(107, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettingsFdsExe,
            this.MenuSettingsSmvExe,
            this.toolStripMenuItem2,
            this.MenuSettingsDataFolder});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // MenuSettingsFdsExe
            // 
            this.MenuSettingsFdsExe.Name = "MenuSettingsFdsExe";
            this.MenuSettingsFdsExe.Size = new System.Drawing.Size(155, 22);
            this.MenuSettingsFdsExe.Text = "FDS Exe";
            this.MenuSettingsFdsExe.Click += new System.EventHandler(this.MenuSettingsFdsExe_Click);
            // 
            // MenuSettingsSmvExe
            // 
            this.MenuSettingsSmvExe.Name = "MenuSettingsSmvExe";
            this.MenuSettingsSmvExe.Size = new System.Drawing.Size(155, 22);
            this.MenuSettingsSmvExe.Text = "SmokeView Exe";
            this.MenuSettingsSmvExe.Click += new System.EventHandler(this.MenuSettingsSmvExe_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // MenuSettingsDataFolder
            // 
            this.MenuSettingsDataFolder.Name = "MenuSettingsDataFolder";
            this.MenuSettingsDataFolder.Size = new System.Drawing.Size(155, 22);
            this.MenuSettingsDataFolder.Text = "Data Folder";
            this.MenuSettingsDataFolder.Click += new System.EventHandler(this.MenuSettingsDataFolder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ListBoxConsole, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnPickFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblFdsDataFile, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 167);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ListBoxConsole
            // 
            this.ListBoxConsole.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.ListBoxConsole, 5);
            this.ListBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxConsole.Font = new System.Drawing.Font("Lucida Console", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxConsole.ForeColor = System.Drawing.Color.LawnGreen;
            this.ListBoxConsole.FormattingEnabled = true;
            this.ListBoxConsole.Items.AddRange(new object[] {
            "Test Line 1",
            "Test Line 2"});
            this.ListBoxConsole.Location = new System.Drawing.Point(2, 73);
            this.ListBoxConsole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListBoxConsole.Name = "ListBoxConsole";
            this.ListBoxConsole.ScrollAlwaysVisible = true;
            this.ListBoxConsole.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListBoxConsole.Size = new System.Drawing.Size(794, 97);
            this.ListBoxConsole.TabIndex = 0;
            // 
            // BtnPickFile
            // 
            this.BtnPickFile.AutoSize = true;
            this.BtnPickFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPickFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPickFile.Location = new System.Drawing.Point(5, 5);
            this.BtnPickFile.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPickFile.Name = "BtnPickFile";
            this.BtnPickFile.Size = new System.Drawing.Size(149, 42);
            this.BtnPickFile.TabIndex = 1;
            this.BtnPickFile.Text = "Pick Data File";
            this.BtnPickFile.UseVisualStyleBackColor = true;
            // 
            // LblFdsDataFile
            // 
            this.LblFdsDataFile.AutoSize = true;
            this.LblFdsDataFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.LblFdsDataFile, 5);
            this.LblFdsDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFdsDataFile.Location = new System.Drawing.Point(2, 52);
            this.LblFdsDataFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFdsDataFile.Name = "LblFdsDataFile";
            this.LblFdsDataFile.Size = new System.Drawing.Size(794, 18);
            this.LblFdsDataFile.TabIndex = 2;
            this.LblFdsDataFile.Text = "C:\\Users\\Documents\\FDS\\SubFolder\\123456.fds";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // FdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 191);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FdsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FDS Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FdsLauncherForm_FormClosing);
            this.Load += new System.EventHandler(this.FdsLauncherForm_Load);
            this.Shown += new System.EventHandler(this.FdsForm_Shown);
            this.Resize += new System.EventHandler(this.FdsForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsFdsExe;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsDataFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox ListBoxConsole;
        private System.Windows.Forms.Button BtnPickFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label LblFdsDataFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsSmvExe;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

