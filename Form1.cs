using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NxtPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private int newx=0, newy=0, oldx = 0, oldy = 0, actionInt = 0;
        private bool actionButtonPressed = false;
        private char[] action = {'0','0','0','0'}; //legacy array for storing which action button was pressed
        //private bool dialogvisible  = false;
       

        private void Setup(object sender, EventArgs e)
        {
            comboBoxComports.SelectedIndex = 1; //my default setting: COM1
            serialPort1.Close();//just to   be sure.
            serialPort1.PortName = "COM1";//my default
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

            string actionString = new string(action);
            string NXTString = direction.ToString() + "," + nfs(steer) + "," + nfs(pwr) + "," + nfs(outX) + "," + nfs(outY) + "," + actionString + "," + actionInt.ToString();
            //DialogResult rslt = MessageBox.Show(NXTString);
           
            byte[] Command = new byte[NXTString.Length + 7];
            byte[] CommandHeader = {(byte)(NXTString.Length + 5),0x00, 0x00, 0x09, 0x00, (byte)(NXTString.Length + 1) }; //NoReply, SendMSG, MsgBox 1, MSG length.
                        
            
            int j = 6; //start writing the string to the byte array on the 7th byte
            foreach (char ch in NXTString.ToCharArray())
            {
                Command[j] = (byte)ch;
                j++;
            }
            Command[Command.Length - 1] = 0x00; //set the last byte to zero, required by NXT protocol

            //putting it all together
            System.Buffer.BlockCopy(CommandHeader, 0, Command, 0, CommandHeader.Length);
            

            if (serialPort1.IsOpen)
            {
                pBled.Visible = true;
                serialPort1.Write(Command, 0, Command.Length);
            }
            else
            {
                pBled.Visible = false;
                try
                {
                    serialPort1.Open();
                    pBled.Visible = true;
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
            serialPort1.PortName = comboBoxComports.SelectedItem.ToString();
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

        private void pBBackground_MouseDown(object sender, MouseEventArgs e)
        {

            if (within(e.X, e.Y, pBAction1.Left, pBAction1.Top, pBAction1.Right, pBAction1.Bottom))
            {
                if (CB_Toggling.Checked)
                {
                    pBAction1.Visible = !pBAction1.Visible;

                }
                else
                {
                    pBAction1.Visible = true;
                }
                setActionOutput(pBAction1.Visible, 1);
            }
            if (within(e.X, e.Y, pBAction2.Left, pBAction2.Top, pBAction2.Right, pBAction2.Bottom))
            {
                if (CB_Toggling.Checked)
                {
                    pBAction2.Visible = !pBAction2.Visible;

                }
                else
                {
                    pBAction2.Visible = true;
                }
                setActionOutput(pBAction2.Visible, 2);
            } 
            if (within(e.X, e.Y, pBAction3.Left, pBAction3.Top, pBAction3.Right, pBAction3.Bottom))
            {
                if (CB_Toggling.Checked)
                {
                    pBAction3.Visible = !pBAction3.Visible;

                }
                else
                {
                    pBAction3.Visible = true;
                }
                setActionOutput(pBAction3.Visible, 3);
            } 
            if (within(e.X, e.Y, pBAction4.Left, pBAction4.Top, pBAction4.Right, pBAction4.Bottom))
            {
                if (CB_Toggling.Checked)
                {
                    pBAction4.Visible = !pBAction4.Visible;

                }
                else
                {
                    pBAction4.Visible = true;
                }
                setActionOutput(pBAction4.Visible, 4);
            }
            actionButtonPressed = true; //to keep track of changed states and wether ot not to send a new msg
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
                pBAction1.Visible = false;
                action[0] = '0';
                pBAction2.Visible = false;
                action[1] = '0';
                pBAction3.Visible = false;
                action[2] = '0';
                pBAction4.Visible = false;
                action[3] = '0';
                actionInt = 0;
            }
            actionButtonPressed = true;
            
        }



        private void pad_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked) {newx =0;newy=0;}
        }

        private void pBAction1_MouseDown(object sender, MouseEventArgs e)
        {
            pBAction1.Visible = false;
            setActionOutput(false, 1);
            actionButtonPressed = true;
        }

        private void pBAction2_MouseDown(object sender, MouseEventArgs e)
        {
            pBAction2.Visible = false;
            setActionOutput(false, 2);
            actionButtonPressed = true;
        }

        private void pBAction3_MouseDown(object sender, MouseEventArgs e)
        {
            pBAction3.Visible = false;
            setActionOutput(false, 3);
            actionButtonPressed = true;
        }

        private void pBAction4_MouseDown(object sender, MouseEventArgs e)
        {
            pBAction4.Visible = false;
            setActionOutput(false, 4);
            actionButtonPressed = true;
        }

            

       
    }
}