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
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiSmoothLabel2 = new Sunny.UI.UISmoothLabel();
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
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiTrackBar1 = new Sunny.UI.UITrackBar();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiTitlePanel4 = new Sunny.UI.UITitlePanel();
            this.uiTitlePanel5 = new Sunny.UI.UITitlePanel();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.TextBox_Angle = new Sunny.UI.UITextBox();
            this.trackBar_Angle = new System.Windows.Forms.TrackBar();
            this.uiTitlePanel6 = new Sunny.UI.UITitlePanel();
            this.uiSmoothLabel5 = new Sunny.UI.UISmoothLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.TextBox_setaddr = new Sunny.UI.UITextBox();
            this.uiTitlePanel7 = new Sunny.UI.UITitlePanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.TextBox_scan_end = new Sunny.UI.UITextBox();
            this.TextBox_scan_start = new Sunny.UI.UITextBox();
            this.uiTitlePanel8 = new Sunny.UI.UITitlePanel();
            this.button5 = new System.Windows.Forms.Button();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.uiTitlePanel9 = new Sunny.UI.UITitlePanel();
            this.TextBox_pre = new Sunny.UI.UITextBox();
            this.uiButton7 = new Sunny.UI.UIButton();
            this.uiTitlePanel10 = new Sunny.UI.UITitlePanel();
            this.TextBox_wd1 = new Sunny.UI.UITextBox();
            this.TextBox_wd2 = new Sunny.UI.UITextBox();
            this.uiButton8 = new Sunny.UI.UIButton();
            this.uiButton9 = new Sunny.UI.UIButton();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiTitlePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Angle)).BeginInit();
            this.uiTitlePanel6.SuspendLayout();
            this.uiTitlePanel7.SuspendLayout();
            this.uiTitlePanel8.SuspendLayout();
            this.uiTitlePanel9.SuspendLayout();
            this.uiTitlePanel10.SuspendLayout();
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
            this.uiTitlePanel1.Controls.Add(this.uiComboBox1);
            this.uiTitlePanel1.Controls.Add(this.uiSmoothLabel2);
            this.uiTitlePanel1.Controls.Add(this.button2);
            this.uiTitlePanel1.Controls.Add(this.button1);
            this.uiTitlePanel1.Controls.Add(this.comboBox1);
            this.uiTitlePanel1.Controls.Add(this.button_serach_ports);
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(13, 50);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(168, 365);
            this.uiTitlePanel1.TabIndex = 3;
            this.uiTitlePanel1.Text = "串口设置";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(21, 240);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(121, 34);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 10;
            this.uiComboBox1.Text = "9600";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiSmoothLabel2
            // 
            this.uiSmoothLabel2.BackColor = System.Drawing.Color.AliceBlue;
            this.uiSmoothLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel2.Location = new System.Drawing.Point(56, 191);
            this.uiSmoothLabel2.Name = "uiSmoothLabel2";
            this.uiSmoothLabel2.Size = new System.Drawing.Size(67, 26);
            this.uiSmoothLabel2.TabIndex = 5;
            this.uiSmoothLabel2.Text = "波特率";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "关闭串口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 282);
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
            this.TextBox_main.Location = new System.Drawing.Point(194, 50);
            this.TextBox_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_main.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_main.Multiline = true;
            this.TextBox_main.Name = "TextBox_main";
            this.TextBox_main.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_main.ShowScrollBar = true;
            this.TextBox_main.ShowText = false;
            this.TextBox_main.Size = new System.Drawing.Size(383, 365);
            this.TextBox_main.TabIndex = 4;
            this.TextBox_main.Text = "作者：罗永哲\r\nEmail：luoyzshu@qq.com\r\n该上位机适用于Motor1接口\r\n";
            this.TextBox_main.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox_main.Watermark = "";
            // 
            // serialPort1
            // 
            this.serialPort1.WriteBufferSize = 6000;
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
            this.uiTitlePanel2.Location = new System.Drawing.Point(589, 427);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.ShowText = false;
            this.uiTitlePanel2.Size = new System.Drawing.Size(564, 152);
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
            this.TrackBar_speed.Value = 50;
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
            this.uiTitlePanel3.Location = new System.Drawing.Point(154, 425);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.ShowText = false;
            this.uiTitlePanel3.Size = new System.Drawing.Size(159, 154);
            this.uiTitlePanel3.TabIndex = 6;
            this.uiTitlePanel3.Text = "驱动板地址设置";
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "确认";
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
            this.uiSmoothLabel3.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel3.Location = new System.Drawing.Point(15, 46);
            this.uiSmoothLabel3.Name = "uiSmoothLabel3";
            this.uiSmoothLabel3.RectColor = System.Drawing.Color.Black;
            this.uiSmoothLabel3.Size = new System.Drawing.Size(46, 34);
            this.uiSmoothLabel3.TabIndex = 5;
            this.uiSmoothLabel3.Text = "00-FF";
            this.uiSmoothLabel3.Click += new System.EventHandler(this.uiSmoothLabel3_Click);
            // 
            // uiSmoothLabel4
            // 
            this.uiSmoothLabel4.BackColor = System.Drawing.Color.AliceBlue;
            this.uiSmoothLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel4.Location = new System.Drawing.Point(816, 47);
            this.uiSmoothLabel4.Name = "uiSmoothLabel4";
            this.uiSmoothLabel4.Size = new System.Drawing.Size(88, 26);
            this.uiSmoothLabel4.TabIndex = 5;
            this.uiSmoothLabel4.Text = "通讯明细";
            this.uiSmoothLabel4.Click += new System.EventHandler(this.uiSmoothLabel4_Click);
            // 
            // TextBox_sp
            // 
            this.TextBox_sp.FillColor = System.Drawing.Color.White;
            this.TextBox_sp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_sp.Location = new System.Drawing.Point(588, 78);
            this.TextBox_sp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_sp.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBox_sp.Name = "TextBox_sp";
            this.TextBox_sp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_sp.ScrollBarStyleInherited = false;
            this.TextBox_sp.ShowText = false;
            this.TextBox_sp.Size = new System.Drawing.Size(564, 337);
            this.TextBox_sp.TabIndex = 7;
            this.TextBox_sp.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(1000, 40);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "正转";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(635, 40);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 0;
            this.uiButton2.Text = "反转";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiTrackBar1
            // 
            this.uiTrackBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTrackBar1.Location = new System.Drawing.Point(19, 81);
            this.uiTrackBar1.Maximum = 1000;
            this.uiTrackBar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTrackBar1.Name = "uiTrackBar1";
            this.uiTrackBar1.Size = new System.Drawing.Size(1689, 29);
            this.uiTrackBar1.TabIndex = 6;
            this.uiTrackBar1.Text = "50";
            this.uiTrackBar1.Value = 500;
            this.uiTrackBar1.ValueChanged += new System.EventHandler(this.uiTrackBar1_ValueChanged_1);
            this.uiTrackBar1.Validating += new System.ComponentModel.CancelEventHandler(this.uiTrackBar1_Validating);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(816, 40);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.TabIndex = 0;
            this.uiButton3.Text = "停止";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.DoubleValue = 500D;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.IntValue = 500;
            this.uiTextBox1.Location = new System.Drawing.Point(1648, 40);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(50, 35);
            this.uiTextBox1.TabIndex = 5;
            this.uiTextBox1.Text = "500";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox1.Watermark = "";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.uiTrackBar1);
            this.uiTitlePanel4.Controls.Add(this.uiTextBox1);
            this.uiTitlePanel4.Controls.Add(this.uiButton1);
            this.uiTitlePanel4.Controls.Add(this.uiButton2);
            this.uiTitlePanel4.Controls.Add(this.uiButton3);
            this.uiTitlePanel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel4.Location = new System.Drawing.Point(4, 914);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiTitlePanel4.ShowText = false;
            this.uiTitlePanel4.Size = new System.Drawing.Size(1711, 118);
            this.uiTitlePanel4.TabIndex = 8;
            this.uiTitlePanel4.Text = "推进器测试（务必使用115200波特率）";
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTitlePanel4.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            // 
            // uiTitlePanel5
            // 
            this.uiTitlePanel5.Controls.Add(this.uiLedLabel1);
            this.uiTitlePanel5.Controls.Add(this.uiButton6);
            this.uiTitlePanel5.Controls.Add(this.uiButton4);
            this.uiTitlePanel5.Controls.Add(this.uiTextBox2);
            this.uiTitlePanel5.Controls.Add(this.TextBox_Angle);
            this.uiTitlePanel5.Controls.Add(this.trackBar_Angle);
            this.uiTitlePanel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel5.Location = new System.Drawing.Point(589, 589);
            this.uiTitlePanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel5.Name = "uiTitlePanel5";
            this.uiTitlePanel5.ShowText = false;
            this.uiTitlePanel5.Size = new System.Drawing.Size(561, 138);
            this.uiTitlePanel5.TabIndex = 9;
            this.uiTitlePanel5.Text = "位置模式";
            this.uiTitlePanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLedLabel1.Location = new System.Drawing.Point(382, 89);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(100, 35);
            this.uiLedLabel1.TabIndex = 13;
            this.uiLedLabel1.Text = "uiLedLabel1";
            this.uiLedLabel1.Click += new System.EventHandler(this.uiLedLabel1_Click);
            // 
            // uiButton6
            // 
            this.uiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton6.Location = new System.Drawing.Point(80, 86);
            this.uiButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton6.Name = "uiButton6";
            this.uiButton6.Size = new System.Drawing.Size(143, 38);
            this.uiButton6.TabIndex = 12;
            this.uiButton6.Text = "连续采集角度";
            this.uiButton6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton6.Click += new System.EventHandler(this.uiButton6_Click);
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Location = new System.Drawing.Point(229, 86);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(100, 38);
            this.uiButton4.TabIndex = 12;
            this.uiButton4.Text = "确定";
            this.uiButton4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.DoubleValue = 180D;
            this.uiTextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.IntValue = 180;
            this.uiTextBox2.Location = new System.Drawing.Point(489, 86);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(52, 38);
            this.uiTextBox2.TabIndex = 11;
            this.uiTextBox2.Text = "180";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox2.Watermark = "";
            // 
            // TextBox_Angle
            // 
            this.TextBox_Angle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Angle.DoubleValue = 180D;
            this.TextBox_Angle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Angle.IntValue = 180;
            this.TextBox_Angle.Location = new System.Drawing.Point(21, 86);
            this.TextBox_Angle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Angle.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_Angle.Name = "TextBox_Angle";
            this.TextBox_Angle.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_Angle.ShowText = false;
            this.TextBox_Angle.Size = new System.Drawing.Size(52, 38);
            this.TextBox_Angle.TabIndex = 11;
            this.TextBox_Angle.Text = "180";
            this.TextBox_Angle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextBox_Angle.Watermark = "";
            // 
            // trackBar_Angle
            // 
            this.trackBar_Angle.BackColor = System.Drawing.Color.AliceBlue;
            this.trackBar_Angle.Location = new System.Drawing.Point(6, 40);
            this.trackBar_Angle.Maximum = 360;
            this.trackBar_Angle.Name = "trackBar_Angle";
            this.trackBar_Angle.Size = new System.Drawing.Size(548, 56);
            this.trackBar_Angle.TabIndex = 10;
            this.trackBar_Angle.Value = 180;
            this.trackBar_Angle.ValueChanged += new System.EventHandler(this.trackBar_Angle_ValueChanged);
            // 
            // uiTitlePanel6
            // 
            this.uiTitlePanel6.Controls.Add(this.uiSmoothLabel5);
            this.uiTitlePanel6.Controls.Add(this.button4);
            this.uiTitlePanel6.Controls.Add(this.TextBox_setaddr);
            this.uiTitlePanel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel6.Location = new System.Drawing.Point(13, 425);
            this.uiTitlePanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel6.Name = "uiTitlePanel6";
            this.uiTitlePanel6.ShowText = false;
            this.uiTitlePanel6.Size = new System.Drawing.Size(133, 154);
            this.uiTitlePanel6.TabIndex = 10;
            this.uiTitlePanel6.Text = "上位机地址";
            this.uiTitlePanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSmoothLabel5
            // 
            this.uiSmoothLabel5.BackColor = System.Drawing.Color.AliceBlue;
            this.uiSmoothLabel5.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel5.Location = new System.Drawing.Point(11, 45);
            this.uiSmoothLabel5.Name = "uiSmoothLabel5";
            this.uiSmoothLabel5.RectColor = System.Drawing.Color.Black;
            this.uiSmoothLabel5.Size = new System.Drawing.Size(46, 24);
            this.uiSmoothLabel5.TabIndex = 6;
            this.uiSmoothLabel5.Text = "00-FF";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "确定";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextBox_setaddr
            // 
            this.TextBox_setaddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_setaddr.DoubleValue = 1D;
            this.TextBox_setaddr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_setaddr.IntValue = 1;
            this.TextBox_setaddr.Location = new System.Drawing.Point(9, 74);
            this.TextBox_setaddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_setaddr.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_setaddr.Name = "TextBox_setaddr";
            this.TextBox_setaddr.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_setaddr.ShowText = false;
            this.TextBox_setaddr.Size = new System.Drawing.Size(48, 35);
            this.TextBox_setaddr.TabIndex = 0;
            this.TextBox_setaddr.Text = "01";
            this.TextBox_setaddr.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextBox_setaddr.Watermark = "";
            // 
            // uiTitlePanel7
            // 
            this.uiTitlePanel7.Controls.Add(this.uiLabel2);
            this.uiTitlePanel7.Controls.Add(this.uiLabel1);
            this.uiTitlePanel7.Controls.Add(this.uiButton5);
            this.uiTitlePanel7.Controls.Add(this.TextBox_scan_end);
            this.uiTitlePanel7.Controls.Add(this.TextBox_scan_start);
            this.uiTitlePanel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel7.Location = new System.Drawing.Point(13, 589);
            this.uiTitlePanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel7.Name = "uiTitlePanel7";
            this.uiTitlePanel7.ShowText = false;
            this.uiTitlePanel7.Size = new System.Drawing.Size(564, 138);
            this.uiTitlePanel7.TabIndex = 11;
            this.uiTitlePanel7.Text = "扫描模式";
            this.uiTitlePanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(163, 56);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(61, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "终止";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(32, 56);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(61, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "起始";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton5
            // 
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.Location = new System.Drawing.Point(279, 56);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Size = new System.Drawing.Size(261, 76);
            this.uiButton5.TabIndex = 1;
            this.uiButton5.Text = "确定";
            this.uiButton5.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // TextBox_scan_end
            // 
            this.TextBox_scan_end.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_scan_end.DoubleValue = 180D;
            this.TextBox_scan_end.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_scan_end.IntValue = 180;
            this.TextBox_scan_end.Location = new System.Drawing.Point(146, 96);
            this.TextBox_scan_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_scan_end.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_scan_end.Name = "TextBox_scan_end";
            this.TextBox_scan_end.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_scan_end.ShowText = false;
            this.TextBox_scan_end.Size = new System.Drawing.Size(93, 36);
            this.TextBox_scan_end.TabIndex = 0;
            this.TextBox_scan_end.Text = "180";
            this.TextBox_scan_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox_scan_end.Watermark = "";
            // 
            // TextBox_scan_start
            // 
            this.TextBox_scan_start.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_scan_start.DoubleValue = 90D;
            this.TextBox_scan_start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_scan_start.IntValue = 90;
            this.TextBox_scan_start.Location = new System.Drawing.Point(18, 96);
            this.TextBox_scan_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_scan_start.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_scan_start.Name = "TextBox_scan_start";
            this.TextBox_scan_start.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_scan_start.ShowText = false;
            this.TextBox_scan_start.Size = new System.Drawing.Size(93, 36);
            this.TextBox_scan_start.TabIndex = 0;
            this.TextBox_scan_start.Text = "90";
            this.TextBox_scan_start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox_scan_start.Watermark = "";
            // 
            // uiTitlePanel8
            // 
            this.uiTitlePanel8.Controls.Add(this.button5);
            this.uiTitlePanel8.Controls.Add(this.uiComboBox2);
            this.uiTitlePanel8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel8.Location = new System.Drawing.Point(318, 425);
            this.uiTitlePanel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel8.Name = "uiTitlePanel8";
            this.uiTitlePanel8.ShowText = false;
            this.uiTitlePanel8.Size = new System.Drawing.Size(260, 154);
            this.uiTitlePanel8.TabIndex = 12;
            this.uiTitlePanel8.Text = "设置驱动板RS485波特率";
            this.uiTitlePanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(146, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 34);
            this.button5.TabIndex = 12;
            this.button5.Text = "确定";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.DataSource = null;
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox2.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox2.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox2.Location = new System.Drawing.Point(17, 74);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(121, 34);
            this.uiComboBox2.SymbolSize = 24;
            this.uiComboBox2.TabIndex = 11;
            this.uiComboBox2.Text = "9600";
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // uiTitlePanel9
            // 
            this.uiTitlePanel9.Controls.Add(this.TextBox_pre);
            this.uiTitlePanel9.Controls.Add(this.uiButton7);
            this.uiTitlePanel9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel9.Location = new System.Drawing.Point(13, 737);
            this.uiTitlePanel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel9.Name = "uiTitlePanel9";
            this.uiTitlePanel9.ShowText = false;
            this.uiTitlePanel9.Size = new System.Drawing.Size(564, 124);
            this.uiTitlePanel9.TabIndex = 13;
            this.uiTitlePanel9.Text = "位置模式角度提前量设置（单位：度）";
            this.uiTitlePanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_pre
            // 
            this.TextBox_pre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_pre.DoubleValue = 5D;
            this.TextBox_pre.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_pre.Location = new System.Drawing.Point(18, 63);
            this.TextBox_pre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_pre.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_pre.Name = "TextBox_pre";
            this.TextBox_pre.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_pre.ShowText = false;
            this.TextBox_pre.Size = new System.Drawing.Size(93, 34);
            this.TextBox_pre.TabIndex = 0;
            this.TextBox_pre.Text = "5.00";
            this.TextBox_pre.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextBox_pre.Watermark = "";
            // 
            // uiButton7
            // 
            this.uiButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton7.Location = new System.Drawing.Point(159, 63);
            this.uiButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton7.Name = "uiButton7";
            this.uiButton7.Size = new System.Drawing.Size(100, 35);
            this.uiButton7.TabIndex = 12;
            this.uiButton7.Text = "确定";
            this.uiButton7.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton7.Click += new System.EventHandler(this.uiButton7_Click);
            // 
            // uiTitlePanel10
            // 
            this.uiTitlePanel10.Controls.Add(this.uiButton9);
            this.uiTitlePanel10.Controls.Add(this.uiButton8);
            this.uiTitlePanel10.Controls.Add(this.TextBox_wd2);
            this.uiTitlePanel10.Controls.Add(this.TextBox_wd1);
            this.uiTitlePanel10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel10.Location = new System.Drawing.Point(589, 737);
            this.uiTitlePanel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel10.Name = "uiTitlePanel10";
            this.uiTitlePanel10.ShowText = false;
            this.uiTitlePanel10.Size = new System.Drawing.Size(561, 124);
            this.uiTitlePanel10.TabIndex = 14;
            this.uiTitlePanel10.Text = "看门狗参数设置（ms）";
            this.uiTitlePanel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_wd1
            // 
            this.TextBox_wd1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_wd1.DoubleValue = 2500D;
            this.TextBox_wd1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_wd1.IntValue = 2500;
            this.TextBox_wd1.Location = new System.Drawing.Point(21, 64);
            this.TextBox_wd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_wd1.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_wd1.Name = "TextBox_wd1";
            this.TextBox_wd1.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_wd1.ShowText = false;
            this.TextBox_wd1.Size = new System.Drawing.Size(96, 34);
            this.TextBox_wd1.TabIndex = 0;
            this.TextBox_wd1.Text = "2500";
            this.TextBox_wd1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextBox_wd1.Watermark = "";
            // 
            // TextBox_wd2
            // 
            this.TextBox_wd2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_wd2.DoubleValue = 5000D;
            this.TextBox_wd2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_wd2.IntValue = 5000;
            this.TextBox_wd2.Location = new System.Drawing.Point(318, 64);
            this.TextBox_wd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_wd2.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox_wd2.Name = "TextBox_wd2";
            this.TextBox_wd2.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_wd2.ShowText = false;
            this.TextBox_wd2.Size = new System.Drawing.Size(96, 35);
            this.TextBox_wd2.TabIndex = 1;
            this.TextBox_wd2.Text = "5000";
            this.TextBox_wd2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextBox_wd2.Watermark = "";
            // 
            // uiButton8
            // 
            this.uiButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton8.Location = new System.Drawing.Point(124, 64);
            this.uiButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton8.Name = "uiButton8";
            this.uiButton8.Size = new System.Drawing.Size(145, 35);
            this.uiButton8.TabIndex = 2;
            this.uiButton8.Text = "循环转动看门狗";
            this.uiButton8.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton8.Click += new System.EventHandler(this.uiButton8_Click);
            // 
            // uiButton9
            // 
            this.uiButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton9.Location = new System.Drawing.Point(421, 64);
            this.uiButton9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton9.Name = "uiButton9";
            this.uiButton9.Size = new System.Drawing.Size(120, 35);
            this.uiButton9.TabIndex = 3;
            this.uiButton9.Text = "位置看门狗";
            this.uiButton9.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton9.Click += new System.EventHandler(this.uiButton9_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1171, 866);
            this.Controls.Add(this.uiTitlePanel10);
            this.Controls.Add(this.uiTitlePanel9);
            this.Controls.Add(this.uiTitlePanel8);
            this.Controls.Add(this.uiTitlePanel7);
            this.Controls.Add(this.uiTitlePanel3);
            this.Controls.Add(this.uiTitlePanel6);
            this.Controls.Add(this.uiTitlePanel5);
            this.Controls.Add(this.uiTitlePanel4);
            this.Controls.Add(this.TextBox_sp);
            this.Controls.Add(this.uiTitlePanel2);
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.uiSmoothLabel4);
            this.Controls.Add(this.TextBox_main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "电机驱动板上位机";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1736, 888);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel5.ResumeLayout(false);
            this.uiTitlePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Angle)).EndInit();
            this.uiTitlePanel6.ResumeLayout(false);
            this.uiTitlePanel7.ResumeLayout(false);
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel9.ResumeLayout(false);
            this.uiTitlePanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_serach_ports;
        private System.Windows.Forms.ComboBox comboBox1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.Button button1;
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
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UITrackBar uiTrackBar1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITitlePanel uiTitlePanel4;
        private Sunny.UI.UITitlePanel uiTitlePanel5;
        private System.Windows.Forms.TrackBar trackBar_Angle;
        private Sunny.UI.UITextBox TextBox_Angle;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITitlePanel uiTitlePanel6;
        private System.Windows.Forms.Button button4;
        private Sunny.UI.UITextBox TextBox_setaddr;
        private Sunny.UI.UITitlePanel uiTitlePanel7;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UITextBox TextBox_scan_end;
        private Sunny.UI.UITextBox TextBox_scan_start;
        private Sunny.UI.UITitlePanel uiTitlePanel8;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UISmoothLabel uiSmoothLabel5;
        private System.Windows.Forms.Button button5;
        private Sunny.UI.UITextBox uiTextBox2;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private System.Windows.Forms.Timer timer2;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UITitlePanel uiTitlePanel9;
        private Sunny.UI.UITextBox TextBox_pre;
        private Sunny.UI.UIButton uiButton7;
        private Sunny.UI.UITitlePanel uiTitlePanel10;
        private Sunny.UI.UIButton uiButton9;
        private Sunny.UI.UIButton uiButton8;
        private Sunny.UI.UITextBox TextBox_wd2;
        private Sunny.UI.UITextBox TextBox_wd1;
    }
}

