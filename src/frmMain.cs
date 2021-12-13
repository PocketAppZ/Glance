using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        src.Widgets.frmBattery Battery = new src.Widgets.frmBattery();
        src.Widgets.frmTime Time = new src.Widgets.frmTime();
        src.frmOptions Options = new src.frmOptions();
        src.Widgets.frmInternet Internet = new src.Widgets.frmInternet();

        private void button1_Click(object sender, EventArgs e)
        {
            Battery.Show();
            Time.Show();
            Internet.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Battery.Hide();
           Time.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(3000);
            this.Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
         
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
 
        }
    }
}
