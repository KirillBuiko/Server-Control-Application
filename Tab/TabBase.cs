using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerControl.Tab
{
    abstract class TabBase: System.Windows.Forms.TabPage
    {
        protected String preset;
        protected String path;

        public TabBase(ConfigClass config)
        {
            this.preset = config.get("preset-name");
            this.path = config.get("preset-path");
            initTab();
        }

        protected void initOnOffPathControls()
        {

        }

        protected void initPathControls()
        {

        }

        protected void initTab()
        {
            this.Location = new System.Drawing.Point(4, 32);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(771, 653);
            this.Text = "nginx2";
            this.UseVisualStyleBackColor = true;
        }
    }
}
