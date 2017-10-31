using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPManager
{
    public partial class frmConnectionParams : Form
    {
        private void _setConfig(cfgRemoteServer Config)
        {
            int i;
            // init screen controls
            InitControls();
            // set screen controls by config
            tbConnectionName.Text = Config.ConnectionName;
            tbServer.Text = Config.ServerName;
            tbPort.Text = (Config.ServerPort != 0 && Config.ServerPort != 3389) ? Config.ServerPort.ToString(): "";
            tbUserName.Text = Config.UserName;
            tbPassword.Text = Config.Password;
            tbDomain.Text = Config.Domain;
            if (Config.FullScreen)
            {
                Config.DisplayWidth = Config.DisplayHeight = -1;
            }
            for (i = 0; i < cfgRemoteServer.ScreenResolutions.Count();i++)
            {
                ScreenResolution val = cbxScreenResolution.Items[i] as ScreenResolution;
                if (val.Height == Config.DisplayHeight && val.Width == Config.DisplayWidth)
                {
                    cbxScreenResolution.SelectedIndex = i;
                    break;
                }
            }
            if (i == cfgRemoteServer.ScreenResolutions.Count())
            {
                cbxScreenResolution.SelectedIndex = 0;
                tbCustomDisplayHeight.Text = Config.DisplayHeight.ToString();
                tbCustomDisplayWidth.Text = Config.DisplayWidth.ToString();
            }
            cbxFitToWindow.Checked = Config.FitToWindow;
            for (i = 0; i < cfgRemoteServer.ColorDepths.Count(); i++)
            {
                ColorDepth val = cbxColorDepth.Items[i] as ColorDepth;
                if (val.bpp == Config.ColorDepth)
                {
                    cbxColorDepth.SelectedIndex = i;
                    break;
                }
            }
            cbPrinters.Checked = Config.RedirectPrinters;
            cbClipboard.Checked = Config.RedirectClipboard;
            cbDrives.Checked = Config.RedirectDrives;
            cbPorts.Checked = Config.RedirectPorts;
            cbDevices.Checked = Config.RedirectDevices;
            cbSmartCards.Checked = Config.RedirectSmartCards;
            for (i = 0; i < cfgRemoteServer.AudioPlaybackModes.Count(); i++)
            {
                AudioPlaybackMode val = cbxAudioPlayback.Items[i] as AudioPlaybackMode;
                if (val.Mode == Config.AudioRedirectionMode)
                {
                    cbxAudioPlayback.SelectedIndex = i;
                    break;
                }
            }
            for (i = 0; i < cfgRemoteServer.AudioRecordingModes.Count(); i++)
            {
                AudioPlaybackMode val = cbxAudioRecording.Items[i] as AudioPlaybackMode;
                if (val.Mode == Config.AudioAudioCaptureRedirectionMode)
                {
                    cbxAudioRecording.SelectedIndex = i;
                    break;
                }
            }

        }
        private cfgRemoteServer _getConfig()
        {
            cfgRemoteServer xCfg = new cfgRemoteServer();
            // load config from form
            xCfg.ConnectionName = tbConnectionName.Text;
            xCfg.ServerName = tbServer.Text;
            if (String.IsNullOrEmpty(tbPort.Text))
                xCfg.ServerPort = 3389;
            else
                xCfg.ServerPort = Convert.ToInt32(tbPort.Text);
            xCfg.UserName = tbUserName.Text;
            xCfg.Password = tbPassword.Text;
            xCfg.Domain =  tbDomain.Text;
            if (cbxScreenResolution.SelectedIndex == 0)
            {
                xCfg.DisplayHeight = Convert.ToInt32(tbCustomDisplayHeight.Text);
                xCfg.DisplayWidth = Convert.ToInt32(tbCustomDisplayWidth.Text);
            }
            else
            {
                xCfg.DisplayHeight = (cbxScreenResolution.SelectedItem as ScreenResolution).Height;
                xCfg.DisplayWidth = (cbxScreenResolution.SelectedItem as ScreenResolution).Width;
            }
            xCfg.FullScreen = (cbxScreenResolution.SelectedIndex + 1 == cbxScreenResolution.Items.Count);
            xCfg.FitToWindow = cbxFitToWindow.Checked;
            xCfg.ColorDepth = (cbxColorDepth.SelectedItem as ColorDepth).bpp;
            return xCfg;
        }
        public frmConnectionParams()
        {
            InitializeComponent();
        }
        protected void InitControls()
        {
            // load screen resolutions
            cbxScreenResolution.Items.Clear();
            foreach(ScreenResolution val in cfgRemoteServer.ScreenResolutions)
            {
                cbxScreenResolution.Items.Add(val);
            }
            // load color depth
            cbxColorDepth.Items.Clear();
            foreach(ColorDepth val in cfgRemoteServer.ColorDepths)
            {
                cbxColorDepth.Items.Add(val);
            }
            // load audio playback modes
            cbxAudioPlayback.Items.Clear();
            foreach (AudioPlaybackMode val in cfgRemoteServer.AudioPlaybackModes)
            {
                cbxAudioPlayback.Items.Add(val);
            }
            cbxAudioRecording.Items.Clear();
            foreach (AudioPlaybackMode val in cfgRemoteServer.AudioRecordingModes)
            {
                cbxAudioRecording.Items.Add(val);
            }
        }
        public cfgRemoteServer Config
        {
            get { return _getConfig(); }
            set { _setConfig(value); }
        }

        private void cbxScreenResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCustomDisplayHeight.Enabled = cbxScreenResolution.SelectedIndex == 0;
            tbCustomDisplayWidth.Enabled = cbxScreenResolution.SelectedIndex == 0;
        }
        private bool CheckConfig()
        {
            if (String.IsNullOrWhiteSpace(tbConnectionName.Text))
            {
                MessageBox.Show("Connection name must be declared");
                tbConnectionName.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbServer.Text))
            {
                MessageBox.Show("Server name must be declared");
                tbServer.Focus();
                return false;
            }
            if (cbxScreenResolution.SelectedIndex == 0 
                && (String.IsNullOrWhiteSpace(tbCustomDisplayHeight.Text) 
                    || String.IsNullOrWhiteSpace(tbCustomDisplayWidth.Text)))
            {
                MessageBox.Show("Custom screen resolution must be declared");
                tbCustomDisplayHeight.Focus();
                return false;
            }

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CheckConfig();
        }

        // for ports and custom screen resolution allow only digits
        private void checkDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
