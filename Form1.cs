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
using Sunny.UI;

namespace 电机驱动板上位机V1._1
{
    public partial class Form1 : UIForm
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
            try
            {
                button_serach_ports_Click(sender, e);//搜索串口
            }
            catch
            {
                TextBox_main.AppendText("注意：未搜索到串口" + Environment.NewLine);
            }

            uiComboBox1.Items.AddRange(new string[] { "9600","19200","38400","57600","115200"});//波特率下拉框
            uiComboBox1.SelectedIndex = 0;
            uiComboBox2.Items.AddRange(new string[] { "9600", "19200", "38400", "57600", "115200" });//波特率下拉框
            uiComboBox2.SelectedIndex = 0;
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
                //number = int.Parse(TextBox1.Text);
                number = int.Parse(uiComboBox1.Text);
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

            // 使用Invoke确保在正确的线程上更新UI
            Invoke(new MethodInvoker(delegate
            {
                TextBox_sp.SelectionColor = Color.Black;
                TextBox_sp.AppendText(DateTime.Now.ToString("HH:mm:ss") + " 收:" + receiveData + Environment.NewLine);
                TextBox_sp.ScrollToCaret();
            }));
            dataAnalysis(buffer);
        }

        //确认地址
        private void button3_Click(object sender, EventArgs e)
        {
            string addr_set = TextBox_addr.Text;
            string com;
            com = address + " " + "07 00 00 00 " + addr_set;   //修改地址

            comsend(com);
        }

        private void uiSmoothLabel3_Click(object sender, EventArgs e)
        {

        }



        private void uiButton1_Click(object sender, EventArgs e)
        {
            uiTrackBar1.Value = 750;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            uiTrackBar1.Value = 250;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            uiTrackBar1.Value = 500;
        }

        private void uiTrackBar1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void uiTrackBar1_ValueChanged_1(object sender, EventArgs e)
        {
            uiTextBox1.Text = uiTrackBar1.Value.ToString();
            ushort myValue = (ushort)(1000 + uiTrackBar1.Value);
            byte[] bytes = BitConverter.GetBytes(myValue);
            string com = "FF" + " " + bytes[1].ToString("x2") + " " + bytes[0].ToString("x2");
            comsend(com);
        }

        private void trackBar_Angle_ValueChanged(object sender, EventArgs e)
        {
            TextBox_Angle.Text = trackBar_Angle.Value.ToString();
        }

        //位置模式
        private void uiButton4_Click(object sender, EventArgs e)
        {
            string com;
            string angle = (trackBar_Angle.Value * 100).ToString("X4");

            com = address + " " + "11 04" + " " + angle.Substring(0, 2) + " " +angle.Substring(2) +" FF FF";   //电机反转
            comsend(com);
        }

        //设置驱动板地址
        private void button4_Click(object sender, EventArgs e)
        {
            address = TextBox_setaddr.Text;
            TextBox_main.AppendText("驱动板地址已设置为：" + address + Environment.NewLine);

        }

        private void uiSmoothLabel4_Click(object sender, EventArgs e)
        {

        }

        //扫描模式
        private void uiButton5_Click(object sender, EventArgs e)
        {
            //将字符串转化为整数
            int start = int.Parse(TextBox_scan_start.Text);
            int end = int.Parse(TextBox_scan_end.Text);
            string com;
            string angle_start = (start * 100).ToString("X4");
            string angle_end = (end * 100).ToString("X4");
            com = address + " " + "08 05 01" + " " + angle_start.Substring(0, 2) + " " + angle_start.Substring(2) + " " + angle_end.Substring(0, 2) + " " + angle_end.Substring(2);
            comsend(com);
        }

        //驱动板波特率设置
        private void button5_Click(object sender, EventArgs e)
        {
            string com;
            int baudrate = int.Parse(uiComboBox2.Text);
            string hexString = baudrate.ToString("X6"); // 转化为16进制字符串
            com = hexString;
            com = address + " " + "0A 00 " + hexString.Substring(0, 2) + " " + hexString.Substring(2, 2) + " " + hexString.Substring(4);
            comsend(com);
            TextBox_main.AppendText("波特率已设置为：" + baudrate + Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count / 2;
            uiLedLabel1.Text = count.ToString();
            count = 0;

            if (TextBox_main.Lines.Length > 500)
            {
                StringBuilder newText = new StringBuilder();

                for (int i = TextBox_main.Lines.Length - 500; i < TextBox_main.Lines.Length; i++)
                {
                    newText.AppendLine(TextBox_main.Lines[i]);
                }

                TextBox_main.Text = newText.ToString();
                //TextBox_main.ScrollToCaret();
            }

            if (TextBox_sp.Lines.Length > 500)
            {
                StringBuilder newText = new StringBuilder();

                for (int i = TextBox_sp.Lines.Length - 500; i < TextBox_sp.Lines.Length; i++)
                {
                    newText.AppendLine(TextBox_sp.Lines[i]);
                }

                TextBox_sp.Text = newText.ToString();
                TextBox_sp.ScrollToCaret();
            }
        }

        //读取当前位置
        private void uiLedLabel1_Click(object sender, EventArgs e)
        {
            string com;
            com = address + " " + "04 00 00 00 03";   //读取当前位置
            comsend(com);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            uiLedLabel1_Click(sender, e);
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            if(timer2.Enabled == false)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        //修改提前角度
        private void uiButton7_Click(object sender, EventArgs e)
        {
            string com;
            int angle = (int)(100 * double.Parse(TextBox_pre.Text));
            string angle_str = angle.ToString("X4");
            com = address + " " + "0B 04" + " " + angle_str.Substring(0, 2) + " " + angle_str.Substring(2) + " FF FF";
            comsend(com);
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            string com;
            int wd1 = int.Parse(TextBox_wd1.Text);
            string wd1_str = wd1.ToString("X4");
            com = address + " " + "09 04" + " " + wd1_str.Substring(0, 2) + " " + wd1_str.Substring(2) + " FF FF";
            comsend(com);
        }

        private void uiButton9_Click(object sender, EventArgs e)
        {
            string com;
            int wd2 = int.Parse(TextBox_wd2.Text);
            string wd2_str = wd2.ToString("X4");
            com = address + " " + "09 04" + " FF FF " + wd2_str.Substring(0, 2) + " " + wd2_str.Substring(2);
            comsend(com);
        }
    }
    
}
