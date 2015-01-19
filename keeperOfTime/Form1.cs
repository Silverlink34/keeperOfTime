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
using GemBox.Spreadsheet;

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

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string clockInTime = DateTime.Now.ToString("HH:mm");
            txtClockIn.Text = clockInTime;

        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            if (txtClockIn.MaskCompleted.Equals(true) || Properties.Settings.Default.ManualClicked == true)
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
            if (txtLunchOut.MaskCompleted.Equals(true) || Properties.Settings.Default.ManualClicked == true)
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
            else if (txtLunchOut.MaskCompleted.Equals(false))
            {
                MessageBox.Show("You must finish lunch first. I know, you want to leave...");
            }

        }

        private void btnEndShift_Click(object sender, EventArgs e)
        {
            if (txtClockIn.MaskCompleted.Equals(true) &&
                txtLunchIn.MaskCompleted.Equals(true) &&
                txtClockOut.MaskCompleted.Equals(true) &&
                txtLunchOut.MaskCompleted.Equals(true))
                    {
                        MessageBox.Show("Shift ended and exprted to current date in spreadsheet");
                        //string xfPath = System.Environment.CurrentDirectory;
                        string xfPath = "C:\\Users\\bryan.jones\\Desktop\\storage\\";

                        //MessageBox.Show(xfPath);
                        ExcelFile xf = ExcelFile.Load(xfPath + "\\template.xltx");
                        //ExcelFile.Load(,)
                        
                        xf.Worksheets.ActiveWorksheet.Cells["C13"].Value = DateTime.Now.ToString("MM/dd/yyy");
                        xf.Worksheets.ActiveWorksheet.Cells["C3"].Value = txtClockIn.Text;

                        string currDate = DateTime.Today.ToString("MM.dd.yyyy");
                        string savePath = xfPath + currDate + ".xlsx";

                        xf.Save(savePath);
                        

                        //ExcelFile.Load();
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
            if (txtClockIn.MaskCompleted.Equals(true)) 
            {
                btnIn.Enabled = false;
            }
            else if (txtClockIn.MaskCompleted.Equals(false)) 
            {
                btnIn.Enabled = true;
            }
        }

        private void txtLunchIn_TextChanged(object sender, EventArgs e)
        {
            seeIfValid();
            if (txtLunchIn.MaskCompleted.Equals(true) && txtLunchOut.MaskCompleted.Equals(true))
            {
                btnLunch.Enabled = false;
            }
            else if (txtLunchIn.MaskCompleted.Equals(false) || txtLunchOut.MaskCompleted.Equals(false))
            {
                btnLunch.Enabled = true;
            }
        }

        private void txtClockOut_TextChanged(object sender, EventArgs e)
        {
            seeIfValid();
            if (txtClockOut.MaskCompleted.Equals(true))
            {
                btnOut.Enabled = false;
            }
            else if (txtClockOut.MaskCompleted.Equals(false))
            {
                btnOut.Enabled = true;
            }
        }

        private void txtLunchOut_TextChanged(object sender, EventArgs e)
        {
            seeIfValid();
            if (txtClockIn.MaskCompleted.Equals(true) || txtLunchOut.MaskCompleted.Equals(true))
            {
                btnLunch.Enabled = false;
            }
            else if (txtClockIn.MaskCompleted.Equals(false) || txtLunchOut.MaskCompleted.Equals(true))
            {
                btnLunch.Enabled = true;
            }
        }

    }
}
