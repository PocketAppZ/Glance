using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glance.src.Classes
{
    class SettingsCheck
    {

        public void PreloadCheck()
        {
            if (Properties.Settings.Default.WidgetShape == "newer")
            {
                Debug.Print("Widget Shape: Circular / Newer Version");
            }
        }
    }
}
