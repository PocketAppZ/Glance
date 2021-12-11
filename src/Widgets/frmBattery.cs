using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glance.src.Widgets
{
    public partial class frmBattery : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,     // x-coordinate of upper-left corner
                 int nTopRect,      // y-coordinate of upper-left corner
                 int nRightRect,    // x-coordinate of lower-right corner
                 int nBottomRect,   // y-coordinate of lower-right corner
                 int nWidthEllipse, // width of ellipse
                 int nHeightEllipse // height of ellipse
             );
        public frmBattery()
        {
            InitializeComponent();
            timer1.Enabled = true;

                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            if (Properties.Settings.Default.WidgetTheme == "dark")
            {
                // do nothing.
            }

            if (Properties.Settings.Default.WidgetTheme == "light")
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }



        }

        private void CallSettings()
        {
             Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            

            if (Properties.Settings.Default.WidgetTheme == "dark")
            {
                //Fallback in case it doesn't change properly.

                this.BackColor = Color.FromArgb(20, 20, 20);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }

            if (Properties.Settings.Default.WidgetTheme == "light")
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }

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
                if(Properties.Settings.Default.WidgetTheme == "light")
                {
                    label2.Text = "" + perFull * 100 + "%";
                    label1.Text = "Charging.";
                    pictureBox1.Image = Properties.Resources.BatteryChargingWhite;
                }
            } else
            {
                label2.Text = "" + perFull * 100 + "%";
                label1.Text = "On Battery.";
                pictureBox1.Image = Properties.Resources.BatteryOnCharge;
                if (Properties.Settings.Default.WidgetTheme == "light")
                {
                    label2.Text = "" + perFull * 100 + "%";
                    label1.Text = "On Battery.";
                    pictureBox1.Image = Properties.Resources.BatteryOnChargeWhite;
                }
            }

            CallSettings();
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
