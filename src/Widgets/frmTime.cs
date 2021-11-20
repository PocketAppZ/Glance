using System;
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
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public void displayTime(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("h:mm:ss tt");
            label2.Text = String.Format("{0:dd MMMM yyyy}", DateTime.Now);
        }
        private Timer tim;
        private void frmTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
            displayTime(null, null);
            tim = new Timer();
            tim.Interval = 100;
            tim.Tick += displayTime;
            tim.Start();
        }

        private void frmTime_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
