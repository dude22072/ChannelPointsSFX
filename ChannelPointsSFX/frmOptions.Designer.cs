namespace ChannelPointsSFX
{
    partial class frmOptions
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
            this.cbTrayMini = new System.Windows.Forms.CheckBox();
            this.btnResetID = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVersioning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTrayMini
            // 
            this.cbTrayMini.AutoSize = true;
            this.cbTrayMini.Checked = true;
            this.cbTrayMini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrayMini.Location = new System.Drawing.Point(12, 35);
            this.cbTrayMini.Name = "cbTrayMini";
            this.cbTrayMini.Size = new System.Drawing.Size(101, 17);
            this.cbTrayMini.TabIndex = 0;
            this.cbTrayMini.Text = "Minimize to tray.";
            this.cbTrayMini.UseVisualStyleBackColor = true;
            this.cbTrayMini.CheckedChanged += new System.EventHandler(this.cbTrayMini_CheckedChanged);
            // 
            // btnResetID
            // 
            this.btnResetID.Location = new System.Drawing.Point(12, 58);
            this.btnResetID.Name = "btnResetID";
            this.btnResetID.Size = new System.Drawing.Size(101, 23);
            this.btnResetID.TabIndex = 1;
            this.btnResetID.Text = "Reset ChannelID";
            this.btnResetID.UseVisualStyleBackColor = true;
            this.btnResetID.Click += new System.EventHandler(this.btnResetID_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(238, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVersioning
            // 
            this.lblVersioning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersioning.Location = new System.Drawing.Point(9, 9);
            this.lblVersioning.Name = "lblVersioning";
            this.lblVersioning.Size = new System.Drawing.Size(304, 23);
            this.lblVersioning.TabIndex = 3;
            this.lblVersioning.Text = "Channel Points SFX vX.Y.Z Options";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 257);
            this.ControlBox = false;
            this.Controls.Add(this.lblVersioning);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnResetID);
            this.Controls.Add(this.cbTrayMini);
            this.MinimumSize = new System.Drawing.Size(341, 296);
            this.Name = "frmOptions";
            this.Text = "Dude22072\'s Channel Points SFX Program";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTrayMini;
        private System.Windows.Forms.Button btnResetID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVersioning;
    }
}