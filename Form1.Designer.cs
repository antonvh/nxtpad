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
            this.CB_Toggling = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxComports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btMsgTimer = new System.Windows.Forms.Timer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 268);
            this.tabControl1.TabIndex = 1;
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
            this.pBAction4.Image = ((System.Drawing.Image)(resources.GetObject("pBAction4.Image")));
            this.pBAction4.Location = new System.Drawing.Point(176, 209);
            this.pBAction4.Name = "pBAction4";
            this.pBAction4.Size = new System.Drawing.Size(44, 31);
            this.pBAction4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction4.Visible = false;
            this.pBAction4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction4_MouseDown);
            // 
            // pBAction3
            // 
            this.pBAction3.BackColor = System.Drawing.Color.White;
            this.pBAction3.Image = ((System.Drawing.Image)(resources.GetObject("pBAction3.Image")));
            this.pBAction3.Location = new System.Drawing.Point(125, 209);
            this.pBAction3.Name = "pBAction3";
            this.pBAction3.Size = new System.Drawing.Size(44, 31);
            this.pBAction3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction3.Visible = false;
            this.pBAction3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction3_MouseDown);
            // 
            // pBAction2
            // 
            this.pBAction2.BackColor = System.Drawing.Color.White;
            this.pBAction2.Image = ((System.Drawing.Image)(resources.GetObject("pBAction2.Image")));
            this.pBAction2.Location = new System.Drawing.Point(74, 209);
            this.pBAction2.Name = "pBAction2";
            this.pBAction2.Size = new System.Drawing.Size(44, 31);
            this.pBAction2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction2.Visible = false;
            this.pBAction2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction2_MouseDown);
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
            this.pBAction1.Image = ((System.Drawing.Image)(resources.GetObject("pBAction1.Image")));
            this.pBAction1.Location = new System.Drawing.Point(19, 209);
            this.pBAction1.Name = "pBAction1";
            this.pBAction1.Size = new System.Drawing.Size(44, 31);
            this.pBAction1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAction1.Visible = false;
            this.pBAction1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBAction1_MouseDown);
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.Color.OrangeRed;
            this.pad.Image = ((System.Drawing.Image)(resources.GetObject("pad.Image")));
            this.pad.Location = new System.Drawing.Point(20, 3);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(200, 200);
            this.pad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pad_MouseUp);
            // 
            // pBBackground
            // 
            this.pBBackground.Image = ((System.Drawing.Image)(resources.GetObject("pBBackground.Image")));
            this.pBBackground.Location = new System.Drawing.Point(0, 0);
            this.pBBackground.Name = "pBBackground";
            this.pBBackground.Size = new System.Drawing.Size(240, 245);
            this.pBBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBBackground_MouseDown);
            this.pBBackground.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBBackground_MouseUp);
            // 
            // tabPage2
            // 
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
            // CB_Toggling
            // 
            this.CB_Toggling.Location = new System.Drawing.Point(28, 160);
            this.CB_Toggling.Name = "CB_Toggling";
            this.CB_Toggling.Size = new System.Drawing.Size(173, 20);
            this.CB_Toggling.TabIndex = 12;
            this.CB_Toggling.Text = "Toggling buttons";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 133);
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
            // btMsgTimer
            // 
            this.btMsgTimer.Enabled = true;
            this.btMsgTimer.Interval = 60;
            this.btMsgTimer.Tick += new System.EventHandler(this.btMsgTimerHandler);
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

    }
}

