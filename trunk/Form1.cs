using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        //for btn Array
        public bool ButtonArraySetup = false;
        AryButton[] Buttons = new AryButton[12];
        string[] ABNames = new string[6];
        bool changed = false;
        bool enablesend = true;
        //for Actionbtns
        private bool[] actiondown=new bool[4];
        private int newx=0, newy=0, oldx = 0, oldy = 0, actionInt = 0;
        private bool actionButtonPressed = false;
        private char[] action = {'0','0','0','0'}; //legacy array for storing which action button was pressed
        int beeppos = 0;
   
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
            }

          foreach (Control C in AryBtnPage.Controls)
              if (C is PictureBox)
                  if (C.Name!="bgr")
                  ((PictureBox)C).Image = imageList1.Images[0];
          for (int i = 0; i < ABNames.Count(); i++)
          {
              ABNames[i] = "";
          }

              

          pBAction1.Image = imageList1.Images[0];
          pBAction2.Image = imageList1.Images[0];
          pBAction3.Image = imageList1.Images[0];
          pBAction4.Image = imageList1.Images[0];
          DoLoadPages();
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
              //  pBled.Visible = true;
                //Need Invoke
                
                try
                {
                    while (serialPort1.BytesToWrite != 0) ;
                    //while (serialPort1.BytesToRead != 0) ;
                    int a = serialPort1.BytesToWrite;
                    int b = serialPort1.BytesToRead;
                    if (a!= 0) 
                        MessageBox.Show(String.Concat("Nicht leer W", a.ToString()));
                    //if (b!= 0)
                        //MessageBox.Show(String.Concat("Nicht leer R", b.ToString()));
                   
                    serialPort1.Write(All, 0, All.Length);
                  
                }
                catch
                {
                    MessageBox.Show("Error while sending");
                    serialPort1.Close();
                }

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
            enablesend = false;
            serialPort1.Close();
            //serialPort1.PortName = comboBoxComports.SelectedItem.ToString();
            serialPort1.PortName = comboBoxComports.Text.ToString();
            try
            {
                serialPort1.Open();
                pBled.Visible = true;
                SendWelcomeBeep();
                enablesend = true;
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
            DevKey.CreateSubKey(SaveName.Text).SetValue("Port", SavePort.SelectedItem.ToString());
            //Port

            for (int i = 0; i < ABNames.Count(); i++)
            {
                DevKey.CreateSubKey(SaveName.Text).SetValue("BTNName" + i, ABNames[i]);
            }
            DevKey.CreateSubKey(SaveName.Text).SetValue("BTNName", ABNames.Count());

            for (int i = 0; i < Buttons.Count(); i++)
            {
                DevKey.CreateSubKey(SaveName.Text).SetValue("BTNToggle" + i, (bool)Buttons[i].toggle);
                DevKey.CreateSubKey(SaveName.Text).SetValue("BTNDown" + i, (bool)Buttons[i].down);
            }
            DevKey.CreateSubKey(SaveName.Text).SetValue("BTNToggle", Buttons.Count());
            DevKey.CreateSubKey(SaveName.Text).SetValue("Port", SavePort.SelectedItem.ToString());
            DevKey.CreateSubKey(SaveName.Text).SetValue("ProgName", FileSelector.Text);

            
            LoadDevices();
            changed = false;


        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            DoSave();


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
            FileSelector.Text= (string)DevKey.CreateSubKey(NXTName).GetValue("ProgName");
            //Doesen't work as expected
            //Save the last used NXT
            SettingsKey.SetValue("LastNXT", NXTName);

       
            changed = false;
        }
        
       void getinfo(string regname, MenuItem Item, TabPage page, RegistryKey TabKey)
    {
           bool showit= (int) TabKey.GetValue(regname, 1)==1;
           Item.Checked = showit;
           SwitchTabPage(page, showit);


    }
       void setinfo(string regname, MenuItem Item, RegistryKey TabKey)
       {
           bool showit = Item.Checked;
           if (showit)
               TabKey.SetValue(regname, 1);
           else
               TabKey.SetValue(regname, 0);


       }
        private void DoLoadPages()
     
        {
            RegistryKey TabKey = SettingsKey.CreateSubKey("Pages");

            getinfo("control",showcontrol,ControlPage,TabKey);
            getinfo("settings", showsettings, SettingsPage, TabKey);
            getinfo("NXTs", shownxts, NXTsPage, TabKey);
            getinfo("files", showfiles, FilesPage, TabKey);
            getinfo("buttons", showbuttons, AryBtnPage, TabKey);
            getinfo("debug", showdebug, DebugPage, TabKey);
            getinfo("sensors", showsensors,SensorPage, TabKey);


        }
        private void DoSavePages()
        {
            RegistryKey TabKey = SettingsKey.CreateSubKey("Pages");

            setinfo("control", showcontrol, TabKey);
            setinfo("settings", showsettings, TabKey);
            setinfo("NXTs", shownxts,  TabKey);
            setinfo("files", showfiles,  TabKey);
            setinfo("buttons", showbuttons,  TabKey);
            setinfo("debug", showdebug,  TabKey);
            setinfo("sensors", showsensors, TabKey);



        }
        private void SaveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskSave();
            DoLoad((string)SaveList.SelectedItem);
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DevKey.DeleteSubKeyTree((string) SaveList.SelectedItem);
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
                MessageLabel.Visible = true;

            }
            else
            {
                this.WindowState =
                    FormWindowState.Normal;
                this.Menu = mainMenu1;
                MessageLabel.Visible = false;
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
            GetBatteryLevel();

        }


        public delegate void MethodInvoker();
        private delegate void InvokeStr(string text);
        private delegate void InvokeInt(int i);


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] Data = new byte[serialPort1.ReadBufferSize];

            serialPort1.Read(Data, 0, serialPort1.ReadBufferSize);

            if ((Data[2] == 02) && (Data[3] == 0x0B))//GETBATTERYLEVEL Answer
            {//80 23
           //     textBox7.Invoke(new InvokeInt(NewBatteryData), Data[5] + Data[6]*256);
            }
            if ((Data[2] == 02) && (Data[3] == 0x86))//Find First
            {
                byte ErrorCode = Data[4];
                byte Handle = Data[5];
                string Filename;
                Filename = "";
                for (int j = 0; j < 19; j++)
                {
                    Filename = Filename + (char)Data[6 + j];
                }
                if (ErrorCode == 0)
                {
                    FileSelector.Invoke(new InvokeStr(AddFileToList), Filename);
                    FindNext(Handle);
                }
                else
                    DoLogText("error");
                

            }
            if ((Data[2] == 02) && (Data[3] == 0x87))//Find Next
            {
                byte ErrorCode = Data[4];
                byte Handle = Data[5];
                string Filename;
                Filename = "";
                for (int j = 0; j < 18; j++)
                {
                    Filename = Filename + (char)Data[6 + j];
                }

                if (ErrorCode == 0)
                {
                    FindNext(Handle);
                    FileSelector.Invoke(new InvokeStr(AddFileToList), Filename);
                }
                else
                {
                    DoLogText("error");
                    enablesend = true;
                }


            }
            if ((Data[2] == 02) && (Data[3] == 0x07))//GetInputValues
            {
                byte ErrorCode = Data[4];
                byte Port = Data[5];
                byte DataValid = Data[6];
                byte DataCalib = Data[7];
                byte SensorType = Data[8];
                byte SensorMode = Data[9];

                
                UInt16 Raw = BitConverter.ToUInt16(Data, 10);

                UInt16 NormData = BitConverter.ToUInt16(Data, 12);

                Int16 ScaleData = BitConverter.ToInt16(Data, 14);
                DebugTextBox.Invoke(new InvokeStr(logtext), ScaleData.ToString());
    
            
            }
            if ((Data[2] == 02) && (Data[3] == 0x13))//ReadMessage
            {
                byte Status = Data[4];
                byte LocalMailBoxNr = Data[5];
                byte Size = Data[6];
               

                string Text;
                Text = "";
                for (int j = 0; j < (Size-1); j++)
                {
                    Text = Text + (char)Data[7 + j];
                }
              
                DisplayMessage(ParseMessage(Text));
            }


                

        }

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




void HideTabPage(TabPage page) 
    {

        if (TabController.TabPages.Contains(page))
            TabController.TabPages.RemoveAt(
                TabController.TabPages.IndexOf(page));
            
    }



void ShowTabPage(TabPage page)
    {

if (! TabController.TabPages.Contains(page))
TabController.TabPages.Add(page);
    }
void SwitchTabPage(TabPage page, bool mode)
{
    if (mode)
        ShowTabPage(page);
    else
        HideTabPage(page);

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
        if (MessageLabel.InvokeRequired)
            MessageLabel.Invoke(new InvokeStr(setmessagelabel), Text);
        else
            setmessagelabel(Text);
    }
        private void setmessagelabel(string s)
    {
        if (!(s == ""))
            MessageLabel.Text = s;

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
        FileSelector.Items.Add((string) s);
    }
    void GetBatteryLevel()
    {
        byte[] Command = { 0x00, 0x0B };
        Send(Command);
    }





    void FindFirst(string Filter)
    {
        enablesend = false;
        byte[] Command = new byte[21];

        Command[0] = 0x01;
        Command[1] = 0x86;

        int j = 2;//6 //start writing the string to the byte array on the 7th byte
        foreach (char ch in Filter.ToCharArray())
        {

            Command[j] = (byte)ch;
            j++;
        }
        Send(Command);

    }
    void FindNext(byte OldHandle)
        {


            byte[] Command = new byte[3];

            Command[0] = 0x01;
            Command[1] = 0x87;
            Command[2] = OldHandle;

            Send(Command);

        }


        void SendBeep(UInt16 freq,UInt16 duration)
        {


            byte[] Command = new byte[6];

            Command[0] = 0x80;
            Command[1] = 0x03;
            Command[2] = (byte)(freq & 0xff);
            Command[3] = (byte)(freq >> 8);
            Command[4] = (byte)(duration & 0xff);
            Command[5] = (byte)(duration >> 8);
            Send(Command);

        }
    void MessageRead(byte Remotebox, byte Localbox, bool remove)
    {


        byte[] Command = new byte[5];

        Command[0] = 0x00;
        Command[1] = 0x13;
        Command[2] = Remotebox;
        Command[3] = Localbox;
        if (remove)
            Command[4] = 0x01;
        else
            Command[4] = 0x00;


        Send(Command);

    }
    void Run(string Filter)
    {

        byte[] Command = new byte[21];

        Command[0] = 0x00;
        Command[1] = 0x00;


        int j = 2;//6 //start writing the string to the byte array on the 7th byte
        foreach (char ch in Filter.ToCharArray())
        {

            Command[j] = (byte)ch;
            j++;
        }
        Send(Command);

    }
    void Stop()
    {

        byte[] Command = new byte[2];

        Command[0] = 0x00;
        Command[1] = 0x01;


        Send(Command);

    }


        private void GetFileList_Click(object sender, EventArgs e)
        {
            FindFirst("*.rxe");
        }


        private void StartProgram_Click(object sender, EventArgs e)
        {
            Run(FileSelector.Text);

        }


        private void StopProgramBtn_Click(object sender, EventArgs e)
        {
            Stop();
        }
        bool switchitem(MenuItem Item)
        {
            Item.Checked = !Item.Checked;
            return Item.Checked;
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            //control
            SwitchTabPage(ControlPage, switchitem((MenuItem)sender));
            DoSavePages();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            //settinga
            SwitchTabPage(SettingsPage,switchitem((MenuItem)sender));
            DoSavePages();
        }




        private void shownxts_Click(object sender, EventArgs e)
        {
            //NXTs
            SwitchTabPage(NXTsPage,switchitem((MenuItem)sender));
            DoSavePages();
    
        }



        private void showfiles_Click(object sender, EventArgs e)
        {
            //Files
            SwitchTabPage(FilesPage, switchitem((MenuItem)sender));
            DoSavePages();
        }

        private void showdebug_Click(object sender, EventArgs e)
        {
            //Debug
            SwitchTabPage(DebugPage, switchitem((MenuItem)sender));
            DoSavePages();
        }

        private void showbuttons_Click(object sender, EventArgs e)
        {
            //buttons
            SwitchTabPage(AryBtnPage, switchitem((MenuItem)sender));
            DoSavePages();
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
          
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            byte[] Command = new byte[3];

            Command[0] = 0x00;
            Command[1] = 0x07;
            Command[2] = Convert.ToByte(textBox7.Text);


            Send(Command);

        }

        private void showSensors_Click(object sender, EventArgs e)
        {
            //buttons
            SwitchTabPage(SensorPage, switchitem((MenuItem)sender));
            DoSavePages();

        }

        private void menuItem7_Click(object sender, EventArgs e)
        {

            AskSave();
            serialPort1.Close();
            Application.Exit();
         
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void SavePort_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Stop();
        }
        void SendWelcomeBeep()
        {
            beeppos = 0;
            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            byte time = 200;
        if (beeppos==0)
            SendBeep(780, time);//N
        if (beeppos == 1)
            SendBeep(880, time);//X
        if (beeppos == 2)
            SendBeep(840, time);//T
        if (beeppos == 3)
            SendBeep(800, time);//P
        if (beeppos == 4)
            SendBeep(970, time);//a
        if (beeppos == 5)
            SendBeep(1000, time);//d
        if (beeppos >= 6)
            timer1.Enabled = false;
    

            beeppos++;

        }

        private void AnswerCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            btQuery.Enabled=((CheckBox) sender).Checked;
        }

        private void btQuery_Tick(object sender, EventArgs e)
        {
            if (enablesend)
            {
                MessageRead(0x01, 1, true);
            }
        }

 



        
       
    }
}