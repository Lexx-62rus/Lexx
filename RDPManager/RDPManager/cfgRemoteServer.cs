using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RDPManager
{
    // config form helpers
    public class ScreenResolution
    {
        public int index;
        public string Name;
        public int Width;
        public int Height;
        public override string ToString()
        {
            return Name;
        }
    }

    public class ColorDepth
    {
        public int index;
        public string Name;
        public int bpp;
        public override string ToString()
        {
            return Name;
        }
    }

    public class AudioPlaybackMode
    {
        public int Mode;
        public string Name;
        public override string ToString()
        {
            return Name;
        }
    }

    public class cfgRemoteServer
    {
        public static ScreenResolution[] ScreenResolutions =
            new ScreenResolution[]
            {
                new ScreenResolution() { index = 0, Name= "Custom", Width = 0, Height = 0 },
                new ScreenResolution() { index = 0, Name= "640x480", Width = 640, Height = 480 },
                new ScreenResolution() { index = 1, Name= "800x600", Width = 800, Height = 600 },
                new ScreenResolution() { index = 2, Name= "1024x768", Width = 1024, Height = 768 },
                new ScreenResolution() { index = 3, Name= "1280x720", Width = 1280, Height = 720 },
                new ScreenResolution() { index = 4, Name= "1280x768", Width = 1280, Height = 768 },
                new ScreenResolution() { index = 5, Name= "1280x800", Width = 1280, Height = 800 },
                new ScreenResolution() { index = 6, Name= "1280x1024", Width = 1280, Height = 1024 },
                new ScreenResolution() { index = 7, Name= "1366x768", Width = 1366, Height = 768 },
                new ScreenResolution() { index = 8, Name= "1440x900", Width = 1440, Height = 900 },
                new ScreenResolution() { index = 9, Name= "1400x1050", Width = 1400, Height = 1050 },
                new ScreenResolution() { index = 10, Name= "1680x1050", Width = 1680, Height = 1050 },
                new ScreenResolution() { index = 11, Name= "1920x1080", Width = 1920, Height = 1080 },
                new ScreenResolution() { index = 12, Name= "Full screen", Width = -1, Height = -1 }
            };
        public static ColorDepth[] ColorDepths =
            new ColorDepth[]
            {
                new ColorDepth() {index = 0, Name = "8 bpp (256 color)", bpp = 8 },
                new ColorDepth() {index = 1, Name = "15 bpp (high color)", bpp = 15 },
                new ColorDepth() {index = 2, Name = "16 bpp (high color)", bpp = 16 },
                new ColorDepth() {index = 3, Name = "24 bpp (true color)", bpp = 24 },
                new ColorDepth() {index = 4, Name = "32 bpp (higest quality)", bpp = 32 }
            };
        public static AudioPlaybackMode[] AudioPlaybackModes =
            new AudioPlaybackMode[]
            {
                new AudioPlaybackMode() { Mode = 0, Name = "Play local" },
                new AudioPlaybackMode() { Mode = 1, Name = "Play remote" },
                new AudioPlaybackMode() { Mode = 2, Name = "Disable" }
            };
        public static AudioPlaybackMode[] AudioRecordingModes =
            new AudioPlaybackMode[]
            {
                new AudioPlaybackMode() { Mode = 0, Name = "Disable" },
                new AudioPlaybackMode() { Mode = 1, Name = "Record local" }
            };
        public string ConnectionName { get; set; }
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public int DisplayWidth { get; set; } = 1000;
        public int DisplayHeight { get; set; } = 800;
        public bool FullScreen { get; set; }
        public bool FitToWindow { get; set; }
        public int ColorDepth { get; set; } = 32;
        public int ServerPort { get; set; } = 0;
        public bool RedirectPrinters { get; set; }
        public bool RedirectClipboard { get; set; } = true;
        public bool RedirectDrives { get; set; } = true;
        public bool RedirectPorts { get; set; }
        public bool RedirectDevices { get; set; }
        public bool RedirectSmartCards { get; set; }
        public int AudioRedirectionMode { get; set; }
        public int AudioAudioCaptureRedirectionMode { get; set; }
        public cfgRemoteServer()
        {
            // starting init
            ConnectionName = "test";
            ServerName = "";
            UserName = "";
            Password = "";
        }
    }
}
