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
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnFitToWindow = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientControl)).BeginInit();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientControl
            // 
            this.ClientControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientControl.Enabled = true;
            this.ClientControl.Location = new System.Drawing.Point(0, 25);
            this.ClientControl.Name = "ClientControl";
            this.ClientControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ClientControl.OcxState")));
            this.ClientControl.Size = new System.Drawing.Size(784, 536);
            this.ClientControl.TabIndex = 0;
            this.ClientControl.OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.ClientControl_OnDisconnected);
            this.ClientControl.OnRequestGoFullScreen += new System.EventHandler(this.ClientControl_OnRequestGoFullScreen);
            this.ClientControl.OnRequestLeaveFullScreen += new System.EventHandler(this.ClientControl_OnRequestLeaveFullScreen);
            this.ClientControl.OnRequestContainerMinimize += new System.EventHandler(this.ClientControl_OnRequestContainerMinimize);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFitToWindow});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(784, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnFitToWindow
            // 
            this.btnFitToWindow.CheckOnClick = true;
            this.btnFitToWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitToWindow.Image = global::RDPManager.Properties.Resources.full_screen_21;
            this.btnFitToWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitToWindow.Name = "btnFitToWindow";
            this.btnFitToWindow.Size = new System.Drawing.Size(23, 22);
            this.btnFitToWindow.Text = "toolStripButton1";
            this.btnFitToWindow.ToolTipText = "Fit to window";
            this.btnFitToWindow.Click += new System.EventHandler(this.btnFitToWindow_Click);
            // 
            // frmRDPWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ClientControl);
            this.Controls.Add(this.tsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRDPWindow";
            this.Text = "frmRDPWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRDPWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ClientControl)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting ClientControl;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btnFitToWindow;
    }
}