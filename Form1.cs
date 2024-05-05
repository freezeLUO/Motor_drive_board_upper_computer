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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace 电机驱动板上位机V1._1
{
    public partial class Form1 : Form
    {
        public static string[] serialPortNames;
        //定义串口
        public static string PortName1;

        //Log File
        public static StreamWriter sw;

        public string address = "01";   //电机地址

        float angle1 = 0;// 电机1角度
        float angle2 = 0;// 电机2角度

        int speed1 = 0;// 电机1速度
        int speed2 = 0;// 电机2速度

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_serach_ports_Click(sender, e);
        }

        private void button_serach_ports_Click(object sender, EventArgs e)
        {
            serialPortNames = SerialPort.GetPortNames();
            if (serialPortNames.Length == 0)
            {
                MessageBox.Show("未获取到任何可用串口！");
                TextBox_main.AppendText("未获取到任何可用串口！" + Environment.NewLine);
            }
            else
            {
                TextBox_main.AppendText(Environment.NewLine + "Available Serial Ports:" + Environment.NewLine);
                foreach (string portName in serialPortNames)
                {
                    TextBox_main.AppendText(portName + Environment.NewLine);
                }
            }
            // 添加到下拉框
            comboBox1.Items.AddRange(serialPortNames);
            // 设置默认选中项
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortName1 = comboBox1.Text;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    TextBox_main.AppendText("串口已关闭" + Environment.NewLine);
                }

                //设置波特率，无校验，8位数据位，2位停止位
                serialPort1.PortName = PortName1;

                int number;
                number = int.Parse(TextBox1.Text);
                serialPort1.BaudRate = number;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.Two;
                // 设置接收和发送缓冲区大小
                serialPort1.ReadBufferSize = 512;
                serialPort1.WriteBufferSize = 2048;


                // 发送缓冲区空触发发送事件
                serialPort1.ReceivedBytesThreshold = 9;

                // 打开串口
                serialPort1.Open();
                // 清空输入和输出缓冲区
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                TextBox_main.AppendText("串口已打开" + Environment.NewLine);

            }
            catch
            {
                TextBox_main.AppendText("注意：串口打开失败" + Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //关闭串口
            try
            {
                serialPort1.Close();
                TextBox_main.AppendText("串口已关闭" + Environment.NewLine);
            }
            catch
            {
                TextBox_main.AppendText("注意：串口关闭失败" + Environment.NewLine);
            }
        }

        private void Button_forward_Click(object sender, EventArgs e)
        {
            string com;

            com = address + " " + "05 00 00 00 00";   //电机正转

            comsend(com);
        }

        private void Button_backward_Click(object sender, EventArgs e)
        {
            string com;

            com = address + " " + "05 00 01 01 00";   //电机反转

            comsend(com);
        }

        private void Button_stop_Click(object sender, EventArgs e)
        {
            string com;

            com = address + " " + "05 00 FF FF 00";   //电机停止

            comsend(com);
        }

        private void Button_GetSpeed_Click(object sender, EventArgs e)
        {
            string com;

            com = address + " " + "06 00 FF FF 00";   //获取转速，实际是发送转速控制指令，当速度保持不变

            comsend(com);
        }

        //设置转速
        private void TrackBar_speed_ValueChanged(object sender, EventArgs e)
        {
            TextBox_speed.Text = TrackBar_speed.Value.ToString();
            string com;
            int speed = TrackBar_speed.Value;
            string hexString = speed.ToString("x2"); // 转化为16进制字符串
            com = address + " 06 00 " + hexString + " " + hexString + " 00";   //设置转速
            comsend(com);
        }

        //设置地址
        private void TextBox_addr_TextChanged(object sender, EventArgs e)
        {
            address = TextBox_addr.Text;
        }

        //接收数据
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[serialPort1.BytesToRead];
            int counter = serialPort1.BytesToRead;//字节数
            serialPort1.Read(buffer, 0, buffer.Length);
            string receiveData = BitConverter.ToString(buffer);
            
            TextBox_sp.SelectionColor = Color.Black;
            TextBox_sp.AppendText(DateTime.Now.ToString("HH:mm:ss") + " 收:" + receiveData + Environment.NewLine);
            dataAnalysis(buffer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string addr_set = TextBox_addr.Text;
            string com;
            com = address + " " + "07 00 00 00 " + addr_set;   //修改地址

            comsend(com);
        }
    }
}
