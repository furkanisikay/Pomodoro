namespace Pomodoro
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnResetle = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.cmbSayacTuru = new System.Windows.Forms.ComboBox();
            this.btn4Pomodoro = new System.Windows.Forms.Button();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.cboxtop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(9, 20);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(61, 13);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum : {0}";
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.Location = new System.Drawing.Point(459, 20);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(127, 13);
            this.lblKalanSure.TabIndex = 2;
            this.lblKalanSure.Text = "Kalan süre : {0:00}:{1:00}";
            this.lblKalanSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(181, 81);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Enabled = false;
            this.btnDuraklat.Location = new System.Drawing.Point(262, 81);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(75, 23);
            this.btnDuraklat.TabIndex = 4;
            this.btnDuraklat.Text = "Duraklat";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnResetle
            // 
            this.btnResetle.Enabled = false;
            this.btnResetle.Location = new System.Drawing.Point(343, 81);
            this.btnResetle.Name = "btnResetle";
            this.btnResetle.Size = new System.Drawing.Size(75, 23);
            this.btnResetle.TabIndex = 5;
            this.btnResetle.Text = "Resetle";
            this.btnResetle.UseVisualStyleBackColor = true;
            this.btnResetle.Click += new System.EventHandler(this.Resetle_Click);
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.Color.Transparent;
            this.lblSure.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(217, 9);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(165, 33);
            this.lblSure.TabIndex = 6;
            this.lblSure.Text = "{0:00}:{1:00}:{2:00}";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSayacTuru
            // 
            this.cmbSayacTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSayacTuru.FormattingEnabled = true;
            this.cmbSayacTuru.Items.AddRange(new object[] {
            "Çalışma",
            "Dinlenme",
            "Uzun Dinlenme"});
            this.cmbSayacTuru.Location = new System.Drawing.Point(362, 132);
            this.cmbSayacTuru.Name = "cmbSayacTuru";
            this.cmbSayacTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbSayacTuru.TabIndex = 7;
            this.cmbSayacTuru.SelectedIndexChanged += new System.EventHandler(this.cmbSayacTuru_SelectedIndexChanged);
            // 
            // btn4Pomodoro
            // 
            this.btn4Pomodoro.Location = new System.Drawing.Point(12, 126);
            this.btn4Pomodoro.Name = "btn4Pomodoro";
            this.btn4Pomodoro.Size = new System.Drawing.Size(237, 27);
            this.btn4Pomodoro.TabIndex = 8;
            this.btn4Pomodoro.Text = "4.lü Pomodoro";
            this.btn4Pomodoro.UseVisualStyleBackColor = true;
            this.btn4Pomodoro.Click += new System.EventHandler(this.btn4Pomodoro_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBarControl1.Location = new System.Drawing.Point(12, 49);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBarControl1.Properties.Appearance.ForeColor2 = System.Drawing.Color.White;
            this.progressBarControl1.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.progressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.ShowProgressInTaskBar = true;
            this.progressBarControl1.Size = new System.Drawing.Size(574, 26);
            this.progressBarControl1.TabIndex = 9;
            // 
            // cboxtop
            // 
            this.cboxtop.AutoSize = true;
            this.cboxtop.Location = new System.Drawing.Point(500, 134);
            this.cboxtop.Name = "cboxtop";
            this.cboxtop.Size = new System.Drawing.Size(86, 17);
            this.cboxtop.TabIndex = 10;
            this.cboxtop.Text = "Sürekli Üstte";
            this.cboxtop.UseVisualStyleBackColor = true;
            this.cboxtop.CheckedChanged += new System.EventHandler(this.cboxtop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 165);
            this.Controls.Add(this.cboxtop);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btn4Pomodoro);
            this.Controls.Add(this.cmbSayacTuru);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btnResetle);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.lblDurum);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnResetle;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.ComboBox cmbSayacTuru;
        private System.Windows.Forms.Button btn4Pomodoro;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.CheckBox cboxtop;
    }
}

