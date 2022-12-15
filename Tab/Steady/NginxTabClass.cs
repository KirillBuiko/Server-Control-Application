using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerControl.Tab.Steady
{
    class NginxTabClass: TabBase
    {
        public NginxTabClass(ConfigClass config) : base(config)
        {
                    
        }

        public static Dictionary<String, String> generateDefaultConf()
        {
            Dictionary<String, String> res = new Dictionary<string, string>();
            res.Add("nginx-path", "C:\\nginx-1.22.0");
            return res;
        }
    }
}
