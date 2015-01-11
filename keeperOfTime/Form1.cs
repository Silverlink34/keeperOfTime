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

            btnDone.Visible = false;
            btnLunch.Enabled = false;
            btnOut.Enabled = false;

            Properties.Settings.Default.ClockOutBtn = true;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.DoneBtnClicked = false;
            Properties.Settings.Default.Save();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string clockInTime = DateTime.Now.ToString("HH:mm");
            txtClockIn.Text = clockInTime;

            txtClockIn.Text = clockInTime;

            btnIn.Enabled = false;
            btnLunch.Enabled = true;
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            string lunchIn = DateTime.Now.ToString("HH:mm");
            txtLunchIn.Text = lunchIn;
            string lunchOut = DateTime.Now.AddHours(1).ToString("HH:mm");
            txtLunchOut.Text = lunchOut;

            btnLunch.Enabled = false;
            btnOut.Enabled = true;

        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            string calDay = daCal.SelectionRange.Start.ToString(":MM/dd/yyy");
            MessageBox.Show(calDay);
        }

        private void manualEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtClockIn.ReadOnly = false;
            txtClockOut.ReadOnly = false;
            txtLunchIn.ReadOnly = false;
            txtLunchOut.ReadOnly = false;

            btnDone.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DoneBtnClicked = true;
            Properties.Settings.Default.Save();

            txtClockIn.ReadOnly = true;
            txtClockOut.ReadOnly = true;
            txtLunchIn.ReadOnly = true;
            txtLunchOut.ReadOnly = true;

            DateTime startTime = Convert.ToDateTime(txtClockIn.Text);
            DateTime endTimes = Convert.ToDateTime(txtClockOut.Text);
            TimeSpan hours = endTimes - startTime;

            txtHours.Text = hours.TotalHours.ToString();

            btnDone.Visible = false;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string clockOutTime = DateTime.Now.ToString("HH:mm");
            txtClockOut.Text = clockOutTime;

            Properties.Settings.Default.ClockOutBtn = false;
            Properties.Settings.Default.Save();

            btnOut.Enabled = false;

            DateTime startTime = Convert.ToDateTime(txtClockIn.Text);
            DateTime endTimes = Convert.ToDateTime(txtClockOut.Text);
            TimeSpan hours = startTime - endTimes;
            TimeSpan hoursGross = TimeSpan.FromHours(1);

            //string hoursGross2 = hoursGross.ToString("hh:mm");

            txtHours.Text = hoursGross.TotalHours.ToString();


        }

        private void btnEndShift_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ClockOutBtn == false)
            
            {
                MessageBox.Show("Shift ended");
            }

            else if (Properties.Settings.Default.ClockOutBtn == true)
            {
                MessageBox.Show("Must have valid time submitted in all fields to end shift.");
            }

            else
 
            {
                MessageBox.Show("Something weird happened... Well... moving on then.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.ClockOutBtn.ToString());
        }
    }
}
