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
            WidgetShapeSetting();
            WidgetColorSetting();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WidgetShapeSetting();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WidgetShapeSetting();
        }

        private void WidgetShapeSetting()
        {

        }

        private void WidgetColorSetting()
        {   
            if(radioButton3.Checked == true)
            {
                Properties.Settings.Default.WidgetTheme = "dark";
            }

            if (radioButton4.Checked == true)
            {
                Properties.Settings.Default.WidgetTheme = "light";
            }
            label5.Text = "Current Setting: " + Properties.Settings.Default.WidgetTheme;


            if (Properties.Settings.Default.WidgetTheme == "dark")
            {
                radioButton3.Checked = true;
            }

            if (Properties.Settings.Default.WidgetTheme == "light")
            {
                radioButton4.Checked = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            WidgetColorSetting();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            WidgetColorSetting();
        }
    }
}
