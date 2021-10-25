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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Sayac sayac;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            //lblDurum.Text = "Durum : " + _islem_getir(sira) + " işleniyor...";
            btnBasla.Enabled = false;
            sayac.Basla();
            btnDuraklat.Enabled = true;
            btnResetle.Enabled = true;
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            //lblDurum.Text = "Durum : " + _islem_getir(sira) + " durduruldu...";
            btnBasla.Enabled = true;
            sayac.Duraklat();
            btnDuraklat.Enabled = false;
            btnResetle.Enabled = true;
        }

        private void btnResetle_Click(object sender, EventArgs e)
        {
            //lblDurum.Text = "Durum : " + _islem_getir(sira) + " bekleniyor...";
            btnBasla.Enabled = true;
            sayac.Resetle();
            btnDuraklat.Enabled = false;
            btnResetle.Enabled = false;
            _Sureleri_Guncelle();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            this.sayac = new Sayac(new TimeSpan(0, 25, 0));
            this.sayac.Tick += new EventHandler(Sayac_Tick);
            this.sayac.Bitti += new EventHandler(Sayac_Bitti);
            //lblDurum.Text = "Durum : Bekleniyor...";
            //prgIlerleme.Properties.Maximum = Convert.ToInt32(this.sayac.Sure.TotalSeconds);
            _Sureleri_Guncelle();
            _SureLabelFontAyarla();
        }

        int sira = 0;
        private void Sayac_Bitti(object sender, EventArgs e)
        {
            if (sira == 0 || sira == 2 || sira == 4 || sira == 6)
            {
                Fonk.SesCal(Application.StartupPath + "\\Sounds\\dinlenmeyegecis.mp3");
                //lblDurum.Text = "Durum : Dinlenme süresi işliyor...";
                this.sayac = new Sayac(new TimeSpan(0, 5, 0));
            }
            else if (sira == 1 || sira == 3 || sira == 5)
            {
                Fonk.SesCal(Application.StartupPath + "\\Sounds\\calisma.mp3");
                //lblDurum.Text = "Durum : Çalışma süresi işliyor...";
                this.sayac = new Sayac(new TimeSpan(0, 25, 0));
            }
            else if (sira == 7)
            {
                Fonk.SesCal(Application.StartupPath + "\\Sounds\\uzundinlenmegecis.mp3");
                //lblDurum.Text = "Durum : Uzun dinlenme süresi işliyor...";
                this.sayac = new Sayac(new TimeSpan(0, 15, 0));
            }
            this.sayac.Tick += new EventHandler(Sayac_Tick);
            this.sayac.Bitti += new EventHandler(Sayac_Bitti);
            if (sira == 8)
            {
                sira = 0;
                this.sayac = new Sayac(new TimeSpan(0, 25, 0));
                this.sayac.Tick += new EventHandler(Sayac_Tick);
                this.sayac.Bitti += new EventHandler(Sayac_Bitti);
                //lblDurum.Text = "Durum : Bekleniyor...";
                MessageBox.Show("Tebrikler 4 pomodoroyuda tamamladınız!", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sira++;
                sayac.Basla();
            }
            btnBasla.Enabled = false;
            btnDuraklat.Enabled = false;
            //prgIlerleme.Properties.Maximum = Convert.ToInt32(this.sayac.Sure.TotalSeconds);
        }

        private string _islem_getir(int sira)
        {
            if (sira == 0 || sira == 2 || sira == 4 || sira == 6)
            {
                return "Çalışma Süresi";
            }
            else if (sira == 1 || sira == 3 || sira == 5 || sira == 7)
            {
                return "Dinlenme Süresi";
            }
            else if (sira == 8)
            {
                return "Uzun Dinlenme Süresi";
            }
            else { return ""; }
        }

        private void Sayac_Tick(object sender, EventArgs e)
        {
            _Sureleri_Guncelle();
        }

        private void _Sureleri_Guncelle()
        {
            TimeSpan kalansure = this.sayac.Sure - this.sayac.GecenSure;
            //lblKalanSure.Text = string.Format("Kalan süre : {0:00}:{1:00}", kalansure.Minutes, kalansure.Seconds);
            lblSure.Text = string.Format("{0:00}:{1:00}:{2:00}", this.sayac.GecenSure.Minutes, this.sayac.GecenSure.Seconds, this.sayac.GecenSure.Milliseconds / 10);
            //prgIlerleme.Position = Convert.ToInt32(this.sayac.GecenSure.TotalSeconds);
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            _SureLabelFontAyarla();
        }

        private void _SureLabelFontAyarla()
        {
            string yazi = lblSure.Text;
            float buyukluk = GetFontSize(this.lblSure, yazi, 0, 1, 1000);
            lblSure.Font = new Font(lblSure.Font.FontFamily, buyukluk);
            lblSure.Text = yazi;
        }

        private float GetFontSize(Label label, string text,
            int margin, float min_size, float max_size)
        {
            // Only bother if there's text.
            if (text.Length == 0) return min_size;

            // See how much room we have, allowing a bit
            // for the Label's internal margin.
            int wid = label.DisplayRectangle.Width - margin;
            int hgt = label.DisplayRectangle.Height - margin;

            // Make a Graphics object to measure the text.
            using (Graphics gr = label.CreateGraphics())
            {
                while (max_size - min_size > 0.1f)
                {
                    float pt = (min_size + max_size) / 2f;
                    using (Font test_font = new Font(label.Font.FontFamily, pt))
                    {
                        // See if this font is too big.
                        SizeF text_size = gr.MeasureString(text, test_font);
                        if ((text_size.Width > wid) || (text_size.Height > hgt))
                            max_size = pt;
                        else
                            min_size = pt;
                    }
                }
                return min_size;
            }
        }

        private void pboxPlayPause_Click(object sender, EventArgs e)
        {
            if(pboxPlayPause.Tag.ToString() == "play")
            {
                sayac.Basla();
                pboxPlayPause.Image = Properties.Resources.pause;
                pboxPlayPause.Tag = "pause";
                pboxReset.Enabled = true;
            }
            else
            {
                sayac.Duraklat();
                pboxPlayPause.Image = Properties.Resources.play;
                pboxPlayPause.Tag = "play";
                pboxReset.Enabled = true;
            }
        }

        private void pboxReset_Click(object sender, EventArgs e)
        {
            pboxPlayPause.Enabled = true;
            pboxPlayPause.Image = Properties.Resources.play;
            sayac.Duraklat();
            sayac.Resetle();
            pboxReset.Enabled = false;
            _Sureleri_Guncelle();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tekli moda geçmek istediğinize eminmisiniz?", "Pomodoro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
