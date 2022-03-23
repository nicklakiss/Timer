using System.Diagnostics;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Update();
        }
        int _hours = 0;
        int _minutes = 0;
        int _seconds = 0;
        bool flag = false;
        private void hoursMinus_Click(object sender, EventArgs e)
        {
            if (_hours > 0) _hours--;
            Update();
        }

        private void hourPlus_Click(object sender, EventArgs e)
        {
            if (_hours < 99) _hours++;
            Update();
        }

        private void minutesPlus_Click(object sender, EventArgs e)
        {
            if (_minutes < 59) _minutes++;
            else
            {
                _minutes = 0;
                hourPlus_Click(sender, e);
            }
            Update();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                flag = true;
                timer1.Start();
                Start.Text = "Stop";
            }
            else
            {
                flag = false;
                timer1.Stop();
                Start.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_seconds > 0) _seconds--;
            else if (_seconds == 0 && _minutes > 0)
            {
                _minutes--;
                _seconds = 59;
            }
            else if (_seconds == 0 && _minutes == 0 && _hours > 0)
            {
                _hours--;
                _seconds = _minutes = 59;
            }
            else
            {
                Process.Start("shutdown", "/f /s /t 0");
            }
            Update();
        }
        private void Update()
        {
            Hours.Text = _hours.ToString("00");
            Minutes.Text = _minutes.ToString("00");
            Seconds.Text = _seconds.ToString("00");
        }

        private void secondPlus_Click(object sender, EventArgs e)
        {
            if (_seconds < 59) _seconds++;
            else
            {
                _seconds = 0;
                minutesPlus_Click(sender, e);
            }
            Update();
        }

        private void secondMinus_Click(object sender, EventArgs e)
        {
            if (_seconds > 0) _seconds--;
            Seconds.Text = _seconds.ToString("00");
        }

        private void minutesMinus_Click(object sender, EventArgs e)
        {
            if (_minutes > 0) {_minutes--; }
            Minutes.Text = _minutes.ToString("00");
        }
    }
}