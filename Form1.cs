using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace Uart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int i = 0; i <= 20; i++)
            {
                PortBox.Items.Add("COM" + i.ToString());          
            }
            PortBox.Text = "COM1";
            BaudrateBox.Text = "4800";


            /*********/
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口数据接收事件
        {
            if (radioButton3.Checked)//字符模式
            {
                string str = serialPort1.ReadExisting();
                textBox1.AppendText(str);
            }
            else//数值模式
            {
                byte data;
                data = (byte)serialPort1.ReadByte();
                string str = Convert.ToString(data, 16).ToUpper();
                textBox1.AppendText("0x" + (str.Length == 1 ? "0" + str : str));   
            }        
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string data = comboBox1.Text;
            string convertdata = data.Substring(2, 2);
            byte[] buffer = new byte[1];
            buffer[0] = Convert.ToByte(convertdata, 16);
            try
            {
                serialPort1.Open();
                serialPort1.Write(buffer, 0, 1);
                serialPort1.Close();

            }
            catch
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                MessageBox.Show("端口错误", "错误");            
            }
        }

        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BaudrateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = PortBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudrateBox.Text);
                    serialPort1.Open();
                    button2.Text = "关闭串口";
                    button2.ForeColor = Color.Red;

                }
                catch
                {
                    MessageBox.Show("端口错误，请检查串口", "错误");
                }

            }
            else 
            {
                try
                {                    
                    serialPort1.Close();
                    button2.Text = "打开串口";
                    button2.ForeColor = Color.DarkGreen;

                }
                catch
                {
                   
                }

            }


        }
    }
}
