using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Forms;


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
        public struct InMessage
        {
            public DateTime time;
            public string message;
            public byte flags;

        }
        public Com NXT = new Com();
        //for btn Array
        public bool ButtonArraySetup = false;
        AryButton[] Buttons = new AryButton[12];
        string[] ABNames = new string[6];
        bool changed = false;
        bool enablesend = true;
        bool send0whenreleased = true;
        bool loading = false;
        //for Actionbtns
        private bool[] actiondown=new bool[4];
        public bool[] actiontoggle = {false,false,false,false};//false= no toggeling
        private int newx=0, newy=0, oldx = 0, oldy = 0, actionInt = 0;
        private bool actionButtonPressed = false;
        private char[] action = {'0','0','0','0'}; //legacy array for storing which action button was pressed
        int angle = 0;
        int V1,V2,V3;
   
        //private bool dialogvisible  = false;
        //for saving
        //2 Keys, one to Store the DEVices and their matching Com port, one to store general settings
        RegistryKey DevKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\NXTPad\\Devices");
        RegistryKey SettingsKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\NXTPad");
        
        private void LoadDevices()
        {
           //Clears the Displayed list and rebuild it using the Registry
            ProfileCombobox.Items.Clear();
            foreach (string i in DevKey.GetSubKeyNames())
            {
                ProfileCombobox.Items.Add(i);
            }

            
        }
        private void Setup(object sender, EventArgs e)
        {
            
            NXT._OnBattery += new Com.IntegerHandler(OnBattery);
            NXT._OnError += new Com.StringHandler(OnError);
            NXT._OnFindFirst += new Com.StringHandler(OnFindFirst);
            NXT._OnFindNext += new Com.StringHandler(OnFindSth);
            NXT._OnInputData += new Com.InputHandler(OnInputData);
            NXT._OnMailBox += new Com.MailboxHandler(OnMailBox);
            NXT._OnOutputData += new Com.OutputHandler(OnOutput);

            ReleaseBehavior.SelectedIndex = 0;
            LoadDevices();
            comboBoxComports.SelectedIndex = 1; //my default setting: COM1
            NXT.Close();
            
            //serialPort1.Close();//just to   be sure.
            //serialPort1.PortName = "COM1";//my default
            
            //if LastNXT is saved, load it and goto save page
          string NXTName=(string) SettingsKey.GetValue("LastNXT","");
          if (NXTName != "")
            {

                DoLoad((string)NXTName);
            }

          /*
           * foreach (Control C in AryBtnPage.Controls)
              if (C is PictureBox)
                  if (C.Name!="bgr")
                  ((PictureBox)C).Image = imageList1.Images[0];
           * */
          for (int i = 0; i < ABNames.Count(); i++)
          {
              ABNames[i] = "";
          }

              

          pBR1B1.Image = ButtonImgList.Images[0];
          pBR1B2.Image = ButtonImgList.Images[0];
          pBR1B3.Image = ButtonImgList.Images[0];
          pBR1B4.Image = ButtonImgList.Images[0];

          DrawNavBtn(1);
        }
        private void DrawNavBtn(int active)
        {
           NavImg1.Image= NavImgList.Images[0];//Control
           NavImg2.Image = NavImgList.Images[1];//Settings
           NavImg3.Image = NavImgList.Images[2];//Programs
           NavImg4.Image = NavImgList.Images[3];//Stop
           if (active==1)
           {
               NavImg1.Image = NavImgList.Images[4]; 
           }
           if (active == 2)
           {
               NavImg2.Image = NavImgList.Images[5];
           }
           if (active == 3)
           {
               NavImg3.Image = NavImgList.Images[6];
           }
           if (active == 4)
           {
               NavImg4.Image = NavImgList.Images[7];
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   try
            {
                byte[] data = { 0x06, 0x00, 0x80, 0x03, 0xff, 0x01, 0xff, 0x00 };
                serialPort1.Write(data, 0, 8);
            }
            catch
            {
                MessageBox.Show("Error sending beep command");
            }*/

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
            if (outX>100) {
                outX = 100;}
            if (outX<-100) {
                outX = -100; }
            if (outY>100) { 
                outY = 100; }
            if (outY<-100) { 
                outY = -100; }


            //calculate values for direct use in NXT-G Motor blocks
            /*The idea is this:
            atan2(y,x) gives me the angle between the positive x axis and a line to (x,y). (x and y axis should be pointing up and right)
            so a full left steer, say (y=0,x=-100) should give an angle of Pi radians.
            straight ahead (y=100,x=0) should give Pi/2 radians
            left (y=0,x=100) gives 0 radians etc...
            

            In my code, I switched x and y. The mixup gives the formula a neat 90 degrees twist, zeroing around the forward axis.


            Therefore:
            left steer = -Pi/2
            forward = 0
            right = Pi/2


            Now to map this range to (-100,100) I divide it by Pi and multiply it by 200.
            */


            int steer = (int) Math.Round(Math.Atan2(outX, outY) * 200 / Math.PI);
            int pwr = (int) Math.Round(Math.Sqrt(Math.Pow(outX, 2) + Math.Pow(outY, 2)));

            //Fix to limit value to -100/+100
            if (pwr > 100)
                pwr = 100;
            if (pwr < -100)
                pwr = -100;

            int direction = 0;
            if (outY >= 0) { direction = 1; }

            if (steer > 100) {
                steer = map(steer, 100, 200, 100, 0); 
            }
            if (steer < -100) {
                steer = map(steer, -100, -200, -100, 0); 
            }
            
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
            byte[] CommandHeader = { 0x80, 0x09, 0x00, (byte)(NXTString.Length + 1) }; //
               
            
            int j = 4;//6 //start writing the string to the byte array on the 7th byte
            foreach (char ch in NXTString.ToCharArray())
            {
                Command[j] = (byte)ch;
                j++;
            }
            
            //putting it all together
            System.Buffer.BlockCopy(CommandHeader, 0, Command, 0, CommandHeader.Length);
            
            NXT.Send(Command);

         

                 
         }
       

        private string nfs(int nr) //create a 4-character string of any number. first character is sign.
        {
            string rtrn = nr.ToString("000");
            if (nr >= 0) { rtrn = "+" + rtrn; }
            return rtrn;
        }

               

        private void openBtnClick(object sender, EventArgs e)
        {
            enablesend = false;
            NXT.Close();
            NXT.SetPort( comboBoxComports.Text.ToString());
            if (NXT.Open())

            {
//                pBled.Visible = true;
                enablesend = true;
            }
            else
            {
                MessageBox.Show("Error opening ComPort");
                //pBled.Visible = false;
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
            NXT.Close();
        }

        private void pBBackground_MouseUp(object sender, MouseEventArgs e)
        {
            actionButtonPressed = true;
            
        }



        private void pad_MouseUp(object sender, MouseEventArgs e)
        {
            if (send0whenreleased) { newx = 0; newy = 0; }
        }
      
        private void pBAction1_MouseDown(object sender, MouseEventArgs e)
        {
            int ButtonNr=Convert.ToInt32(((PictureBox)sender).Tag);
            
            if (actiontoggle[ButtonNr])

                actiondown[ButtonNr] = !actiondown[ButtonNr];
            else
                actiondown[ButtonNr] = true;

            setActionOutput(actiondown[ButtonNr], ButtonNr + 1);
            actionButtonPressed = true;
            if (actiondown[ButtonNr])
                ((PictureBox)sender).Image = ButtonImgList.Images[1];
            else
                ((PictureBox)sender).Image = ButtonImgList.Images[0];
        }


        private void pBAction1_MouseUp(object sender, MouseEventArgs e)
        {
            int ButtonNr = Convert.ToInt32(((PictureBox)sender).Tag);
            
            if (!actiontoggle[ButtonNr])
            {
                actiondown[ButtonNr] = false;
                actionButtonPressed = true;
                setActionOutput(actiondown[ButtonNr], ButtonNr + 1);
            }
               
            if (actiondown[ButtonNr])
                ((PictureBox)sender).Image = ButtonImgList.Images[1];
                else
                ((PictureBox)sender).Image = ButtonImgList.Images[0];


        }
        void AskSave()
        {
            if (changed)
            {
               DialogResult DR= MessageBox.Show("Data has not been saved yet. Do now? You'll lose latest changes else.", "Not saved yet.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
               if (DR == DialogResult.Yes)
               {
                   DoSave();
               }

            }
        }
        void DoSave()
        {
            //Save
            //First saving crashes app (maybe first loading)
            string Savename = SaveText.Text;
                // ProfileCombobox.Text;

            RegistryKey SaveRegistryKey = DevKey.CreateSubKey(Savename);
            SaveRegistryKey.SetValue("Port", comboBoxComports.Text);
            //Port

            for (int i = 0; i < 3; i++)
            {
                SaveRegistryKey.SetValue("MainBTNToggle" + i, (bool)actiontoggle[i]);
            }




            for (int i = 0; i < ABNames.Count(); i++)
            {
                SaveRegistryKey.SetValue("BTNName" + i, ABNames[i]);
            }
            SaveRegistryKey.SetValue("BTNName", ABNames.Count());

            for (int i = 0; i < Buttons.Count(); i++)
            {
                SaveRegistryKey.SetValue("BTNToggle" + i, (bool)Buttons[i].toggle);
                SaveRegistryKey.SetValue("BTNDown" + i, (bool)Buttons[i].down);
            }
            SaveRegistryKey.SetValue("BTNToggle", Buttons.Count());
            SaveRegistryKey.SetValue("Port", comboBoxComports.SelectedItem.ToString());
            SaveRegistryKey.SetValue("ProgName", FileSelector.Text);
            SaveRegistryKey.SetValue("ReleaseBehavior", ReleaseBehavior.SelectedIndex);
            
            LoadDevices();
            changed = false;
            SaveRegistryKey.Close();

        }
       

        private void DoLoad(string NXTName)
        {
            loading = true;
             RegistryKey SaveRegistryKey = DevKey.CreateSubKey(NXTName);
            //The four "classic" buttons
            for (int i = 0; i < 3; i++)
            {
                actiontoggle[i]=((string)(SaveRegistryKey.GetValue("MainBTNToggle" + i,"false"))).ToUpper() == "TRUE";
                ToggleSetup.Items[i].Checked = actiontoggle[i];
            }


            //new button array
            for (int i = 0; i < (int) SaveRegistryKey.GetValue("BTNName", -1); i++)
            {
                ABNames[i] = (string)SaveRegistryKey.GetValue("BTNName" + i);
            }
            ;

            for (int i = 0; i < (int) SaveRegistryKey.GetValue("BTNToggle", -1); i++)
            {
                Buttons[i].toggle = ((string)(SaveRegistryKey.GetValue("BTNToggle" + i))).ToUpper() == "TRUE";
                Buttons[i].down = ((string)(SaveRegistryKey.GetValue("BTNDown" + i))).ToUpper() == "TRUE";
            }
            RedrawBTNAry();   

            // Loads the Port for NXTName from the Registry and sets the ComboboxPorts Name to Point to it
            comboBoxComports.Text = (string)SaveRegistryKey.GetValue("Port","COM1");
            ProfileCombobox.Text = NXTName;
  
            SaveText.Text = NXTName;
           ReleaseBehavior.SelectedIndex = (int)SaveRegistryKey.GetValue("ReleaseBehavior",0);
           
            FileSelector.Text= (string)SaveRegistryKey.GetValue("ProgName","");
    
            //Save the last used NXT
            SettingsKey.SetValue("LastNXT", NXTName);

            loading = false;
            changed = false;
            SaveRegistryKey.Close();
        }
        
       
        private void SaveList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //ButtonArray
            if (ButtonArraySetup)
            {
                Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle= ! (Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle);
               if  (Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle)
                  ((PictureBox)sender).Image = ButtonImgList.Images[1];
              else 
                  ((PictureBox)sender).Image = ButtonImgList.Images[0];
               changed = true;

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
                    ((PictureBox)sender).Image = ButtonImgList.Images[1];
                else
                    ((PictureBox)sender).Image = ButtonImgList.Images[0];
                
            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //ButtonArray
            if (!Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].toggle)
            {

                Buttons[Convert.ToInt32(((PictureBox)sender).Tag)].down = false;
                ((PictureBox)sender).Image = ButtonImgList.Images[0];
                actionButtonPressed=true;
            }
        }


        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            ////ButtonArray
            ButtonArraySetup = ((CheckBox)sender).Checked;
            RedrawBTNAry();

        }
        void RedrawBTNAry()
        {
            //ButtonArray
           /* foreach (Control C in AryBtnPage.Controls)
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

            }*/
        }


        private void checkBox2_CheckStateChanged_1(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.WindowState =
                FormWindowState.Maximized;
               // MessageLabel.Visible = true;

            }
            else
            {
                this.WindowState =
                    FormWindowState.Normal;
            
              //  MessageLabel.Visible = false;
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



        private void button3_Click_1(object sender, EventArgs e)
        {
            NXT.GetBatteryLevel();

        }


        public delegate void MethodInvoker();
        private delegate void InvokeStr(string text);
        private delegate void InvokeInt(int i);

        private void OnMailBox(object sender, MailboxMessageEventArgs e)
        {
            //DisplayMessage(ParseMessage(Text));
           
        }
        private void OnInputData(object sender, InputValuesEventArgs e)
        {
            DebugTextBox.Invoke(new InvokeStr(logtext), e.ScaleData.ToString());
        }
        private void OnFindFirst(object sender, StringEventArgs e)
        {
            FileSelector.Invoke(new InvokeStr(ClearFileListAndAdd), e.Text);
        }
        private void OnFindSth(object sender, StringEventArgs e)
        {
            FileSelector.Invoke(new InvokeStr(AddFileToList), e.Text);
        }
        private void OnBattery(object sender, IntegerEventArgs e)
        {
            //textBox7.Invoke(new InvokeInt(NewBatteryData), e.Value);
        }
        private void OnError(object sender, StringEventArgs e)
        {
            DoLogText(e.Text);
            
        }
        private void OnOutput(object sender, OutputValuesEventArgs e)
        {
            int v=Convert.ToInt32( e.RotatationCount);
            if (e.Port == 0) V1 = v;
            if (e.Port == 1) V2 = v;
            if (e.Port == 2) V3 = v;
            NXT.GetMotorValues(e.Port);

        }

                    
//Just for the NXT->PPC Messagingstuff (inactive atm to keep it simple)
InMessage ParseMessage(string Text)
{
    InMessage tmp=new InMessage();
    tmp.flags = 0;

    if (!(Text == ""))    {
       
           tmp.time = DateTime.Now;
        tmp.flags = Convert.ToByte (Text.Substring(0,2));
        tmp.message = Text.Substring(3, Text.Length - 3);
       
       
    }


    return tmp;
  
    }
[DllImport("CoreDll.dll")]
public static extern void MessageBeep(int code); 

void DisplayMessage(InMessage Message)
{
    
    if ((Message.flags & 8) == 8)
    {
        MessageBeep(-1);

    }
    if ((Message.flags & 1)==1)
    {
        DoSetMessage(Message.message);
     
    }

    if ((Message.flags & 2) == 2)
    {
        DoLogText(Message.message);

    }
    if ((Message.flags & 4)==4)
    {
        MessageBox.Show(Message.message);

    }  

}






void DoLogText(string Text)
{
    DebugTextBox.Invoke(new InvokeStr(logtext), Text);
}
    private void logtext(string s)
    {
        if (!(s==""))
        DebugTextBox.Text = DebugTextBox.Text + s +  Environment.NewLine;
      
    }

    void DoSetMessage(string Text)
    {
//        if (MessageLabel.InvokeRequired)
            //MessageLabel.Invoke(new InvokeStr(setmessagelabel), Text);
        //else
            //setmessagelabel(Text);
    }
        private void setmessagelabel(string s)
    {
     //   if (!(s == ""))
    //        MessageLabel.Text = s;

    }
    void SetText(string text)
    {
        DebugTextBox.Text = text;
    }

    void NewBatteryData(int Voltage)
    {
        DebugTextBox.Text = Voltage.ToString()+" mV";
    }
 

    private void AddFileToList(string s)
    {
        ListViewItem I =new ListViewItem(s);
        I.ImageIndex=0;
        FileSelector.Items.Add(I);
        
    }
    private void ClearFileListAndAdd(string s)
    {
        FileSelector.Items.Clear();
        FileSelector.Items.Add(new ListViewItem(s));
    }




        private void GetFileList_Click(object sender, EventArgs e)
        {
            
        }


        private void StartProgram_Click(object sender, EventArgs e)
        {
            
            
        }


        private void StopProgramBtn_Click(object sender, EventArgs e)
        {
            
        }
        bool switchitem(MenuItem Item)
        {
            Item.Checked = !Item.Checked;
            return Item.Checked;
        }

      
     
 
        private void button3_Click_2(object sender, EventArgs e)
        {
            //NXT.GetSensorValues( Convert.ToByte(textBox7.Text));

        }

    
        private void menuItem7_Click(object sender, EventArgs e)
        {

            AskSave();
            NXT.Close();
            Application.Exit();
         
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void SavePort_TextChanged(object sender, EventArgs e)
        {
            //Event fires even if text is changed trough the programm
            changed = true;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            NXT.Stop();
        }
 

        private void AnswerCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
         //   btQuery.Enabled=((CheckBox) sender).Checked;
        }

        private void btQuery_Tick(object sender, EventArgs e)
        {
            /*if (enablesend)
            {
                NXT.MessageRead(0x01, 1, true);
            }*/
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            NXT.Test();
            
            
            
            
        }

        private void pBAction2_Click(object sender, EventArgs e)
        {

        }

        private void pBAction1_Click(object sender, EventArgs e)
        {

        }

        private void pBBackground_Click(object sender, EventArgs e)
        {

        }

        private void pBAction3_Click(object sender, EventArgs e)
        {

        }

        private void pBAction4_Click(object sender, EventArgs e)
        {

        }

        private void FilesPage_GotFocus(object sender, EventArgs e)
        {
            
        }

        private void FileSelector_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            NXT.Run(FileSelector.FocusedItem.Text);

            DrawNavBtn(1);
            TabController.SelectedIndex = 0;
            
        }

        private void FileSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void contextMenu1_Popup(object sender, EventArgs e)
        {

        }

        private void SaveProf_Click(object sender, EventArgs e)
        {
            DoSave();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            string keyname = (string)ProfileCombobox.SelectedItem;
            RegistryKey DK = Registry.CurrentUser.OpenSubKey("SOFTWARE\\NXTPad\\Devices",true);
            DK.DeleteSubKey(keyname);
            DK.Close();
            LoadDevices();
        }

        private void ProfileCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //how to seperate between user and program?
            if (!loading)
            {
                AskSave();
                DoLoad((string)ProfileCombobox.SelectedItem);
            }
        }

        private void panel1_GotFocus(object sender, EventArgs e)
        {

        }

        private void NavImg1_Click(object sender, EventArgs e)
        {
            DrawNavBtn(1);
            TabController.SelectedIndex = 0;
        }

        private void NavImg2_Click(object sender, EventArgs e)
        {
            DrawNavBtn(2);
            TabController.SelectedIndex = 1;

        }   
        private void NavImg3_Click(object sender, EventArgs e)
        {
            DrawNavBtn(3);
            NXT.FindFirst("*.rxe");
            TabController.SelectedIndex = 2;
        }

        private void NavImg4_Click(object sender, EventArgs e)
        {
            NXT.Stop();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            changed = true;
            actiontoggle[e.Index] = !ToggleSetup.Items[e.Index].Checked;

        }

        private void TestBtn1_Click(object sender, EventArgs e)
        {

        }

        private void ReleaseBehavior_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed = true;
            send0whenreleased = ReleaseBehavior.SelectedIndex==0;
        }

        void DrawNeedle(int centerX, int centerY, int radius, double angle)
        {
            Graphics g = Dashboard.CreateGraphics();
            Pen p = new Pen(Color.Red, 2);
            int pointX = centerX + Convert.ToInt32(Math.Cos(2 * Math.PI / 360 * angle) * radius);
            int pointY = centerY + Convert.ToInt32(Math.Sin(2 * Math.PI / 360 * angle) * radius);
            g.DrawLine(p, centerX, centerY, pointX,pointY);
            g.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            NXT.GetMotorValues(0);
            timer1.Enabled = true;

            
        }
        
        void DrawSpeedDashboard(int v1, int v2, int v3)
        {
            Graphics g = Dashboard.CreateGraphics();
            g.DrawImage(DashboardList.Images[0], 0, 0);
            g.Dispose();
            //DrawNeedle(32, 40, 25, angle);//angle=210-360
            DrawNeedle(31, 35, 25, (double)(210+v1*1.5));
            DrawNeedle(96, 35, 25, 210 + v2 * 1.5);
            DrawNeedle(160, 35, 25, 210 + v3 * 1.5);
            
        }
        



        private void timer1_Tick(object sender, EventArgs e)
        {
//            DrawSpeedDashboard(V1, V2, V3);
            
        DrawSpeedDashboard(angle, angle, angle);

        angle = angle + 10;
        if (angle > 100) angle = 0;
      

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrawNavBtn(-1);
            TabController.SelectedIndex = 3;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string s = NxtPad.Properties.Resources.HelpHTML;
            helpbrowser.DocumentText = s;
        }

        private void helpbrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
           
        }



 



        
       
    }
}