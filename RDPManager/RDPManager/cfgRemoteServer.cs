using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDPManager
{
    public class cfgRemoteServer
    {
        public string ConnectionName { get; set; }
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int DisplayWidth { get; set; }
        public int DispalyHeight { get; set; }
        public bool FullScreen { get; set; }
        public bool FitToWindow { get; set; }
        public int ColorDepth { get; set; }
        public cfgRemoteServer()
        {
            // starting init
            ConnectionName = "test";
            ServerName = "lexx13.ddns.info";
            UserName = "Lexx";
            Password = "39782000";
            //DisplayWidth = 1366;
            //DispalyHeight = 768;
            DisplayWidth = 1920;
            DispalyHeight = 1080;
            FullScreen = false;
            FitToWindow = true;
            ColorDepth = 24;
        }
    }
}
