using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//指示詞
using System.IO.Ports;
using System.Threading;
using System.IO;
using iniFileFrm; //讀取ini檔用

//C# 呼叫一個按鈕的Click事件
using System.Reflection; 

namespace BluetoothSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string INIPath = Convert.ToString(System.AppDomain.CurrentDomain.BaseDirectory) + "Config.ini";
        public bool TypeA = false;

        
        //建立一個函式  //C# 呼叫一個按鈕的Click事件 https://www.796t.com/content/1546790941.html
        private void callOnClick(Button btn)
        {
            //建立一個型別  
            Type t = typeof(Button);
            //引數物件  
            object[] p = new object[1];
            //產生方法  
            MethodInfo m = t.GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
            //引數賦值。傳入函式  
            p[0] = EventArgs.Empty;
            //呼叫  
            m.Invoke(btn, p);
            return;
        }

        //Console 接收資料
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {


            this.Invoke(new EventHandler(DoReceive));

        }


        //Console 發送資料
        public void SendData(Object sendBuffer)
        {
            if (sendBuffer != null)
            {
                Byte[] buffer = sendBuffer as Byte[];

                try
                {

                    serialPort1.Write(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    CloseComport();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Console 接收資料
        private void DoReceive(object sender, EventArgs e)
        {
            try
            {

                if (serialPort1.BytesToRead > 0)
                {
                    int ilen = serialPort1.BytesToRead;
                    byte[] bytes = new byte[ilen];
                    serialPort1.Read(bytes, 0, ilen);
                    // dataIN = Encoding.Default.GetString(bytes); //xx="中文";

                    // char[] delimiterChars = { ' ', ',', '.', ':', '\t', ';' };
                    // string text = dataIN;
                    // string[] words = text.Split(delimiterChars);


                    // textBox4.Text = words[0] + "Kg";
                    // textBox5.Text = words[1];

                }

                Thread.Sleep(20);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //關閉 Console
        public void CloseComport()
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    textBox3.Text = "斷線";
                    textBox3.ForeColor = Color.Red;

                }
                else
                {
                    FilesINI ConfigINI = new FilesINI();


                    serialPort1.PortName = ConfigINI.INIRead("連接埠設定", "連接埠", INIPath);
                    serialPort1.BaudRate = int.Parse(ConfigINI.INIRead("連接埠設定", "傳輸速率", INIPath));
                    serialPort1.DataBits = int.Parse(ConfigINI.INIRead("連接埠設定", "資料位元", INIPath));

                    Parity parity = 0;
                    switch (ConfigINI.INIRead("連接埠設定", "同位檢查", INIPath))
                    {
                        case "無":
                            parity = Parity.None; break;
                        case "奇數":
                            parity = Parity.Odd; break;
                        case "偶數":
                            parity = Parity.Even; break;
                        case "標記":
                            parity = Parity.Mark; break;
                        case "空格":
                            parity = Parity.Space; break;
                    }
                    serialPort1.Parity = parity;

                    StopBits stopBits = 0;
                    switch (ConfigINI.INIRead("連接埠設定", "停止位元", INIPath))
                    {
                        case "1":
                            stopBits = StopBits.One; break;
                        case "2":
                            stopBits = StopBits.Two; break;
                        case "1.5":
                            stopBits = StopBits.OnePointFive; break;
                    }
                    serialPort1.StopBits = stopBits;

                    Handshake handshake = 0;
                    switch (ConfigINI.INIRead("連接埠設定", "停止位元", INIPath))
                    {
                        case "None":
                            handshake = Handshake.None; break;
                        case "XOnXOff":
                            handshake = Handshake.XOnXOff; break;
                        case "RequestToSend":
                            handshake = Handshake.RequestToSend; break;
                        case "RequestToSendXOnXOff":
                            handshake = Handshake.RequestToSendXOnXOff; break;
                    }
                    serialPort1.Handshake = handshake;

                    serialPort1.Open();
                    textBox3.Text = "連線";
                    textBox3.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 埠號設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 OrdersForm = new Form2();
            OrdersForm.ShowDialog(this);
        }

        private void cSV檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cSV檔ToolStripMenuItem.Checked == true)
            {
                FilesINI ConfigINI = new FilesINI();
                ConfigINI.INIWrite("存檔設定", "CSV", "1", INIPath);
            }
            else
            {
                FilesINI ConfigINI = new FilesINI();
                ConfigINI.INIWrite("存檔設定", "CSV", "0", INIPath);
            }

        }

        private void tXT檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tXT檔ToolStripMenuItem.Checked == true)
            {
                FilesINI ConfigINI = new FilesINI();
                ConfigINI.INIWrite("存檔設定", "TXT", "1", INIPath);
            }
            else
            {
                FilesINI ConfigINI = new FilesINI();
                ConfigINI.INIWrite("存檔設定", "TXT", "0", INIPath);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "狀態";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "狀態";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (TypeA == false)
                {
                    button2.Text = "開啟";
                    //送出字串
                    SendData(Encoding.Default.GetBytes("1" + "\r"));
                    label1.Image = BluetoothSerial.Properties.Resources._1;
                    TypeA = true;
                }
                else if (TypeA == true)
                {
                    button2.Text = "關閉";
                    //送出字串
                    SendData(Encoding.Default.GetBytes("2" + "\r"));
                    label1.Image = BluetoothSerial.Properties.Resources._2;
                    TypeA = false;
                }

            }
            else
            {
                DialogResult result;  //訊息方塊的回傳值

                result = MessageBox.Show("是否連線?", "埠號連提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    callOnClick(button1);

                }
            }
        }





        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (TypeA == false)
                {
                    button2.Text = "點我打開";

                }
                else if (TypeA == true)
                {
                    button2.Text = "點我關掉";

                }
            }
        }
    }
}
