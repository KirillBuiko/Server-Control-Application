
namespace ServerControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nginxDisconnect = new System.Windows.Forms.Button();
            this.nginxConnect = new System.Windows.Forms.Button();
            this.nginxStatus = new System.Windows.Forms.Label();
            this.pythonGroup = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pythonDisconnect = new System.Windows.Forms.Button();
            this.pythonConnect = new System.Windows.Forms.Button();
            this.pythonStatus = new System.Windows.Forms.Label();
            this.ngrok = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ngrokDisconnect = new System.Windows.Forms.Button();
            this.ngrokShowHide = new System.Windows.Forms.Button();
            this.ngrokConnect = new System.Windows.Forms.Button();
            this.ngrokStatus = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.exitMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.pythonGroup.SuspendLayout();
            this.ngrok.SuspendLayout();
            this.exitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.nginxDisconnect);
            this.groupBox1.Controls.Add(this.nginxConnect);
            this.groupBox1.Controls.Add(this.nginxStatus);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "nginx";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "C:\\nginx-1.22.0";
            // 
            // nginxDisconnect
            // 
            this.nginxDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nginxDisconnect.Location = new System.Drawing.Point(11, 129);
            this.nginxDisconnect.Name = "nginxDisconnect";
            this.nginxDisconnect.Size = new System.Drawing.Size(258, 35);
            this.nginxDisconnect.TabIndex = 2;
            this.nginxDisconnect.Text = "Отключить";
            this.nginxDisconnect.UseVisualStyleBackColor = true;
            this.nginxDisconnect.Click += new System.EventHandler(this.nginxDisconnect_Click);
            // 
            // nginxConnect
            // 
            this.nginxConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nginxConnect.Location = new System.Drawing.Point(11, 88);
            this.nginxConnect.Name = "nginxConnect";
            this.nginxConnect.Size = new System.Drawing.Size(258, 35);
            this.nginxConnect.TabIndex = 1;
            this.nginxConnect.Text = "Подключить";
            this.nginxConnect.UseVisualStyleBackColor = true;
            this.nginxConnect.Click += new System.EventHandler(this.nginxConnect_Click);
            // 
            // nginxStatus
            // 
            this.nginxStatus.AutoSize = true;
            this.nginxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nginxStatus.Location = new System.Drawing.Point(24, 38);
            this.nginxStatus.Name = "nginxStatus";
            this.nginxStatus.Size = new System.Drawing.Size(105, 28);
            this.nginxStatus.TabIndex = 0;
            this.nginxStatus.Text = "Отключён";
            // 
            // pythonGroup
            // 
            this.pythonGroup.Controls.Add(this.richTextBox1);
            this.pythonGroup.Controls.Add(this.textBox2);
            this.pythonGroup.Controls.Add(this.pythonDisconnect);
            this.pythonGroup.Controls.Add(this.pythonConnect);
            this.pythonGroup.Controls.Add(this.pythonStatus);
            this.pythonGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pythonGroup.Location = new System.Drawing.Point(13, 245);
            this.pythonGroup.Name = "pythonGroup";
            this.pythonGroup.Size = new System.Drawing.Size(777, 229);
            this.pythonGroup.TabIndex = 2;
            this.pythonGroup.TabStop = false;
            this.pythonGroup.Text = "python";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Navy;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(292, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(479, 187);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "D:\\Documents\\GitHub\\Jarvis-prod\\Jarvis_backend\\app.py";
            // 
            // pythonDisconnect
            // 
            this.pythonDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pythonDisconnect.Location = new System.Drawing.Point(11, 129);
            this.pythonDisconnect.Name = "pythonDisconnect";
            this.pythonDisconnect.Size = new System.Drawing.Size(258, 35);
            this.pythonDisconnect.TabIndex = 2;
            this.pythonDisconnect.Text = "Отключить";
            this.pythonDisconnect.UseVisualStyleBackColor = true;
            this.pythonDisconnect.Click += new System.EventHandler(this.pythonDisconnect_Click);
            // 
            // pythonConnect
            // 
            this.pythonConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pythonConnect.Location = new System.Drawing.Point(11, 88);
            this.pythonConnect.Name = "pythonConnect";
            this.pythonConnect.Size = new System.Drawing.Size(258, 35);
            this.pythonConnect.TabIndex = 1;
            this.pythonConnect.Text = "Подключить";
            this.pythonConnect.UseVisualStyleBackColor = true;
            this.pythonConnect.Click += new System.EventHandler(this.pythonConnect_Click);
            // 
            // pythonStatus
            // 
            this.pythonStatus.AutoSize = true;
            this.pythonStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pythonStatus.Location = new System.Drawing.Point(24, 38);
            this.pythonStatus.Name = "pythonStatus";
            this.pythonStatus.Size = new System.Drawing.Size(105, 28);
            this.pythonStatus.TabIndex = 0;
            this.pythonStatus.Text = "Отключён";
            // 
            // ngrok
            // 
            this.ngrok.Controls.Add(this.textBox3);
            this.ngrok.Controls.Add(this.ngrokDisconnect);
            this.ngrok.Controls.Add(this.ngrokShowHide);
            this.ngrok.Controls.Add(this.ngrokConnect);
            this.ngrok.Controls.Add(this.ngrokStatus);
            this.ngrok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrok.Location = new System.Drawing.Point(13, 480);
            this.ngrok.Name = "ngrok";
            this.ngrok.Size = new System.Drawing.Size(777, 229);
            this.ngrok.TabIndex = 4;
            this.ngrok.TabStop = false;
            this.ngrok.Text = "ngrok";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 30);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "D:\\Desktop\\Ngrok\\ngrok.exe";
            // 
            // ngrokDisconnect
            // 
            this.ngrokDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrokDisconnect.Location = new System.Drawing.Point(11, 129);
            this.ngrokDisconnect.Name = "ngrokDisconnect";
            this.ngrokDisconnect.Size = new System.Drawing.Size(258, 35);
            this.ngrokDisconnect.TabIndex = 2;
            this.ngrokDisconnect.Text = "Отключить";
            this.ngrokDisconnect.UseVisualStyleBackColor = true;
            this.ngrokDisconnect.Click += new System.EventHandler(this.ngrokDisconnect_Click);
            // 
            // ngrokShowHide
            // 
            this.ngrokShowHide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrokShowHide.Location = new System.Drawing.Point(292, 88);
            this.ngrokShowHide.Name = "ngrokShowHide";
            this.ngrokShowHide.Size = new System.Drawing.Size(258, 35);
            this.ngrokShowHide.TabIndex = 1;
            this.ngrokShowHide.Text = "Спрятать/Показать";
            this.ngrokShowHide.UseVisualStyleBackColor = true;
            this.ngrokShowHide.Click += new System.EventHandler(this.ngrokShowHide_Click);
            // 
            // ngrokConnect
            // 
            this.ngrokConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrokConnect.Location = new System.Drawing.Point(11, 88);
            this.ngrokConnect.Name = "ngrokConnect";
            this.ngrokConnect.Size = new System.Drawing.Size(258, 35);
            this.ngrokConnect.TabIndex = 1;
            this.ngrokConnect.Text = "Подключить";
            this.ngrokConnect.UseVisualStyleBackColor = true;
            this.ngrokConnect.Click += new System.EventHandler(this.ngrokConnect_Click);
            // 
            // ngrokStatus
            // 
            this.ngrokStatus.AutoSize = true;
            this.ngrokStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrokStatus.Location = new System.Drawing.Point(24, 38);
            this.ngrokStatus.Name = "ngrokStatus";
            this.ngrokStatus.Size = new System.Drawing.Size(105, 28);
            this.ngrokStatus.TabIndex = 0;
            this.ngrokStatus.Text = "Отключён";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.exitMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Server Control";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // exitMenu
            // 
            this.exitMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.exitMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(103, 28);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 24);
            this.exit.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 722);
            this.Controls.Add(this.ngrok);
            this.Controls.Add(this.pythonGroup);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pythonGroup.ResumeLayout(false);
            this.pythonGroup.PerformLayout();
            this.ngrok.ResumeLayout(false);
            this.ngrok.PerformLayout();
            this.exitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nginxDisconnect;
        private System.Windows.Forms.Button nginxConnect;
        private System.Windows.Forms.Label nginxStatus;
        private System.Windows.Forms.GroupBox pythonGroup;
        private System.Windows.Forms.Button pythonDisconnect;
        private System.Windows.Forms.Button pythonConnect;
        private System.Windows.Forms.Label pythonStatus;
        private System.Windows.Forms.GroupBox ngrok;
        private System.Windows.Forms.Button ngrokDisconnect;
        private System.Windows.Forms.Button ngrokConnect;
        private System.Windows.Forms.Label ngrokStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ngrokShowHide;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip exitMenu;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}

