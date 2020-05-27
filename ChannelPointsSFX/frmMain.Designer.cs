namespace ChannelPointsSFX
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lstbxSoundsRewards = new System.Windows.Forms.ListBox();
            this.lstbxSoundsPaths = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblNOTICE = new System.Windows.Forms.Label();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "Dude22072\'s Channel Points SFX Program";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(12, 200);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(271, 45);
            this.trkVolume.TabIndex = 0;
            this.trkVolume.Scroll += new System.EventHandler(this.trkVolume_Scroll);
            this.trkVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrkVolume_MouseUp);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(289, 200);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(28, 20);
            this.txtVolume.TabIndex = 1;
            this.txtVolume.Text = "100";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(12, 184);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "Volume";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(60, 191);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(257, 2);
            this.lblLine.TabIndex = 3;
            // 
            // lstbxSoundsRewards
            // 
            this.lstbxSoundsRewards.FormattingEnabled = true;
            this.lstbxSoundsRewards.Items.AddRange(new object[] {
            "Highlight my Message",
            "Modify a Single Emote",
            "Unlock a Random Sub Emote",
            "Choose an emote to unlock",
            "T1 Sub"});
            this.lstbxSoundsRewards.Location = new System.Drawing.Point(15, 13);
            this.lstbxSoundsRewards.Name = "lstbxSoundsRewards";
            this.lstbxSoundsRewards.Size = new System.Drawing.Size(136, 95);
            this.lstbxSoundsRewards.TabIndex = 4;
            this.lstbxSoundsRewards.SelectedIndexChanged += new System.EventHandler(this.lstbxSoundsRewards_SelectedIndexChanged);
            // 
            // lstbxSoundsPaths
            // 
            this.lstbxSoundsPaths.FormattingEnabled = true;
            this.lstbxSoundsPaths.Items.AddRange(new object[] {
            "C:\\test1",
            "C:\\test2",
            "C:\\test3",
            "C:\\test4",
            "C:\\test5"});
            this.lstbxSoundsPaths.Location = new System.Drawing.Point(151, 13);
            this.lstbxSoundsPaths.Name = "lstbxSoundsPaths";
            this.lstbxSoundsPaths.Size = new System.Drawing.Size(139, 95);
            this.lstbxSoundsPaths.TabIndex = 5;
            this.lstbxSoundsPaths.SelectedIndexChanged += new System.EventHandler(this.lstbxSoundsPaths_SelectedIndexChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(296, 13);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(21, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "∧";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(296, 85);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(21, 23);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "∨";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Sound";
            this.toolTip1.SetToolTip(this.btnAdd, "Add a new sound to the list.\r\nFirsts asks for the reward name then opens a file s" +
        "elect dialog.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(113, 114);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test Sound";
            this.toolTip1.SetToolTip(this.btnTest, "Tests the sound as if someone had redemed the reward.");
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(210, 114);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Delete Sound";
            this.toolTip1.SetToolTip(this.btnRemove, "Deletes the currently highlighted sound.");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblNOTICE
            // 
            this.lblNOTICE.Location = new System.Drawing.Point(12, 235);
            this.lblNOTICE.Name = "lblNOTICE";
            this.lblNOTICE.Size = new System.Drawing.Size(305, 13);
            this.lblNOTICE.TabIndex = 11;
            this.lblNOTICE.Text = "Update available on GitHub!";
            this.lblNOTICE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNOTICE.Visible = false;
            // 
            // btnStopAll
            // 
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(15, 143);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(275, 23);
            this.btnStopAll.TabIndex = 12;
            this.btnStopAll.Text = "Emergency Stop";
            this.toolTip1.SetToolTip(this.btnStopAll, "Stops all playing sounds.");
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(296, 230);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(21, 23);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "⚙️";
            this.toolTip1.SetToolTip(this.btnSettings, "Opens the settings dialog.");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 257);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.lblNOTICE);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lstbxSoundsPaths);
            this.Controls.Add(this.lstbxSoundsRewards);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.trkVolume);
            this.MaximumSize = new System.Drawing.Size(1000, 296);
            this.MinimumSize = new System.Drawing.Size(341, 296);
            this.Name = "frmMain";
            this.Text = "Dude22072\'s Channel Points SFX Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_OnClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.ListBox lstbxSoundsRewards;
        private System.Windows.Forms.ListBox lstbxSoundsPaths;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblNOTICE;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

