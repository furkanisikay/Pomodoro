using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pomodoro
{
    class Sayac
    {
        public TimeSpan Sure { get; }
        private System.Windows.Forms.Timer Zamanlayici { get; set; }
        private System.Windows.Forms.Timer ZamanIsleyici { get; set; }
        public TimeSpan GecenSure { get { return this._GecenSure; } }
        private TimeSpan _GecenSure { get; set; }

        public event EventHandler Tick;
        public event EventHandler Bitti;
        public Sayac(TimeSpan Sure)
        {
            this.Sure = Sure;
            this._GecenSure = TimeSpan.Zero;
            this.Zamanlayici = new System.Windows.Forms.Timer();
            this.Zamanlayici.Interval = 100;
            this.Zamanlayici.Tick += new EventHandler(Zamanlayici_Tick);
            this.ZamanIsleyici = new System.Windows.Forms.Timer();
            this.ZamanIsleyici.Interval = 100;
            this.ZamanIsleyici.Tick += new EventHandler(ZamanIsleyici_Tick);
        }

        private void ZamanIsleyici_Tick(object sender, EventArgs e)
        {
            if (this.Tick != null)
            {
                Thread th = new Thread(() => { Tick(sender, e); });
                th.IsBackground = true;
                th.Priority = ThreadPriority.Highest;
                th.Start();
            }
            if (this.GecenSure.TotalMilliseconds == this.Sure.TotalMilliseconds)
            {
                this.ZamanIsleyici.Stop();
                if (Bitti != null)
                {
                    Bitti(sender, e);
                }
            }
        }

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            TimeSpan span = new TimeSpan(0, 0, 0, 0, 100);
            this._GecenSure = this._GecenSure + span;
            if (this.GecenSure.TotalMilliseconds == this.Sure.TotalMilliseconds)
            {
                this.Zamanlayici.Stop();
            }
        }

        public void Basla()
        {
            this.Zamanlayici.Start();
            this.ZamanIsleyici.Start();
        }
        public void Duraklat()
        {
            this.Zamanlayici.Stop();
            this.ZamanIsleyici.Stop();
        }
        public void Resetle()
        {
            this._GecenSure = TimeSpan.Zero;
            this.Zamanlayici = new System.Windows.Forms.Timer();
            this.Zamanlayici.Interval = 100;
            this.Zamanlayici.Tick += new EventHandler(Zamanlayici_Tick);
            this.ZamanIsleyici = new System.Windows.Forms.Timer();
            this.ZamanIsleyici.Interval = 100;
            this.ZamanIsleyici.Tick += new EventHandler(ZamanIsleyici_Tick);
        }
    }
}
