using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace keeperOfTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string clockInTime = DateTime.Now.ToString("hh:mm tt");
            txtClockIn.Text = clockInTime;
            btnIn.Enabled = false;
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            string lunchIn = DateTime.Now.ToString("hh:mm tt");
            txtLunchIn.Text = lunchIn;

            string lunchOut = DateTime.Now.AddHours(1).ToString("hh:mm tt");
            txtLunchOut.Text = lunchOut;

        }
    }
}
