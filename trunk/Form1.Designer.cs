namespace NxtPad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem();
            this.TabController = new System.Windows.Forms.TabControl();
            this.ControlPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.PictureBox();
            this.pBR1B4 = new System.Windows.Forms.PictureBox();
            this.pBR1B3 = new System.Windows.Forms.PictureBox();
            this.pBR1B2 = new System.Windows.Forms.PictureBox();
            this.pBR1B1 = new System.Windows.Forms.PictureBox();
            this.pad = new System.Windows.Forms.PictureBox();
            this.pBBackground = new System.Windows.Forms.PictureBox();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DashboardTypeSelector = new System.Windows.Forms.ComboBox();
            this.ReleaseBehavior = new System.Windows.Forms.ComboBox();
            this.ToggleSetup = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SaveText = new System.Windows.Forms.TextBox();
            this.DebugTextBox = new System.Windows.Forms.ListBox();
            this.SaveProf = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.ProfileCombobox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxComports = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FilesPage = new System.Windows.Forms.TabPage();
            this.FileSelector = new System.Windows.Forms.ListView();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.ButtonImgList = new System.Windows.Forms.ImageList();
            this.NavImg2 = new System.Windows.Forms.PictureBox();
            this.btMsgTimer = new System.Windows.Forms.Timer();
            this.timer1 = new System.Windows.Forms.Timer();
            this.btQuery = new System.Windows.Forms.Timer();
            this.NavImg4 = new System.Windows.Forms.PictureBox();
            this.NavImg3 = new System.Windows.Forms.PictureBox();
            this.NavImg1 = new System.Windows.Forms.PictureBox();
            this.NavImgList = new System.Windows.Forms.ImageList();
            this.Needle = new System.Windows.Forms.ImageList();
            this.DashboardList = new System.Windows.Forms.ImageList();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.helpbrowser = new System.Windows.Forms.WebBrowser();
            this.TabController.SuspendLayout();
            this.ControlPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FilesPage.SuspendLayout();
            this.HelpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.ControlPage);
            this.TabController.Controls.Add(this.SettingsPage);
            this.TabController.Controls.Add(this.FilesPage);
            this.TabController.Controls.Add(this.HelpTab);
            this.TabController.Location = new System.Drawing.Point(0, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(240, 309);
            this.TabController.TabIndex = 2;
            // 
            // ControlPage
            // 
            this.ControlPage.AutoScroll = true;
            this.ControlPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ControlPage.Controls.Add(this.pictureBox1);
            this.ControlPage.Controls.Add(this.button3);
            this.ControlPage.Controls.Add(this.Dashboard);
            this.ControlPage.Controls.Add(this.pBR1B4);
            this.ControlPage.Controls.Add(this.pBR1B3);
            this.ControlPage.Controls.Add(this.pBR1B2);
            this.ControlPage.Controls.Add(this.pBR1B1);
            this.ControlPage.Controls.Add(this.pad);
            this.ControlPage.Controls.Add(this.pBBackground);
            this.ControlPage.Location = new System.Drawing.Point(0, 0);
            this.ControlPage.Name = "ControlPage";
            this.ControlPage.Size = new System.Drawing.Size(240, 286);
            this.ControlPage.Text = "control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 16);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(20, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(200, 40);
            this.Dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pBR1B4
            // 
            this.pBR1B4.BackColor = System.Drawing.Color.White;
            this.pBR1B4.Location = new System.Drawing.Point(176, 243);
            this.pBR1B4.Name = "pBR1B4";
            this.pBR1B4.Size = new System.Drawing.Size(47, 35);
            this.pBR1B4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBR1B4.Tag = "3";
            this.pBR1B4.Click += new System.EventHandler(this.pBAction4_Click);
            this.pBR1B4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBR1B4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pBR1B3
            // 
            this.pBR1B3.BackColor = System.Drawing.Color.White;
            this.pBR1B3.Location = new System.Drawing.Point(124, 243);
            this.pBR1B3.Name = "pBR1B3";
            this.pBR1B3.Size = new System.Drawing.Size(47, 35);
            this.pBR1B3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBR1B3.Tag = "2";
            this.pBR1B3.Click += new System.EventHandler(this.pBAction3_Click);
            this.pBR1B3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBR1B3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pBR1B2
            // 
            this.pBR1B2.BackColor = System.Drawing.Color.White;
            this.pBR1B2.Location = new System.Drawing.Point(72, 243);
            this.pBR1B2.Name = "pBR1B2";
            this.pBR1B2.Size = new System.Drawing.Size(47, 35);
            this.pBR1B2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBR1B2.Tag = "1";
            this.pBR1B2.Click += new System.EventHandler(this.pBAction2_Click);
            this.pBR1B2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBR1B2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pBR1B1
            // 
            this.pBR1B1.BackColor = System.Drawing.Color.White;
            this.pBR1B1.Location = new System.Drawing.Point(20, 243);
            this.pBR1B1.Name = "pBR1B1";
            this.pBR1B1.Size = new System.Drawing.Size(47, 35);
            this.pBR1B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBR1B1.Tag = "0";
            this.pBR1B1.Click += new System.EventHandler(this.pBAction1_Click);
            this.pBR1B1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            this.pBR1B1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseUp);
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.Color.OrangeRed;
            this.pad.Image = ((System.Drawing.Image)(resources.GetObject("pad.Image")));
            this.pad.Location = new System.Drawing.Point(20, 40);
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
            this.pBBackground.Size = new System.Drawing.Size(240, 286);
            this.pBBackground.Click += new System.EventHandler(this.pBBackground_Click);
            this.pBBackground.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBBackground_MouseUp);
            // 
            // SettingsPage
            // 
            this.SettingsPage.AutoScroll = true;
            this.SettingsPage.Controls.Add(this.panel1);
            this.SettingsPage.Location = new System.Drawing.Point(0, 0);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(240, 286);
            this.SettingsPage.Text = "settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DashboardTypeSelector);
            this.panel1.Controls.Add(this.ReleaseBehavior);
            this.panel1.Controls.Add(this.ToggleSetup);
            this.panel1.Controls.Add(this.SaveText);
            this.panel1.Controls.Add(this.DebugTextBox);
            this.panel1.Controls.Add(this.SaveProf);
            this.panel1.Controls.Add(this.ProfileCombobox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxComports);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 598);
            this.panel1.GotFocus += new System.EventHandler(this.panel1_GotFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 14);
            this.label3.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 14);
            this.label2.Text = "Release behavior";
            // 
            // DashboardTypeSelector
            // 
            this.DashboardTypeSelector.Items.Add("motor speed");
            this.DashboardTypeSelector.Items.Add("sensor values");
            this.DashboardTypeSelector.Items.Add("disabled");
            this.DashboardTypeSelector.Location = new System.Drawing.Point(16, 257);
            this.DashboardTypeSelector.Name = "DashboardTypeSelector";
            this.DashboardTypeSelector.Size = new System.Drawing.Size(159, 22);
            this.DashboardTypeSelector.TabIndex = 44;
            this.DashboardTypeSelector.SelectedIndexChanged += new System.EventHandler(this.ReleaseBehavior_SelectedIndexChanged);
            // 
            // ReleaseBehavior
            // 
            this.ReleaseBehavior.Items.Add("Autocenter");
            this.ReleaseBehavior.Items.Add("Keep position");
            this.ReleaseBehavior.Location = new System.Drawing.Point(16, 207);
            this.ReleaseBehavior.Name = "ReleaseBehavior";
            this.ReleaseBehavior.Size = new System.Drawing.Size(159, 22);
            this.ReleaseBehavior.TabIndex = 44;
            this.ReleaseBehavior.SelectedIndexChanged += new System.EventHandler(this.ReleaseBehavior_SelectedIndexChanged);
            // 
            // ToggleSetup
            // 
            this.ToggleSetup.CheckBoxes = true;
            this.ToggleSetup.Columns.Add(this.columnHeader1);
            this.ToggleSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.Text = "Button1";
            listViewItem2.Tag = "";
            listViewItem2.Text = "Button2";
            listViewItem3.Text = "Button3";
            listViewItem4.Text = "Button4";
            this.ToggleSetup.Items.Add(listViewItem1);
            this.ToggleSetup.Items.Add(listViewItem2);
            this.ToggleSetup.Items.Add(listViewItem3);
            this.ToggleSetup.Items.Add(listViewItem4);
            this.ToggleSetup.Location = new System.Drawing.Point(16, 360);
            this.ToggleSetup.Name = "ToggleSetup";
            this.ToggleSetup.Size = new System.Drawing.Size(188, 90);
            this.ToggleSetup.TabIndex = 38;
            this.ToggleSetup.View = System.Windows.Forms.View.Details;
            this.ToggleSetup.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.ToggleSetup.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ColumnHeader";
            this.columnHeader1.Width = 180;
            // 
            // SaveText
            // 
            this.SaveText.Location = new System.Drawing.Point(16, 62);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(128, 21);
            this.SaveText.TabIndex = 37;
            this.SaveText.Text = "SaveName";
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Location = new System.Drawing.Point(16, 509);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.Size = new System.Drawing.Size(181, 86);
            this.DebugTextBox.TabIndex = 31;
            // 
            // SaveProf
            // 
            this.SaveProf.ContextMenu = this.contextMenu1;
            this.SaveProf.Location = new System.Drawing.Point(150, 34);
            this.SaveProf.Name = "SaveProf";
            this.SaveProf.Size = new System.Drawing.Size(72, 22);
            this.SaveProf.TabIndex = 21;
            this.SaveProf.Text = "Save";
            this.SaveProf.Click += new System.EventHandler(this.SaveProf_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItem1);
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Delete";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // ProfileCombobox
            // 
            this.ProfileCombobox.ContextMenu = this.contextMenu1;
            this.ProfileCombobox.Location = new System.Drawing.Point(16, 34);
            this.ProfileCombobox.Name = "ProfileCombobox";
            this.ProfileCombobox.Size = new System.Drawing.Size(128, 22);
            this.ProfileCombobox.TabIndex = 19;
            this.ProfileCombobox.SelectedIndexChanged += new System.EventHandler(this.ProfileCombobox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 120);
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
            this.comboBoxComports.Location = new System.Drawing.Point(16, 120);
            this.comboBoxComports.Name = "comboBoxComports";
            this.comboBoxComports.Size = new System.Drawing.Size(128, 22);
            this.comboBoxComports.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 22);
            this.label7.Text = "toggle buttons";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.Text = "Connection";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.Text = "Settings profile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Beep! (test port open)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilesPage
            // 
            this.FilesPage.Controls.Add(this.FileSelector);
            this.FilesPage.Location = new System.Drawing.Point(0, 0);
            this.FilesPage.Name = "FilesPage";
            this.FilesPage.Size = new System.Drawing.Size(240, 286);
            this.FilesPage.Text = "files";
            this.FilesPage.GotFocus += new System.EventHandler(this.FilesPage_GotFocus);
            // 
            // FileSelector
            // 
            this.FileSelector.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.FileSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileSelector.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.FileSelector.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.FileSelector.Location = new System.Drawing.Point(0, 0);
            this.FileSelector.Name = "FileSelector";
            this.FileSelector.Size = new System.Drawing.Size(240, 286);
            this.FileSelector.TabIndex = 3;
            this.FileSelector.View = System.Windows.Forms.View.SmallIcon;
            this.FileSelector.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.FileSelector.SelectedIndexChanged += new System.EventHandler(this.FileSelector_SelectedIndexChanged);
            // 
            // HelpTab
            // 
            this.HelpTab.Controls.Add(this.helpbrowser);
            this.HelpTab.Location = new System.Drawing.Point(0, 0);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Size = new System.Drawing.Size(240, 286);
            this.HelpTab.Text = "Help";
            // 
            // ButtonImgList
            // 
            this.ButtonImgList.ImageSize = new System.Drawing.Size(47, 35);
            this.ButtonImgList.Images.Clear();
            this.ButtonImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.ButtonImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            // 
            // NavImg2
            // 
            this.NavImg2.Location = new System.Drawing.Point(60, 303);
            this.NavImg2.Name = "NavImg2";
            this.NavImg2.Size = new System.Drawing.Size(60, 37);
            this.NavImg2.Tag = "2";
            this.NavImg2.Click += new System.EventHandler(this.NavImg2_Click);
            // 
            // btMsgTimer
            // 
            this.btMsgTimer.Enabled = true;
            this.btMsgTimer.Interval = 60;
            this.btMsgTimer.Tick += new System.EventHandler(this.btMsgTimerHandler);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btQuery
            // 
            this.btQuery.Interval = 70;
            this.btQuery.Tick += new System.EventHandler(this.btQuery_Tick);
            // 
            // NavImg4
            // 
            this.NavImg4.Location = new System.Drawing.Point(180, 303);
            this.NavImg4.Name = "NavImg4";
            this.NavImg4.Size = new System.Drawing.Size(60, 37);
            this.NavImg4.Click += new System.EventHandler(this.NavImg4_Click);
            // 
            // NavImg3
            // 
            this.NavImg3.Location = new System.Drawing.Point(120, 303);
            this.NavImg3.Name = "NavImg3";
            this.NavImg3.Size = new System.Drawing.Size(60, 37);
            this.NavImg3.Tag = "1";
            this.NavImg3.Click += new System.EventHandler(this.NavImg3_Click);
            // 
            // NavImg1
            // 
            this.NavImg1.Location = new System.Drawing.Point(0, 303);
            this.NavImg1.Name = "NavImg1";
            this.NavImg1.Size = new System.Drawing.Size(60, 37);
            this.NavImg1.Tag = "0";
            this.NavImg1.Click += new System.EventHandler(this.NavImg1_Click);
            // 
            // NavImgList
            // 
            this.NavImgList.ImageSize = new System.Drawing.Size(60, 37);
            this.NavImgList.Images.Clear();
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource7"))));
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource8"))));
            this.NavImgList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource9"))));
            // 
            // Needle
            // 
            this.Needle.ImageSize = new System.Drawing.Size(41, 18);
            this.Needle.Images.Clear();
            this.Needle.Images.Add(((System.Drawing.Image)(resources.GetObject("resource10"))));
            // 
            // DashboardList
            // 
            this.DashboardList.ImageSize = new System.Drawing.Size(200, 40);
            this.DashboardList.Images.Clear();
            this.DashboardList.Images.Add(((System.Drawing.Image)(resources.GetObject("resource11"))));
            // 
            // comboBox1
            // 
            this.comboBox1.Items.Add("big pad / 4 Buttons");
            this.comboBox1.Items.Add("small pad / 8 Buttons");
            this.comboBox1.Location = new System.Drawing.Point(16, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 22);
            this.comboBox1.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 14);
            this.label5.Text = "Pad/Buttons";
            // 
            // helpbrowser
            // 
            this.helpbrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpbrowser.Location = new System.Drawing.Point(0, 0);
            this.helpbrowser.Name = "helpbrowser";
            this.helpbrowser.ScriptErrorsSuppressed = true;
            this.helpbrowser.Size = new System.Drawing.Size(240, 286);
            this.helpbrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.helpbrowser_Navigating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.NavImg2);
            this.Controls.Add(this.NavImg4);
            this.Controls.Add(this.NavImg3);
            this.Controls.Add(this.NavImg1);
            this.Controls.Add(this.TabController);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.Text = "NXTPad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Setup);
            this.TabController.ResumeLayout(false);
            this.ControlPage.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.FilesPage.ResumeLayout(false);
            this.HelpTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage ControlPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxComports;
        private System.Windows.Forms.PictureBox pad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pBR1B1;
        private System.Windows.Forms.PictureBox pBBackground;
        private System.Windows.Forms.PictureBox pBR1B4;
        private System.Windows.Forms.PictureBox pBR1B3;
        private System.Windows.Forms.PictureBox pBR1B2;
        private System.Windows.Forms.Timer btMsgTimer;
        private System.Windows.Forms.ImageList ButtonImgList;
        private System.Windows.Forms.TabPage FilesPage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer btQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveProf;
        private System.Windows.Forms.ComboBox ProfileCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView FileSelector;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ListBox DebugTextBox;
        private System.Windows.Forms.PictureBox NavImg4;
        private System.Windows.Forms.PictureBox NavImg3;
        private System.Windows.Forms.PictureBox NavImg2;
        private System.Windows.Forms.PictureBox NavImg1;
        private System.Windows.Forms.ImageList NavImgList;
        private System.Windows.Forms.TextBox SaveText;
        private System.Windows.Forms.TabPage HelpTab;
        private System.Windows.Forms.ListView ToggleSetup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ReleaseBehavior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DashboardTypeSelector;
        private System.Windows.Forms.PictureBox Dashboard;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList Needle;
        private System.Windows.Forms.ImageList DashboardList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser helpbrowser;

    }
}

