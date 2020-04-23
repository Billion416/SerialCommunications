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
using System.IO;

namespace Uart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)//窗口加载
        {
            if (RxBox.Text == string.Empty) clearButton.Enabled = false;
            else clearButton.Enabled = true;

            ScanPort(PortBox);
            
            BaudrateBox.Text = "115200";
            StopBitsBox.Text = "1";
            DataBitBox.Text = "8";
            ParityBitBox.Text = "无";
            timer1.Start();
            TimeNowLabel.Text = "现在时间：" + DateTime.Now.ToLongTimeString();
            if(SerialPort.GetPortNames().Length==0) PortBox.Text = string.Empty; 
           



            /*********/
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口数据接收事件
        {
            if (!RxHexBox.Checked)//字符模式
            {
                //string str = serialPort1.ReadExisting();
                byte[] readbytes = new Byte[serialPort1.BytesToRead];
                serialPort1.Read(readbytes, 0, readbytes.Length);
                if (RUTF8Button.Checked) RxBox.AppendText(UTF8Encoding.UTF8.GetString(readbytes));
                else if (RGB2312Button.Checked) RxBox.AppendText(Encoding.Default.GetString(readbytes));

                //if ((Byte)str == 0x0D)
                //    RxBox.AppendText(DateTime.Now.ToLongTimeString());

            }
            else//数值模式
            {
                byte data;
                data = (byte)serialPort1.ReadByte();
                string str = Convert.ToString(data, 16).ToUpper();
                RxBox.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + "  ");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)//串口发送事件
        {
            byte[] Data = new Byte[1];
            if (serialPort1.IsOpen && TxBox.Text != string.Empty)
            {

                if (!TxHexBox.Checked)
                {
                    try
                    {
                        if (TUTF8Button.Checked)
                        {
                            serialPort1.Write(UTF8Encoding.UTF8.GetBytes(TxBox.Text), 0, UTF8Encoding.UTF8.GetBytes(TxBox.Text).Length);
                            label1.Text = "最后发送时间：\n" + DateTime.Now.ToLongTimeString();
                        }
                        else
                        {
                            serialPort1.Write(UTF8Encoding.Default.GetBytes(TxBox.Text), 0, UTF8Encoding.UTF8.GetBytes(TxBox.Text).Length);
                            label1.Text = "最后发送时间：\n" + DateTime.Now.ToLongTimeString();

                        }
                    }
                    catch
                    {
                        MessageBox.Show("串口数据写入错误", "错误");
                        serialPort1.Close();
                        button2.Text = "打开串口";
                        button2.ForeColor = Color.DarkGreen;
                    }
                }

                else
                {
                    try
                    {
                        string buffer = TxBox.Text.Replace(" ", string.Empty);
                        for (int i = 0; i < (buffer.Length - buffer.Length % 2) / 2; i++)
                        {
                            Data[0] = Convert.ToByte(buffer.Substring(i * 2, 2), 16);
                            serialPort1.Write(Data, 0, 1);
                        }
                        if (buffer.Length % 2 != 0)
                        {
                            Data[0] = Convert.ToByte(buffer.Substring(buffer.Length - 1, 1), 16);
                            serialPort1.Write(Data, 0, 1);
                        }
                        label1.Text = "最后发送时间：" + DateTime.Now.ToLongTimeString();
                    }
                    catch
                    {
                        MessageBox.Show("串口数据写入错误", "错误");
                        serialPort1.Close();
                        button2.Text = "打开串口";
                        button2.ForeColor = Color.DarkGreen;
                    }
                }
            }
            else
            {
                MessageBox.Show("请打开串口", "提示");

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
                    serialPort1.DataBits = Convert.ToInt32(DataBitBox.Text);
                    if (Convert.ToInt32(StopBitsBox.Text) == 0) serialPort1.StopBits = StopBits.None;
                    else if (Convert.ToInt32(StopBitsBox.Text) == 1) serialPort1.StopBits = StopBits.One;
                    else if (Convert.ToInt32(StopBitsBox.Text) == 1.5) serialPort1.StopBits = StopBits.OnePointFive;
                    else if (Convert.ToInt32(StopBitsBox.Text) == 2) serialPort1.StopBits = StopBits.Two;
                    if (ParityBitBox.Text == "无") serialPort1.Parity = Parity.None;
                    else if (ParityBitBox.Text == "奇校验") serialPort1.Parity = Parity.Odd;
                    else if (ParityBitBox.Text == "偶校验") serialPort1.Parity = Parity.Even;


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

                serialPort1.Close();
                button2.Text = "打开串口";
                button2.ForeColor = Color.DarkGreen;

            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)//清空按键
        {
            RxBox.Text = string.Empty;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RxBox_TextChanged(object sender, EventArgs e)
        {
            if (RxBox.Text != string.Empty) clearButton.Enabled = true;
            else clearButton.Enabled = false;
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeNowLabel.Text = "现在时间：" + DateTime.Now.ToLongTimeString();
            ScanPort(PortBox);
        }

        int com;


        private void RxHexBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RxHexBox.Checked)
            {
                RUTF8Button.Enabled = false;
                RGB2312Button.Enabled = false;
                byte[] RxBtyes;
                if (RUTF8Button.Checked) RxBtyes = UTF8toASCII(RxBox.Text);
                else RxBtyes = GB2312toASCII(RxBox.Text);
                RxBox.Clear();
                foreach (byte theByte in RxBtyes)
                {
                    string str = theByte.ToString("x").ToUpper();
                    RxBox.Text += "0x" + (str.Length == 1 ? "0" + str : str) + " ";
                }
            }
            else
            {
                RUTF8Button.Enabled = true;
                RGB2312Button.Enabled = true;
                string buffer = RxBox.Text;
                RxBox.Clear();
                if (RUTF8Button.Checked) RxBox.Text = ASCIItoUTF8(buffer);
                else RxBox.Text = ASCIItoGB2312(buffer);
            }
        }

        private void TxHexBox_CheckedChanged(object sender, EventArgs e)//勾选"十六进制发送"按钮
        {
            if (TxHexBox.Checked)
            {
                TUTF8Button.Enabled = false;
                TGB2312Button.Enabled = false;
                byte[] TxBtyes;
                if (TUTF8Button.Checked) TxBtyes = UTF8toASCII(TxBox.Text);
                else TxBtyes = GB2312toASCII(TxBox.Text);
                TxBox.Clear();
                foreach(byte theByte in TxBtyes)
                {
                    string str = theByte.ToString("x").ToUpper();
                    TxBox.Text += "0x" + (str.Length == 1 ? "0" + str : str) + " ";
                }
            }
            else
            {
                TUTF8Button.Enabled = true;
                TGB2312Button.Enabled = true;
                string buffer = TxBox.Text;
                TxBox.Clear();
                if (TUTF8Button.Checked) TxBox.Text=ASCIItoUTF8(buffer);    
                else TxBox.Text = ASCIItoGB2312(buffer);
            }
        }

        private void 深色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            深色ToolStripMenuItem.Text = "√深色";
            浅色ToolStripMenuItem.Text = "  浅色";
            DarkTheme();

        }
        private void 浅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            深色ToolStripMenuItem.Text = "  深色";
            浅色ToolStripMenuItem.Text = "√浅色";
            Bright();
        }
        private void 保存接收数据ToolStripMenuItem_Click(object sender, EventArgs e)//文件保存
        {

            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
            sw.WriteLine(RxBox.Text);
            sw.Close();
            saveFileDialog1.FileName = string.Empty;
        }

        /*************************自定义函数**************************/
        private void ScanPort(ComboBox TheBox)//串口自动扫描
        {

            if (com != SerialPort.GetPortNames().Length)
            {
                TheBox.Items.Clear();
                foreach (string str in SerialPort.GetPortNames())
                {
                    TheBox.Items.Add(str);
                }
                com = SerialPort.GetPortNames().Length;
            }
        }
        private byte[] UTF8toASCII(string UTF8Text)
        {            
            byte[] theBtyes = Encoding.UTF8.GetBytes(UTF8Text);
            return theBtyes;
        }
        private byte[] GB2312toASCII(string GB2312Text)
        {
            byte[] theBtyes = Encoding.Default.GetBytes(GB2312Text);
            return theBtyes;
        }
        private string ASCIItoUTF8(string ASCIIText)
        {
            byte[] data = new byte[ASCIIText.Length / 2];
            int i;
            string buffer = ASCIIText;
            buffer = buffer.Replace("0x", string.Empty);
            buffer = buffer.Replace("0X", string.Empty);
            buffer = buffer.Replace(" ", string.Empty);
            for (i = 0; i < buffer.Length / 2; i++)
            {
                data[i] = Convert.ToByte(buffer.Substring(i * 2, 2), 16);
            }            
            string str = Encoding.UTF8.GetString(data);
            return str;
        }
        private string ASCIItoGB2312(string ASCIIText)
        {
            byte[] data = new byte[ASCIIText.Length / 2];
            int i;
            string buffer = ASCIIText;
            buffer = buffer.Replace("0x", string.Empty);
            buffer = buffer.Replace("0X", string.Empty);
            buffer = buffer.Replace(" ", string.Empty);
            for (i = 0; i < buffer.Length / 2; i++)
            {
                data[i] = Convert.ToByte(buffer.Substring(i * 2, 2), 16);
            }
            string str = Encoding.Default.GetString(data);
            return str;
        }
        private void DarkTheme()//深色模式
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.Snow;
            
            PortBox.BackColor = Color.Sienna;
            BaudrateBox.BackColor = Color.Sienna;
            StopBitsBox.BackColor = Color.Sienna;
            DataBitBox.BackColor = Color.Sienna;
            ParityBitBox.BackColor = Color.Sienna;
            PortBox.ForeColor = Color.Snow;
            BaudrateBox.ForeColor = Color.Snow;
            StopBitsBox.ForeColor = Color.Snow;
            DataBitBox.ForeColor = Color.Snow;
            ParityBitBox.ForeColor = Color.Snow;
            RxBox.BackColor = Color.SaddleBrown;
            RxBox.ForeColor = Color.Silver;
            TxBox.BackColor = Color.Peru;
            TxBox.ForeColor = Color.Silver;
            button2.BackColor = Color.Gray;
            sendButton.BackColor = Color.Gray;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Snow;
            statusStrip1.BackColor = Color.Black;
            groupBox1.ForeColor = Color.Snow;
            groupBox2.ForeColor = Color.Snow;
        }
        private void Bright()
        {
            this.BackColor = Color.WhiteSmoke;
            this.ForeColor = Color.Black;
            PortBox.BackColor = Color.PeachPuff;
            BaudrateBox.BackColor = Color.PeachPuff;
            StopBitsBox.BackColor = Color.PeachPuff;
            DataBitBox.BackColor = Color.PeachPuff;
            ParityBitBox.BackColor = Color.PeachPuff;
            PortBox.ForeColor = Color.Black;
            BaudrateBox.ForeColor = Color.Black;
            StopBitsBox.ForeColor = Color.Black;
            DataBitBox.ForeColor = Color.Black;
            ParityBitBox.ForeColor = Color.Black;
            RxBox.BackColor = Color.LightYellow;
            RxBox.ForeColor = Color.Black;
            TxBox.BackColor = Color.OldLace;
            TxBox.ForeColor = Color.Black;
            button2.BackColor = Color.Snow;
            sendButton.BackColor = Color.Snow;
            menuStrip1.BackColor = Color.Snow;
            menuStrip1.ForeColor = Color.Black;
            statusStrip1.BackColor = Color.Snow;
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Snow;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }


    }
}
