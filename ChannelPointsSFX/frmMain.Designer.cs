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
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(12, 171);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(271, 45);
            this.trkVolume.TabIndex = 0;
            this.trkVolume.Scroll += new System.EventHandler(this.trkVolume_Scroll);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(289, 171);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(28, 20);
            this.txtVolume.TabIndex = 1;
            this.txtVolume.Text = "100";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(12, 155);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "Volume";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(60, 162);
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
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 228);
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
            this.MaximumSize = new System.Drawing.Size(341, 267);
            this.MinimumSize = new System.Drawing.Size(341, 267);
            this.Name = "frmMain";
            this.Text = "Dude22072\'s Channel Points SFX Program";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}

