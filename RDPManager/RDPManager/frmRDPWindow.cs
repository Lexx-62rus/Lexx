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
        // border params
        private const int WMSZ_BOTTOM = 6;
        private const int WMSZ_TOP = 3;
        private const int WMSZ_LEFT = 1;
        private const int WMSZ_RIGHT = 2;

        // correction for properly setup client window size
        private int _addHeight;
        private int _addWidth;
        private double _aspectRatio;

        // internal flags
        private bool _FullScreen;

        private bool _isInitialization = false;

        // old display configuration
        private Rectangle _NormalWindowBounds;

        // connection configuration
        private cfgRemoteServer _connectionConfig;

        private bool _ShowControls;
        public bool ShowControls {
            get
            {
                return _ShowControls;
            }
            set
            {
                _ShowControls = value;
                tsMain.Visible = _ShowControls;
            }
        }        
        public bool FitToWindow {
            get
            {
                return btnFitToWindow.Checked;
            }
            set
            {
                if (btnFitToWindow.Checked != value)
                    btnFitToWindow.Checked = value;
                MsRdpClient8NotSafeForScripting rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
                if (rdp.AdvancedSettings8.SmartSizing != btnFitToWindow.Checked)
                {
                    rdp.AdvancedSettings8.SmartSizing = btnFitToWindow.Checked;
                }
            }
        }
        public bool FullScreen
        {
            get
            {
                return _FullScreen;
            }
            set
            {
                _isInitialization = true; 
                if (btnFullScreen.Checked != value)
                {
                    btnFullScreen.Checked = value;
                }
                //if (value != _FullScreen)
                //{
                    _FullScreen = value;
                    MsRdpClient8NotSafeForScripting rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
                    if (value)
                    {
                        // set window size for full screen
                        rdp.AdvancedSettings8.SmartSizing = false;
                        if (WindowState == FormWindowState.Normal)
                            _NormalWindowBounds = Bounds;
                        FormBorderStyle = FormBorderStyle.None;
                        ShowControls = false;
                        Bounds = Screen.FromControl(this).Bounds;
                    }
                    else
                    {
                        // restore original window size
                        rdp.AdvancedSettings8.SmartSizing = true;
                        FormBorderStyle = FormBorderStyle.Sizable;
                        ShowControls = true;
                        Bounds = _NormalWindowBounds;
                        rdp.AdvancedSettings8.SmartSizing = FitToWindow;
                    }
                    rdp.FullScreen = _FullScreen;
                ClientControl.Refresh();
                //}
                _isInitialization = false;
            }
        }

        private void SetClientWindowSize(int width, int height)
        {
            // calculate aspect ratio
            _aspectRatio = 1.0 * width / height;
            // calculate new window size
            Size size = new Size(width + _addWidth, height + _addHeight); 
            // check display bounds
            if (size.Width > (Screen.FromControl(this).Bounds.Width + 12))
            {
                // the width is greater maximum window width
                // recalc new size using aspect ratio
                size.Width = Screen.FromControl(this).Bounds.Width + 12;
                size.Height = Convert.ToInt32((size.Width - _addWidth) / _aspectRatio) + _addHeight;
            }
            if (size.Height > (Bounds.Height + 12))
            {
                // the width is greater maximum window width
                // recalc new size using aspect ratio
                size.Height = Screen.FromControl(this).Bounds.Height + 12;
                size.Width = Convert.ToInt32((size.Height - _addHeight) * _aspectRatio) + _addWidth;
            }
            Size = size;
        }

        public void ConnectToServer(cfgRemoteServer Config)
        {
            _connectionConfig = Config;            
            doConnect();            
            FitToWindow = Config.FitToWindow;
            //FullScreen = Config.FullScreen;
        }

        protected void doConnect()
        {
            MsRdpClient8NotSafeForScripting rdp;
            rdp = (MsRdpClient8NotSafeForScripting)ClientControl.GetOcx();
            rdp.Server = _connectionConfig.ServerName;
            rdp.UserName = _connectionConfig.UserName;
            rdp.AdvancedSettings8.ClearTextPassword = _connectionConfig.Password;
            rdp.AdvancedSettings8.AuthenticationLevel = 2;
            rdp.AdvancedSettings8.EnableCredSspSupport = true;
            rdp.AdvancedSettings8.NegotiateSecurityLayer = false;
            //rdp.AdvancedSettings8.SmartSizing = FitToWindow;            
            rdp.AdvancedSettings8.ContainerHandledFullScreen = -1;
            //rdp.AdvancedSettings8.AudioCaptureRedirectionMode
            //rdp.AdvancedSettings8.
            //rdp.AdvancedSettings8.RelativeMouseMode
            //rdp.AdvancedSettings8.RedirectDrives = true;    
            FullScreen = _connectionConfig.FullScreen;
            //rdp.FullScreen = _connectionConfig.FullScreen;
            rdp.DesktopHeight = _connectionConfig.DisplayHeight;
            rdp.DesktopWidth = _connectionConfig.DisplayWidth;
            SetClientWindowSize(_connectionConfig.DisplayWidth, _connectionConfig.DisplayHeight);
            rdp.ColorDepth = _connectionConfig.ColorDepth;
            ClientControl.Connect();
        }

        public frmRDPWindow()
        {
            InitializeComponent();
            _addHeight = Height - ClientControl.Height;
            _addWidth = Width - ClientControl.Width;                                    
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x216 || m.Msg == 0x214)
            { // WM_MOVING || WM_SIZING
              // Keep the window aspect ratio
                RECT rc = (RECT)Marshal.PtrToStructure(m.LParam, typeof(RECT));
                int w = rc.Right - rc.Left - _addWidth;
                int h = rc.Bottom - rc.Top - _addHeight;
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
                        rc.Bottom = rc.Top + h + _addHeight;
                        break;
                    case WMSZ_TOP:
                    case WMSZ_BOTTOM:
                        rc.Right = rc.Left + w + _addWidth;
                        break;
                    case WMSZ_LEFT + WMSZ_TOP:
                        rc.Top = rc.Bottom - h - _addHeight;
                        rc.Left = rc.Right - w - _addWidth;
                        break;
                    case WMSZ_LEFT + WMSZ_BOTTOM:
                        rc.Bottom = rc.Top + h + _addHeight;
                        rc.Left = rc.Right - w - _addWidth;
                        break;
                    case WMSZ_RIGHT + WMSZ_TOP:
                        rc.Top = rc.Bottom - h - _addHeight;
                        rc.Right = rc.Left + w + _addWidth;
                        break;
                    case WMSZ_RIGHT + WMSZ_BOTTOM:
                        rc.Bottom = rc.Top + h + _addHeight;
                        rc.Right = rc.Left + w + _addWidth;
                        break;
                }
                Marshal.StructureToPtr(rc, m.LParam, false);
                m.Result = (IntPtr)1;
                return;
            }
            if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
                // Check window state
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    FullScreen = true;
                    m.Result = (IntPtr)1;
                    return;
                }
                if (m.WParam == new IntPtr(0xF120)) // Restore event - SC_RESTORE from Winuser.h
                {
                    if (WindowState == FormWindowState.Minimized)
                    {
                        if (FullScreen)
                            WindowState = FormWindowState.Maximized;
                        else
                        {
                            WindowState = FormWindowState.Normal;
                        }
                    }
                    m.Result = (IntPtr)1;
                    return;
                }
            }
            if (m.Msg == 0x00A3) // WM_NCLBUTTONDBLCLK - double click on a title bar 
            {                
                FullScreen = true;
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

        private void ClientControl_OnRequestGoFullScreen(object sender, EventArgs e)
        {
            if (!_isInitialization)
                FullScreen = true;           
        }

        private void ClientControl_OnRequestLeaveFullScreen(object sender, EventArgs e)
        {
            if (!_isInitialization)
                FullScreen = false;
        }
        private void ClientControl_OnRequestContainerMinimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmRDPWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ClientControl.Connected > 0)
                ClientControl.Disconnect();
        }

        private void btnFitToWindow_Click(object sender, EventArgs e)
        {
            FitToWindow = btnFitToWindow.Checked;
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            FullScreen = btnFullScreen.Checked;
        }
    }
}
