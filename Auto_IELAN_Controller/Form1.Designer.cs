namespace Auto_IELAN_Controller
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox_ProxyEn = new System.Windows.Forms.CheckBox();
            this.textBox_ProxyAddr = new System.Windows.Forms.TextBox();
            this.label_ProxyAddr = new System.Windows.Forms.Label();
            this.label_ProxyPort = new System.Windows.Forms.Label();
            this.textBox_ProxyPort = new System.Windows.Forms.TextBox();
            this.groupBox_Proxy = new System.Windows.Forms.GroupBox();
            this.button_ProxyApply = new System.Windows.Forms.Button();
            this.groupBox_Conf_Script = new System.Windows.Forms.GroupBox();
            this.button_SctiptApply = new System.Windows.Forms.Button();
            this.label_ScriptAddr = new System.Windows.Forms.Label();
            this.textBox_Script = new System.Windows.Forms.TextBox();
            this.checkBox_ScriptEn = new System.Windows.Forms.CheckBox();
            this.timer_monitor = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button_monitor = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.checkBox_Startup = new System.Windows.Forms.CheckBox();
            this.groupBox_Proxy.SuspendLayout();
            this.groupBox_Conf_Script.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_ProxyEn
            // 
            this.checkBox_ProxyEn.AutoSize = true;
            this.checkBox_ProxyEn.Location = new System.Drawing.Point(8, 26);
            this.checkBox_ProxyEn.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ProxyEn.Name = "checkBox_ProxyEn";
            this.checkBox_ProxyEn.Size = new System.Drawing.Size(113, 19);
            this.checkBox_ProxyEn.TabIndex = 0;
            this.checkBox_ProxyEn.Text = "Enabled Proxy";
            this.checkBox_ProxyEn.UseVisualStyleBackColor = true;
            this.checkBox_ProxyEn.CheckedChanged += new System.EventHandler(this.checkBox_ProxyEn_CheckedChanged);
            // 
            // textBox_ProxyAddr
            // 
            this.textBox_ProxyAddr.Enabled = false;
            this.textBox_ProxyAddr.Location = new System.Drawing.Point(33, 69);
            this.textBox_ProxyAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ProxyAddr.Name = "textBox_ProxyAddr";
            this.textBox_ProxyAddr.Size = new System.Drawing.Size(252, 25);
            this.textBox_ProxyAddr.TabIndex = 1;
            // 
            // label_ProxyAddr
            // 
            this.label_ProxyAddr.AutoSize = true;
            this.label_ProxyAddr.Location = new System.Drawing.Point(31, 50);
            this.label_ProxyAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ProxyAddr.Name = "label_ProxyAddr";
            this.label_ProxyAddr.Size = new System.Drawing.Size(94, 15);
            this.label_ProxyAddr.TabIndex = 2;
            this.label_ProxyAddr.Text = "Proxy Address:";
            // 
            // label_ProxyPort
            // 
            this.label_ProxyPort.AutoSize = true;
            this.label_ProxyPort.Location = new System.Drawing.Point(31, 100);
            this.label_ProxyPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ProxyPort.Name = "label_ProxyPort";
            this.label_ProxyPort.Size = new System.Drawing.Size(73, 15);
            this.label_ProxyPort.TabIndex = 3;
            this.label_ProxyPort.Text = "Proxy Port:";
            // 
            // textBox_ProxyPort
            // 
            this.textBox_ProxyPort.Enabled = false;
            this.textBox_ProxyPort.Location = new System.Drawing.Point(33, 119);
            this.textBox_ProxyPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ProxyPort.Name = "textBox_ProxyPort";
            this.textBox_ProxyPort.Size = new System.Drawing.Size(99, 25);
            this.textBox_ProxyPort.TabIndex = 4;
            // 
            // groupBox_Proxy
            // 
            this.groupBox_Proxy.Controls.Add(this.button_ProxyApply);
            this.groupBox_Proxy.Controls.Add(this.checkBox_ProxyEn);
            this.groupBox_Proxy.Controls.Add(this.textBox_ProxyPort);
            this.groupBox_Proxy.Controls.Add(this.label_ProxyAddr);
            this.groupBox_Proxy.Controls.Add(this.label_ProxyPort);
            this.groupBox_Proxy.Controls.Add(this.textBox_ProxyAddr);
            this.groupBox_Proxy.Location = new System.Drawing.Point(16, 15);
            this.groupBox_Proxy.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Proxy.Name = "groupBox_Proxy";
            this.groupBox_Proxy.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Proxy.Size = new System.Drawing.Size(298, 169);
            this.groupBox_Proxy.TabIndex = 5;
            this.groupBox_Proxy.TabStop = false;
            this.groupBox_Proxy.Text = "Proxy Settings";
            // 
            // button_ProxyApply
            // 
            this.button_ProxyApply.Enabled = false;
            this.button_ProxyApply.Location = new System.Drawing.Point(185, 115);
            this.button_ProxyApply.Margin = new System.Windows.Forms.Padding(4);
            this.button_ProxyApply.Name = "button_ProxyApply";
            this.button_ProxyApply.Size = new System.Drawing.Size(100, 29);
            this.button_ProxyApply.TabIndex = 5;
            this.button_ProxyApply.Text = "Proxy Apply";
            this.button_ProxyApply.UseVisualStyleBackColor = true;
            this.button_ProxyApply.Click += new System.EventHandler(this.button_ProxyApply_Click);
            // 
            // groupBox_Conf_Script
            // 
            this.groupBox_Conf_Script.Controls.Add(this.button_SctiptApply);
            this.groupBox_Conf_Script.Controls.Add(this.label_ScriptAddr);
            this.groupBox_Conf_Script.Controls.Add(this.textBox_Script);
            this.groupBox_Conf_Script.Controls.Add(this.checkBox_ScriptEn);
            this.groupBox_Conf_Script.Location = new System.Drawing.Point(16, 191);
            this.groupBox_Conf_Script.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Conf_Script.Name = "groupBox_Conf_Script";
            this.groupBox_Conf_Script.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Conf_Script.Size = new System.Drawing.Size(298, 158);
            this.groupBox_Conf_Script.TabIndex = 6;
            this.groupBox_Conf_Script.TabStop = false;
            this.groupBox_Conf_Script.Text = "Configuration Script Settings";
            // 
            // button_SctiptApply
            // 
            this.button_SctiptApply.Location = new System.Drawing.Point(185, 108);
            this.button_SctiptApply.Margin = new System.Windows.Forms.Padding(4);
            this.button_SctiptApply.Name = "button_SctiptApply";
            this.button_SctiptApply.Size = new System.Drawing.Size(100, 29);
            this.button_SctiptApply.TabIndex = 6;
            this.button_SctiptApply.Text = "Script Apply";
            this.button_SctiptApply.UseVisualStyleBackColor = true;
            this.button_SctiptApply.Click += new System.EventHandler(this.button_SctiptApply_Click);
            // 
            // label_ScriptAddr
            // 
            this.label_ScriptAddr.AutoSize = true;
            this.label_ScriptAddr.Location = new System.Drawing.Point(31, 50);
            this.label_ScriptAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ScriptAddr.Name = "label_ScriptAddr";
            this.label_ScriptAddr.Size = new System.Drawing.Size(94, 15);
            this.label_ScriptAddr.TabIndex = 6;
            this.label_ScriptAddr.Text = "Script Address:";
            // 
            // textBox_Script
            // 
            this.textBox_Script.Location = new System.Drawing.Point(33, 75);
            this.textBox_Script.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Script.Name = "textBox_Script";
            this.textBox_Script.Size = new System.Drawing.Size(252, 25);
            this.textBox_Script.TabIndex = 5;
            // 
            // checkBox_ScriptEn
            // 
            this.checkBox_ScriptEn.AutoSize = true;
            this.checkBox_ScriptEn.Checked = true;
            this.checkBox_ScriptEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ScriptEn.Location = new System.Drawing.Point(9, 26);
            this.checkBox_ScriptEn.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ScriptEn.Name = "checkBox_ScriptEn";
            this.checkBox_ScriptEn.Size = new System.Drawing.Size(178, 19);
            this.checkBox_ScriptEn.TabIndex = 1;
            this.checkBox_ScriptEn.Text = "Auto Configuration Script";
            this.checkBox_ScriptEn.UseVisualStyleBackColor = true;
            this.checkBox_ScriptEn.CheckedChanged += new System.EventHandler(this.checkBox_ScriptEn_CheckedChanged);
            // 
            // timer_monitor
            // 
            this.timer_monitor.Interval = 1000;
            this.timer_monitor.Tick += new System.EventHandler(this.timer_monitor_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Good Job!!";
            this.notifyIcon1.BalloonTipTitle = "IE LAN Controller";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "IE LAN Conctroller";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // button_monitor
            // 
            this.button_monitor.Location = new System.Drawing.Point(322, 26);
            this.button_monitor.Margin = new System.Windows.Forms.Padding(4);
            this.button_monitor.Name = "button_monitor";
            this.button_monitor.Size = new System.Drawing.Size(130, 46);
            this.button_monitor.TabIndex = 7;
            this.button_monitor.Text = "Open Monitor";
            this.button_monitor.UseVisualStyleBackColor = true;
            this.button_monitor.Click += new System.EventHandler(this.button_monitor_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(322, 84);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(130, 46);
            this.button_reset.TabIndex = 8;
            this.button_reset.Text = "RESET Settings";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(12, 353);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(159, 15);
            this.label_Info.TabIndex = 9;
            this.label_Info.Text = "Release Version: 0.2.1.824";
            // 
            // checkBox_Startup
            // 
            this.checkBox_Startup.AutoSize = true;
            this.checkBox_Startup.Location = new System.Drawing.Point(322, 140);
            this.checkBox_Startup.Name = "checkBox_Startup";
            this.checkBox_Startup.Size = new System.Drawing.Size(141, 34);
            this.checkBox_Startup.TabIndex = 10;
            this.checkBox_Startup.Text = "Auto Launch when \r\nStart Windows";
            this.checkBox_Startup.UseVisualStyleBackColor = true;
            this.checkBox_Startup.CheckedChanged += new System.EventHandler(this.checkBox_Startup_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 372);
            this.Controls.Add(this.checkBox_Startup);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_monitor);
            this.Controls.Add(this.groupBox_Conf_Script);
            this.Controls.Add(this.groupBox_Proxy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IE LAN Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox_Proxy.ResumeLayout(false);
            this.groupBox_Proxy.PerformLayout();
            this.groupBox_Conf_Script.ResumeLayout(false);
            this.groupBox_Conf_Script.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ProxyEn;
        private System.Windows.Forms.TextBox textBox_ProxyAddr;
        private System.Windows.Forms.Label label_ProxyAddr;
        private System.Windows.Forms.Label label_ProxyPort;
        private System.Windows.Forms.TextBox textBox_ProxyPort;
        private System.Windows.Forms.GroupBox groupBox_Proxy;
        private System.Windows.Forms.GroupBox groupBox_Conf_Script;
        private System.Windows.Forms.Label label_ScriptAddr;
        private System.Windows.Forms.TextBox textBox_Script;
        private System.Windows.Forms.CheckBox checkBox_ScriptEn;
        private System.Windows.Forms.Timer timer_monitor;
        private System.Windows.Forms.Button button_ProxyApply;
        private System.Windows.Forms.Button button_SctiptApply;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button_monitor;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.CheckBox checkBox_Startup;
    }
}

