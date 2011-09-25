﻿namespace NxtPad
{
    partial class Form1
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.showcontrol = new System.Windows.Forms.MenuItem();
            this.showsettings = new System.Windows.Forms.MenuItem();
            this.showbuttons = new System.Windows.Forms.MenuItem();
            this.shownxts = new System.Windows.Forms.MenuItem();
            this.showfiles = new System.Windows.Forms.MenuItem();
            this.showdebug = new System.Windows.Forms.MenuItem();
            this.showsensors = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TabController = new System.Windows.Forms.TabControl();
            this.ControlPage = new System.Windows.Forms.TabPage();
            this.pBAction4 = new System.Windows.Forms.PictureBox();
            this.pBAction3 = new System.Windows.Forms.PictureBox();
            this.pBAction2 = new System.Windows.Forms.PictureBox();
            this.pBled = new System.Windows.Forms.PictureBox();
            this.pBAction1 = new System.Windows.Forms.PictureBox();
            this.pad = new System.Windows.Forms.PictureBox();
            this.pBBackground = new System.Windows.Forms.PictureBox();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.Fullscreen = new System.Windows.Forms.CheckBox();
            this.AryBtnCheckbox = new System.Windows.Forms.CheckBox();
            this.CB_Toggling = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxComports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AryBtnPage = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bgr = new System.Windows.Forms.PictureBox();
            this.FilesPage = new System.Windows.Forms.TabPage();
            this.StopProgramBtn = new System.Windows.Forms.Button();
            this.StartProgram = new System.Windows.Forms.Button();
            this.FileSelector = new System.Windows.Forms.ComboBox();
            this.GetFileList = new System.Windows.Forms.Button();
            this.NXTsPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SavePort = new System.Windows.Forms.ComboBox();
            this.SaveName = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.ListBox();
            this.DebugPage = new System.Windows.Forms.TabPage();
            this.TestBtn1 = new System.Windows.Forms.Button();
            this.DebugTextBox = new System.Windows.Forms.TextBox();
            this.SensorPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.PollSensorBtn = new System.Windows.Forms.Button();
            this.btMsgTimer = new System.Windows.Forms.Timer();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.timer1 = new System.Windows.Forms.Timer();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.AnswerCheckbox = new System.Windows.Forms.CheckBox();
            this.btQuery = new System.Windows.Forms.Timer();
            this.TabController.SuspendLayout();
            this.ControlPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.AryBtnPage.SuspendLayout();
            this.FilesPage.SuspendLayout();
            this.NXTsPage.SuspendLayout();
            this.DebugPage.SuspendLayout();
            this.SensorPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem12);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.Text = "menu";
            this.menuItem1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.MenuItems.Add(this.showcontrol);
            this.menuItem5.MenuItems.Add(this.showsettings);
            this.menuItem5.MenuItems.Add(this.showbuttons);
            this.menuItem5.MenuItems.Add(this.shownxts);
            this.menuItem5.MenuItems.Add(this.showfiles);
            this.menuItem5.MenuItems.Add(this.showdebug);
            this.menuItem5.MenuItems.Add(this.showsensors);
            this.menuItem5.Text = "Features";
            // 
            // showcontrol
            // 
            this.showcontrol.Checked = true;
            this.showcontrol.Text = "control";
            this.showcontrol.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // showsettings
            // 
            this.showsettings.Checked = true;
            this.showsettings.Text = "settings";
            this.showsettings.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // showbuttons
            // 
            this.showbuttons.Checked = true;
            this.showbuttons.Text = "buttons";
            this.showbuttons.Click += new System.EventHandler(this.showbuttons_Click);
            // 
            // shownxts
            // 
            this.shownxts.Checked = true;
            this.shownxts.Text = "NXTs";
            this.shownxts.Click += new System.EventHandler(this.shownxts_Click);
            // 
            // showfiles
            // 
            this.showfiles.Checked = true;
            this.showfiles.Text = "files";
            this.showfiles.Click += new System.EventHandler(this.showfiles_Click);
            // 
            // showdebug
            // 
            this.showdebug.Text = "debug";
            this.showdebug.Click += new System.EventHandler(this.showdebug_Click);
            // 
            // showsensors
            // 
            this.showsensors.Checked = true;
            this.showsensors.Text = "sensors";
            this.showsensors.Click += new System.EventHandler(this.showSensors_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.MenuItems.Add(this.menuItem3);
            this.menuItem12.MenuItems.Add(this.menuItem4);
            this.menuItem12.Text = "Connection";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Open";
            this.menuItem3.Click += new System.EventHandler(this.openBtnClick);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Close";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.menuItem7);
            this.menuItem6.Text = "File";
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Exit";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "STOP";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.ControlPage);
            this.TabController.Controls.Add(this.SettingsPage);
            this.TabController.Controls.Add(this.AryBtnPage);
            this.TabController.Controls.Add(this.FilesPage);
            this.TabController.Controls.Add(this.NXTsPage);
            this.TabController.Controls.Add(this.DebugPage);
            this.TabController.Controls.Add(this.SensorPage);
            this.TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabController.Location = new System.Drawing.Point(0, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(240, 268);
            this.TabController.TabIndex = 3;
            // 
            // ControlPage
            // 
            this.ControlPage.AutoScroll = true;
            this.ControlPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ControlPage.Controls.Add(this.MessageLabel);
            this.ControlPage.Controls.Add(this.pBAction4);
            this.ControlPage.Controls.Add(this.pBAction3);
            this.ControlPage.Controls.Add(this.pBAction2);
            this.ControlPage.Controls.Add(this.pBled);
            this.ControlPage.Controls.Add(this.pBAction1);
            this.ControlPage.Controls.Add(this.pad);
            this.ControlPage.Controls.Add(this.pBBackground);
            this.ControlPage.Location = new System.Drawing.Point(0, 0);
            this.ControlPage.Name = "ControlPage";
            this.ControlPage.Size = new System.Drawing.Size(240, 245);
            this.ControlPage.Text = "control";
            // 
            // pBAction4
            // 
            this.pBAction4.BackColor = System.Drawing.Color.White;
            this.pBAction4.Location = new System.Drawing.Point(176, 209);
            this.pBAction4.Name = "pBAction4";
            this.pBAction4.Size = new System.Drawing.Size(44, 31);
            this.pBAction4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction4.Tag = "3";
            this.pBAction4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBAction4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pBAction3
            // 
            this.pBAction3.BackColor = System.Drawing.Color.White;
            this.pBAction3.Location = new System.Drawing.Point(125, 209);
            this.pBAction3.Name = "pBAction3";
            this.pBAction3.Size = new System.Drawing.Size(44, 31);
            this.pBAction3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction3.Tag = "2";
            this.pBAction3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBAction3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pBAction2
            // 
            this.pBAction2.BackColor = System.Drawing.Color.White;
            this.pBAction2.Location = new System.Drawing.Point(74, 209);
            this.pBAction2.Name = "pBAction2";
            this.pBAction2.Size = new System.Drawing.Size(44, 31);
            this.pBAction2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction2.Tag = "1";
            this.pBAction2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBAction2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pBled
            // 
            this.pBled.BackColor = System.Drawing.Color.White;
            this.pBled.Image = ((System.Drawing.Image)(resources.GetObject("pBled.Image")));
            this.pBled.Location = new System.Drawing.Point(220, 7);
            this.pBled.Name = "pBled";
            this.pBled.Size = new System.Drawing.Size(20, 18);
            this.pBled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBled.Visible = false;
            // 
            // pBAction1
            // 
            this.pBAction1.BackColor = System.Drawing.Color.White;
            this.pBAction1.Location = new System.Drawing.Point(19, 209);
            this.pBAction1.Name = "pBAction1";
            this.pBAction1.Size = new System.Drawing.Size(44, 31);
            this.pBAction1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction1.Tag = "0";
            this.pBAction1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBAction1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.Color.OrangeRed;
            this.pad.Image = ((System.Drawing.Image)(resources.GetObject("pad.Image")));
            this.pad.Location = new System.Drawing.Point(19, 3);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(200, 200);
            this.pad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pad_MouseDown);
            this.pad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pad_MouseUp);
            // 
            // pBBackground
            // 
            this.pBBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBBackground.Image = ((System.Drawing.Image)(resources.GetObject("pBBackground.Image")));
            this.pBBackground.Location = new System.Drawing.Point(0, 0);
            this.pBBackground.Name = "pBBackground";
            this.pBBackground.Size = new System.Drawing.Size(240, 270);
            this.pBBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBackground.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBBackground_MouseUp);
            // 
            // SettingsPage
            // 
            this.SettingsPage.AutoScroll = true;
            this.SettingsPage.Controls.Add(this.AnswerCheckbox);
            this.SettingsPage.Controls.Add(this.Fullscreen);
            this.SettingsPage.Controls.Add(this.AryBtnCheckbox);
            this.SettingsPage.Controls.Add(this.CB_Toggling);
            this.SettingsPage.Controls.Add(this.checkBox1);
            this.SettingsPage.Controls.Add(this.button1);
            this.SettingsPage.Controls.Add(this.button2);
            this.SettingsPage.Controls.Add(this.comboBoxComports);
            this.SettingsPage.Controls.Add(this.label1);
            this.SettingsPage.Location = new System.Drawing.Point(0, 0);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(240, 245);
            this.SettingsPage.Text = "settings";
            // 
            // Fullscreen
            // 
            this.Fullscreen.Location = new System.Drawing.Point(28, 167);
            this.Fullscreen.Name = "Fullscreen";
            this.Fullscreen.Size = new System.Drawing.Size(100, 20);
            this.Fullscreen.TabIndex = 15;
            this.Fullscreen.Text = "Fullscreen";
            this.Fullscreen.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged_1);
            // 
            // AryBtnCheckbox
            // 
            this.AryBtnCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.AryBtnCheckbox.ForeColor = System.Drawing.Color.Black;
            this.AryBtnCheckbox.Location = new System.Drawing.Point(30, 193);
            this.AryBtnCheckbox.Name = "AryBtnCheckbox";
            this.AryBtnCheckbox.Size = new System.Drawing.Size(182, 20);
            this.AryBtnCheckbox.TabIndex = 14;
            this.AryBtnCheckbox.Text = "Set Toggeling (Btn Array)";
            this.AryBtnCheckbox.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // CB_Toggling
            // 
            this.CB_Toggling.Location = new System.Drawing.Point(28, 141);
            this.CB_Toggling.Name = "CB_Toggling";
            this.CB_Toggling.Size = new System.Drawing.Size(173, 20);
            this.CB_Toggling.TabIndex = 12;
            this.CB_Toggling.Text = "Toggling buttons";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Output 0 when released";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Beep! (test port open)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open";
            this.button2.Click += new System.EventHandler(this.openBtnClick);
            // 
            // comboBoxComports
            // 
            this.comboBoxComports.DisplayMember = "2";
            this.comboBoxComports.Items.Add("COM0");
            this.comboBoxComports.Items.Add("COM1");
            this.comboBoxComports.Items.Add("COM2");
            this.comboBoxComports.Items.Add("COM3");
            this.comboBoxComports.Items.Add("COM4");
            this.comboBoxComports.Items.Add("COM5");
            this.comboBoxComports.Items.Add("COM6");
            this.comboBoxComports.Location = new System.Drawing.Point(90, 13);
            this.comboBoxComports.Name = "comboBoxComports";
            this.comboBoxComports.Size = new System.Drawing.Size(73, 22);
            this.comboBoxComports.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "BT Com port";
            // 
            // AryBtnPage
            // 
            this.AryBtnPage.AutoScroll = true;
            this.AryBtnPage.Controls.Add(this.textBox6);
            this.AryBtnPage.Controls.Add(this.textBox5);
            this.AryBtnPage.Controls.Add(this.textBox4);
            this.AryBtnPage.Controls.Add(this.textBox3);
            this.AryBtnPage.Controls.Add(this.textBox2);
            this.AryBtnPage.Controls.Add(this.textBox1);
            this.AryBtnPage.Controls.Add(this.pictureBox23);
            this.AryBtnPage.Controls.Add(this.pictureBox22);
            this.AryBtnPage.Controls.Add(this.pictureBox19);
            this.AryBtnPage.Controls.Add(this.pictureBox18);
            this.AryBtnPage.Controls.Add(this.pictureBox15);
            this.AryBtnPage.Controls.Add(this.pictureBox14);
            this.AryBtnPage.Controls.Add(this.pictureBox11);
            this.AryBtnPage.Controls.Add(this.pictureBox10);
            this.AryBtnPage.Controls.Add(this.pictureBox7);
            this.AryBtnPage.Controls.Add(this.pictureBox6);
            this.AryBtnPage.Controls.Add(this.pictureBox3);
            this.AryBtnPage.Controls.Add(this.pictureBox2);
            this.AryBtnPage.Controls.Add(this.bgr);
            this.AryBtnPage.Location = new System.Drawing.Point(0, 0);
            this.AryBtnPage.Name = "AryBtnPage";
            this.AryBtnPage.Size = new System.Drawing.Size(240, 245);
            this.AryBtnPage.Text = "buttons";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(8, 196);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 21);
            this.textBox6.TabIndex = 48;
            this.textBox6.Tag = "5";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 159);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 21);
            this.textBox5.TabIndex = 48;
            this.textBox5.Tag = "4";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 21);
            this.textBox4.TabIndex = 48;
            this.textBox4.Tag = "3";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 21);
            this.textBox3.TabIndex = 48;
            this.textBox3.Tag = "2";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 21);
            this.textBox2.TabIndex = 48;
            this.textBox2.Tag = "1";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 21);
            this.textBox1.TabIndex = 48;
            this.textBox1.Tag = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.White;
            this.pictureBox23.Location = new System.Drawing.Point(189, 196);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(44, 31);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.Tag = "11";
            this.pictureBox23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.White;
            this.pictureBox22.Location = new System.Drawing.Point(127, 196);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(44, 31);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.Tag = "10";
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            this.pictureBox22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.White;
            this.pictureBox19.Location = new System.Drawing.Point(189, 159);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(44, 31);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.Tag = "9";
            this.pictureBox19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.White;
            this.pictureBox18.Location = new System.Drawing.Point(127, 159);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(44, 31);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.Tag = "8";
            this.pictureBox18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.White;
            this.pictureBox15.Location = new System.Drawing.Point(189, 122);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(44, 31);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.Tag = "7";
            this.pictureBox15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.White;
            this.pictureBox14.Location = new System.Drawing.Point(127, 122);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(44, 31);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.Tag = "6";
            this.pictureBox14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Location = new System.Drawing.Point(189, 85);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(44, 31);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.Tag = "5";
            this.pictureBox11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Location = new System.Drawing.Point(127, 85);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(44, 31);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.Tag = "4";
            this.pictureBox10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(189, 48);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(44, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.Tag = "3";
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(127, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.Tag = "2";
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(189, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.Tag = "1";
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(127, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.Tag = "0";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // bgr
            // 
            this.bgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgr.Image = ((System.Drawing.Image)(resources.GetObject("bgr.Image")));
            this.bgr.Location = new System.Drawing.Point(0, 0);
            this.bgr.Name = "bgr";
            this.bgr.Size = new System.Drawing.Size(240, 245);
            this.bgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // FilesPage
            // 
            this.FilesPage.Controls.Add(this.StopProgramBtn);
            this.FilesPage.Controls.Add(this.StartProgram);
            this.FilesPage.Controls.Add(this.FileSelector);
            this.FilesPage.Controls.Add(this.GetFileList);
            this.FilesPage.Location = new System.Drawing.Point(0, 0);
            this.FilesPage.Name = "FilesPage";
            this.FilesPage.Size = new System.Drawing.Size(240, 245);
            this.FilesPage.Text = "files";
            // 
            // StopProgramBtn
            // 
            this.StopProgramBtn.Location = new System.Drawing.Point(7, 125);
            this.StopProgramBtn.Name = "StopProgramBtn";
            this.StopProgramBtn.Size = new System.Drawing.Size(223, 22);
            this.StopProgramBtn.TabIndex = 3;
            this.StopProgramBtn.Text = "Stop the running program";
            this.StopProgramBtn.Click += new System.EventHandler(this.StopProgramBtn_Click);
            // 
            // StartProgram
            // 
            this.StartProgram.Location = new System.Drawing.Point(7, 91);
            this.StartProgram.Name = "StartProgram";
            this.StartProgram.Size = new System.Drawing.Size(224, 23);
            this.StartProgram.TabIndex = 2;
            this.StartProgram.Text = "Run selected program";
            this.StartProgram.Click += new System.EventHandler(this.StartProgram_Click);
            // 
            // FileSelector
            // 
            this.FileSelector.Location = new System.Drawing.Point(7, 55);
            this.FileSelector.Name = "FileSelector";
            this.FileSelector.Size = new System.Drawing.Size(225, 22);
            this.FileSelector.TabIndex = 1;
            // 
            // GetFileList
            // 
            this.GetFileList.Location = new System.Drawing.Point(7, 3);
            this.GetFileList.Name = "GetFileList";
            this.GetFileList.Size = new System.Drawing.Size(223, 34);
            this.GetFileList.TabIndex = 0;
            this.GetFileList.Text = "List programs on NXT";
            this.GetFileList.Click += new System.EventHandler(this.GetFileList_Click);
            // 
            // NXTsPage
            // 
            this.NXTsPage.AutoScroll = true;
            this.NXTsPage.Controls.Add(this.label3);
            this.NXTsPage.Controls.Add(this.label2);
            this.NXTsPage.Controls.Add(this.ConnectBtn);
            this.NXTsPage.Controls.Add(this.DelBtn);
            this.NXTsPage.Controls.Add(this.SavePort);
            this.NXTsPage.Controls.Add(this.SaveName);
            this.NXTsPage.Controls.Add(this.SaveBtn);
            this.NXTsPage.Controls.Add(this.SaveList);
            this.NXTsPage.Location = new System.Drawing.Point(0, 0);
            this.NXTsPage.Name = "NXTsPage";
            this.NXTsPage.Size = new System.Drawing.Size(232, 242);
            this.NXTsPage.Text = "NXTs";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(140, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(7, 218);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(226, 24);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.openBtnClick);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(140, 186);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(93, 26);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "Delete";
            this.DelBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // SavePort
            // 
            this.SavePort.DisplayMember = "2";
            this.SavePort.Items.Add("COM0");
            this.SavePort.Items.Add("COM1");
            this.SavePort.Items.Add("COM2");
            this.SavePort.Items.Add("COM3");
            this.SavePort.Items.Add("COM4");
            this.SavePort.Items.Add("COM5");
            this.SavePort.Items.Add("COM6");
            this.SavePort.Location = new System.Drawing.Point(140, 149);
            this.SavePort.Name = "SavePort";
            this.SavePort.Size = new System.Drawing.Size(93, 22);
            this.SavePort.TabIndex = 3;
            this.SavePort.TextChanged += new System.EventHandler(this.SavePort_TextChanged);
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(7, 149);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(127, 21);
            this.SaveName.TabIndex = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(7, 186);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 26);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveList
            // 
            this.SaveList.Location = new System.Drawing.Point(7, 16);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(226, 114);
            this.SaveList.TabIndex = 0;
            this.SaveList.SelectedIndexChanged += new System.EventHandler(this.SaveList_SelectedIndexChanged);
            // 
            // DebugPage
            // 
            this.DebugPage.Controls.Add(this.TestBtn1);
            this.DebugPage.Controls.Add(this.DebugTextBox);
            this.DebugPage.Location = new System.Drawing.Point(0, 0);
            this.DebugPage.Name = "DebugPage";
            this.DebugPage.Size = new System.Drawing.Size(232, 242);
            this.DebugPage.Text = "Debug";
            // 
            // TestBtn1
            // 
            this.TestBtn1.Location = new System.Drawing.Point(20, 132);
            this.TestBtn1.Name = "TestBtn1";
            this.TestBtn1.Size = new System.Drawing.Size(200, 22);
            this.TestBtn1.TabIndex = 1;
            this.TestBtn1.Text = "Get battery level";
            this.TestBtn1.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Location = new System.Drawing.Point(20, 16);
            this.DebugTextBox.Multiline = true;
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.Size = new System.Drawing.Size(200, 110);
            this.DebugTextBox.TabIndex = 0;
            // 
            // SensorPage
            // 
            this.SensorPage.Controls.Add(this.button3);
            this.SensorPage.Controls.Add(this.label4);
            this.SensorPage.Controls.Add(this.textBox7);
            this.SensorPage.Controls.Add(this.PollSensorBtn);
            this.SensorPage.Location = new System.Drawing.Point(0, 0);
            this.SensorPage.Name = "SensorPage";
            this.SensorPage.Size = new System.Drawing.Size(232, 242);
            this.SensorPage.Text = "sensors";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.Text = "Port";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(22, 100);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(194, 21);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "1";
            // 
            // PollSensorBtn
            // 
            this.PollSensorBtn.Location = new System.Drawing.Point(22, 29);
            this.PollSensorBtn.Name = "PollSensorBtn";
            this.PollSensorBtn.Size = new System.Drawing.Size(197, 25);
            this.PollSensorBtn.TabIndex = 0;
            this.PollSensorBtn.Text = "Poll Sensor Values";
            this.PollSensorBtn.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // btMsgTimer
            // 
            this.btMsgTimer.Enabled = true;
            this.btMsgTimer.Interval = 60;
            this.btMsgTimer.Tick += new System.EventHandler(this.btMsgTimerHandler);
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(44, 31);
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(20, 248);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(200, 22);
            this.MessageLabel.Text = "No Message";
            this.MessageLabel.Visible = false;
            // 
            // AnswerCheckbox
            // 
            this.AnswerCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckbox.ForeColor = System.Drawing.Color.Black;
            this.AnswerCheckbox.Location = new System.Drawing.Point(28, 219);
            this.AnswerCheckbox.Name = "AnswerCheckbox";
            this.AnswerCheckbox.Size = new System.Drawing.Size(195, 20);
            this.AnswerCheckbox.TabIndex = 17;
            this.AnswerCheckbox.Text = "Enable Messages NXT->PPC";
            this.AnswerCheckbox.CheckStateChanged += new System.EventHandler(this.AnswerCheckbox_CheckStateChanged);
            // 
            // btQuery
            // 
            this.btQuery.Interval = 70;
            this.btQuery.Tick += new System.EventHandler(this.btQuery_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TabController);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "NXTPad";
            this.Load += new System.EventHandler(this.Setup);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.TabController.ResumeLayout(false);
            this.ControlPage.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.AryBtnPage.ResumeLayout(false);
            this.FilesPage.ResumeLayout(false);
            this.NXTsPage.ResumeLayout(false);
            this.DebugPage.ResumeLayout(false);
            this.SensorPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage ControlPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxComports;
        private System.Windows.Forms.PictureBox pad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.PictureBox pBAction1;
        private System.Windows.Forms.PictureBox pBled;
        private System.Windows.Forms.PictureBox pBBackground;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.PictureBox pBAction4;
        private System.Windows.Forms.PictureBox pBAction3;
        private System.Windows.Forms.PictureBox pBAction2;
        private System.Windows.Forms.Timer btMsgTimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CB_Toggling;
        private System.Windows.Forms.TabPage AryBtnPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage NXTsPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.ComboBox SavePort;
        private System.Windows.Forms.TextBox SaveName;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox SaveList;
        private System.Windows.Forms.PictureBox bgr;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox AryBtnCheckbox;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.CheckBox Fullscreen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage DebugPage;
        private System.Windows.Forms.Button TestBtn1;
        private System.Windows.Forms.TextBox DebugTextBox;
        private System.Windows.Forms.TabPage FilesPage;
        private System.Windows.Forms.Button GetFileList;
        private System.Windows.Forms.ComboBox FileSelector;
        private System.Windows.Forms.Button StartProgram;
        private System.Windows.Forms.Button StopProgramBtn;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem showcontrol;
        private System.Windows.Forms.MenuItem showsettings;
        private System.Windows.Forms.MenuItem showbuttons;
        private System.Windows.Forms.MenuItem shownxts;
        private System.Windows.Forms.MenuItem showfiles;
        private System.Windows.Forms.MenuItem showdebug;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.TabPage SensorPage;
        private System.Windows.Forms.Button PollSensorBtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuItem showsensors;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.CheckBox AnswerCheckbox;
        private System.Windows.Forms.Timer btQuery;

    }
}
