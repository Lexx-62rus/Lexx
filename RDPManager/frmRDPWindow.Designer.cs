namespace RDPManager
{
    partial class frmRDPWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRDPWindow));
            this.ClientControl = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.ClientControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientControl
            // 
            this.ClientControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientControl.Enabled = true;
            this.ClientControl.Location = new System.Drawing.Point(0, 0);
            this.ClientControl.Name = "ClientControl";
            this.ClientControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ClientControl.OcxState")));
            this.ClientControl.Size = new System.Drawing.Size(784, 561);
            this.ClientControl.TabIndex = 0;
            this.ClientControl.OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.ClientControl_OnDisconnected);
            this.ClientControl.OnEnterFullScreenMode += new System.EventHandler(this.ClientControl_OnEnterFullScreenMode);
            this.ClientControl.OnLeaveFullScreenMode += new System.EventHandler(this.ClientControl_OnLeaveFullScreenMode);
            this.ClientControl.OnRequestGoFullScreen += new System.EventHandler(this.ClientControl_OnRequestGoFullScreen);
            this.ClientControl.OnRequestLeaveFullScreen += new System.EventHandler(this.ClientControl_OnRequestLeaveFullScreen);
            // 
            // frmRDPWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ClientControl);
            this.Name = "frmRDPWindow";
            this.Text = "frmRDPWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRDPWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ClientControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting ClientControl;
    }
}