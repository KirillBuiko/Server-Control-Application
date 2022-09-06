using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ServerControl
{
    public partial class Form1 : Form
    {
        ProcessHandler pythonProc;
        ProcessHandler ngrokProc;
        NginxHandler nginxProc;
        Boolean noExit = true;

        public Form1()
        {  
            InitializeComponent();
            pythonProc = new ProcessHandler("python.exe", textBox2.Text, pythonStatus, richTextBox1);
            ngrokProc = new ProcessHandler(textBox3.Text, "http 8100", ngrokStatus, null, false);

            exit.Click += exit_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nginxProc = new NginxHandler(textBox1.Text, nginxStatus);
        }

        private void pythonConnect_Click(object sender, EventArgs e)
        {
            pythonProc.Connect();
        }

        private void pythonDisconnect_Click(object sender, EventArgs e)
        {
            pythonProc.Disconnect();
        }

        private void ngrokConnect_Click(object sender, EventArgs e)
        {
            ngrokProc.Connect();
        }

        private void ngrokDisconnect_Click(object sender, EventArgs e)
        {
            ngrokProc.Disconnect();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            nginxProc.Disconnect();
            pythonProc.Disconnect();
            ngrokProc.Disconnect();
        }

        private void nginxConnect_Click(object sender, EventArgs e)
        {
            nginxProc.Connect();
        }

        private void nginxDisconnect_Click(object sender, EventArgs e)
        {
            nginxProc.Disconnect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = noExit;
            this.Hide();
        }

        private void ngrokShowHide_Click(object sender, EventArgs e)
        {
            if (!ngrokProc.isExecuted) return;
            if (ngrokProc.isHidden)
                ngrokProc.Show();
            else
                ngrokProc.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            noExit = false;
            this.Close();
        }
    }
}
