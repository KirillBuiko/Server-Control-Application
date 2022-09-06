using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ServerControl
{
    class ProcessHandler
    {
        Process myProcess = new Process();
        public Boolean isExecuted = false;
        public Boolean isHidden = false;
        Label statusLabel = new Label();
        RichTextBox outputText = new RichTextBox();

        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public ProcessHandler(string Path, string Command, Label Status, RichTextBox Output, Boolean noWindow = true)
        {
            statusLabel = Status;
            outputText = Output == null ?  outputText : Output;
            myProcess.StartInfo.FileName = Path;
            myProcess.StartInfo.Arguments = Command;
            myProcess.StartInfo.RedirectStandardError = noWindow;
            myProcess.StartInfo.RedirectStandardOutput = noWindow;
            myProcess.StartInfo.RedirectStandardInput = noWindow;
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.EnableRaisingEvents = true;
            myProcess.StartInfo.CreateNoWindow = noWindow;

            myProcess.OutputDataReceived += new DataReceivedEventHandler((s, e) =>
            {
                Console.WriteLine(e.Data);
                outputText.Invoke((Action)delegate { outputText.Text = outputText.Text + '\n' + e.Data; });
            });
            myProcess.ErrorDataReceived += new DataReceivedEventHandler((s, e) =>
            {
                Console.WriteLine(e.Data);
                outputText.Invoke((Action)delegate { outputText.Text = outputText.Text + '\n' + e.Data; });
            });
            myProcess.Exited += Disconnect;
        }

        public void Connect()
        {
            if (isExecuted) return;
            myProcess.Start();
            try
            {
                myProcess.BeginOutputReadLine();
                myProcess.BeginErrorReadLine();
            }
            catch (Exception) { }
            statusLabel.Invoke((Action)delegate { outputText.Text = ""; });
            statusLabel.Invoke((Action)delegate { statusLabel.Text = "Подключено"; });
            isExecuted = true;
        }

        public void Disconnect(object sender, EventArgs e)
        {
            Disconnect();
        }

        public void Disconnect()
        {
            if (!isExecuted) return;

            try
            {
                //myProcess.StandardInput.Close();
                myProcess.Kill();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                myProcess.CancelOutputRead();
                myProcess.CancelErrorRead();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            statusLabel.Invoke((Action)delegate { statusLabel.Text = "Отключено"; });
            isExecuted = false;
        }

        public void Hide()
        {
            isHidden = true;
            ShowWindow(myProcess.MainWindowHandle, 0);
        }

        public void Show()
        {
            isHidden = false;
            ShowWindow(myProcess.MainWindowHandle, 1);
        }
    }
}
