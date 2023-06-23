using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using iniFileFrm;  //讀取ini檔用

namespace BluetoothSerial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string INIPath = Convert.ToString(System.AppDomain.CurrentDomain.BaseDirectory) + "Config.ini";
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;  //訊息方塊的回傳值

            result = MessageBox.Show("是否儲存資料?" , "資料存儲提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FilesINI ConfigINI = new FilesINI();
                ConfigINI.INIWrite("連接埠設定", "連接埠", comboBox1.Text, INIPath);
                ConfigINI.INIWrite("連接埠設定", "傳輸速率", comboBox2.Text, INIPath);
                ConfigINI.INIWrite("連接埠設定", "資料位元", comboBox3.Text, INIPath);
                ConfigINI.INIWrite("連接埠設定", "同位檢查", comboBox4.Text, INIPath);
                ConfigINI.INIWrite("連接埠設定", "停止位元", comboBox5.Text, INIPath);
                ConfigINI.INIWrite("連接埠設定", "流量控制", comboBox6.Text, INIPath);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] ports1 = SerialPort.GetPortNames();
            string[] ports2 = new string[] {  "115200" ,"9600", "2400" };
            string[] ports3 = new string[] { "8", "7", "6", "5" };
            string[] ports4 = new string[] { "偶數", "奇數", "無", "標記", "空格" };
            string[] ports5 = new string[] { "1", "2", "1.5" };
            string[] ports6 = new string[] { "None", "XOnXOff", "RequestToSend", "RequestToSendXOnXOff" };
            comboBox1.Items.AddRange(ports1);
            comboBox2.Items.AddRange(ports2);
            comboBox3.Items.AddRange(ports3);
            comboBox4.Items.AddRange(ports4);
            comboBox5.Items.AddRange(ports5);
            comboBox6.Items.AddRange(ports6);

            FilesINI ConfigINI = new FilesINI();
            comboBox1.Text = ConfigINI.INIRead("連接埠設定", "連接埠", INIPath);
            comboBox2.Text = ConfigINI.INIRead("連接埠設定", "傳輸速率", INIPath);
            comboBox3.Text = ConfigINI.INIRead("連接埠設定", "資料位元", INIPath);
            comboBox4.Text = ConfigINI.INIRead("連接埠設定", "同位檢查", INIPath);
            comboBox5.Text = ConfigINI.INIRead("連接埠設定", "停止位元", INIPath);
            comboBox6.Text = ConfigINI.INIRead("連接埠設定", "流量控制", INIPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
