using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerControl
{
    class MainClasss
    {
        private PresetControlClass presetControl;
        private TabControlClass steadyControl;
        public MainClasss()
        {
            steadyControl = new TabControlClass("config");
            steadyControl.initSteadyTabControl();
            
        }
        
        // FIX - Uncompleted method
        public String[] getPresets()
        {
            return Directory.GetFiles("config\\presets");
        }

        public void attachForm(Form1 f)
        {
            steadyControl.attachForm(f);
            //presetControl.attachForm(f);
        }
    }
}
