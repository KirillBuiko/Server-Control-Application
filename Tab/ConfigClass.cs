using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerControl.Tab
{
    class ConfigClass
    {
        public Dictionary<String, String> configDict;
        public String path = "";

        public ConfigClass(String path)
        {
            configDict = new Dictionary<string, string>();
            this.path = path;
            parse();
        }

        // TODO - Write get preset name
        public String getPresetName()
        {
            return "";
        }

        // TODO - Write config parse
        public void parse()
        {
            configDict.Clear();
            String presetName = "";
            if (this.path.Contains('\\'))
                presetName = this.path.Split('\\').Last();
            configDict.Add("preset-name", presetName);
            configDict.Add("preset-path", this.path);
        }

        public String get(String key)
        {
            return configDict[key];
        }

        public void set(String key, String value)
        {
            configDict[key] = value;
        }

        // TODO - Write config save
        public void save()
        {

        }
    }
}
