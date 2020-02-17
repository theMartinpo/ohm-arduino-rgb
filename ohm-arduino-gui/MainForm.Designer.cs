namespace ohm_arduino_gui
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.comPortCombo = new System.Windows.Forms.ComboBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.Line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.switchTimer = new System.Windows.Forms.Label();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.rNumeric = new System.Windows.Forms.NumericUpDown();
            this.gNumeric = new System.Windows.Forms.NumericUpDown();
            this.gLabel = new System.Windows.Forms.Label();
            this.bNumeric = new System.Windows.Forms.NumericUpDown();
            this.bLabel = new System.Windows.Forms.Label();
            this.brightnessNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkRainbow = new System.Windows.Forms.CheckBox();
            this.line2GPUClock = new System.Windows.Forms.CheckBox();
            this.line1GPUClock = new System.Windows.Forms.CheckBox();
            this.line2CPUClock = new System.Windows.Forms.CheckBox();
            this.line1CPUClock = new System.Windows.Forms.CheckBox();
            this.comboBoxSwitchTimer = new System.Windows.Forms.ComboBox();
            this.line2RAM = new System.Windows.Forms.CheckBox();
            this.line2GPU = new System.Windows.Forms.CheckBox();
            this.line2CPU = new System.Windows.Forms.CheckBox();
            this.line1RAM = new System.Windows.Forms.CheckBox();
            this.line1GPU = new System.Windows.Forms.CheckBox();
            this.line1CPU = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.notifyIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 2000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // comPortCombo
            // 
            this.comPortCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortCombo.FormattingEnabled = true;
            this.comPortCombo.Location = new System.Drawing.Point(12, 17);
            this.comPortCombo.Name = "comPortCombo";
            this.comPortCombo.Size = new System.Drawing.Size(369, 21);
            this.comPortCombo.TabIndex = 1;
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(12, 48);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(369, 230);
            this.logBox.TabIndex = 2;
            this.logBox.Text = "";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "OHM - Arduino";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(149, 48);
            // 
            // showWindowToolStripMenuItem
            // 
            this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.showWindowToolStripMenuItem.Text = "Show window";
            this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(9, 286);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(166, 13);
            this.githubLink.TabIndex = 3;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "View About information on GitHub";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // Line1
            // 
            this.Line1.AutoSize = true;
            this.Line1.Location = new System.Drawing.Point(387, 17);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(36, 13);
            this.Line1.TabIndex = 7;
            this.Line1.Text = "Line 1";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(387, 80);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(36, 13);
            this.line2.TabIndex = 11;
            this.line2.Text = "Line 2";
            // 
            // switchTimer
            // 
            this.switchTimer.AutoSize = true;
            this.switchTimer.Location = new System.Drawing.Point(389, 148);
            this.switchTimer.Name = "switchTimer";
            this.switchTimer.Size = new System.Drawing.Size(70, 13);
            this.switchTimer.TabIndex = 12;
            this.switchTimer.Text = "Switch timer :";
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Location = new System.Drawing.Point(387, 178);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(30, 13);
            this.rgbLabel.TabIndex = 14;
            this.rgbLabel.Text = "RGB";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rLabel.Location = new System.Drawing.Point(387, 196);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(15, 13);
            this.rLabel.TabIndex = 15;
            this.rLabel.Text = "R";
            // 
            // rNumeric
            // 
            this.rNumeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ohm_arduino_gui.Properties.Settings.Default, "R", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rNumeric.Location = new System.Drawing.Point(408, 194);
            this.rNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rNumeric.Name = "rNumeric";
            this.rNumeric.Size = new System.Drawing.Size(45, 20);
            this.rNumeric.TabIndex = 16;
            this.rNumeric.Value = global::ohm_arduino_gui.Properties.Settings.Default.R;
            // 
            // gNumeric
            // 
            this.gNumeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ohm_arduino_gui.Properties.Settings.Default, "G", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gNumeric.Location = new System.Drawing.Point(490, 194);
            this.gNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gNumeric.Name = "gNumeric";
            this.gNumeric.Size = new System.Drawing.Size(45, 20);
            this.gNumeric.TabIndex = 18;
            this.gNumeric.Value = global::ohm_arduino_gui.Properties.Settings.Default.G;
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.ForeColor = System.Drawing.Color.Green;
            this.gLabel.Location = new System.Drawing.Point(469, 196);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(15, 13);
            this.gLabel.TabIndex = 17;
            this.gLabel.Text = "G";
            // 
            // bNumeric
            // 
            this.bNumeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ohm_arduino_gui.Properties.Settings.Default, "B", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bNumeric.Location = new System.Drawing.Point(571, 194);
            this.bNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bNumeric.Name = "bNumeric";
            this.bNumeric.Size = new System.Drawing.Size(45, 20);
            this.bNumeric.TabIndex = 20;
            this.bNumeric.Value = global::ohm_arduino_gui.Properties.Settings.Default.B;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.ForeColor = System.Drawing.Color.Blue;
            this.bLabel.Location = new System.Drawing.Point(550, 196);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(14, 13);
            this.bLabel.TabIndex = 19;
            this.bLabel.Text = "B";
            // 
            // brightnessNumeric
            // 
            this.brightnessNumeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ohm_arduino_gui.Properties.Settings.Default, "Brightness", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.brightnessNumeric.Location = new System.Drawing.Point(449, 231);
            this.brightnessNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessNumeric.Name = "brightnessNumeric";
            this.brightnessNumeric.Size = new System.Drawing.Size(45, 20);
            this.brightnessNumeric.TabIndex = 26;
            this.brightnessNumeric.Value = global::ohm_arduino_gui.Properties.Settings.Default.Brightness;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(387, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Brightness";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(392, 268);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(229, 27);
            this.buttonSaveSettings.TabIndex = 28;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.saveSettings);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "- ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "seconds";
            // 
            // checkRainbow
            // 
            this.checkRainbow.AutoSize = true;
            this.checkRainbow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkRainbow.Checked = global::ohm_arduino_gui.Properties.Settings.Default.Rainbow;
            this.checkRainbow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "Rainbow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkRainbow.Location = new System.Drawing.Point(527, 232);
            this.checkRainbow.Name = "checkRainbow";
            this.checkRainbow.Size = new System.Drawing.Size(68, 17);
            this.checkRainbow.TabIndex = 27;
            this.checkRainbow.Text = "Rainbow";
            this.checkRainbow.UseVisualStyleBackColor = true;
            // 
            // line2GPUClock
            // 
            this.line2GPUClock.AutoSize = true;
            this.line2GPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2GPUClock;
            this.line2GPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2GPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2GPUClock.Location = new System.Drawing.Point(486, 122);
            this.line2GPUClock.Name = "line2GPUClock";
            this.line2GPUClock.Size = new System.Drawing.Size(79, 17);
            this.line2GPUClock.TabIndex = 24;
            this.line2GPUClock.Text = "GPU Clock";
            this.line2GPUClock.UseVisualStyleBackColor = true;
            // 
            // line1GPUClock
            // 
            this.line1GPUClock.AutoSize = true;
            this.line1GPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1GPUClock;
            this.line1GPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1GPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1GPUClock.Location = new System.Drawing.Point(486, 59);
            this.line1GPUClock.Name = "line1GPUClock";
            this.line1GPUClock.Size = new System.Drawing.Size(79, 17);
            this.line1GPUClock.TabIndex = 23;
            this.line1GPUClock.Text = "GPU Clock";
            this.line1GPUClock.UseVisualStyleBackColor = true;
            // 
            // line2CPUClock
            // 
            this.line2CPUClock.AutoSize = true;
            this.line2CPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2CPUClock;
            this.line2CPUClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.line2CPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2CPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2CPUClock.Location = new System.Drawing.Point(392, 122);
            this.line2CPUClock.Name = "line2CPUClock";
            this.line2CPUClock.Size = new System.Drawing.Size(78, 17);
            this.line2CPUClock.TabIndex = 22;
            this.line2CPUClock.Text = "CPU Clock";
            this.line2CPUClock.UseVisualStyleBackColor = true;
            // 
            // line1CPUClock
            // 
            this.line1CPUClock.AutoSize = true;
            this.line1CPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1CPUClock;
            this.line1CPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1CPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1CPUClock.Location = new System.Drawing.Point(392, 59);
            this.line1CPUClock.Name = "line1CPUClock";
            this.line1CPUClock.Size = new System.Drawing.Size(78, 17);
            this.line1CPUClock.TabIndex = 21;
            this.line1CPUClock.Text = "CPU Clock";
            this.line1CPUClock.UseVisualStyleBackColor = true;
            // 
            // comboBoxSwitchTimer
            // 
            this.comboBoxSwitchTimer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ohm_arduino_gui.Properties.Settings.Default, "switchTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxSwitchTimer.FormattingEnabled = true;
            this.comboBoxSwitchTimer.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.comboBoxSwitchTimer.Location = new System.Drawing.Point(459, 145);
            this.comboBoxSwitchTimer.Name = "comboBoxSwitchTimer";
            this.comboBoxSwitchTimer.Size = new System.Drawing.Size(41, 21);
            this.comboBoxSwitchTimer.TabIndex = 13;
            this.comboBoxSwitchTimer.Text = global::ohm_arduino_gui.Properties.Settings.Default.switchTimer;
            // 
            // line2RAM
            // 
            this.line2RAM.AutoSize = true;
            this.line2RAM.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2RAM;
            this.line2RAM.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2RAM", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2RAM.Location = new System.Drawing.Point(571, 99);
            this.line2RAM.Name = "line2RAM";
            this.line2RAM.Size = new System.Drawing.Size(50, 17);
            this.line2RAM.TabIndex = 10;
            this.line2RAM.Text = "RAM";
            this.line2RAM.UseVisualStyleBackColor = true;
            // 
            // line2GPU
            // 
            this.line2GPU.AutoSize = true;
            this.line2GPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2GPU;
            this.line2GPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2GPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2GPU.Location = new System.Drawing.Point(486, 99);
            this.line2GPU.Name = "line2GPU";
            this.line2GPU.Size = new System.Drawing.Size(49, 17);
            this.line2GPU.TabIndex = 9;
            this.line2GPU.Text = "GPU";
            this.line2GPU.UseVisualStyleBackColor = true;
            // 
            // line2CPU
            // 
            this.line2CPU.AutoSize = true;
            this.line2CPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2CPU;
            this.line2CPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2CPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2CPU.Location = new System.Drawing.Point(392, 99);
            this.line2CPU.Name = "line2CPU";
            this.line2CPU.Size = new System.Drawing.Size(48, 17);
            this.line2CPU.TabIndex = 8;
            this.line2CPU.Text = "CPU";
            this.line2CPU.UseVisualStyleBackColor = true;
            // 
            // line1RAM
            // 
            this.line1RAM.AutoSize = true;
            this.line1RAM.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1RAM;
            this.line1RAM.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1RAM", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1RAM.Location = new System.Drawing.Point(571, 36);
            this.line1RAM.Name = "line1RAM";
            this.line1RAM.Size = new System.Drawing.Size(50, 17);
            this.line1RAM.TabIndex = 6;
            this.line1RAM.Text = "RAM";
            this.line1RAM.UseVisualStyleBackColor = true;
            // 
            // line1GPU
            // 
            this.line1GPU.AutoSize = true;
            this.line1GPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1GPU;
            this.line1GPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1GPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1GPU.Location = new System.Drawing.Point(486, 36);
            this.line1GPU.Name = "line1GPU";
            this.line1GPU.Size = new System.Drawing.Size(49, 17);
            this.line1GPU.TabIndex = 5;
            this.line1GPU.Text = "GPU";
            this.line1GPU.UseVisualStyleBackColor = true;
            // 
            // line1CPU
            // 
            this.line1CPU.AutoSize = true;
            this.line1CPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1CPU;
            this.line1CPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.line1CPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1CPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1CPU.Location = new System.Drawing.Point(392, 36);
            this.line1CPU.Name = "line1CPU";
            this.line1CPU.Size = new System.Drawing.Size(48, 17);
            this.line1CPU.TabIndex = 4;
            this.line1CPU.Text = "CPU";
            this.line1CPU.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(200, 286);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Adapted by MPR";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked_MPR);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 308);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.checkRainbow);
            this.Controls.Add(this.brightnessNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line2GPUClock);
            this.Controls.Add(this.line1GPUClock);
            this.Controls.Add(this.line2CPUClock);
            this.Controls.Add(this.line1CPUClock);
            this.Controls.Add(this.bNumeric);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.gNumeric);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.rNumeric);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.comboBoxSwitchTimer);
            this.Controls.Add(this.switchTimer);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line2RAM);
            this.Controls.Add(this.line2GPU);
            this.Controls.Add(this.line2CPU);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.line1RAM);
            this.Controls.Add(this.line1GPU);
            this.Controls.Add(this.line1CPU);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.comPortCombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OpenHardwareMonitor - Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ComboBox comPortCombo;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox line1CPU;
        private System.Windows.Forms.CheckBox line1GPU;
        private System.Windows.Forms.CheckBox line1RAM;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.CheckBox line2RAM;
        private System.Windows.Forms.CheckBox line2GPU;
        private System.Windows.Forms.CheckBox line2CPU;
        private System.Windows.Forms.Label switchTimer;
        private System.Windows.Forms.ComboBox comboBoxSwitchTimer;
        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.NumericUpDown rNumeric;
        private System.Windows.Forms.NumericUpDown gNumeric;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.NumericUpDown bNumeric;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.CheckBox line1CPUClock;
        private System.Windows.Forms.CheckBox line2CPUClock;
        private System.Windows.Forms.CheckBox line1GPUClock;
        private System.Windows.Forms.CheckBox line2GPUClock;
        private System.Windows.Forms.NumericUpDown brightnessNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkRainbow;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

