using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glance.src
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            label4.Text = "Current Setting: " + Properties.Settings.Default.WidgetShape;
           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Properties.Settings.Default.WidgetShape = "default";
            }
            if (radioButton2.Checked == true)
            {
                Properties.Settings.Default.WidgetShape = "newer";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Properties.Settings.Default.WidgetShape = "default";
            }
            if (radioButton2.Checked == true)
            {
                Properties.Settings.Default.WidgetShape = "newer";
            }
        }
    }
}
