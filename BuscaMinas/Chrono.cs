
using System;
using System.Windows.Forms;
namespace BuscaMinas
{
    class Chrono
    {
        protected Label display;
        protected int hours;
        protected int minutes;
        protected int seconds;

        protected Timer timer;

        public Chrono(Label display)
        {
            this.display = display;

            Reset();

            this.timer = new Timer
            {
                Interval = 1000,
                Enabled = true
            };

            this.timer.Tick += OnTimedEvent;
        }

        public void Start() { this.timer.Start(); }
        public void Pause() { this.timer.Stop(); }

        public void Reset()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            seconds = (seconds == 59) ? 0 : seconds + 1;
            minutes = (seconds == 0) ? minutes + 1 : minutes;
            hours = (minutes == 0 && seconds == 0) ? hours + 1 : hours;

            this.display.Text = hours + ":" + ((minutes < 10) ? "0" : "") + minutes + " " + ((seconds < 10) ? "0" : "") + seconds;
        }

        public void Dispose() 
        {
            Pause();
            Reset();
            this.display = null;
        }

    }
}
