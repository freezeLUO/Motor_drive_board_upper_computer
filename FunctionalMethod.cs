using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 电机驱动板上位机V1._1
{
    public partial class Form1
    {
        //crc16
        private void crc16(byte[] data, int length, out byte crc16Lo, out byte crc16Hi)
        {
            ///计算 CRC16 校验值,静态方法，无需实例化可直接调用
            /// <param name="data">待校验的字节数组</param>
            /// <param name="length">字节数组长度</param>
            /// <param name="crc16Lo">计算得到的 CRC16 校验低字节</param>
            /// <param name="crc16Hi">计算得到的 CRC16 校验高字节</param>
            crc16Hi = 0xFF;
            crc16Lo = 0xFF;
            byte CH = 0xA0;
            byte CL = 0x01;

            for (int ii = 0; ii < length; ii++)
            {
                crc16Lo ^= data[ii];

                for (int j = 0; j < 8; j++)
                {
                    byte saveHi = crc16Hi;
                    byte saveLo = crc16Lo;

                    crc16Hi = (byte)(crc16Hi >> 1);
                    crc16Lo = (byte)(crc16Lo >> 1);

                    if ((saveHi & 0x01) == 0x01)
                    {
                        crc16Lo |= 0x80;
                    }

                    if ((saveLo & 0x01) == 0x01)
                    {
                        crc16Hi ^= CH;
                        crc16Lo ^= CL;
                    }
                }
            }
        }

        //Creat Log File
        private void CreateLogFile()
        {
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            string fileName = currentDate + ".txt";
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
            string filePath = Path.Combine(folderPath, fileName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (File.Exists(filePath))
            {
                Form1.sw = File.AppendText(filePath);
                // 将文件指针移到文件末尾
                Form1.sw.BaseStream.Seek(0, SeekOrigin.End);
            }
            else
            {
                Form1.sw = new StreamWriter(filePath);
            }

            try
            {
                Form1.sw.BaseStream.Seek(0, SeekOrigin.End);
                Form1.sw.WriteLine();
                Form1.sw.WriteLine($"{DateTime.Now}");
                Form1.sw.Flush();
            }
            catch
            {
                MessageBox.Show("!!!");
            }

        }
        int count = 0;
        //串口通讯
        private void comsend(string com)
        {
            try
            {
                //向端口发送485通讯
                byte crclo, crchi;
                // 根据每三个字符代表一个字节的规则计算字节长度
                int Length = (com.Length + 1) / 3;


                // 初始化字节数组以存储要发送的数据和 CRC 检查
                byte[] dpp = new byte[Length + 2];

                // 将字符串的每三个字符转换为一个字节并存储在字节数组中
                for (int i = 0; i < Length; i++)
                {
                    dpp[i] = byte.Parse(com.Substring(3 * i, 2), System.Globalization.NumberStyles.HexNumber);
                }

                // 计算 CRC 检查并将结果存储在字节数组的最后两个位置
                crc16(dpp, Length, out crclo, out crchi);
                dpp[Length] = crclo;
                dpp[Length + 1] = crchi;

                // 通过所选的串口发送数据
                serialPort1.Write(dpp, 0, Length + 2);
                string receiveData = BitConverter.ToString(dpp);

                TextBox_sp.SelectionColor = Color.Blue;
                TextBox_sp.AppendText(DateTime.Now.ToString("HH:mm:ss") + " 发:" + receiveData + Environment.NewLine);
                //更新到最新一行
                TextBox_sp.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        float scale1 = 3.3F / 2.5F;
        float scale2 = 360F / 4095F;
        //数据解析
        private void dataAnalysis(byte[] buffer)
        {
            
            if (buffer.Length > 5)
            {
                //读取位置
                if (buffer[1] == 0x04)
                {

                    float value1 = ((buffer[3] << 8) | buffer[4]);
                    float value2 = (buffer[5] << 8) | buffer[6];
                    //将0-4095的值转换为0-360度
                    angle1 = value1 * scale1 * scale2;
                    Invoke(new MethodInvoker(delegate
                    {
                        uiTextBox2.Text = angle1.ToString();
                    }));

                    angle2 = value2 * scale1 * scale2;
                    Invoke(new MethodInvoker(delegate
                    {
                        TextBox_main.AppendText("电机1位置：" + angle1 + "°" + Environment.NewLine);
                        //TextBox_main.AppendText("电机2位置：" + angle2 + "°" + Environment.NewLine);
                    }));

                    count++;
                }

                //设置速度
                else if (buffer[1] == 0x06)
                {
                    speed1 = buffer[4];
                    speed2 = buffer[6];
                    Invoke(new MethodInvoker(delegate
                    {
                        TextBox_main.AppendText("获取转速为：" + speed1.ToString() + Environment.NewLine);
                    }));

                }

                //设置新地址
                else if (buffer[1] == 0x06)
                {
                    byte a1 = buffer[4];
                    if (a1 == 0xFF)
                    {
                        int a2 = buffer[6];

                        Invoke(new MethodInvoker(delegate
                        {
                            TextBox_main.AppendText("成功设置新地址为：" + a2 + Environment.NewLine);
                        }));
                    }
                    else
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            TextBox_main.AppendText("设置新地址失败" + Environment.NewLine);
                        }));

                    }
                }

                //设置波特率
                else if (buffer[1] == 0x0A)
                {
                    byte a1 = buffer[3];
                    if (a1 == 0xFF)
                    {
                        int a2 = (buffer[3] << 16) | (buffer[4] << 8) | buffer[5];
                        Invoke(new MethodInvoker(delegate
                        {
                            TextBox_main.AppendText("成功设置新波特率为：" + a2 + Environment.NewLine);
                        }));

                    }
                    else
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            TextBox_main.AppendText("设置新波特率失败" + Environment.NewLine);
                        }));

                    }
                }
                //设置位置模式角度提前量
                else if (buffer[1] == 0x0B)
                {
                    float value1 = ((buffer[3] << 8) | buffer[4]);
                    Invoke(new MethodInvoker(delegate
                    {
                        TextBox_main.AppendText("成功设置位置模式角度提前量为：" + value1/100 + "°" + Environment.NewLine);
                    }));
                }

                else
                {
                    //...
                }
            }

        }

    }
}
