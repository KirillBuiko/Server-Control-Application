using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerControl.Tab.Steady
{
    class NgrokTabClass: TabBase
    {
        public NgrokTabClass(ConfigClass config) : base(config)
        {

        }

        public static Dictionary<String, String> generateDefaultConf()
        {
            Dictionary<String, String> res = new Dictionary<string, string>();
            res.Add("ngrok-path", "D:\\Desktop\\Ngrok\\ngrok.exe");
            return res;
        }
    }
}
