namespace NxtPad
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
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pBAction4 = new System.Windows.Forms.PictureBox();
            this.pBAction3 = new System.Windows.Forms.PictureBox();
            this.pBAction2 = new System.Windows.Forms.PictureBox();
            this.pBled = new System.Windows.Forms.PictureBox();
            this.pBAction1 = new System.Windows.Forms.PictureBox();
            this.pad = new System.Windows.Forms.PictureBox();
            this.pBBackground = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Fullscreen = new System.Windows.Forms.CheckBox();
            this.AryBtnCheckbox = new System.Windows.Forms.CheckBox();
            this.CB_Toggling = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxComports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SavePort = new System.Windows.Forms.ComboBox();
            this.SaveName = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.ListBox();
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
            this.btMsgTimer = new System.Windows.Forms.Timer();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.AryBtnPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.Text = "Connection";
            this.menuItem1.Click += new System.EventHandler(this.button1_Click);
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
            // menuItem2
            // 
            this.menuItem2.Text = "Exit";
            this.menuItem2.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.AryBtnPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 268);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.pBAction4);
            this.tabPage1.Controls.Add(this.pBAction3);
            this.tabPage1.Controls.Add(this.pBAction2);
            this.tabPage1.Controls.Add(this.pBled);
            this.tabPage1.Controls.Add(this.pBAction1);
            this.tabPage1.Controls.Add(this.pad);
            this.tabPage1.Controls.Add(this.pBBackground);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 245);
            this.tabPage1.Text = "control";
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
            this.pBled.Location = new System.Drawing.Point(220, 0);
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
            this.pBBackground.Size = new System.Drawing.Size(240, 245);
            this.pBBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBackground.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBBackground_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Fullscreen);
            this.tabPage2.Controls.Add(this.AryBtnCheckbox);
            this.tabPage2.Controls.Add(this.CB_Toggling);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBoxComports);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 242);
            this.tabPage2.Text = "settings";
            // 
            // Fullscreen
            // 
            this.Fullscreen.Location = new System.Drawing.Point(28, 177);
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
            this.AryBtnCheckbox.Location = new System.Drawing.Point(30, 203);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.ConnectBtn);
            this.tabPage3.Controls.Add(this.DelBtn);
            this.tabPage3.Controls.Add(this.SavePort);
            this.tabPage3.Controls.Add(this.SaveName);
            this.tabPage3.Controls.Add(this.SaveBtn);
            this.tabPage3.Controls.Add(this.SaveList);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 242);
            this.tabPage3.Text = "NXTs";
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
            this.SaveList.Size = new System.Drawing.Size(226, 86);
            this.SaveList.TabIndex = 0;
            this.SaveList.SelectedIndexChanged += new System.EventHandler(this.SaveList_SelectedIndexChanged);
            // 
            // AryBtnPage
            // 
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItem5);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "NXTPad";
            this.Load += new System.EventHandler(this.Setup);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.AryBtnPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TabPage tabPage3;
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

    }
}

