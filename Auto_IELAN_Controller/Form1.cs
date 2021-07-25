using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;

namespace Auto_IELAN_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string DefaultProxyAddr = "pxy102.liteon.com";
        public string DefaultProxyPort = "3128";
        public string DefaultScriptAddr = "http://pac.liteon.com/pac/proxy.pac";

        public object ConfScript;

        public RegistryKey RegKey = Registry.CurrentUser;
        public string SubKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
        public RegistryKey optionKey;

        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "InternetSetOption",
            CallingConvention = CallingConvention.StdCall)]

        public static extern bool InternetSetOption(
            int hInternet,
            int dmOption,
            IntPtr lpBuffer,
            int dwBufferLength
        );   

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load IE LAN Settings
            optionKey = RegKey.OpenSubKey(SubKeyPath, true);
            object proxy = null;

            //Check LAN Proxy Settings
            if (optionKey.GetValue("ProxyEnable") == null)
            {
                MessageBox.Show("Cannot Find Proxy Enable Infomation!!");
                //return;
            }

            try
            {
                proxy = optionKey.GetValue("ProxyServer");
            }
            catch
            {
                if (proxy == null)
                {
                    MessageBox.Show("Cannot Read Proxy Server Infomation!!");
                    return;
                }
            }

            string strProxy;
            string[] proxyList;

            if (proxy != null)
            {
               strProxy = proxy.ToString();
                proxyList = strProxy.Split(':');
                textBox_ProxyAddr.Text = proxyList[0];
                textBox_ProxyPort.Text = proxyList[1];
            }


            //Configuration Script Settings
            ConfScript = optionKey.GetValue("AutoConfigURL");
            int ProxyEn = (int)optionKey.GetValue("ProxyEnable");
            if (ConfScript != null)
            {
                textBox_Script.Text = ConfScript.ToString();
                textBox_Script.Enabled = true;
                checkBox_ScriptEn.Checked = true;
            }
            else
            {
                textBox_Script.Enabled = false;
                checkBox_ScriptEn.Checked = false;
            }


            if (checkBox_ProxyEn.Checked)
            {
                textBox_ProxyAddr.Enabled = true;
                textBox_ProxyPort.Enabled = true;
            }
            else
            {
                textBox_ProxyAddr.Enabled = false;
                textBox_ProxyPort.Enabled = false;
            }

            if (ProxyEn > 0)
                checkBox_ProxyEn.Checked = true;
            else
                checkBox_ProxyEn.Checked = false;

            //Auto Startup State
            string R_startPath = Application.ExecutablePath + " -S";

            optionKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            if (optionKey.GetValue("AutoLAN") != null)
            {
                checkBox_Startup.Checked = true;
            }


            optionKey.Flush();
            optionKey.Close();
            optionKey.Dispose();
            GC.Collect();
        }

        private void checkBox_ProxyEn_CheckedChanged(object sender, EventArgs e)
        {
            optionKey = RegKey.OpenSubKey(SubKeyPath, true);

            if (optionKey.GetValue("ProxyEnable") == null)
            {
                MessageBox.Show("Cannot Find Proxy Enable Infomation!!");
                return;
            }

            bool ProxyEn = checkBox_ProxyEn.Checked;

            if(ProxyEn)
            {
                optionKey.SetValue("ProxyEnable", 1);
                textBox_ProxyAddr.Enabled = true;
                textBox_ProxyPort.Enabled = true;
                optionKey.SetValue("ProxyServer", textBox_ProxyAddr.Text + ":" + textBox_ProxyPort.Text);
                button_ProxyApply.Enabled = true;
            }
            else
            {
                optionKey.SetValue("ProxyEnable", 0);
                textBox_ProxyAddr.Enabled = false;
                textBox_ProxyPort.Enabled = false;
                button_ProxyApply.Enabled = false;
                //optionKey.SetValue("ProxyServer", textBox_ProxyAddr.Text + ":" + textBox_ProxyPort.Text);
            }


            optionKey.Flush();
            optionKey.Close();

            optionKey.Dispose();

            //激活代理设置  
            InternetSetOption(0, 39, IntPtr.Zero, 0);
            InternetSetOption(0, 37, IntPtr.Zero, 0);

            GC.Collect();
        }

        private void checkBox_ScriptEn_CheckedChanged(object sender, EventArgs e)
        {
            optionKey = RegKey.OpenSubKey(SubKeyPath, true);

            bool ScrpitEn = checkBox_ScriptEn.Checked;

            if(ScrpitEn)
            {
                if (ConfScript != null)
                {
                    optionKey.SetValue("AutoConfigURL", ConfScript);
                    textBox_Script.Text = ConfScript.ToString();
                }
                else
                {
                    ConfScript = DefaultScriptAddr;
                    optionKey.SetValue("AutoConfigURL", ConfScript);
                    textBox_Script.Text = ConfScript.ToString();
                }
                textBox_Script.Enabled = true;
                button_SctiptApply.Enabled = true;
            }
            else
            {
                optionKey.DeleteValue("AutoConfigURL", false);
                textBox_Script.Enabled = false;
                button_SctiptApply.Enabled = false;
            }


            optionKey.Flush();
            optionKey.Close();
            optionKey.Dispose();

            //激活代理设置  
            InternetSetOption(0, 39, IntPtr.Zero, 0);
            InternetSetOption(0, 37, IntPtr.Zero, 0);

            GC.Collect();
        }

        private void button_SctiptApply_Click(object sender, EventArgs e)
        {
            optionKey = RegKey.OpenSubKey(SubKeyPath, true);

            //Apply Configuration Address
            if (textBox_Script.Text == null)
            {
                MessageBox.Show("Please Check Script Address!!");
            }

            ConfScript = textBox_Script.Text;
            optionKey.SetValue("AutoConfigURL", ConfScript);
            textBox_Script.Text = ConfScript.ToString();

            optionKey.Flush();
            optionKey.Close();
            optionKey.Dispose();

            InternetSetOption(0, 39, IntPtr.Zero, 0);
            InternetSetOption(0, 37, IntPtr.Zero, 0);

            GC.Collect();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = true;
                this.Hide();
                this.ShowInTaskbar = false;
            }

            GC.Collect();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ShowInTaskbar == false)
                this.ShowInTaskbar = true;
            
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;

            GC.Collect();
        }

        private void button_ProxyApply_Click(object sender, EventArgs e)
        {
            optionKey = RegKey.OpenSubKey(SubKeyPath, true);

            //Apply Configuration Address
            if (textBox_ProxyAddr.Text == null || textBox_ProxyPort.Text == null)
            {
                MessageBox.Show("Please Check Proxy Address & Port!!");
            }

            optionKey.SetValue("ProxyServer", textBox_ProxyAddr.Text + ":" + textBox_ProxyPort.Text);

            optionKey.Flush();
            optionKey.Close();
            optionKey.Dispose();

            InternetSetOption(0, 39, IntPtr.Zero, 0);
            InternetSetOption(0, 37, IntPtr.Zero, 0);

            GC.Collect();
        }

        public bool monitorEn = false;

        private void button_monitor_Click(object sender, EventArgs e)
        {
            monitorEn = !monitorEn;

            timer_monitor.Enabled = monitorEn;

            if(monitorEn)
            {
                button_monitor.Text = "Close Monitor";
                checkBox_ProxyEn.Enabled = false;
                checkBox_ScriptEn.Enabled = false;
                button_reset.Enabled = false;
                textBox_ProxyAddr.Enabled = false;
                textBox_ProxyPort.Enabled = false;
                textBox_Script.Enabled = false;
                button_ProxyApply.Enabled = false;
                button_SctiptApply.Enabled = false;
            }
            else
            {
                button_monitor.Text = "Open Monitor";
                checkBox_ProxyEn.Enabled = true;
                checkBox_ScriptEn.Enabled = true;
                button_reset.Enabled = true;
                if (checkBox_ProxyEn.Checked)
                {
                    textBox_ProxyAddr.Enabled = true;
                    textBox_ProxyPort.Enabled = true;
                    button_ProxyApply.Enabled = true;
                }
                if (checkBox_ScriptEn.Checked)
                {
                    textBox_Script.Enabled = true;
                    button_SctiptApply.Enabled = true;
                }
            }
        }

        private void timer_monitor_Tick(object sender, EventArgs e)
        {
            optionKey = RegKey.OpenSubKey(SubKeyPath, true);

            bool ProxyEn = checkBox_ProxyEn.Checked;
            bool ScrpitEn = checkBox_ScriptEn.Checked;

            if (ProxyEn)
            {
                optionKey.SetValue("ProxyEnable", 1);
                if (!timer_monitor.Enabled)
                {
                    textBox_ProxyAddr.Enabled = true;
                    textBox_ProxyPort.Enabled = true;
                }
                optionKey.SetValue("ProxyServer", textBox_ProxyAddr.Text + ":" + textBox_ProxyPort.Text);
                //button_ProxyApply.Enabled = true;
            }
            else
            {
                optionKey.SetValue("ProxyEnable", 0);
                textBox_ProxyAddr.Enabled = false;
                textBox_ProxyPort.Enabled = false;
                button_ProxyApply.Enabled = false;
                //optionKey.SetValue("ProxyServer", textBox_ProxyAddr.Text + ":" + textBox_ProxyPort.Text);
            }

            if (ScrpitEn)
            {
                if (ConfScript != null)
                {
                    optionKey.SetValue("AutoConfigURL", ConfScript);
                    textBox_Script.Text = ConfScript.ToString();
                }
                if (!timer_monitor.Enabled)
                    textBox_Script.Enabled = true;
                //button_SctiptApply.Enabled = true;
            }
            else
            {
                optionKey.DeleteValue("AutoConfigURL", false);
                textBox_Script.Enabled = false;
                button_SctiptApply.Enabled = false;
            }


            optionKey.Flush();
            optionKey.Close();
            optionKey.Dispose();

            //激活代理设置  
            InternetSetOption(0, 39, IntPtr.Zero, 0);
            InternetSetOption(0, 37, IntPtr.Zero, 0);

            GC.Collect();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            optionKey = RegKey.OpenSubKey(SubKeyPath, true);

            bool ProxyEn = checkBox_ProxyEn.Checked;
            bool ScrpitEn = checkBox_ScriptEn.Checked;

            optionKey.SetValue("ProxyEnable", 1);
            textBox_ProxyAddr.Enabled = true;
            textBox_ProxyPort.Enabled = true;
            textBox_ProxyAddr.Text = DefaultProxyAddr;
            textBox_ProxyPort.Text = DefaultProxyPort;
            optionKey.SetValue("ProxyServer", DefaultProxyAddr + ":" + DefaultProxyPort);
            button_ProxyApply.Enabled = true;
            checkBox_ProxyEn.Checked = true;
            checkBox_ScriptEn.Checked = true;


            textBox_Script.Enabled = true;

            if (ConfScript != null)
            {
                textBox_Script.Text = ConfScript.ToString();
            }
            else
            {
                ConfScript = DefaultScriptAddr;
                textBox_Script.Text = ConfScript.ToString();
            }


            optionKey.Flush();
            optionKey.Close();
            optionKey.Dispose();

            InternetSetOption(0, 39, IntPtr.Zero, 0);
            InternetSetOption(0, 37, IntPtr.Zero, 0);

            GC.Collect();
        }

        private void checkBox_Startup_CheckedChanged(object sender, EventArgs e)
        {
            string app_name = "AutoLAN";
            RegistryKey aimdir;
            try
            {
                if (checkBox_Startup.Checked == true)
                {
                    
                    string R_startPath = Application.ExecutablePath + " -S";
                    
                    aimdir = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                    
                    if (aimdir.GetValue(app_name) != null)
                    {
                        aimdir.DeleteValue(app_name, false);
                    }
                    aimdir.SetValue(app_name, R_startPath);
                    aimdir.Close();
                }
                else
                {
                    aimdir = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                    if (aimdir.GetValue(app_name) != null)
                    {
                        aimdir.DeleteValue(app_name, false);
                    }
                    aimdir.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Write Register Error!:" + ex.Message);
            }
        }
    }
}
