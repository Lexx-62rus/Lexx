﻿using AxMSTSCLib;
using MSTSCLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RDPManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            frmRDPWindow xWnd = new frmRDPWindow();
            cfgRemoteServer xSrv = new cfgRemoteServer();
            xWnd.ConnectToServer(xSrv);
            xWnd.Show()
            */
            //xWnd.FullScreen = xSrv.FullScreen;                      
            frmConnectionParams xWnd = new frmConnectionParams();
            xWnd.Config = new cfgRemoteServer();
            xWnd.Show();
            /*ClientControl.Server = Config.ServerName;
            ClientControl.UserName = Config.UserName;
            IMsTscNonScriptable rdp = (IMsTscNonScriptable)ClientControl.GetOcx();
            rdp.ClearTextPassword = Config.Password;
            
            ClientControl.Connect();*/

            //MsRdpClient8NotSafeForScripting rdp = new MsRdpClient8NotSafeForScripting();
            /*
            AxMsRdpClient8 rdp = new AxMsRdpClient8();
            ((ISupportInitialize)rdp).BeginInit();
            Controls.Add(rdp);
            ((ISupportInitialize)rdp).EndInit();
            //rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
            cfgRemoteServer Config = new cfgRemoteServer();
            rdp.Server = Config.ServerName;
            rdp.UserName = Config.UserName;
            rdp.AdvancedSettings8.ClearTextPassword = Config.Password;
            rdp.AdvancedSettings8.AuthenticationLevel = 2;
            rdp.AdvancedSettings8.EnableCredSspSupport = true;
            rdp.AdvancedSettings8.NegotiateSecurityLayer = false;
            rdp.AdvancedSettings8.SmartSizing = true;
            rdp.DesktopHeight = Config.DispalyHeight;
            rdp.DesktopWidth = Config.DisplayWidth;
            //SetClientWindowSize(Config.DisplayWidth, Config.DispalyHeight);
            rdp.ColorDepth = Config.ColorDepth;
            rdp.FullScreen = true;
            rdp.Connect();*/
        }
    }
}
