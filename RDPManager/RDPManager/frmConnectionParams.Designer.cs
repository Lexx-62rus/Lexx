namespace RDPManager
{
    partial class frmConnectionParams
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbConnectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCustomDisplayHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCustomDisplayWidth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxColorDepth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxFitToWindow = new System.Windows.Forms.CheckBox();
            this.cbxScreenResolution = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPorts = new System.Windows.Forms.CheckBox();
            this.cbDrives = new System.Windows.Forms.CheckBox();
            this.cbClipboard = new System.Windows.Forms.CheckBox();
            this.cbPrinters = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxAudioPlayback = new System.Windows.Forms.ComboBox();
            this.cbxAudioRecording = new System.Windows.Forms.ComboBox();
            this.cbDevices = new System.Windows.Forms.CheckBox();
            this.cbSmartCards = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpResources.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(339, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(258, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbConnectionName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 34);
            this.panel2.TabIndex = 2;
            // 
            // tbConnectionName
            // 
            this.tbConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnectionName.Location = new System.Drawing.Point(108, 8);
            this.tbConnectionName.Name = "tbConnectionName";
            this.tbConnectionName.Size = new System.Drawing.Size(306, 20);
            this.tbConnectionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection name";
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpGeneral);
            this.tcSettings.Controls.Add(this.tpResources);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(0, 34);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(418, 273);
            this.tcSettings.TabIndex = 3;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(410, 247);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCustomDisplayHeight);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbCustomDisplayWidth);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxColorDepth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxFitToWindow);
            this.groupBox2.Controls.Add(this.cbxScreenResolution);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 106);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display properties";
            // 
            // tbCustomDisplayHeight
            // 
            this.tbCustomDisplayHeight.Location = new System.Drawing.Point(310, 50);
            this.tbCustomDisplayHeight.Name = "tbCustomDisplayHeight";
            this.tbCustomDisplayHeight.Size = new System.Drawing.Size(88, 20);
            this.tbCustomDisplayHeight.TabIndex = 10;
            this.tbCustomDisplayHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDigits);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Height:";
            // 
            // tbCustomDisplayWidth
            // 
            this.tbCustomDisplayWidth.Location = new System.Drawing.Point(155, 50);
            this.tbCustomDisplayWidth.Name = "tbCustomDisplayWidth";
            this.tbCustomDisplayWidth.Size = new System.Drawing.Size(88, 20);
            this.tbCustomDisplayWidth.TabIndex = 9;
            this.tbCustomDisplayWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDigits);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Custom";
            // 
            // cbxColorDepth
            // 
            this.cbxColorDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColorDepth.FormattingEnabled = true;
            this.cbxColorDepth.Items.AddRange(new object[] {
            "8 bpp (256 color)",
            "15 bpp (32768 color)",
            "16 bpp (65536 color)",
            "24 bpp (true color)"});
            this.cbxColorDepth.Location = new System.Drawing.Point(114, 79);
            this.cbxColorDepth.Name = "cbxColorDepth";
            this.cbxColorDepth.Size = new System.Drawing.Size(284, 21);
            this.cbxColorDepth.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Color depth";
            // 
            // cbxFitToWindow
            // 
            this.cbxFitToWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFitToWindow.AutoSize = true;
            this.cbxFitToWindow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxFitToWindow.Location = new System.Drawing.Point(310, 21);
            this.cbxFitToWindow.Name = "cbxFitToWindow";
            this.cbxFitToWindow.Size = new System.Drawing.Size(88, 17);
            this.cbxFitToWindow.TabIndex = 8;
            this.cbxFitToWindow.Text = "Fit to window";
            this.cbxFitToWindow.UseVisualStyleBackColor = true;
            // 
            // cbxScreenResolution
            // 
            this.cbxScreenResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxScreenResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxScreenResolution.FormattingEnabled = true;
            this.cbxScreenResolution.Items.AddRange(new object[] {
            "640x480",
            "800x600",
            "1024x768",
            "1280x720",
            "1280x768",
            "1280x800",
            "1280x1024",
            "1366x768",
            "1440x900",
            "1400x1050",
            "1680x1050",
            "1920x1080",
            "Full screen"});
            this.cbxScreenResolution.Location = new System.Drawing.Point(114, 19);
            this.cbxScreenResolution.Name = "cbxScreenResolution";
            this.cbxScreenResolution.Size = new System.Drawing.Size(190, 21);
            this.cbxScreenResolution.TabIndex = 7;
            this.cbxScreenResolution.SelectedIndexChanged += new System.EventHandler(this.cbxScreenResolution_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Resolution";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbDomain);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection properties";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(345, 19);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(53, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDigits);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Port:";
            // 
            // tbDomain
            // 
            this.tbDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDomain.Location = new System.Drawing.Point(114, 107);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(284, 20);
            this.tbDomain.TabIndex = 6;
            this.tbDomain.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Domain:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(114, 77);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(284, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserName.Location = new System.Drawing.Point(114, 48);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(284, 20);
            this.tbUserName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User name:";
            // 
            // tbServer
            // 
            this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServer.Location = new System.Drawing.Point(114, 19);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(190, 20);
            this.tbServer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Computer:";
            // 
            // tpResources
            // 
            this.tpResources.Controls.Add(this.groupBox4);
            this.tpResources.Controls.Add(this.groupBox3);
            this.tpResources.Location = new System.Drawing.Point(4, 22);
            this.tpResources.Name = "tpResources";
            this.tpResources.Padding = new System.Windows.Forms.Padding(3);
            this.tpResources.Size = new System.Drawing.Size(410, 247);
            this.tpResources.TabIndex = 1;
            this.tpResources.Text = "Advanced";
            this.tpResources.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxAudioRecording);
            this.groupBox4.Controls.Add(this.cbxAudioPlayback);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 42);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Audo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSmartCards);
            this.groupBox3.Controls.Add(this.cbDevices);
            this.groupBox3.Controls.Add(this.cbPorts);
            this.groupBox3.Controls.Add(this.cbDrives);
            this.groupBox3.Controls.Add(this.cbClipboard);
            this.groupBox3.Controls.Add(this.cbPrinters);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 66);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local Resources";
            // 
            // cbPorts
            // 
            this.cbPorts.AutoSize = true;
            this.cbPorts.Location = new System.Drawing.Point(188, 42);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(50, 17);
            this.cbPorts.TabIndex = 3;
            this.cbPorts.Text = "Ports";
            this.cbPorts.UseVisualStyleBackColor = true;
            // 
            // cbDrives
            // 
            this.cbDrives.AutoSize = true;
            this.cbDrives.Location = new System.Drawing.Point(188, 19);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(56, 17);
            this.cbDrives.TabIndex = 2;
            this.cbDrives.Text = "Drives";
            this.cbDrives.UseVisualStyleBackColor = true;
            // 
            // cbClipboard
            // 
            this.cbClipboard.AutoSize = true;
            this.cbClipboard.Location = new System.Drawing.Point(5, 42);
            this.cbClipboard.Name = "cbClipboard";
            this.cbClipboard.Size = new System.Drawing.Size(70, 17);
            this.cbClipboard.TabIndex = 1;
            this.cbClipboard.Text = "Clipboard";
            this.cbClipboard.UseVisualStyleBackColor = true;
            // 
            // cbPrinters
            // 
            this.cbPrinters.AutoSize = true;
            this.cbPrinters.Location = new System.Drawing.Point(5, 19);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Size = new System.Drawing.Size(61, 17);
            this.cbPrinters.TabIndex = 0;
            this.cbPrinters.Text = "Printers";
            this.cbPrinters.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Playback:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Recording:";
            // 
            // cbxAudioPlayback
            // 
            this.cbxAudioPlayback.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAudioPlayback.FormattingEnabled = true;
            this.cbxAudioPlayback.Items.AddRange(new object[] {
            "Local computer",
            "Remote computer",
            "None"});
            this.cbxAudioPlayback.Location = new System.Drawing.Point(66, 13);
            this.cbxAudioPlayback.Name = "cbxAudioPlayback";
            this.cbxAudioPlayback.Size = new System.Drawing.Size(121, 21);
            this.cbxAudioPlayback.TabIndex = 2;
            // 
            // cbxAudioRecording
            // 
            this.cbxAudioRecording.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAudioRecording.FormattingEnabled = true;
            this.cbxAudioRecording.Items.AddRange(new object[] {
            "Local computer",
            "None"});
            this.cbxAudioRecording.Location = new System.Drawing.Point(277, 13);
            this.cbxAudioRecording.Name = "cbxAudioRecording";
            this.cbxAudioRecording.Size = new System.Drawing.Size(121, 21);
            this.cbxAudioRecording.TabIndex = 3;
            // 
            // cbDevices
            // 
            this.cbDevices.AutoSize = true;
            this.cbDevices.Location = new System.Drawing.Point(314, 19);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(65, 17);
            this.cbDevices.TabIndex = 4;
            this.cbDevices.Text = "Devices";
            this.cbDevices.UseVisualStyleBackColor = true;
            // 
            // cbSmartCards
            // 
            this.cbSmartCards.AutoSize = true;
            this.cbSmartCards.Location = new System.Drawing.Point(314, 42);
            this.cbSmartCards.Name = "cbSmartCards";
            this.cbSmartCards.Size = new System.Drawing.Size(83, 17);
            this.cbSmartCards.TabIndex = 5;
            this.cbSmartCards.Text = "Smart Cards";
            this.cbSmartCards.UseVisualStyleBackColor = true;
            // 
            // frmConnectionParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 344);
            this.Controls.Add(this.tcSettings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmConnectionParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection properties";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpResources.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbConnectionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpResources;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxFitToWindow;
        private System.Windows.Forms.ComboBox cbxScreenResolution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxColorDepth;
        private System.Windows.Forms.TextBox tbCustomDisplayHeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCustomDisplayWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbClipboard;
        private System.Windows.Forms.CheckBox cbPrinters;
        private System.Windows.Forms.CheckBox cbDrives;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbPorts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxAudioRecording;
        private System.Windows.Forms.ComboBox cbxAudioPlayback;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbSmartCards;
        private System.Windows.Forms.CheckBox cbDevices;
    }
}