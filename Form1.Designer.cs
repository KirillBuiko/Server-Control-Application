
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nginxDisconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nginxConnect = new System.Windows.Forms.Button();
            this.nginxStatus = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pythonDisconnect = new System.Windows.Forms.Button();
            this.pythonConnect = new System.Windows.Forms.Button();
            this.pythonStatus = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ngrokDisconnect = new System.Windows.Forms.Button();
            this.ngrokShowHide = new System.Windows.Forms.Button();
            this.ngrokConnect = new System.Windows.Forms.Button();
            this.ngrokStatus = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.exitMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пресетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetBox = new System.Windows.Forms.GroupBox();
            this.presetTabControl = new System.Windows.Forms.TabControl();
            this.pythonTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.steadyTabControl = new System.Windows.Forms.TabControl();
            this.nginxTab = new System.Windows.Forms.TabPage();
            this.ngrokTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.exitMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.presetBox.SuspendLayout();
            this.presetTabControl.SuspendLayout();
            this.pythonTab.SuspendLayout();
            this.steadyTabControl.SuspendLayout();
            this.nginxTab.SuspendLayout();
            this.ngrokTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "C:\\nginx-1.22.0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // nginxDisconnect
            // 
            this.nginxDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nginxDisconnect.Location = new System.Drawing.Point(20, 100);
            this.nginxDisconnect.Name = "nginxDisconnect";
            this.nginxDisconnect.Size = new System.Drawing.Size(258, 35);
            this.nginxDisconnect.TabIndex = 2;
            this.nginxDisconnect.Text = "Отключить";
            this.nginxDisconnect.UseVisualStyleBackColor = true;
            this.nginxDisconnect.Click += new System.EventHandler(this.nginxDisconnect_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(284, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть файл конфигураций";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nginxConnect
            // 
            this.nginxConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nginxConnect.Location = new System.Drawing.Point(20, 59);
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
            this.nginxStatus.Location = new System.Drawing.Point(15, 19);
            this.nginxStatus.Name = "nginxStatus";
            this.nginxStatus.Size = new System.Drawing.Size(105, 28);
            this.nginxStatus.TabIndex = 0;
            this.nginxStatus.Text = "Отключён";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Navy;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 463);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(769, 187);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(554, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "D:\\Documents\\GitHub\\Jarvis-prod\\Jarvis_backend\\app.py";
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // pythonDisconnect
            // 
            this.pythonDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pythonDisconnect.Location = new System.Drawing.Point(352, 12);
            this.pythonDisconnect.Name = "pythonDisconnect";
            this.pythonDisconnect.Size = new System.Drawing.Size(166, 35);
            this.pythonDisconnect.TabIndex = 2;
            this.pythonDisconnect.Text = "Отключить";
            this.pythonDisconnect.UseVisualStyleBackColor = true;
            this.pythonDisconnect.Click += new System.EventHandler(this.pythonDisconnect_Click);
            // 
            // pythonConnect
            // 
            this.pythonConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pythonConnect.Location = new System.Drawing.Point(184, 12);
            this.pythonConnect.Name = "pythonConnect";
            this.pythonConnect.Size = new System.Drawing.Size(162, 35);
            this.pythonConnect.TabIndex = 1;
            this.pythonConnect.Text = "Подключить";
            this.pythonConnect.UseVisualStyleBackColor = true;
            this.pythonConnect.Click += new System.EventHandler(this.pythonConnect_Click);
            // 
            // pythonStatus
            // 
            this.pythonStatus.AutoSize = true;
            this.pythonStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pythonStatus.Location = new System.Drawing.Point(15, 19);
            this.pythonStatus.Name = "pythonStatus";
            this.pythonStatus.Size = new System.Drawing.Size(105, 28);
            this.pythonStatus.TabIndex = 0;
            this.pythonStatus.Text = "Отключён";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(538, 30);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "D:\\Desktop\\Ngrok\\ngrok.exe";
            this.textBox3.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // ngrokDisconnect
            // 
            this.ngrokDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrokDisconnect.Location = new System.Drawing.Point(418, 21);
            this.ngrokDisconnect.Name = "ngrokDisconnect";
            this.ngrokDisconnect.Size = new System.Drawing.Size(182, 35);
            this.ngrokDisconnect.TabIndex = 2;
            this.ngrokDisconnect.Text = "Отключить";
            this.ngrokDisconnect.UseVisualStyleBackColor = true;
            this.ngrokDisconnect.Click += new System.EventHandler(this.ngrokDisconnect_Click);
            // 
            // ngrokShowHide
            // 
            this.ngrokShowHide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrokShowHide.Location = new System.Drawing.Point(214, 112);
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
            this.ngrokConnect.Location = new System.Drawing.Point(214, 20);
            this.ngrokConnect.Name = "ngrokConnect";
            this.ngrokConnect.Size = new System.Drawing.Size(198, 35);
            this.ngrokConnect.TabIndex = 1;
            this.ngrokConnect.Text = "Подключить";
            this.ngrokConnect.UseVisualStyleBackColor = true;
            this.ngrokConnect.Click += new System.EventHandler(this.ngrokConnect_Click);
            // 
            // ngrokStatus
            // 
            this.ngrokStatus.AutoSize = true;
            this.ngrokStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ngrokStatus.Location = new System.Drawing.Point(15, 19);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пресетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1621, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пресетToolStripMenuItem
            // 
            this.пресетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem});
            this.пресетToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пресетToolStripMenuItem.Name = "пресетToolStripMenuItem";
            this.пресетToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.пресетToolStripMenuItem.Text = "Установки";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.новыйToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.новыйToolStripMenuItem.Text = "Новая";
            // 
            // presetBox
            // 
            this.presetBox.Controls.Add(this.presetTabControl);
            this.presetBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.presetBox.Location = new System.Drawing.Point(12, 31);
            this.presetBox.Name = "presetBox";
            this.presetBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.presetBox.Size = new System.Drawing.Size(800, 713);
            this.presetBox.TabIndex = 6;
            this.presetBox.TabStop = false;
            this.presetBox.Text = "Установка";
            this.presetBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // presetTabControl
            // 
            this.presetTabControl.Controls.Add(this.pythonTab);
            this.presetTabControl.Location = new System.Drawing.Point(9, 18);
            this.presetTabControl.Name = "presetTabControl";
            this.presetTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.presetTabControl.SelectedIndex = 0;
            this.presetTabControl.Size = new System.Drawing.Size(783, 689);
            this.presetTabControl.TabIndex = 3;
            // 
            // pythonTab
            // 
            this.pythonTab.Controls.Add(this.richTextBox1);
            this.pythonTab.Controls.Add(this.textBox2);
            this.pythonTab.Controls.Add(this.pythonStatus);
            this.pythonTab.Controls.Add(this.pythonDisconnect);
            this.pythonTab.Controls.Add(this.label2);
            this.pythonTab.Controls.Add(this.pythonConnect);
            this.pythonTab.Location = new System.Drawing.Point(4, 32);
            this.pythonTab.Name = "pythonTab";
            this.pythonTab.Size = new System.Drawing.Size(775, 653);
            this.pythonTab.TabIndex = 0;
            this.pythonTab.Text = "Python";
            this.pythonTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь до файла:";
            // 
            // steadyTabControl
            // 
            this.steadyTabControl.Controls.Add(this.nginxTab);
            this.steadyTabControl.Controls.Add(this.ngrokTab);
            this.steadyTabControl.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.steadyTabControl.Location = new System.Drawing.Point(838, 49);
            this.steadyTabControl.Name = "steadyTabControl";
            this.steadyTabControl.SelectedIndex = 0;
            this.steadyTabControl.Size = new System.Drawing.Size(779, 689);
            this.steadyTabControl.TabIndex = 7;
            this.steadyTabControl.Visible = false;
            // 
            // nginxTab
            // 
            this.nginxTab.Controls.Add(this.textBox1);
            this.nginxTab.Controls.Add(this.nginxConnect);
            this.nginxTab.Controls.Add(this.nginxDisconnect);
            this.nginxTab.Controls.Add(this.nginxStatus);
            this.nginxTab.Controls.Add(this.button1);
            this.nginxTab.Location = new System.Drawing.Point(4, 32);
            this.nginxTab.Name = "nginxTab";
            this.nginxTab.Padding = new System.Windows.Forms.Padding(3);
            this.nginxTab.Size = new System.Drawing.Size(771, 653);
            this.nginxTab.TabIndex = 0;
            this.nginxTab.Text = "nginx";
            this.nginxTab.UseVisualStyleBackColor = true;
            // 
            // ngrokTab
            // 
            this.ngrokTab.Controls.Add(this.textBox3);
            this.ngrokTab.Controls.Add(this.ngrokStatus);
            this.ngrokTab.Controls.Add(this.ngrokDisconnect);
            this.ngrokTab.Controls.Add(this.ngrokConnect);
            this.ngrokTab.Controls.Add(this.label1);
            this.ngrokTab.Controls.Add(this.ngrokShowHide);
            this.ngrokTab.Location = new System.Drawing.Point(4, 32);
            this.ngrokTab.Name = "ngrokTab";
            this.ngrokTab.Padding = new System.Windows.Forms.Padding(3);
            this.ngrokTab.Size = new System.Drawing.Size(771, 653);
            this.ngrokTab.TabIndex = 1;
            this.ngrokTab.Text = "ngrok";
            this.ngrokTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Путь до файла:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 756);
            this.Controls.Add(this.steadyTabControl);
            this.Controls.Add(this.presetBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.exitMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.presetBox.ResumeLayout(false);
            this.presetTabControl.ResumeLayout(false);
            this.pythonTab.ResumeLayout(false);
            this.pythonTab.PerformLayout();
            this.steadyTabControl.ResumeLayout(false);
            this.nginxTab.ResumeLayout(false);
            this.nginxTab.PerformLayout();
            this.ngrokTab.ResumeLayout(false);
            this.ngrokTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button nginxDisconnect;
        public System.Windows.Forms.Button nginxConnect;
        public System.Windows.Forms.Label nginxStatus;
        public System.Windows.Forms.Button pythonDisconnect;
        public System.Windows.Forms.Button pythonConnect;
        public System.Windows.Forms.Label pythonStatus;
        public System.Windows.Forms.Button ngrokDisconnect;
        public System.Windows.Forms.Button ngrokConnect;
        public System.Windows.Forms.Label ngrokStatus;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button ngrokShowHide;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ContextMenuStrip exitMenu;
        public System.Windows.Forms.ToolStripMenuItem exit;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem пресетToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        public System.Windows.Forms.GroupBox presetBox;
        public System.Windows.Forms.TabControl presetTabControl;
        public System.Windows.Forms.TabPage pythonTab;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl steadyTabControl;
        public System.Windows.Forms.TabPage nginxTab;
        public System.Windows.Forms.TabPage ngrokTab;
        public System.Windows.Forms.Label label2;
    }
}

