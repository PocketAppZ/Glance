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
    public partial class frmBattery : Form
    {
        public frmBattery()
        {
            InitializeComponent();
        }

        private void frmBattery_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
