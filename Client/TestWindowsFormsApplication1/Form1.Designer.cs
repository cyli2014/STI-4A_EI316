namespace TestWindowsFormsApplication1
{
    partial class MainControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComButton = new System.Windows.Forms.Button();
            this.BTL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FSButton = new System.Windows.Forms.Button();
            this.generalCom = new System.Windows.Forms.TextBox();
            this.CheckSum = new System.Windows.Forms.Button();
            this.VER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ADR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMD1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CMD2 = new System.Windows.Forms.TextBox();
            this.SendCmd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CHECK = new System.Windows.Forms.TextBox();
            this.LENGTH = new System.Windows.Forms.TextBox();
            this.INFO = new System.Windows.Forms.TextBox();
            this.myscom = new System.IO.Ports.SerialPort(this.components);
            this.ReceiveBox = new System.Windows.Forms.RichTextBox();
            this.ClearOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pingButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.currentTemp = new System.Windows.Forms.Label();
            this.waterInfo = new System.Windows.Forms.RichTextBox();
            this.lblonline = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stable = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setTemp = new System.Windows.Forms.Button();
            this.upperTemp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.waterstopButton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.stopHeat = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.waterStartButton = new System.Windows.Forms.Button();
            this.lowerTemp = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.firstThick = new System.Windows.Forms.Label();
            this.ulsoStatus = new System.Windows.Forms.RichTextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.thirdThick = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.secondThick = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ulsoStart = new System.Windows.Forms.Button();
            this.requestStatus = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.currentSpeed = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.motorStatus = new System.Windows.Forms.RichTextBox();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.motoronline = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.speedText = new System.Windows.Forms.TextBox();
            this.speedUp = new System.Windows.Forms.Button();
            this.motorStart = new System.Windows.Forms.Button();
            this.motorDir = new System.Windows.Forms.Button();
            this.motorRestart = new System.Windows.Forms.Button();
            this.speedDown = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.connectStatus = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.tabpage6 = new System.Windows.Forms.TabPage();
            this.watertimer1 = new System.Windows.Forms.Timer(this.components);
            this.watertimer2 = new System.Windows.Forms.Timer(this.components);
            this.watertimer3 = new System.Windows.Forms.Timer(this.components);
            this.watertimer4 = new System.Windows.Forms.Timer(this.components);
            this.ulsotimer1 = new System.Windows.Forms.Timer(this.components);
            this.motortimer1 = new System.Windows.Forms.Timer(this.components);
            this.motortimer2 = new System.Windows.Forms.Timer(this.components);
            this.motortimer3 = new System.Windows.Forms.Timer(this.components);
            this.motortimer4 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComButton);
            this.groupBox1.Controls.Add(this.BTL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Parity);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(540, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // ComNum
            // 
            this.ComNum.FormattingEnabled = true;
            this.ComNum.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.ComNum.Location = new System.Drawing.Point(82, 26);
            this.ComNum.Margin = new System.Windows.Forms.Padding(2);
            this.ComNum.Name = "ComNum";
            this.ComNum.Size = new System.Drawing.Size(61, 20);
            this.ComNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率：";
            // 
            // ComButton
            // 
            this.ComButton.Location = new System.Drawing.Point(450, 24);
            this.ComButton.Margin = new System.Windows.Forms.Padding(2);
            this.ComButton.Name = "ComButton";
            this.ComButton.Size = new System.Drawing.Size(56, 20);
            this.ComButton.TabIndex = 6;
            this.ComButton.Text = "打开串口";
            this.ComButton.UseVisualStyleBackColor = true;
            this.ComButton.Click += new System.EventHandler(this.ComButton_Click);
            // 
            // BTL
            // 
            this.BTL.FormattingEnabled = true;
            this.BTL.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400"});
            this.BTL.Location = new System.Drawing.Point(210, 26);
            this.BTL.Margin = new System.Windows.Forms.Padding(2);
            this.BTL.Name = "BTL";
            this.BTL.Size = new System.Drawing.Size(61, 20);
            this.BTL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "奇偶校验：";
            // 
            // Parity
            // 
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.Parity.Location = new System.Drawing.Point(349, 26);
            this.Parity.Margin = new System.Windows.Forms.Padding(2);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(61, 20);
            this.Parity.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FSButton);
            this.groupBox2.Controls.Add(this.generalCom);
            this.groupBox2.Controls.Add(this.CheckSum);
            this.groupBox2.Controls.Add(this.VER);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ADR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CMD1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CMD2);
            this.groupBox2.Controls.Add(this.SendCmd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CHECK);
            this.groupBox2.Controls.Add(this.LENGTH);
            this.groupBox2.Controls.Add(this.INFO);
            this.groupBox2.Location = new System.Drawing.Point(8, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(540, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通用发送";
            // 
            // FSButton
            // 
            this.FSButton.Location = new System.Drawing.Point(466, 98);
            this.FSButton.Margin = new System.Windows.Forms.Padding(2);
            this.FSButton.Name = "FSButton";
            this.FSButton.Size = new System.Drawing.Size(56, 20);
            this.FSButton.TabIndex = 16;
            this.FSButton.Text = "发送";
            this.FSButton.UseVisualStyleBackColor = true;
            this.FSButton.Click += new System.EventHandler(this.FSButton_Click);
            // 
            // generalCom
            // 
            this.generalCom.Location = new System.Drawing.Point(22, 100);
            this.generalCom.Margin = new System.Windows.Forms.Padding(2);
            this.generalCom.Name = "generalCom";
            this.generalCom.Size = new System.Drawing.Size(428, 21);
            this.generalCom.TabIndex = 15;
            // 
            // CheckSum
            // 
            this.CheckSum.Location = new System.Drawing.Point(388, 28);
            this.CheckSum.Margin = new System.Windows.Forms.Padding(2);
            this.CheckSum.Name = "CheckSum";
            this.CheckSum.Size = new System.Drawing.Size(56, 20);
            this.CheckSum.TabIndex = 14;
            this.CheckSum.Text = "校验和";
            this.CheckSum.UseVisualStyleBackColor = true;
            this.CheckSum.Click += new System.EventHandler(this.CheckSum_Click);
            // 
            // VER
            // 
            this.VER.Location = new System.Drawing.Point(22, 60);
            this.VER.Margin = new System.Windows.Forms.Padding(2);
            this.VER.Name = "VER";
            this.VER.Size = new System.Drawing.Size(46, 21);
            this.VER.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "VER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "INFO";
            // 
            // ADR
            // 
            this.ADR.Location = new System.Drawing.Point(79, 60);
            this.ADR.Margin = new System.Windows.Forms.Padding(2);
            this.ADR.Name = "ADR";
            this.ADR.Size = new System.Drawing.Size(46, 21);
            this.ADR.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "ADR";
            // 
            // CMD1
            // 
            this.CMD1.Location = new System.Drawing.Point(135, 60);
            this.CMD1.Margin = new System.Windows.Forms.Padding(2);
            this.CMD1.Name = "CMD1";
            this.CMD1.Size = new System.Drawing.Size(46, 21);
            this.CMD1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "LENGTH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "CMD1";
            // 
            // CMD2
            // 
            this.CMD2.Location = new System.Drawing.Point(191, 60);
            this.CMD2.Margin = new System.Windows.Forms.Padding(2);
            this.CMD2.Name = "CMD2";
            this.CMD2.Size = new System.Drawing.Size(46, 21);
            this.CMD2.TabIndex = 3;
            // 
            // SendCmd
            // 
            this.SendCmd.Location = new System.Drawing.Point(466, 60);
            this.SendCmd.Margin = new System.Windows.Forms.Padding(2);
            this.SendCmd.Name = "SendCmd";
            this.SendCmd.Size = new System.Drawing.Size(56, 20);
            this.SendCmd.TabIndex = 7;
            this.SendCmd.Text = "发送";
            this.SendCmd.UseVisualStyleBackColor = true;
            this.SendCmd.Click += new System.EventHandler(this.SendCmd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "CMD2";
            // 
            // CHECK
            // 
            this.CHECK.Location = new System.Drawing.Point(382, 60);
            this.CHECK.Margin = new System.Windows.Forms.Padding(2);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(68, 21);
            this.CHECK.TabIndex = 6;
            // 
            // LENGTH
            // 
            this.LENGTH.Location = new System.Drawing.Point(248, 60);
            this.LENGTH.Margin = new System.Windows.Forms.Padding(2);
            this.LENGTH.Name = "LENGTH";
            this.LENGTH.Size = new System.Drawing.Size(46, 21);
            this.LENGTH.TabIndex = 4;
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(304, 60);
            this.INFO.Margin = new System.Windows.Forms.Padding(2);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(68, 21);
            this.INFO.TabIndex = 5;
            // 
            // ReceiveBox
            // 
            this.ReceiveBox.Location = new System.Drawing.Point(19, 27);
            this.ReceiveBox.Margin = new System.Windows.Forms.Padding(2);
            this.ReceiveBox.Name = "ReceiveBox";
            this.ReceiveBox.Size = new System.Drawing.Size(500, 71);
            this.ReceiveBox.TabIndex = 6;
            this.ReceiveBox.Text = "";
            // 
            // ClearOut
            // 
            this.ClearOut.Location = new System.Drawing.Point(379, 116);
            this.ClearOut.Margin = new System.Windows.Forms.Padding(2);
            this.ClearOut.Name = "ClearOut";
            this.ClearOut.Size = new System.Drawing.Size(56, 20);
            this.ClearOut.TabIndex = 11;
            this.ClearOut.Text = "清空内容";
            this.ClearOut.UseVisualStyleBackColor = true;
            this.ClearOut.Click += new System.EventHandler(this.ClearOut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabpage6);
            this.tabControl1.Location = new System.Drawing.Point(11, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 400);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(558, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "wifi调试";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pingButton);
            this.groupBox5.Controls.Add(this.ReceiveBox);
            this.groupBox5.Controls.Add(this.ClearOut);
            this.groupBox5.Location = new System.Drawing.Point(11, 230);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(536, 142);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据接收";
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(105, 118);
            this.pingButton.Margin = new System.Windows.Forms.Padding(2);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(56, 18);
            this.pingButton.TabIndex = 13;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(558, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "水温控制";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.currentTemp);
            this.groupBox4.Controls.Add(this.waterInfo);
            this.groupBox4.Controls.Add(this.lblonline);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.stable);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(8, 186);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(540, 178);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "状态窗格";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 78);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "控制信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "当前温度：";
            // 
            // currentTemp
            // 
            this.currentTemp.AutoSize = true;
            this.currentTemp.Location = new System.Drawing.Point(96, 26);
            this.currentTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.Size = new System.Drawing.Size(29, 12);
            this.currentTemp.TabIndex = 2;
            this.currentTemp.Text = "未知";
            // 
            // waterInfo
            // 
            this.waterInfo.Location = new System.Drawing.Point(29, 100);
            this.waterInfo.Margin = new System.Windows.Forms.Padding(2);
            this.waterInfo.Name = "waterInfo";
            this.waterInfo.Size = new System.Drawing.Size(482, 66);
            this.waterInfo.TabIndex = 21;
            this.waterInfo.Text = "";
            // 
            // lblonline
            // 
            this.lblonline.AutoSize = true;
            this.lblonline.Location = new System.Drawing.Point(471, 26);
            this.lblonline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblonline.Name = "lblonline";
            this.lblonline.Size = new System.Drawing.Size(41, 12);
            this.lblonline.TabIndex = 23;
            this.lblonline.Text = "不在线";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 47);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(481, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // stable
            // 
            this.stable.AutoSize = true;
            this.stable.Location = new System.Drawing.Point(279, 26);
            this.stable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stable.Name = "stable";
            this.stable.Size = new System.Drawing.Size(53, 12);
            this.stable.TabIndex = 22;
            this.stable.Text = "不在加热";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "是否在线：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "加热状态：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.setTemp);
            this.groupBox3.Controls.Add(this.upperTemp);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.waterstopButton);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.stopHeat);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.waterStartButton);
            this.groupBox3.Controls.Add(this.lowerTemp);
            this.groupBox3.Location = new System.Drawing.Point(8, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(540, 152);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制窗格";
            // 
            // setTemp
            // 
            this.setTemp.Location = new System.Drawing.Point(167, 103);
            this.setTemp.Margin = new System.Windows.Forms.Padding(2);
            this.setTemp.Name = "setTemp";
            this.setTemp.Size = new System.Drawing.Size(60, 36);
            this.setTemp.TabIndex = 5;
            this.setTemp.Text = "设定温度";
            this.setTemp.UseVisualStyleBackColor = true;
            this.setTemp.Click += new System.EventHandler(this.setTemp_Click);
            // 
            // upperTemp
            // 
            this.upperTemp.Location = new System.Drawing.Point(167, 46);
            this.upperTemp.Margin = new System.Windows.Forms.Padding(2);
            this.upperTemp.Name = "upperTemp";
            this.upperTemp.Size = new System.Drawing.Size(46, 21);
            this.upperTemp.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "°C";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(112, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 17;
            this.label22.Text = "最大温度";
            // 
            // waterstopButton
            // 
            this.waterstopButton.Location = new System.Drawing.Point(450, 103);
            this.waterstopButton.Margin = new System.Windows.Forms.Padding(2);
            this.waterstopButton.Name = "waterstopButton";
            this.waterstopButton.Size = new System.Drawing.Size(60, 36);
            this.waterstopButton.TabIndex = 16;
            this.waterstopButton.Text = "状态查询";
            this.waterstopButton.UseVisualStyleBackColor = true;
            this.waterstopButton.Click += new System.EventHandler(this.waterStopButton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(377, 49);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 12);
            this.label24.TabIndex = 20;
            this.label24.Text = "°C";
            // 
            // stopHeat
            // 
            this.stopHeat.Location = new System.Drawing.Point(313, 103);
            this.stopHeat.Margin = new System.Windows.Forms.Padding(2);
            this.stopHeat.Name = "stopHeat";
            this.stopHeat.Size = new System.Drawing.Size(60, 36);
            this.stopHeat.TabIndex = 15;
            this.stopHeat.Text = "开始加热";
            this.stopHeat.UseVisualStyleBackColor = true;
            this.stopHeat.Click += new System.EventHandler(this.stopHeat_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(273, 51);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 18;
            this.label23.Text = "最小温度";
            // 
            // waterStartButton
            // 
            this.waterStartButton.Location = new System.Drawing.Point(29, 103);
            this.waterStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.waterStartButton.Name = "waterStartButton";
            this.waterStartButton.Size = new System.Drawing.Size(60, 36);
            this.waterStartButton.TabIndex = 14;
            this.waterStartButton.Text = "启动";
            this.waterStartButton.UseVisualStyleBackColor = true;
            this.waterStartButton.Click += new System.EventHandler(this.waterStartButton_Click);
            // 
            // lowerTemp
            // 
            this.lowerTemp.Location = new System.Drawing.Point(328, 46);
            this.lowerTemp.Margin = new System.Windows.Forms.Padding(2);
            this.lowerTemp.Name = "lowerTemp";
            this.lowerTemp.Size = new System.Drawing.Size(46, 21);
            this.lowerTemp.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(558, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "超声波探伤";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.firstThick);
            this.groupBox8.Controls.Add(this.ulsoStatus);
            this.groupBox8.Controls.Add(this.progressBar2);
            this.groupBox8.Controls.Add(this.thirdThick);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.progressBar4);
            this.groupBox8.Controls.Add(this.secondThick);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.progressBar3);
            this.groupBox8.Location = new System.Drawing.Point(8, 103);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(540, 261);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "状态窗格";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "第一块：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 184);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 14;
            this.label17.Text = "控制信息";
            // 
            // firstThick
            // 
            this.firstThick.AutoSize = true;
            this.firstThick.Location = new System.Drawing.Point(68, 28);
            this.firstThick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstThick.Name = "firstThick";
            this.firstThick.Size = new System.Drawing.Size(41, 12);
            this.firstThick.TabIndex = 12;
            this.firstThick.Text = "0.00mm";
            // 
            // ulsoStatus
            // 
            this.ulsoStatus.Location = new System.Drawing.Point(19, 204);
            this.ulsoStatus.Margin = new System.Windows.Forms.Padding(2);
            this.ulsoStatus.Name = "ulsoStatus";
            this.ulsoStatus.Size = new System.Drawing.Size(507, 44);
            this.ulsoStatus.TabIndex = 7;
            this.ulsoStatus.Text = "";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(19, 46);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Maximum = 3000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(506, 20);
            this.progressBar2.TabIndex = 10;
            // 
            // thirdThick
            // 
            this.thirdThick.AutoSize = true;
            this.thirdThick.Location = new System.Drawing.Point(68, 132);
            this.thirdThick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thirdThick.Name = "thirdThick";
            this.thirdThick.Size = new System.Drawing.Size(41, 12);
            this.thirdThick.TabIndex = 13;
            this.thirdThick.Text = "0.00mm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 132);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 12;
            this.label19.Text = "第三块：";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(19, 152);
            this.progressBar4.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar4.Maximum = 1500;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(506, 20);
            this.progressBar4.TabIndex = 3;
            // 
            // secondThick
            // 
            this.secondThick.AutoSize = true;
            this.secondThick.Location = new System.Drawing.Point(68, 80);
            this.secondThick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondThick.Name = "secondThick";
            this.secondThick.Size = new System.Drawing.Size(41, 12);
            this.secondThick.TabIndex = 11;
            this.secondThick.Text = "0.00mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "第二块：";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(19, 100);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar3.Maximum = 3000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(506, 20);
            this.progressBar3.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ulsoStart);
            this.groupBox6.Controls.Add(this.requestStatus);
            this.groupBox6.Location = new System.Drawing.Point(8, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(540, 69);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "控制窗格";
            // 
            // ulsoStart
            // 
            this.ulsoStart.Location = new System.Drawing.Point(138, 18);
            this.ulsoStart.Margin = new System.Windows.Forms.Padding(2);
            this.ulsoStart.Name = "ulsoStart";
            this.ulsoStart.Size = new System.Drawing.Size(60, 36);
            this.ulsoStart.TabIndex = 4;
            this.ulsoStart.Text = "启动";
            this.ulsoStart.UseVisualStyleBackColor = true;
            this.ulsoStart.Click += new System.EventHandler(this.ulsoStart_Click);
            // 
            // requestStatus
            // 
            this.requestStatus.Location = new System.Drawing.Point(317, 18);
            this.requestStatus.Margin = new System.Windows.Forms.Padding(2);
            this.requestStatus.Name = "requestStatus";
            this.requestStatus.Size = new System.Drawing.Size(60, 36);
            this.requestStatus.TabIndex = 5;
            this.requestStatus.Text = "请求测量";
            this.requestStatus.UseVisualStyleBackColor = true;
            this.requestStatus.Click += new System.EventHandler(this.requestStatus_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(558, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "电机控制";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.currentSpeed);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.motorStatus);
            this.groupBox9.Controls.Add(this.progressBar5);
            this.groupBox9.Controls.Add(this.motoronline);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Location = new System.Drawing.Point(8, 129);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(539, 234);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "状态窗格";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(35, 106);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 21;
            this.label27.Text = "控制信息";
            // 
            // currentSpeed
            // 
            this.currentSpeed.AutoSize = true;
            this.currentSpeed.Location = new System.Drawing.Point(101, 44);
            this.currentSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentSpeed.Name = "currentSpeed";
            this.currentSpeed.Size = new System.Drawing.Size(29, 12);
            this.currentSpeed.TabIndex = 15;
            this.currentSpeed.Text = "未知";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 44);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "当前转速：";
            // 
            // motorStatus
            // 
            this.motorStatus.Location = new System.Drawing.Point(38, 130);
            this.motorStatus.Margin = new System.Windows.Forms.Padding(2);
            this.motorStatus.Name = "motorStatus";
            this.motorStatus.Size = new System.Drawing.Size(466, 86);
            this.motorStatus.TabIndex = 11;
            this.motorStatus.Text = "";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(38, 70);
            this.progressBar5.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(465, 22);
            this.progressBar5.TabIndex = 18;
            // 
            // motoronline
            // 
            this.motoronline.AutoSize = true;
            this.motoronline.Location = new System.Drawing.Point(464, 44);
            this.motoronline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motoronline.Name = "motoronline";
            this.motoronline.Size = new System.Drawing.Size(41, 12);
            this.motoronline.TabIndex = 17;
            this.motoronline.Text = "不在线";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(398, 44);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 16;
            this.label26.Text = "是否在线：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.speedText);
            this.groupBox7.Controls.Add(this.speedUp);
            this.groupBox7.Controls.Add(this.motorStart);
            this.groupBox7.Controls.Add(this.motorDir);
            this.groupBox7.Controls.Add(this.motorRestart);
            this.groupBox7.Controls.Add(this.speedDown);
            this.groupBox7.Location = new System.Drawing.Point(8, 18);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(539, 107);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "控制窗格";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "设定转速";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(450, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 12);
            this.label21.TabIndex = 23;
            this.label21.Text = "r/s";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(323, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 22;
            this.label20.Text = "转速设置";
            // 
            // speedText
            // 
            this.speedText.Location = new System.Drawing.Point(382, 19);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(62, 21);
            this.speedText.TabIndex = 21;
            this.speedText.TextChanged += new System.EventHandler(this.speedText_TextChanged);
            // 
            // speedUp
            // 
            this.speedUp.Location = new System.Drawing.Point(232, 51);
            this.speedUp.Margin = new System.Windows.Forms.Padding(2);
            this.speedUp.Name = "speedUp";
            this.speedUp.Size = new System.Drawing.Size(60, 36);
            this.speedUp.TabIndex = 12;
            this.speedUp.Text = "加速";
            this.speedUp.UseVisualStyleBackColor = true;
            this.speedUp.Click += new System.EventHandler(this.speedUp_Click);
            // 
            // motorStart
            // 
            this.motorStart.Location = new System.Drawing.Point(28, 51);
            this.motorStart.Margin = new System.Windows.Forms.Padding(2);
            this.motorStart.Name = "motorStart";
            this.motorStart.Size = new System.Drawing.Size(60, 36);
            this.motorStart.TabIndex = 0;
            this.motorStart.Text = "启动";
            this.motorStart.UseVisualStyleBackColor = true;
            this.motorStart.Click += new System.EventHandler(this.motorStart_Click);
            // 
            // motorDir
            // 
            this.motorDir.Location = new System.Drawing.Point(132, 51);
            this.motorDir.Margin = new System.Windows.Forms.Padding(2);
            this.motorDir.Name = "motorDir";
            this.motorDir.Size = new System.Drawing.Size(60, 36);
            this.motorDir.TabIndex = 1;
            this.motorDir.Text = "正转";
            this.motorDir.UseVisualStyleBackColor = true;
            this.motorDir.Click += new System.EventHandler(this.motorDir_Click);
            // 
            // motorRestart
            // 
            this.motorRestart.Location = new System.Drawing.Point(339, 51);
            this.motorRestart.Margin = new System.Windows.Forms.Padding(2);
            this.motorRestart.Name = "motorRestart";
            this.motorRestart.Size = new System.Drawing.Size(60, 36);
            this.motorRestart.TabIndex = 2;
            this.motorRestart.Text = "复位";
            this.motorRestart.UseVisualStyleBackColor = true;
            this.motorRestart.Click += new System.EventHandler(this.motorRestart_Click);
            // 
            // speedDown
            // 
            this.speedDown.Location = new System.Drawing.Point(443, 51);
            this.speedDown.Margin = new System.Windows.Forms.Padding(2);
            this.speedDown.Name = "speedDown";
            this.speedDown.Size = new System.Drawing.Size(60, 36);
            this.speedDown.TabIndex = 13;
            this.speedDown.Text = "减速";
            this.speedDown.UseVisualStyleBackColor = true;
            this.speedDown.Click += new System.EventHandler(this.speedDown_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.disconnect_button);
            this.tabPage5.Controls.Add(this.connectStatus);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Controls.Add(this.portBox);
            this.tabPage5.Controls.Add(this.ipBox);
            this.tabPage5.Controls.Add(this.connect_button);
            this.tabPage5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(558, 374);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "远程服务";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 121);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 8;
            this.label30.Text = "连接状态";
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(407, 70);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(91, 37);
            this.disconnect_button.TabIndex = 7;
            this.disconnect_button.Text = "断开";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // connectStatus
            // 
            this.connectStatus.Location = new System.Drawing.Point(27, 145);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(471, 96);
            this.connectStatus.TabIndex = 6;
            this.connectStatus.Text = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(193, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 5;
            this.label29.Text = "端口号";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(25, 49);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 4;
            this.label28.Text = "远程IP";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(246, 46);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(88, 21);
            this.portBox.TabIndex = 3;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(78, 46);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(83, 21);
            this.ipBox.TabIndex = 2;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(407, 16);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(91, 36);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "请求连接";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // tabpage6
            // 
            this.tabpage6.Location = new System.Drawing.Point(4, 22);
            this.tabpage6.Name = "tabpage6";
            this.tabpage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage6.Size = new System.Drawing.Size(558, 374);
            this.tabpage6.TabIndex = 5;
            this.tabpage6.Text = "关于我们";
            this.tabpage6.UseVisualStyleBackColor = true;
            // 
            // watertimer1
            // 
            this.watertimer1.Interval = 2000;
            this.watertimer1.Tick += new System.EventHandler(this.watertimer1_Tick);
            // 
            // watertimer2
            // 
            this.watertimer2.Tick += new System.EventHandler(this.watertimer2_Tick);
            // 
            // watertimer3
            // 
            this.watertimer3.Interval = 50;
            this.watertimer3.Tick += new System.EventHandler(this.watertimer3_Tick);
            // 
            // watertimer4
            // 
            this.watertimer4.Interval = 5000;
            this.watertimer4.Tick += new System.EventHandler(this.watertimer4_Tick);
            // 
            // ulsotimer1
            // 
            this.ulsotimer1.Tick += new System.EventHandler(this.ulsotimer1_Tick);
            // 
            // motortimer1
            // 
            this.motortimer1.Tick += new System.EventHandler(this.motortimer1_Tick);
            // 
            // motortimer2
            // 
            this.motortimer2.Interval = 2000;
            this.motortimer2.Tick += new System.EventHandler(this.motortimer2_Tick);
            // 
            // motortimer3
            // 
            this.motortimer3.Interval = 50;
            this.motortimer3.Tick += new System.EventHandler(this.motortimer3_Tick);
            // 
            // motortimer4
            // 
            this.motortimer4.Interval = 5000;
            this.motortimer4.Tick += new System.EventHandler(this.motortimer4_Tick);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 442);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainControl";
            this.Text = "工科创4A主控程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ComButton;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort myscom;
        private System.Windows.Forms.TextBox VER;
        private System.Windows.Forms.Button CheckSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendCmd;
        private System.Windows.Forms.TextBox CHECK;
        private System.Windows.Forms.TextBox INFO;
        private System.Windows.Forms.TextBox LENGTH;
        private System.Windows.Forms.TextBox CMD2;
        private System.Windows.Forms.TextBox CMD1;
        private System.Windows.Forms.TextBox ADR;
        private System.Windows.Forms.RichTextBox ReceiveBox;
        private System.Windows.Forms.Button ClearOut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox upperTemp;
        private System.Windows.Forms.Label currentTemp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button setTemp;
        private System.Windows.Forms.Button waterstopButton;
        private System.Windows.Forms.Button stopHeat;
        private System.Windows.Forms.Button waterStartButton;
        private System.Windows.Forms.RichTextBox ulsoStatus;
        private System.Windows.Forms.Button requestStatus;
        private System.Windows.Forms.Button ulsoStart;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label thirdThick;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label secondThick;
        private System.Windows.Forms.Button motorDir;
        private System.Windows.Forms.Button motorStart;
        private System.Windows.Forms.RichTextBox waterInfo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox lowerTemp;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox motorStatus;
        private System.Windows.Forms.Button motorRestart;
        private System.Windows.Forms.Timer watertimer1;
        private System.Windows.Forms.Timer watertimer2;
        private System.Windows.Forms.Timer watertimer3;
        private System.Windows.Forms.Timer watertimer4;
        private System.Windows.Forms.Label stable;
        private System.Windows.Forms.Label lblonline;
        private System.Windows.Forms.Timer ulsotimer1;
        private System.Windows.Forms.Timer motortimer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label firstThick;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button speedDown;
        private System.Windows.Forms.Button speedUp;
        private System.Windows.Forms.Timer motortimer2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label currentSpeed;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label motoronline;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer motortimer3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Timer motortimer4;
        private System.Windows.Forms.Button FSButton;
        private System.Windows.Forms.TextBox generalCom;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox speedText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TabPage tabpage6;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RichTextBox connectStatus;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Label label30;
    }
}

