using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace NxtPad
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        

        public struct AryButton
        {
            public bool toggle;
            public bool down;
        }
        //for btn Array
        public bool ButtonArraySetup = false;
        AryButton[] Buttons = new AryButton[12];
        string[] ABNames = new string[6];
        //for Actionbtns
        private bool[] actiondown=new bool[4];
        private int newx=0, newy=0, oldx = 0, oldy = 0, actionInt = 0;
        private bool actionButtonPressed = false;
        private char[] action = {'0','0','0','0'}; //legacy array for storing which action button was pressed
        //private bool dialogvisible  = false;
        //for saving
        //2 Keys, one to Store the DEVices and their matching Com port, one to store general settings
        RegistryKey DevKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\NXTPad\\Devices");
        RegistryKey SettingsKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\NXTPad");
        private void LoadDevices()
        {
           //Clears the Displayed list and rebuild it using the Registry
            SaveList.Items.Clear();
            foreach (string i in DevKey.GetSubKeyNames())
            {
                SaveList.Items.Add(i);
            }

        }
        private void Setup(object sender, EventArgs e)
        {
            LoadDevices();
            comboBoxComports.SelectedIndex = 1; //my default setting: COM1
            serialPort1.Close();//just to   be sure.
            serialPort1.PortName = "COM1";//my default
            
            //if LastNXT is saved, load it and goto save page
          string NXTName=(string) SettingsKey.GetValue("LastNXT","");
          if (NXTName != "")
            {
             
               DoLoad((string)NXTName);
               tabControl1.SelectedIndex = 2;
            }

          foreach (Control C in AryBtnPage.Controls)
              if (C is PictureBox)
                  if (C.Name!="bgr")
                  ((PictureBox)C).Image = imageList1.Images[0];

          pBAction1.Image = imageList1.Images[0];
          pBAction2.Image = imageList1.Images[0];
          pBAction3.Image = imageList1.Images[0];
          pBAction4.Image = imageList1.Images[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = { 0x06, 0x00, 0x80, 0x03, 0xff, 0x01, 0xff, 0x00 };
                serialPort1.Write(data, 0, 8);
            }
            catch
            {
                MessageBox.Show("Error sending beep command");
            }
        }
                   

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
         


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            updatePad(e.X, e.Y);
        }

        private void updatePad(int x, int y)
        {
            newx = map(x, 0, pad.Width, -100, 100);
            newy = map(y, 0, pad.Height, 100, -100);            
        }

        //helper functions
        private bool within(int x, int y, int left, int top, int right, int bottom)
        {
            bool result = false;
            if ((x >= left) && (x <= right) && (y >= top) && (y <= bottom)) { result = true; }
            return result;
        }

        private int map(int value, int istart, int istop, int ostart, int ostop)
        {
             return (int)(ostart + ((float)(ostop - ostart) * ((float)(value - istart) / (float)(istop - istart))));
        }

       
        //private float map(float value, float istart, float istop, float ostart, float ostop)
        //{
        //    return ostart + ((ostop - ostart) * ((value - istart) / (istop - istart)));
        //}

        // this function is called on timer1.click, every 60ms.
        private void btMsgTimerHandler(object sender, EventArgs e)
        {
            if ((newx != oldx) || (newy != oldy) || actionButtonPressed)
            {
                oldx = newx;
                oldy = newy;
                sendToNxt(newx, newy);

                actionButtonPressed = false;
            }
        }

        //the function for calculating the byte message and sending it.
        private void sendToNxt(int outX, int outY)
        {
            //cap outX and outY
            if (outX>100) {outX = 100;}
            if (outX<-100) { outX = -100; }
            if (outY>100) { outY = 100; }
            if (outY<-100) { outY = -100; }


            //calculate values for direct use in NXT-G Motor blocks
            int steer = (int) Math.Round(Math.Atan2(outX, outY) * 200 / Math.PI);
            int pwr = (int) Math.Round(Math.Sqrt(Math.Pow(outX, 2) + Math.Pow(outY, 2)));
            int direction = 0;
            if (outY >= 0) { direction = 1; }

            if (steer > 100) { steer = map(steer, 100, 200, 100, 0); }
            if (steer < -100) { steer = map(steer, -100, -200, -100, 0); }
            
            int BTv1=0;
            for (int i=0; i<((int)Buttons.Count() / 2);i++)
            {
                if (Buttons[i*2].down)
             BTv1=BTv1+ (int) Math.Pow(2,i);

            }
            int BTv2=0;
            for (int i=0; i<(int)Buttons.Count() /2 ;i++)
            {
                if (Buttons[i*2+1].down)
            BTv2=BTv2+(int) Math.Pow(2,(i));

            }

            string actionString = new string(action);
            string NXTString = direction.ToString() + "," + nfs(steer) + "," + nfs(pwr) + "," + nfs(outX) + "," + nfs(outY) + "," + actionString + "," + actionInt.ToString()+","+BTv1.ToString("000")+","+BTv2.ToString("000");

            //DialogResult rslt = MessageBox.Show(NXTString);
           
            byte[] Command = new byte[NXTString.Length + 4];//7
            //byte[] CommandHeader = {(byte)(NXTString.Length + 5),0x00, 0x80, 0x09, 0x00, (byte)(NXTString.Length + 1) }; //
            byte[] CommandHeader = { 0x80, 0x09, 0x00, (byte)(NXTString.Length + 1) }; //
            //orignial byte[] CommandHeader = { (byte)(NXTString.Length + 5), 0x00, 0x00, 0x09, 0x00, (byte)(NXTString.Length + 1) }; //
//            //Lenght LSB,Lenght MSB, NoReply, SendMSG, MsgBox 1, MSG length.
                        
            
            int j = 4;//6 //start writing the string to the byte array on the 7th byte
            foreach (char ch in NXTString.ToCharArray())
            {
                Command[j] = (byte)ch;
                j++;
            }
            
            //putting it all together
            System.Buffer.BlockCopy(CommandHeader, 0, Command, 0, CommandHeader.Length);
            
            Send(Command);

         

                 
         }
        void Send(byte[] Data)
        {
            byte[] All=new byte[Data.Length+3];
            All[0]=(byte)(Data.Length+1);
            All[1]=0;
            Array.Copy(Data, 0, All, 2, Data.Length);
            All[All.Length-1] = 0;
            

            if (serialPort1.IsOpen)
            {
                pBled.Visible = true;
                serialPort1.Write(All, 0, All.Length);
            }
            else
            {
                pBled.Visible = false;
                try
                {
                    //  serialPort1.Open();
                    //  pBled.Visible = true;
                }
                catch
                {
                    pBled.Visible = false;
                    //if (!dialogvisible){
                    //result = MessageBox.Show("Error opening " + serialPort1.PortName);
                    //dialogvisible = true;
                    //if (result == DialogResult.OK) {//resume
                    //}
                    //}
                    //MessageBox.Show(result.ToString);
                }
            }
        }

        private string nfs(int nr) //create a 4-character string of any number. first character is sign.
        {
            string rtrn = nr.ToString("000");
            if (nr >= 0) { rtrn = "+" + rtrn; }
            return rtrn;
        }

               

        private void openBtnClick(object sender, EventArgs e)
        {
            serialPort1.Close();
            //serialPort1.PortName = comboBoxComports.SelectedItem.ToString();
            serialPort1.PortName = comboBoxComports.Text.ToString();
            try
            {
                serialPort1.Open();
                pBled.Visible = true;
            }
            catch
            {
                MessageBox.Show("Error opening "+serialPort1.PortName);
                pBled.Visible = false;
            }
        }

        
        private void setActionOutput(bool pressed, int btnNum)
        {
            if (pressed)
            {
                action[btnNum-1] = '1';
                actionInt = btnNum;
            }
            else
            {
                action[btnNum - 1] = '0';
                actionInt = 0;
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void pBBackground_MouseUp(object sender, MouseEventArgs e)
        {
            if (!CB_Toggling.Checked)
            {
            }
            actionButtonPressed = true;
            
        }



        private void pad_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked) {newx =0;newy=0;}
        }

        private void pBAction1_MouseDown(object sender, MouseEventArgs e)
        {
            if (CB_Toggling.Checked)
                
                actiondown[Convert.ToInt32(((PictureBox)sender).Tag)] = ! actiondown[Convert.ToInt32(((PictureBox)sender).Tag)];
            else
                actiondown[Convert.ToInt32(((PictureBox)sender).Tag)] = true;
            
            setActionOutput(actiondown[Convert.ToInt32(((PictureBox)sender).Tag)], Convert.ToInt32(((PictureBox)sender).Tag) + 1);
            actionButtonPressed = true;
            if (actiondown[Convert.ToInt32(((PictureBox)sender).Tag)])
                ((PictureBox)sender).Image = imageList1.Images[1];
            else
                ((PictureBox)sender).Image = imageList1.Images[0];
        }
        private void pBAction1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!CB_Toggling.Checked)
            {
                actiondown[Convert.ToInt32(((PictureBox)sender).Tag)] = false;
                actionButtonPressed = true;
                setActionOutput(actiondown[Convert.ToInt32(((PictureBox)sender).Tag)], Convert.ToInt32(((PictureBox)sender).Tag) + 1);
            }
               
            if (actiondown[Convert.ToInt32(((PictureBox)sender).Tag)])
                ((PictureBox)sender).Image = imageList1.Images[1];
                else
                ((PictureBox)sender).Image = imageList1.Images[0];


        }


       
        private void button3_Click(object sender, EventArgs e)
        {

            DevKey.CreateSubKey(SaveName.Text).SetValue("Port", SavePort.SelectedItem.ToString());
            //Port
            for (int i = 0; i < ABNames.Count(); i++)
            {
                DevKey.CreateSubKey(SaveName.Text).SetValue("BTNName"+i,ABNames[i]); 
            }
            DevKey.CreateSubKey(SaveName.Text).SetValue("BTNName", ABNames.Count());

            for (int i = 0; i < Buttons.Count(); i++)
            {
                DevKey.CreateSubKey(SaveName.Text).SetValue("BTNToggle" + i, (bool)Buttons[i].toggle);
                DevKey.CreateSubKey(SaveName.Text).SetValue("BTNDown" + i, (bool)Buttons[i].down);
            }
            DevKey.CreateSubKey(SaveName.Text).SetValue("BTNToggle", Buttons.Count());
            DevKey.CreateSubKey(SaveName.Text).SetValue("Port", SavePort.SelectedItem.ToString());
           LoadDevices();


        }
        private void DoLoad(string NXTName)
        {
            for (int i = 0; i < (int) DevKey.CreateSubKey(NXTName).GetValue("BTNName", -1); i++)
            {
                ABNames[i] = (string)DevKey.CreateSubKey(NXTName).GetValue("BTNName" + i);
            }
            ;

            for (int i = 0; i < (int) DevKey.CreateSubKey(NXTName).GetValue("BTNToggle", -1); i++)
            {
                Buttons[i].toggle = ((string)(DevKey.CreateSubKey(NXTName).GetValue("BTNToggle" + i))).ToUpper() == "TRUE";
                Buttons[i].down = ((string)(DevKey.CreateSubKey(NXTName).GetValue("BTNDown" + i))).ToUpper() == "TRUE";
            }
            RedrawBTNAry();   

            // Loads the Port for NXTName from the Registry and sets the ComboboxPorts Name to Point to it
            SavePort.Text = (string)DevKey.CreateSubKey(NXTName).GetValue("Port");
            SaveName.Text = NXTName;
            comboBoxComports.Text = SavePort.Text;
            //Save the last used NXT
            SettingsKey.SetValue("LastNXT", NXTName);  
        
        }
        private void SaveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoLoad((string)SaveList.SelectedItem);
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DevKey.DeleteValue((string) SaveList.SelectedItem);
            LoadDevices();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (ButtonArraySetup)
            {
                Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle= ! (Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle);
               if  (Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle)
                  ((PictureBox)sender).Image = imageList1.Images[1];
              else 
                  ((PictureBox)sender).Image = imageList1.Images[0];


            }
            else
            {
                actionButtonPressed=true;
                if (Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle)
                {
                    Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].down = !Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].down;

                }
                else
                Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].down = true;
                if (Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].down)
                    ((PictureBox)sender).Image = imageList1.Images[1];
                else
                    ((PictureBox)sender).Image = imageList1.Images[0];
                
            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle)
            {

                Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].down = false;
                ((PictureBox)sender).Image = imageList1.Images[0];
                actionButtonPressed=true;
            }
        }


        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            
            ButtonArraySetup = ((CheckBox)sender).Checked;
            RedrawBTNAry();

        }
        void RedrawBTNAry()
        {
            foreach (Control C in AryBtnPage.Controls)
            {
                if (C is PictureBox)
                    if (C.Name != "bgr")
                        if (ButtonArraySetup)
                            if (Buttons[Convert.ToInt32(((PictureBox)C).Tag)].toggle)
                                ((PictureBox)C).Image = imageList1.Images[1];
                            else
                                ((PictureBox)C).Image = imageList1.Images[0];
                        else
                            if (Buttons[Convert.ToInt32(((PictureBox)C).Tag)].down)
                                ((PictureBox)C).Image = imageList1.Images[1];
                            else
                                ((PictureBox)C).Image = imageList1.Images[0];
   if (C is TextBox)
       ((TextBox)C).Text=ABNames[Convert.ToInt32( ((TextBox)C).Tag)];

            }
        }


        private void checkBox2_CheckStateChanged_1(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.WindowState =
                FormWindowState.Maximized;
                this.Menu = null;

            }
            else
            {
                this.WindowState =
                    FormWindowState.Normal;
                this.Menu = mainMenu1;
            }
        }

        private void pad_MouseDown(object sender, MouseEventArgs e)
        {
            updatePad(e.X, e.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ABNames[Convert.ToInt32(((TextBox)sender).Tag)] = ((TextBox)sender).Text;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void StartPrgrBtn_Click(object sender, EventArgs e)
        {
/*            int j = 0;
            foreach (char ch in NXTString.ToCharArray())
            {
                Command[j] = (byte)ch;
                j++;
            }
            byte[] Command = { 0x80, 0x09, 0x00, (byte)(NXTString.Length + 1) };
            Send(Commmand);*/
        }

    

        
       
    }
}