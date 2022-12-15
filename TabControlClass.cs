using ServerControl.Tab.Steady;
using ServerControl.Tab.Preset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerControl.Tab;

namespace ServerControl
{
    
    class TabControlClass
    {
        public TabControl tabControl;
        private ConfigClass config;
        public TabControlClass(String path)
        {
            config = new ConfigClass(path);
            initControl();
        }

        public void initControl()
        {
            tabControl = new TabControl();
            tabControl.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(779, 689);
            tabControl.TabIndex = 7;
        }

        public void initSteadyTabControl()
        {
            tabControl.Name = "steadyTabControl2";
            tabControl.Location = new System.Drawing.Point(838, 49);
            NginxTabClass nginxTab = new NginxTabClass(config);
            NgrokTabClass ngrokTab = new NgrokTabClass(config);
            //tabControl.Controls.Add(nginxTab);
            //tabControl.Controls.Add(ngrokTab);
        }

        public void initPresetTabControl()
        {
            tabControl.Location = new System.Drawing.Point(9, 18);
            PythonTabClass pythonTab = new PythonTabClass(config);
            tabControl.Controls.Add(pythonTab);
        }

        public void attachForm(Form1 f)
        {
            f.Controls.Add(tabControl);
        }

        static Dictionary<String, String> generateDefaultConf()
        {
            List<Dictionary<String, String>> configs = new List<Dictionary<string, string>>();
            configs.Add(PythonTabClass.generateDefaultConf());
            configs.Add(NginxTabClass.generateDefaultConf());
            configs.Add(NgrokTabClass.generateDefaultConf());

            Dictionary<String, String> res = new Dictionary<string, string>();
            foreach (Dictionary<String, String> conf in configs){
                res = res.Concat(conf).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            }
            return res;
        }
    }
   
}
