﻿using System;
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
            label4.Text = "Current Setting: " + Properties.Settings.Default.WidgetShape;
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
            if (radioButton1.Checked == true)
            {
                Properties.Settings.Default.WidgetShape = "default";
            }
            if (radioButton2.Checked == true)
            {
                Properties.Settings.Default.WidgetShape = "newer";
            }
            label4.Text = "Current Setting: " + Properties.Settings.Default.WidgetShape;



            if (Properties.Settings.Default.WidgetShape == "default")
            {
                radioButton1.Checked = true;
            }

            if (Properties.Settings.Default.WidgetShape == "newer")
            {
                radioButton2.Checked = true;
            }
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
