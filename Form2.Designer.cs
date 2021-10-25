namespace Pomodoro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblSure = new System.Windows.Forms.Label();
            this.btnResetle = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.pboxPlayPause = new System.Windows.Forms.PictureBox();
            this.pboxReset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReset)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSure
            // 
            this.lblSure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSure.BackColor = System.Drawing.Color.Transparent;
            this.lblSure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(12, 9);
            this.lblSure.MinimumSize = new System.Drawing.Size(247, 48);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(247, 65);
            this.lblSure.TabIndex = 0;
            this.lblSure.Text = "{0:00}:{1:00}:{2:00}";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetle
            // 
            this.btnResetle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnResetle.Enabled = false;
            this.btnResetle.Location = new System.Drawing.Point(290, 113);
            this.btnResetle.Name = "btnResetle";
            this.btnResetle.Size = new System.Drawing.Size(82, 28);
            this.btnResetle.TabIndex = 14;
            this.btnResetle.Text = "Resetle";
            this.btnResetle.UseVisualStyleBackColor = true;
            this.btnResetle.Click += new System.EventHandler(this.btnResetle_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuraklat.Enabled = false;
            this.btnDuraklat.Location = new System.Drawing.Point(290, 93);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(82, 28);
            this.btnDuraklat.TabIndex = 13;
            this.btnDuraklat.Text = "Duraklat";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBasla.Location = new System.Drawing.Point(290, 77);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(82, 28);
            this.btnBasla.TabIndex = 12;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // pboxPlayPause
            // 
            this.pboxPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pboxPlayPause.Image = global::Pomodoro.Properties.Resources.play;
            this.pboxPlayPause.Location = new System.Drawing.Point(111, 85);
            this.pboxPlayPause.Name = "pboxPlayPause";
            this.pboxPlayPause.Size = new System.Drawing.Size(48, 48);
            this.pboxPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPlayPause.TabIndex = 16;
            this.pboxPlayPause.TabStop = false;
            this.pboxPlayPause.Tag = "play";
            this.pboxPlayPause.Click += new System.EventHandler(this.pboxPlayPause_Click);
            // 
            // pboxReset
            // 
            this.pboxReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pboxReset.Enabled = false;
            this.pboxReset.Image = global::Pomodoro.Properties.Resources.reset_tusu;
            this.pboxReset.Location = new System.Drawing.Point(33, 77);
            this.pboxReset.Name = "pboxReset";
            this.pboxReset.Size = new System.Drawing.Size(64, 64);
            this.pboxReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxReset.TabIndex = 16;
            this.pboxReset.TabStop = false;
            this.pboxReset.Click += new System.EventHandler(this.pboxReset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnResetle;
            this.ClientSize = new System.Drawing.Size(271, 153);
            this.Controls.Add(this.pboxReset);
            this.Controls.Add(this.pboxPlayPause);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btnResetle);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.btnBasla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(287, 147);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4.lü Pomodoro Modu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnResetle;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.PictureBox pboxPlayPause;
        private System.Windows.Forms.PictureBox pboxReset;
    }
}