using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private Sayac sayac;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = false;
            sayac.Basla();
            btnDuraklat.Enabled = true;
            btnResetle.Enabled = true;
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            btnDuraklat.Enabled = false;
            sayac.Duraklat();
            btnBasla.Enabled = true;
            btnResetle.Enabled = true;
        }

        private void Resetle_Click(object sender, EventArgs e)
        {
            btnDuraklat.Enabled = false;
            btnResetle.Enabled = false;
            sayac.Resetle();
            _Sureleri_Guncelle();
            btnBasla.Enabled = true;
        }

        private void cmbSayacTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSayacTuru.SelectedIndex)
            {
                case 0:
                    this.sayac = new Sayac(new TimeSpan(0, 25, 0));
                    lblDurum.Text = "Durum : Çalışma süresi işliyor...";
                    break;
                case 1:
                    this.sayac = new Sayac(new TimeSpan(0, 5, 0));
                    lblDurum.Text = "Durum : Kısa dinlenme süresi işliyor...";
                    break;
                case 2:
                    this.sayac = new Sayac(new TimeSpan(0, 20, 0));
                    lblDurum.Text = "Durum : Uzun dinlenme süresi işliyor...";
                    break;
                default:
                    this.sayac = new Sayac(new TimeSpan(0, 25, 0));
                    lblDurum.Text = "Durum : Çalışma süresi işliyor...";
                    break;
            }
            progressBarControl1.Properties.Maximum = Convert.ToInt32(sayac.Sure.TotalSeconds);
            lblKalanSure.Text = string.Format("Kalan süre : {0:00}:{1:00}", this.sayac.Sure.Minutes, this.sayac.Sure.Seconds);
            lblSure.Text = string.Format("{0:00}:{1:00}:{2:00}", 0, 0, 0);
            this.sayac.Tick += new EventHandler(Sayac_Tick);
            this.sayac.Bitti += new EventHandler(Sayac_Bitti);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbSayacTuru.SelectedIndex = 0;
        }

        private void Sayac_Bitti(object sender, EventArgs e)
        {
            Fonk.SesCal(Application.StartupPath + "\\Sounds\\uzundinlenmegecis.mp3");
            MessageBox.Show("Süre tamamlandı!", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBasla.Enabled = true;
            btnDuraklat.Enabled = false;
            btnResetle.Enabled = false;
            _Sureleri_Guncelle();
        }

        private void Sayac_Tick(object sender, EventArgs e)
        {
            _Sureleri_Guncelle();
        }

        private void _Sureleri_Guncelle()
        {
            TimeSpan kalansure = this.sayac.Sure - this.sayac.GecenSure;
            lblKalanSure.Text = string.Format("Kalan süre : {0:00}:{1:00}", kalansure.Minutes, kalansure.Seconds);
            lblSure.Text = string.Format("{0:00}:{1:00}:{2:00}", this.sayac.GecenSure.Minutes, this.sayac.GecenSure.Seconds, this.sayac.GecenSure.Milliseconds / 10);
            progressBarControl1.Position = Convert.ToInt32(this.sayac.GecenSure.TotalSeconds);
        }

        private void btn4Pomodoro_Click(object sender, EventArgs e)
        {
            if (this.sayac.GecenSure.TotalMilliseconds > 100)
            {
                btnBasla.Enabled = false;
            }
            btnDuraklat.Enabled = false;
            this.sayac.Duraklat();
            this.Hide();
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
            }
            this.Show();
            if (this.sayac.GecenSure.TotalMilliseconds > 100)
            {
                btnBasla.Enabled = true;
            }
        }

        private void cboxtop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cboxtop.Checked;
        }
    }
}
