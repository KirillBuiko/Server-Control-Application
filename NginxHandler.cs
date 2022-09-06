using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerControl
{
    class NginxHandler
    {
        Boolean isExecuted = false;
        string Path = "";
        Label statusLabel;
        RichTextBox outputText;

        public NginxHandler(string Path, Label Status)
        {
            this.Path = Path;
            statusLabel = Status;
            if (File.Exists(Path + "\\logs\\nginx.pid"))
            {
                statusLabel.Invoke((Action)delegate { statusLabel.Text = "Подключено"; });
                isExecuted = true;
            }
        }

        public void Connect()
        {
            if (isExecuted) return;
            isExecuted = true;

            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.EnableRaisingEvents = true;
            myProcess.StartInfo.CreateNoWindow = false;

            statusLabel.Invoke((Action)delegate { statusLabel.Text = "Подключено"; });

            myProcess.Start();
            using (StreamWriter sw = myProcess.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd " + Path);
                    sw.WriteLine("start nginx");
                }
            }
        }

        public void Disconnect(object sender, EventArgs e)
        {
            Disconnect();
        }

        public void Disconnect()
        {
            if (!isExecuted) return;
            isExecuted = false;

            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.EnableRaisingEvents = true;
            myProcess.StartInfo.CreateNoWindow = false;

            statusLabel.Invoke((Action)delegate { statusLabel.Text = "Отключено"; });

            myProcess.Start();
            using (StreamWriter sw = myProcess.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd " + Path);
                    sw.WriteLine("nginx -s stop");
                }
            }
            myProcess.WaitForExit();
        }
    }
}
