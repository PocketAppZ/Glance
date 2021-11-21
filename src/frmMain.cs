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
       
        private void button1_Click(object sender, EventArgs e)
        {
            src.Widgets.frmBattery Battery = new src.Widgets.frmBattery();
            src.Widgets.frmTime Time = new src.Widgets.frmTime();
            Battery.Show();
            Time.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            src.Widgets.frmBattery Battery = new src.Widgets.frmBattery();
            src.Widgets.frmTime Time = new src.Widgets.frmTime();
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
            src.frmOptions Options = new src.frmOptions();
            Options.Show();
        }
    }
}
