﻿namespace FdsLauncher
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
            this.LblRestartFlag = new System.Windows.Forms.Label();
            this.LblChId = new System.Windows.Forms.Label();
            this.BtnStopFds = new System.Windows.Forms.Button();
            this.BtnStartFds = new System.Windows.Forms.Button();
            this.BtnTestFds = new System.Windows.Forms.Button();
            this.ListBoxConsole = new System.Windows.Forms.ListBox();
            this.BtnPickFile = new System.Windows.Forms.Button();
            this.LblFdsDataFile = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(1596, 40);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(324, 38);
            this.MenuAbout.Text = "About";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(321, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(324, 38);
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // MenuSettingsFdsExe
            // 
            this.MenuSettingsFdsExe.Name = "MenuSettingsFdsExe";
            this.MenuSettingsFdsExe.Size = new System.Drawing.Size(324, 38);
            this.MenuSettingsFdsExe.Text = "FDS Exe";
            this.MenuSettingsFdsExe.Click += new System.EventHandler(this.MenuSettingsFdsExe_Click);
            // 
            // MenuSettingsSmvExe
            // 
            this.MenuSettingsSmvExe.Name = "MenuSettingsSmvExe";
            this.MenuSettingsSmvExe.Size = new System.Drawing.Size(324, 38);
            this.MenuSettingsSmvExe.Text = "SmokeView Exe";
            this.MenuSettingsSmvExe.Click += new System.EventHandler(this.MenuSettingsSmvExe_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(321, 6);
            // 
            // MenuSettingsDataFolder
            // 
            this.MenuSettingsDataFolder.Name = "MenuSettingsDataFolder";
            this.MenuSettingsDataFolder.Size = new System.Drawing.Size(324, 38);
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
            this.tableLayoutPanel1.Controls.Add(this.LblRestartFlag, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblChId, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnStopFds, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnStartFds, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnTestFds, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ListBoxConsole, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnPickFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblFdsDataFile, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1596, 865);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblRestartFlag
            // 
            this.LblRestartFlag.AutoSize = true;
            this.LblRestartFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblRestartFlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRestartFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblRestartFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestartFlag.Location = new System.Drawing.Point(1280, 160);
            this.LblRestartFlag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRestartFlag.Name = "LblRestartFlag";
            this.LblRestartFlag.Padding = new System.Windows.Forms.Padding(10);
            this.LblRestartFlag.Size = new System.Drawing.Size(312, 50);
            this.LblRestartFlag.TabIndex = 7;
            // 
            // LblChId
            // 
            this.LblChId.AutoSize = true;
            this.LblChId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblChId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.LblChId, 2);
            this.LblChId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblChId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChId.Location = new System.Drawing.Point(642, 160);
            this.LblChId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblChId.Name = "LblChId";
            this.LblChId.Padding = new System.Windows.Forms.Padding(10);
            this.LblChId.Size = new System.Drawing.Size(630, 50);
            this.LblChId.TabIndex = 6;
            // 
            // BtnStopFds
            // 
            this.BtnStopFds.AutoSize = true;
            this.BtnStopFds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStopFds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStopFds.Location = new System.Drawing.Point(329, 90);
            this.BtnStopFds.Margin = new System.Windows.Forms.Padding(10);
            this.BtnStopFds.Name = "BtnStopFds";
            this.BtnStopFds.Size = new System.Drawing.Size(299, 60);
            this.BtnStopFds.TabIndex = 5;
            this.BtnStopFds.Text = "Stop FDS";
            this.BtnStopFds.UseVisualStyleBackColor = true;
            this.BtnStopFds.Click += new System.EventHandler(this.BtnStopFds_Click);
            // 
            // BtnStartFds
            // 
            this.BtnStartFds.AutoSize = true;
            this.BtnStartFds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStartFds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartFds.Location = new System.Drawing.Point(329, 10);
            this.BtnStartFds.Margin = new System.Windows.Forms.Padding(10);
            this.BtnStartFds.Name = "BtnStartFds";
            this.BtnStartFds.Size = new System.Drawing.Size(299, 60);
            this.BtnStartFds.TabIndex = 4;
            this.BtnStartFds.Text = "Start FDS";
            this.BtnStartFds.UseVisualStyleBackColor = true;
            this.BtnStartFds.Click += new System.EventHandler(this.BtnStartFds_Click);
            // 
            // BtnTestFds
            // 
            this.BtnTestFds.AutoSize = true;
            this.BtnTestFds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTestFds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTestFds.Location = new System.Drawing.Point(10, 90);
            this.BtnTestFds.Margin = new System.Windows.Forms.Padding(10);
            this.BtnTestFds.Name = "BtnTestFds";
            this.BtnTestFds.Size = new System.Drawing.Size(299, 60);
            this.BtnTestFds.TabIndex = 3;
            this.BtnTestFds.Text = "Test FDS";
            this.BtnTestFds.UseVisualStyleBackColor = true;
            this.BtnTestFds.Click += new System.EventHandler(this.BtnTestFds_Click);
            // 
            // ListBoxConsole
            // 
            this.ListBoxConsole.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.ListBoxConsole, 5);
            this.ListBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxConsole.Font = new System.Drawing.Font("Lucida Console", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxConsole.ForeColor = System.Drawing.Color.LawnGreen;
            this.ListBoxConsole.FormattingEnabled = true;
            this.ListBoxConsole.ItemHeight = 27;
            this.ListBoxConsole.Items.AddRange(new object[] {
            "Test Line 1",
            "Test Line 2"});
            this.ListBoxConsole.Location = new System.Drawing.Point(4, 216);
            this.ListBoxConsole.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ListBoxConsole.Name = "ListBoxConsole";
            this.ListBoxConsole.ScrollAlwaysVisible = true;
            this.ListBoxConsole.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListBoxConsole.Size = new System.Drawing.Size(1588, 658);
            this.ListBoxConsole.TabIndex = 0;
            // 
            // BtnPickFile
            // 
            this.BtnPickFile.AutoSize = true;
            this.BtnPickFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPickFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPickFile.Location = new System.Drawing.Point(10, 10);
            this.BtnPickFile.Margin = new System.Windows.Forms.Padding(10);
            this.BtnPickFile.Name = "BtnPickFile";
            this.BtnPickFile.Size = new System.Drawing.Size(299, 60);
            this.BtnPickFile.TabIndex = 1;
            this.BtnPickFile.Text = "Pick Data File";
            this.BtnPickFile.UseVisualStyleBackColor = true;
            this.BtnPickFile.Click += new System.EventHandler(this.BtnPickFile_Click);
            // 
            // LblFdsDataFile
            // 
            this.LblFdsDataFile.AutoSize = true;
            this.LblFdsDataFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblFdsDataFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.LblFdsDataFile, 2);
            this.LblFdsDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFdsDataFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFdsDataFile.Location = new System.Drawing.Point(4, 160);
            this.LblFdsDataFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFdsDataFile.Name = "LblFdsDataFile";
            this.LblFdsDataFile.Padding = new System.Windows.Forms.Padding(10);
            this.LblFdsDataFile.Size = new System.Drawing.Size(630, 50);
            this.LblFdsDataFile.TabIndex = 2;
            // 
            // FdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 905);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label LblFdsDataFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSettingsSmvExe;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Button BtnTestFds;
        private System.Windows.Forms.Button BtnStartFds;
        private System.Windows.Forms.Button BtnStopFds;
        private System.Windows.Forms.Label LblChId;
        private System.Windows.Forms.Label LblRestartFlag;
    }
}

