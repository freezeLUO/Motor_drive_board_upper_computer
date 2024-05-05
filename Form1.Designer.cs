namespace 电机驱动板上位机V1._1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_serach_ports = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiSmoothLabel2 = new Sunny.UI.UISmoothLabel();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.TextBox1 = new Sunny.UI.UITextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_main = new Sunny.UI.UITextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            this.CheckBox1 = new Sunny.UI.UICheckBox();
            this.uiRuler1 = new Sunny.UI.UIRuler();
            this.TrackBar_speed = new Sunny.UI.UITrackBar();
            this.TextBox_speed = new Sunny.UI.UITextBox();
            this.Button_stop = new Sunny.UI.UIButton();
            this.Button_GetSpeed = new Sunny.UI.UIButton();
            this.Button_backward = new Sunny.UI.UIButton();
            this.Button_forward = new Sunny.UI.UIButton();
            this.uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBox_addr = new Sunny.UI.UITextBox();
            this.uiSmoothLabel3 = new Sunny.UI.UISmoothLabel();
            this.uiSmoothLabel4 = new Sunny.UI.UISmoothLabel();
            this.TextBox_sp = new Sunny.UI.UIRichTextBox();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_serach_ports
            // 
            this.button_serach_ports.Location = new System.Drawing.Point(21, 46);
            this.button_serach_ports.Name = "button_serach_ports";
            this.button_serach_ports.Size = new System.Drawing.Size(121, 40);
            this.button_serach_ports.TabIndex = 0;
            this.button_serach_ports.Text = "搜寻串口";
            this.button_serach_ports.UseVisualStyleBackColor = true;
            this.button_serach_ports.Click += new System.EventHandler(this.button_serach_ports_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiSmoothLabel2);
            this.uiTitlePanel1.Controls.Add(this.uiSmoothLabel1);
            this.uiTitlePanel1.Controls.Add(this.TextBox1);
            this.uiTitlePanel1.Controls.Add(this.button2);
            this.uiTitlePanel1.Controls.Add(this.button1);
            this.uiTitlePanel1.Controls.Add(this.comboBox1);
            this.uiTitlePanel1.Controls.Add(this.button_serach_ports);
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(13, 14);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(169, 278);
            this.uiTitlePanel1.TabIndex = 3;
            this.uiTitlePanel1.Text = "串口设置";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSmoothLabel2
            // 
            this.uiSmoothLabel2.BackColor = System.Drawing.Color.AliceBlue;
            this.uiSmoothLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel2.Location = new System.Drawing.Point(51, 126);
            this.uiSmoothLabel2.Name = "uiSmoothLabel2";
            this.uiSmoothLabel2.Size = new System.Drawing.Size(66, 26);
            this.uiSmoothLabel2.TabIndex = 5;
            this.uiSmoothLabel2.Text = "波特率";
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.BackColor = System.Drawing.Color.AliceBlue;
            this.uiSmoothLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(49, 128);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(66, 26);
            this.uiSmoothLabel1.TabIndex = 4;
            this.uiSmoothLabel1.Text = "波特率";
            // 
            // TextBox1
            // 
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DoubleValue = 9600D;
            this.TextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox1.IntValue = 9600;
            this.TextBox1.Location = new System.Drawing.Point(21, 159);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox1.ShowText = false;
            this.TextBox1.Size = new System.Drawing.Size(121, 29);
            this.TextBox1.TabIndex = 4;
            this.TextBox1.Text = "9600";
            this.TextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox1.Watermark = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "关闭串口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_main
            // 
            this.TextBox_main.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_main.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_main.Location = new System.Drawing.Point(201, 14);
            this.TextBox_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_main.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_main.Multiline = true;
            this.TextBox_main.Name = "TextBox_main";
            this.TextBox_main.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_main.ShowScrollBar = true;
            this.TextBox_main.ShowText = false;
            this.TextBox_main.Size = new System.Drawing.Size(369, 278);
            this.TextBox_main.TabIndex = 4;
            this.TextBox_main.Text = "作者：罗永哲\r\nEmail：luoyzshu@qq.com";
            this.TextBox_main.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox_main.Watermark = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.CheckBox1);
            this.uiTitlePanel2.Controls.Add(this.uiRuler1);
            this.uiTitlePanel2.Controls.Add(this.TrackBar_speed);
            this.uiTitlePanel2.Controls.Add(this.TextBox_speed);
            this.uiTitlePanel2.Controls.Add(this.Button_stop);
            this.uiTitlePanel2.Controls.Add(this.Button_GetSpeed);
            this.uiTitlePanel2.Controls.Add(this.Button_backward);
            this.uiTitlePanel2.Controls.Add(this.Button_forward);
            this.uiTitlePanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.Location = new System.Drawing.Point(14, 302);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.ShowText = false;
            this.uiTitlePanel2.Size = new System.Drawing.Size(557, 156);
            this.uiTitlePanel2.TabIndex = 5;
            this.uiTitlePanel2.Text = "速度模式";
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBox1
            // 
            this.CheckBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.CheckBox1.CheckBoxColor = System.Drawing.SystemColors.Highlight;
            this.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CheckBox1.Location = new System.Drawing.Point(5, 39);
            this.CheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(112, 35);
            this.CheckBox1.TabIndex = 122;
            this.CheckBox1.Text = "忽略闪断";
            // 
            // uiRuler1
            // 
            this.uiRuler1.BackColor = System.Drawing.Color.Transparent;
            this.uiRuler1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRuler1.Location = new System.Drawing.Point(21, 117);
            this.uiRuler1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRuler1.MinorCount = 4;
            this.uiRuler1.Name = "uiRuler1";
            this.uiRuler1.Size = new System.Drawing.Size(433, 27);
            this.uiRuler1.TabIndex = 121;
            this.uiRuler1.Text = "uiRuler1";
            this.uiRuler1.TextDirection = Sunny.UI.UIRuler.UITextPos.Behind;
            // 
            // TrackBar_speed
            // 
            this.TrackBar_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TrackBar_speed.Location = new System.Drawing.Point(32, 82);
            this.TrackBar_speed.MinimumSize = new System.Drawing.Size(1, 1);
            this.TrackBar_speed.Name = "TrackBar_speed";
            this.TrackBar_speed.Size = new System.Drawing.Size(417, 29);
            this.TrackBar_speed.TabIndex = 6;
            this.TrackBar_speed.Text = "50";
            this.TrackBar_speed.Value = 70;
            this.TrackBar_speed.ValueChanged += new System.EventHandler(this.TrackBar_speed_ValueChanged);
            // 
            // TextBox_speed
            // 
            this.TextBox_speed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_speed.DoubleValue = 50D;
            this.TextBox_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_speed.IntValue = 50;
            this.TextBox_speed.Location = new System.Drawing.Point(478, 82);
            this.TextBox_speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_speed.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_speed.Name = "TextBox_speed";
            this.TextBox_speed.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_speed.ShowText = false;
            this.TextBox_speed.Size = new System.Drawing.Size(50, 35);
            this.TextBox_speed.TabIndex = 5;
            this.TextBox_speed.Text = "50";
            this.TextBox_speed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextBox_speed.Watermark = "";
            // 
            // Button_stop
            // 
            this.Button_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_stop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_stop.Location = new System.Drawing.Point(335, 39);
            this.Button_stop.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button_stop.Name = "Button_stop";
            this.Button_stop.Size = new System.Drawing.Size(100, 35);
            this.Button_stop.TabIndex = 0;
            this.Button_stop.Text = "停止";
            this.Button_stop.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_stop.Click += new System.EventHandler(this.Button_stop_Click);
            // 
            // Button_GetSpeed
            // 
            this.Button_GetSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_GetSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_GetSpeed.Location = new System.Drawing.Point(441, 39);
            this.Button_GetSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button_GetSpeed.Name = "Button_GetSpeed";
            this.Button_GetSpeed.Size = new System.Drawing.Size(100, 35);
            this.Button_GetSpeed.TabIndex = 0;
            this.Button_GetSpeed.Text = "获取转速";
            this.Button_GetSpeed.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_GetSpeed.Click += new System.EventHandler(this.Button_GetSpeed_Click);
            // 
            // Button_backward
            // 
            this.Button_backward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_backward.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_backward.Location = new System.Drawing.Point(229, 39);
            this.Button_backward.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button_backward.Name = "Button_backward";
            this.Button_backward.Size = new System.Drawing.Size(100, 35);
            this.Button_backward.TabIndex = 0;
            this.Button_backward.Text = "反转";
            this.Button_backward.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_backward.Click += new System.EventHandler(this.Button_backward_Click);
            // 
            // Button_forward
            // 
            this.Button_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_forward.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_forward.Location = new System.Drawing.Point(123, 39);
            this.Button_forward.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button_forward.Name = "Button_forward";
            this.Button_forward.Size = new System.Drawing.Size(100, 35);
            this.Button_forward.TabIndex = 0;
            this.Button_forward.Text = "正转";
            this.Button_forward.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_forward.Click += new System.EventHandler(this.Button_forward_Click);
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.button3);
            this.uiTitlePanel3.Controls.Add(this.TextBox_addr);
            this.uiTitlePanel3.Controls.Add(this.uiSmoothLabel3);
            this.uiTitlePanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.Location = new System.Drawing.Point(14, 485);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.ShowText = false;
            this.uiTitlePanel3.Size = new System.Drawing.Size(270, 127);
            this.uiTitlePanel3.TabIndex = 6;
            this.uiTitlePanel3.Text = "驱动板地址设置";
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "确认地址";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBox_addr
            // 
            this.TextBox_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_addr.DoubleValue = 1D;
            this.TextBox_addr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_addr.IntValue = 1;
            this.TextBox_addr.Location = new System.Drawing.Point(12, 74);
            this.TextBox_addr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_addr.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_addr.Name = "TextBox_addr";
            this.TextBox_addr.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_addr.ShowText = false;
            this.TextBox_addr.Size = new System.Drawing.Size(50, 35);
            this.TextBox_addr.TabIndex = 6;
            this.TextBox_addr.Text = "01";
            this.TextBox_addr.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextBox_addr.Watermark = "";
            this.TextBox_addr.TextChanged += new System.EventHandler(this.TextBox_addr_TextChanged);
            // 
            // uiSmoothLabel3
            // 
            this.uiSmoothLabel3.BackColor = System.Drawing.Color.AliceBlue;
            this.uiSmoothLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel3.Location = new System.Drawing.Point(8, 43);
            this.uiSmoothLabel3.Name = "uiSmoothLabel3";
            this.uiSmoothLabel3.Size = new System.Drawing.Size(241, 26);
            this.uiSmoothLabel3.TabIndex = 5;
            this.uiSmoothLabel3.Text = "地址范围00-FF，默认为01";
            // 
            // uiSmoothLabel4
            // 
            this.uiSmoothLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.uiSmoothLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel4.Location = new System.Drawing.Point(1170, 14);
            this.uiSmoothLabel4.Name = "uiSmoothLabel4";
            this.uiSmoothLabel4.Size = new System.Drawing.Size(88, 26);
            this.uiSmoothLabel4.TabIndex = 5;
            this.uiSmoothLabel4.Text = "通讯明细";
            // 
            // TextBox_sp
            // 
            this.TextBox_sp.FillColor = System.Drawing.Color.White;
            this.TextBox_sp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_sp.Location = new System.Drawing.Point(989, 45);
            this.TextBox_sp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_sp.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBox_sp.Name = "TextBox_sp";
            this.TextBox_sp.Padding = new System.Windows.Forms.Padding(2);
            this.TextBox_sp.ScrollBarStyleInherited = false;
            this.TextBox_sp.ShowText = false;
            this.TextBox_sp.Size = new System.Drawing.Size(430, 735);
            this.TextBox_sp.TabIndex = 7;
            this.TextBox_sp.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 794);
            this.Controls.Add(this.TextBox_sp);
            this.Controls.Add(this.uiTitlePanel3);
            this.Controls.Add(this.uiTitlePanel2);
            this.Controls.Add(this.uiSmoothLabel4);
            this.Controls.Add(this.TextBox_main);
            this.Controls.Add(this.uiTitlePanel1);
            this.Name = "Form1";
            this.Text = "电机驱动板上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_serach_ports;
        private System.Windows.Forms.ComboBox comboBox1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.Button button1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UITextBox TextBox1;
        private Sunny.UI.UITextBox TextBox_main;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UIButton Button_stop;
        private Sunny.UI.UIButton Button_backward;
        private Sunny.UI.UIButton Button_forward;
        private Sunny.UI.UITextBox TextBox_speed;
        private Sunny.UI.UIButton Button_GetSpeed;
        private Sunny.UI.UIRuler uiRuler1;
        private Sunny.UI.UITrackBar TrackBar_speed;
        private Sunny.UI.UISmoothLabel uiSmoothLabel2;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UISmoothLabel uiSmoothLabel3;
        private Sunny.UI.UITextBox TextBox_addr;
        private System.Windows.Forms.Button button3;
        private Sunny.UI.UICheckBox CheckBox1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel4;
        private Sunny.UI.UIRichTextBox TextBox_sp;
    }
}

