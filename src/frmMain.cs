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
            Battery.Show();

            src.Widgets.frmTime Time = new src.Widgets.frmTime();
            Time.Show();
        }
    }
}
