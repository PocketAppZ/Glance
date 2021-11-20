﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glance.src.Widgets
{
    public partial class frmBattery : Form
    {
        public frmBattery()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

     
        private void frmBattery_Load(object sender, EventArgs e)
        {
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void timer1_Tick(object sender, EventArgs e)
        {
            PowerStatus psBattery = SystemInformation.PowerStatus;
            float perFull = psBattery.BatteryLifePercent;

            if (psBattery.PowerLineStatus == PowerLineStatus.Online)
            {
                label2.Text = "" + perFull * 100 + "%";
                label1.Text = "Charging.";
                pictureBox1.Image = Properties.Resources.BatteryCharging;
            } else
            {
                label2.Text = "" + perFull * 100 + "%";
                label1.Text = "On Battery.";
                pictureBox1.Image = Properties.Resources.BatteryOnCharge;
            }
        }

        private void frmBattery_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
