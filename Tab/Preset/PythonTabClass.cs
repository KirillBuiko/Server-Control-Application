using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerControl.Tab.Preset
{
    class PythonTabClass : TabBase
    {
        public PythonTabClass(ConfigClass config) : base(config)
        {

        }

        public static Dictionary<String, String> generateDefaultConf()
        {
            Dictionary<String, String> res = new Dictionary<string, string>();
            res.Add("python-path", "D:\\Documents\\GitHub\\Jarvis-prod\\Jarvis_backend\\app.py");
            return res;
        }
    }
}
