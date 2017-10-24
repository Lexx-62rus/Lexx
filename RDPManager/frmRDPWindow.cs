using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPManager
{    
    public partial class frmRDPWindow : Form
    {
        // connection config
        private cfgRemoteServer _connectionParams;

        // border params
        private const int WMSZ_BOTTOM = 6;
        private const int WMSZ_TOP = 3;
        private const int WMSZ_LEFT = 1;
        private const int WMSZ_RIGHT = 2;

        // correction for properly setup client window size
        private int _addHeight;
        private int _addWidth;
        private int _add_HeightInn;
        private int _add_WidthInn;
        private double _aspectRatio;

        // old display configuration
        private Rectangle _bounds;

        private void SetClientWindowSize(int width, int height)
        {
            // calculate aspect ratio
            _aspectRatio = 1.0 * width / height;
            ClientSize = new Size(width + _addWidth, height + _addHeight);
            _add_WidthInn = Width - width;
            _add_HeightInn = Height - height;
        }

        public void ConnectToServer(cfgRemoteServer Config)
        {
            MsRdpClient8NotSafeForScripting rdp;
            rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
            rdp.Server = Config.ServerName;
            rdp.UserName = Config.UserName;            
            rdp.AdvancedSettings8.ClearTextPassword = Config.Password;
            rdp.AdvancedSettings8.AuthenticationLevel = 2;
            rdp.AdvancedSettings8.EnableCredSspSupport = true;
            rdp.AdvancedSettings8.NegotiateSecurityLayer = false;
            rdp.AdvancedSettings8.SmartSizing = true;
            rdp.AdvancedSettings8.ContainerHandledFullScreen = -1;
            rdp.AdvancedSettings8.RelativeMouseMode
            //rdp.AdvancedSettings8.RedirectDrives = true;            
            rdp.DesktopHeight = Config.DispalyHeight;
            rdp.DesktopWidth = Config.DisplayWidth;
            SetClientWindowSize(Config.DisplayWidth, Config.DispalyHeight);
            rdp.ColorDepth = Config.ColorDepth;
            ClientControl.Connect();            
        }

        public frmRDPWindow()
        {
            InitializeComponent();            
            // initialize correction coefficients
            _addHeight = ClientSize.Height - ClientControl.Height;
            _addWidth = ClientSize.Width - ClientControl.Width;            
        }
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x216 || m.Msg == 0x214)
            { // WM_MOVING || WM_SIZING
              // Keep the window square
                RECT rc = (RECT)Marshal.PtrToStructure(m.LParam, typeof(RECT));
                int w = rc.Right - rc.Left - _add_WidthInn;
                int h = rc.Bottom - rc.Top - _add_HeightInn;
                int edge = (int)m.WParam;
                // calculate window size for constraint aspect ratio
                // check sizing direction
                if (edge == 6 || edge == 3) // change height
                {
                    w = Convert.ToInt32(h * _aspectRatio);
                }
                else
                if (edge == 1 || edge == 2) // change width
                {
                    h = Convert.ToInt32(w / _aspectRatio);
                }
                else // change width and height, calculate max size changes
                {
                    if (Math.Abs(w - Width) < Math.Abs(h - Height))
                    {
                        h = Convert.ToInt32(w / _aspectRatio);
                    }
                    else
                        w = Convert.ToInt32(h * _aspectRatio);
                }
                switch (edge)
                {
                    case WMSZ_LEFT:
                    case WMSZ_RIGHT:
                        rc.Bottom = rc.Top + h + _add_HeightInn;
                        break;
                    case WMSZ_TOP:
                    case WMSZ_BOTTOM:
                        rc.Right = rc.Left + w + _add_WidthInn;
                        break;
                    case WMSZ_LEFT + WMSZ_TOP:
                        rc.Top = rc.Bottom - h - _add_HeightInn; ;
                        rc.Left = rc.Right - w - _add_WidthInn;
                        break;
                    case WMSZ_LEFT + WMSZ_BOTTOM:
                        rc.Bottom = rc.Top + h + _add_HeightInn; ;
                        rc.Left = rc.Right - w - _add_WidthInn;
                        break;
                    case WMSZ_RIGHT + WMSZ_TOP:
                        rc.Top = rc.Bottom - h - _add_HeightInn; ;
                        rc.Right = rc.Left + w + _add_WidthInn;
                        break;
                    case WMSZ_RIGHT + WMSZ_BOTTOM:
                        rc.Bottom = rc.Top + h + _add_HeightInn; ;
                        rc.Right = rc.Left + w + _add_WidthInn;
                        break;
                }
                Marshal.StructureToPtr(rc, m.LParam, false);
                m.Result = (IntPtr)1;
                return;
            }
            base.WndProc(ref m);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private void ClientControl_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            Close();
        }

        private void ClientControl_OnEnterFullScreenMode(object sender, EventArgs e)
        {
            MsRdpClient8NotSafeForScripting rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
            rdp.AdvancedSettings8.SmartSizing = false;
            //Hide();
        }
        private void ClientControl_OnLeaveFullScreenMode(object sender, EventArgs e)
        {
            MsRdpClient8NotSafeForScripting rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
            rdp.AdvancedSettings8.SmartSizing = true;
        }

        private void ClientControl_OnRequestGoFullScreen(object sender, EventArgs e)
        {
            MsRdpClient8NotSafeForScripting rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
            rdp.AdvancedSettings8.SmartSizing = false;            
            _bounds = Bounds;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.FromControl(this).Bounds;
            rdp.FullScreen = true;            
        }

        private void ClientControl_OnRequestLeaveFullScreen(object sender, EventArgs e)
        {
            MsRdpClient8NotSafeForScripting rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
            rdp.AdvancedSettings8.SmartSizing = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            Bounds = _bounds;
            rdp.FullScreen = false;
        }

        private void frmRDPWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ClientControl.Connected > 0)
                ClientControl.Disconnect();
        }
    }
}
