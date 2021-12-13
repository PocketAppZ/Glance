using Microsoft.WindowsAPICodePack.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glance.src.Widgets
{
    public partial class frmInternet : Form
    {
        public frmInternet()
        {
            InitializeComponent();
        }

        private void frmInternet_Load(object sender, EventArgs e)
        {
            showConnectedId();
        
        }

        // Show SSID and Signal Strength
        public void showConnectedId()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {

                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && ni.OperationalStatus == OperationalStatus.Up)
                    {
                        string  Wifi = ni.Name;
                        string WifiSpeed = "WiFi Speed: " + ni.Speed;
                        string WifiDescription = "WiFi Specs: " + ni.Description;
                        label1.Text = Wifi;
                        label2.Text = WifiSpeed.ToString();
                        label3.Text = WifiDescription;
                    }
                }
            }
        }
    }
}
