namespace keeperOfTime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.daCal = new System.Windows.Forms.MonthCalendar();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.btnEndShift = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblLunchEnd = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtClockIn = new System.Windows.Forms.MaskedTextBox();
            this.txtLunchIn = new System.Windows.Forms.MaskedTextBox();
            this.txtLunchOut = new System.Windows.Forms.MaskedTextBox();
            this.txtClockOut = new System.Windows.Forms.MaskedTextBox();
            this.txtHours = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // daCal
            // 
            this.daCal.Location = new System.Drawing.Point(174, 33);
            this.daCal.MaxSelectionCount = 1;
            this.daCal.Name = "daCal";
            this.daCal.TabIndex = 0;
            this.daCal.TabStop = false;
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(326, 255);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(75, 23);
            this.btnLookUp.TabIndex = 1;
            this.btnLookUp.Text = "Look Up";
            this.toolTip.SetToolTip(this.btnLookUp, "Select day then click \'Look Up\' to see shift info for that day.");
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // btnEndShift
            // 
            this.btnEndShift.Location = new System.Drawing.Point(12, 255);
            this.btnEndShift.Name = "btnEndShift";
            this.btnEndShift.Size = new System.Drawing.Size(75, 23);
            this.btnEndShift.TabIndex = 2;
            this.btnEndShift.Text = "End Shift";
            this.toolTip.SetToolTip(this.btnEndShift, "End shift and save to spreadsheet.");
            this.btnEndShift.UseVisualStyleBackColor = true;
            this.btnEndShift.Click += new System.EventHandler(this.btnEndShift_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(419, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.manualEntryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // manualEntryToolStripMenuItem
            // 
            this.manualEntryToolStripMenuItem.Name = "manualEntryToolStripMenuItem";
            this.manualEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualEntryToolStripMenuItem.Text = "Manual entry";
            this.manualEntryToolStripMenuItem.Click += new System.EventHandler(this.manualEntryToolStripMenuItem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 52);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "Clock-in";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(12, 81);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(75, 23);
            this.btnLunch.TabIndex = 5;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(12, 139);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "Clock-out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(112, 167);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(50, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblLunchEnd
            // 
            this.lblLunchEnd.AutoSize = true;
            this.lblLunchEnd.Location = new System.Drawing.Point(28, 115);
            this.lblLunchEnd.Name = "lblLunchEnd";
            this.lblLunchEnd.Size = new System.Drawing.Size(59, 13);
            this.lblLunchEnd.TabIndex = 9;
            this.lblLunchEnd.Text = "Lunch End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hours for today:";
            // 
            // txtClockIn
            // 
            this.txtClockIn.Location = new System.Drawing.Point(93, 54);
            this.txtClockIn.Mask = "00:00";
            this.txtClockIn.Name = "txtClockIn";
            this.txtClockIn.ReadOnly = true;
            this.txtClockIn.Size = new System.Drawing.Size(69, 20);
            this.txtClockIn.TabIndex = 16;
            this.txtClockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClockIn.ValidatingType = typeof(System.DateTime);
            // 
            // txtLunchIn
            // 
            this.txtLunchIn.Location = new System.Drawing.Point(93, 83);
            this.txtLunchIn.Mask = "00:00";
            this.txtLunchIn.Name = "txtLunchIn";
            this.txtLunchIn.ReadOnly = true;
            this.txtLunchIn.Size = new System.Drawing.Size(69, 20);
            this.txtLunchIn.TabIndex = 17;
            this.txtLunchIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLunchIn.ValidatingType = typeof(System.DateTime);
            // 
            // txtLunchOut
            // 
            this.txtLunchOut.Location = new System.Drawing.Point(93, 112);
            this.txtLunchOut.Mask = "00:00";
            this.txtLunchOut.Name = "txtLunchOut";
            this.txtLunchOut.ReadOnly = true;
            this.txtLunchOut.Size = new System.Drawing.Size(69, 20);
            this.txtLunchOut.TabIndex = 18;
            this.txtLunchOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLunchOut.ValidatingType = typeof(System.DateTime);
            // 
            // txtClockOut
            // 
            this.txtClockOut.Location = new System.Drawing.Point(93, 141);
            this.txtClockOut.Mask = "00:00";
            this.txtClockOut.Name = "txtClockOut";
            this.txtClockOut.ReadOnly = true;
            this.txtClockOut.Size = new System.Drawing.Size(69, 20);
            this.txtClockOut.TabIndex = 19;
            this.txtClockOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClockOut.ValidatingType = typeof(System.DateTime);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(178, 257);
            this.txtHours.Mask = "0.00";
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(45, 20);
            this.txtHours.TabIndex = 20;
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 290);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtClockOut);
            this.Controls.Add(this.txtLunchOut);
            this.Controls.Add(this.txtLunchIn);
            this.Controls.Add(this.txtClockIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLunchEnd);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnEndShift);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.daCal);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keeper Of Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar daCal;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Button btnEndShift;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualEntryToolStripMenuItem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblLunchEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtClockIn;
        private System.Windows.Forms.MaskedTextBox txtLunchIn;
        private System.Windows.Forms.MaskedTextBox txtLunchOut;
        private System.Windows.Forms.MaskedTextBox txtClockOut;
        private System.Windows.Forms.MaskedTextBox txtHours;
    }
}

