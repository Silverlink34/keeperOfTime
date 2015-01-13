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

            Properties.Settings.Default.ClockOutBtn = true;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.DoneBtnClicked = false;
            Properties.Settings.Default.Save();

            daCal.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while ()
            {
                btnIn.Enabled = false;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string clockInTime = DateTime.Now.ToString("HH:mm");
            txtClockIn.Text = clockInTime;

        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            if (txtClockIn.MaskCompleted.Equals(true))
            {
                string lunchIn = DateTime.Now.ToString("HH:mm");
                txtLunchIn.Text = lunchIn;
                string lunchOut = DateTime.Now.AddHours(1).ToString("HH:mm");
                txtLunchOut.Text = lunchOut;
            }

            
            else 
            {
                MessageBox.Show("You must clock in first... Hungry, are you?");
            }

        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            string calDay = daCal.SelectionRange.Start.ToString(":MM/dd/yyy");
            MessageBox.Show(calDay);
        }

        private void manualEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ManualClicked = true;
            seeIfValid();

            txtClockIn.ReadOnly = false;
            txtClockOut.ReadOnly = false;
            txtLunchIn.ReadOnly = false;
            txtLunchOut.ReadOnly = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ManualClicked = false;
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

            DateTime startTime = Convert.ToDateTime(txtClockIn.Text);
            DateTime endTimes = Convert.ToDateTime(txtClockOut.Text);
            TimeSpan hours = startTime - endTimes;
            TimeSpan hoursGross = TimeSpan.FromHours(1);

            //string hoursGross2 = hoursGross.ToString("hh:mm");

            txtHours.Text = hoursGross.TotalHours.ToString();


        }

        private void btnEndShift_Click(object sender, EventArgs e)
        {
            if (txtClockIn.MaskCompleted.Equals(true) &&
                txtLunchIn.MaskCompleted.Equals(true) &&
                txtClockOut.MaskCompleted.Equals(true) &&
                txtLunchOut.MaskCompleted.Equals(true))
                    {
                        MessageBox.Show("Shift ended and exprted to current date in spreadsheet");
                    }

            else if (txtClockIn.MaskCompleted.Equals(false) ||
                     txtLunchIn.MaskCompleted.Equals(false) ||
                     txtClockOut.MaskCompleted.Equals(false) ||
                     txtLunchOut.MaskCompleted.Equals(false) ||
                     Properties.Settings.Default.ManualClicked.Equals(true))
                {
                    MessageBox.Show("Enter a valid time in all fields");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.ClockOutBtn.ToString());
        }

        public void seeIfValid() 
        {
            if (txtClockIn.MaskCompleted.Equals(true) &&
                txtLunchIn.MaskCompleted.Equals(true) &&
                txtClockOut.MaskCompleted.Equals(true) &&
                txtLunchOut.MaskCompleted.Equals(true) &&
                Properties.Settings.Default.ManualClicked.Equals(true))
                    {
                        btnDone.Visible = true;
                    }

            else if (txtClockIn.MaskCompleted.Equals(false) ||
                     txtLunchIn.MaskCompleted.Equals(false) ||
                     txtClockOut.MaskCompleted.Equals(false) ||
                     txtLunchOut.MaskCompleted.Equals(false) ||
                     Properties.Settings.Default.ManualClicked.Equals(true))
                        {
                            btnDone.Visible = false;
                        }
        }

        private void txtClockIn_TextChanged(object sender, EventArgs e)
        {
            seeIfValid();
        }

        private void txtLunchIn_TextChanged(object sender, EventArgs e)
        {
            seeIfValid();
        }

        private void txtClockOut_TextChanged(object sender, EventArgs e)
        {
            seeIfValid();
        }

        private void txtLunchOut_TextChanged(object sender, EventArgs e)
        {
            seeIfValid();
        }

    }
}
