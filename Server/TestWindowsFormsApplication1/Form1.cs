using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;

delegate void HandleInterfaceUpdate(string text);

namespace TestWindowsFormsApplication1
{
    public partial class MainControl : Form
    {
        public MessageBoxButtons buttonType { get; set; }
        public MessageBoxIcon iconType;
        HandleInterfaceUpdate interfaceUpdate;
        private delegate void wifi(string text, RichTextBox richtexBox);
        private delegate void Set(byte[] buffer, RichTextBox richTextBox);
        private bool connected_to_clinent = false;
        //private static int port;

        int error_counter = 0;

        public MainControl()
        {
            InitializeComponent();
            interfaceUpdate = new HandleInterfaceUpdate(UpdateTextBox);
        }

        public class SocketInfo
        {
            public byte[] buffer = new byte[255];
            public Socket socketWatch = null;
        }

        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket linkSocket = null;
        SocketInfo info = new SocketInfo();

        private void WIFIData_Process(string text, RichTextBox richTextBox)
        {
            richTextBox.Text += text;
            Local_System_Update(text);
            //wifi_Send_data("hello");
        }

        private void ShowData(byte[] buffer, RichTextBox richTextBox)
        {
            richTextBox.Text += Encoding.Default.GetString(buffer);
        }   
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComButton_Click(object sender, EventArgs e)
        {
            string CommNum = this.ComNum.Text;
            string ParityCheck = this.Parity.Text;
            int IntBdr = Convert.ToInt32(this.BTL.Text);//将串口号和波特率存起来
            if (!myscom.IsOpen)                      //如果串口是关闭的
            {
                myscom.PortName = CommNum;
                myscom.BaudRate = IntBdr;           //设定串口号和波特率
                //选择奇偶校验位
                switch (ParityCheck)
                {
                    case "None": myscom.Parity = System.IO.Ports.Parity.None; break;
                    case "Even": myscom.Parity = System.IO.Ports.Parity.Even; break;
                    case "Odd": myscom.Parity = System.IO.Ports.Parity.Odd; break;
                    case "Mark": myscom.Parity = System.IO.Ports.Parity.Mark; break;
                    case "Space": myscom.Parity = System.IO.Ports.Parity.Space; break;
                };

                try     //try:尝试下面的代码，如果错误就跳出来执行catch里面代码
                {
                    //myscom.Open();          
                    ComButton.Text = "关闭串口"; //改变按钮上的字符
                    ComNum.Enabled = false;
                    BTL.Enabled = false;
                    Parity.Enabled = false;     //将串口号与波特率选择控件关闭
                    myscom.WriteTimeout = 20000;
                    myscom.ReadTimeout = 20000;
                    myscom.ReadBufferSize = 20480;
                    myscom.WriteBufferSize = 20480;
                    myscom.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                    myscom.Open();//打开串口
                }
                catch
                {
                    iconType = MessageBoxIcon.Error;
                    buttonType = MessageBoxButtons.OK;
                    MessageBox.Show("串口打开失败！\n请重新检查", "Error", buttonType, iconType, 0, 0);
                    ComNum.Enabled = true;
                    BTL.Enabled = true;
                    Parity.Enabled = true;
                    ComButton.Text = "打开串口";
                }
            }
            else//如果串口是打开的
            {
                myscom.Close();         //关闭串口；
                ComButton.Text = "打开串口"; //改变按钮上的字符
                ComNum.Enabled = true;
                BTL.Enabled = true;         //将串口号与波特率选择控件打开
                Parity.Enabled = true;
            }
        }

        string SerialPort_command;
        bool SerialPort_flag = false;
        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string portName = ((SerialPort)sender).PortName;
            try
            {
                if (this.myscom.IsOpen && this.myscom.BytesToRead > 0)
                {
                    int readLength = this.myscom.BytesToRead;
                    int offset = 0;
                    byte[] data = new byte[readLength];
                    do
                    {
                        int byteLenght = this.myscom.Read(data, offset, readLength);
                        offset += byteLenght;
                        readLength -= byteLenght;
                    } while (readLength > 0);
                    Set set = new Set(this.ShowData);
                    this.Invoke(set, data, ReceiveBox);
                    if (data[0] == '~')
                    {
                        SerialPort_command = Encoding.ASCII.GetString(data);
                        SerialPort_flag = true;
                    }
                    if (SerialPort_flag && data[data.Length - 1] != '\r' && data[0] != '~')
                    {
                        SerialPort_command += Encoding.ASCII.GetString(data);
                    }
                    if (data[data.Length - 1] == '\r')
                    {
                        SerialPort_flag = false;
                        if (error_counter > 1)
                        {
                            this.Invoke(interfaceUpdate, new string[] { SerialPort_command });
                            if (connected_to_clinent) wifi_Send_data(SerialPort_command);
                        }
                        SerialPort_command = "";
                    }
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string Pcommand = null;
        private void UpdateTextBox(string text)
        {
            Pcommand = text;
        }

        private void SendCmd_Click(object sender, EventArgs e)
        {
            string Message = VER.Text + ADR.Text + CMD1.Text + CMD2.Text + LENGTH.Text + INFO.Text + CHECK.Text;
            if (myscom.IsOpen)
            {
                if (Message != "") //如果数据不为空
                {
                    myscom.Write('~' + Message + '\r');
                }
                else
                {
                    iconType = MessageBoxIcon.Warning;
                    buttonType = MessageBoxButtons.OK;
                    MessageBox.Show("发送失败！\n请确认已输入数据", "Warning", buttonType, iconType, 0, 0);
                }
            }
            else
            {
                iconType = MessageBoxIcon.Warning;
                buttonType = MessageBoxButtons.OK;
                MessageBox.Show("发送失败！\n请先打开串口", "Warning", buttonType, iconType, 0, 0);
            }
        }

        private void Invoke()
        {
            throw new NotImplementedException();
        }

        private void ClearOut_Click(object sender, EventArgs e)
        {
            this.ReceiveBox.Text = "";
        }

        private void CheckSum_Click(object sender, EventArgs e)
        {
            CHECK.Text = CHECKSUM(VER.Text + ADR.Text + CMD1.Text + CMD2.Text + LENGTH.Text + INFO.Text);
        }

        public string CHECKSUM(string t)
        {

            int b = 0;
            int c = 0, d = 0;
            int x = t.Length / 2;

            for (int i = 0; i < x; ++i)
            {
                b = b + Convert.ToInt32(t.Substring(i * 2, 2),16);
            }

            int Csum = 256 - b;
            c = Csum / 16; d = Csum % 16;

            string R = INT_CHAR(c) + INT_CHAR(d);
            return R;
        }

        public string INT_CHAR(int i)
        {

            switch (i)
            {
                case (0): return "0";
                case (1): return "1";
                case (2): return "2";
                case (3): return "3";
                case (4): return "4";
                case (5): return "5";
                case (6): return "6";
                case (7): return "7";
                case (8): return "8";
                case (9): return "9";
                case (10): return "A";
                case (11): return "B";
                case (12): return "C";
                case (13): return "D";
                case (14): return "E";
                case (15): return "F";
                default: return "0";
            }

        }

        //不断向单片机请求查询温度
        private void watertimer1_Tick(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "01" + "01" + "04" + "00";
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
        }

        private void ErrorProcessing(string rth)
        {
            if(rth == "FF")
            {
                MessageBox.Show("命令过短或未收到\"~\"。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rth == "01")
            {
                MessageBox.Show("协议版本错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rth == "02")
            {
                MessageBox.Show("校验和不匹配。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rth == "03")
            {
                MessageBox.Show("未定义指令。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rth == "04")
            {
                MessageBox.Show("INFO与LENGTH不匹配。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rth=="05")
            {
                MessageBox.Show("超声波探伤失败，请确认探头位置是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        int online = 0;
        private void watertimer2_Tick(object sender, EventArgs e)
        {
            if (Pcommand == null || Pcommand.Length < 13)
                return;
            string tmp = Pcommand;
            Pcommand = null;
            if (tmp.Substring(7, 2) != "00")
            {
                string rth = tmp.Substring(7, 2);
                ErrorProcessing(rth);
                return;
            }
            if (tmp.Substring(3, 2) != "01")
                return;
            online++;
            string rspd = tmp.Substring(5, 2);
            if((rspd == "01" || rspd == "02") && tmp.Length >= 13)
            {
                string success = tmp.Substring(11, 2);
                if (success == "00")
                    waterInfo.Text += "温度设置失败\n";
                if (success == "01")
                    waterInfo.Text += "温度设置成功\n";
            }
            if(rspd == "03" && tmp.Length >= 13)
            {
                string success = tmp.Substring(11, 2);
                if (success == "00")
                {
                    waterInfo.Text += "加热失败\n";
                }
                else
                {
                    waterInfo.Text += "开始加热\n";
                }
            }
            if(rspd == "04" && tmp.Length >= 13)
            {
                int currentTempreture = Convert.ToInt32(tmp.Substring(11, 2), 16);
                currentTemp.Text = Convert.ToString(currentTempreture);
                if (currentTempreture >= 90){
                    progressBar1.ForeColor = Color.Red;
                }
                else{
                    progressBar1.ForeColor = Color.Lime;
                }
            }
            if(rspd == "00" && tmp.Length >= 13)
            {
                string success = tmp.Substring(11, 2);
                if (success == "00")
                    stable.Text = "不在加热\n";
                else
                    stable.Text = "正在加热\n";
            }
        }

        private void watertimer3_Tick(object sender, EventArgs e)
        {
            if (currentTemp.Text != "未知")
            {
                if (progressBar1.Value < Convert.ToInt32(currentTemp.Text))
                {
                    progressBar1.Increment(1);
                }
                else if (progressBar1.Value > Convert.ToInt32(currentTemp.Text))
                {
                    progressBar1.Value -= 1;
                }
            }
        }

        private void watertimer4_Tick(object sender, EventArgs e)
        {
            if (online > 0){
                online = 0;
                lblonline.Text = "在线";
                return;
            }
            else{
                online = 0;
                lblonline.Text = "不在线";
            }
        }

        private void waterStartButtom_Process()
        {
            if (waterStartButton.Text == "启动")
            {
                waterStartButton.Text = "停止";
                watertimer1.Enabled = true;
                watertimer2.Enabled = true;
                watertimer3.Enabled = true;
                watertimer4.Enabled = true;

                stable.Text = "不在加热";
                lblonline.Text = "不在线";
                currentTemp.Text = "未知";
                progressBar1.Maximum = 99;
                progressBar1.Minimum = 0;
                progressBar1.Visible = true;
                waterInfo.Text = "";
            }
            else
            {
                waterStartButton.Text = "启动";
                watertimer1.Enabled = false;
                watertimer2.Enabled = false;
                watertimer3.Enabled = false;
                watertimer4.Enabled = false;
            }
        }

        private void waterStartButton_Click(object sender, EventArgs e)
        {
            waterStartButtom_Process();
            error_counter = 2;
        }

        private void waterStopButton_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "01" + "01" + "00" + "00";
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
        }

        //控制是否开始加热
        private void stopHeat_Click(object sender, EventArgs e)
        {
            string Message;
            if(stopHeat.Text == "开始加热")
            {
                stopHeat.Text = "停止加热";
                Message = "10" + "01" + "01" + "03" + "01" + "00";
                Message = Message + CHECKSUM(Message);
                myscom.Write("~" + Message + "\r");
            }
            else
            {
                stopHeat.Text = "开始加热";
                Message = "10" + "01" + "01" + "03" + "01" + "01";
                Message = Message + CHECKSUM(Message);
                myscom.Write("~" + Message + "\r");
            }
        }
        //根据温度的上限和下限编辑并发送指令
        private void setTemp_Click(object sender, EventArgs e)
        {
            int upperTempreture, lowerTempreture;
            string upper = upperTemp.Text;
            string lower = lowerTemp.Text;
            watertimer1.Enabled = false;

            try
            {
                upperTempreture = Convert.ToInt16(upper,10);
                lowerTempreture = Convert.ToInt16(lower,10);
            }
            catch
            {
                MessageBox.Show("只能输入整数。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                watertimer1.Enabled = true;
                return;
            }

            if (upperTempreture >= 100 || upperTempreture < 30 || lowerTempreture >= 100 || lowerTempreture < 30)
            {
                MessageBox.Show("温度超出范围，请输入（30-99）。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                watertimer1.Enabled = true;
                return;
            }
            if(upperTempreture < lowerTempreture)
            {
                MessageBox.Show("最大温度应小于最小温度。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                watertimer1.Enabled = true;
                return;
            }

            string Message;

            Message = "10" + "01" + "01" + "01" + "01";
            string tmp = Convert.ToString(upperTempreture, 16);
            tmp = tmp.ToUpper();
            Message = Message + tmp;
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
            Thread.Sleep(100);
            Message = "10" + "01" + "01" + "02" + "01";
            tmp = Convert.ToString(lowerTempreture, 16);
            tmp = tmp.ToUpper();
            Message = Message + tmp;
           // Message = Message + Convert.ToString(lowerTempreture, 16);
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");

        }

        private void ulsoStart_Process()
        {
            if (ulsoStart.Text == "启动")
            {
                ulsotimer1.Enabled = true;
                ulsoStart.Text = "停止";
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                progressBar4.Value = 0;
                ulsoStatus.Text = "";
            }
            else
            {
                ulsotimer1.Enabled = false;
                ulsoStart.Text = "启动";
            }
        }

        private void ulsoStart_Click(object sender, EventArgs e)
        {
            ulsoStart_Process();
        }

        private void ulsotimer1_Tick(object sender, EventArgs e)
        {
            if (Pcommand == null || Pcommand.Length < 13)
                return;
            string tmp = Pcommand;
            Pcommand = null;
            if (tmp.Substring(7, 2) != "00")
            {
                string rth = tmp.Substring(7, 2);
                ErrorProcessing(rth);
                return;
            }
            if (tmp.Substring(3, 2) != "03")
                return;
            string rspd = tmp.Substring(5, 2);
            if (rspd == "01")
            {
                string length = tmp.Substring(9, 2);
                if (length == "02" && tmp.Length >= 15)
                {
                    int width1Int = Convert.ToInt32(tmp.Substring(11, 2), 16);
                    int width1Dec = Convert.ToInt32(tmp.Substring(13, 2), 16);
                    int time1 = width1Dec + width1Int * 256;
                    int width1 = time1 * 1200 / 1000;
                    firstThick.Text = Convert.ToString(width1/100) + "." + Convert.ToString(width1%100) + "mm";
                    progressBar2.Value = width1;
                }
                if (length == "04" && tmp.Length >= 19)
                {
                    int width1Int = Convert.ToInt32(tmp.Substring(11, 2), 16);
                    int width1Dec = Convert.ToInt32(tmp.Substring(13, 2), 16);
                    int width2Int = Convert.ToInt32(tmp.Substring(15, 2), 16);
                    int width2Dec = Convert.ToInt32(tmp.Substring(17, 2), 16);
                    int time1 = width1Dec + width1Int * 256;
                    int width1 = time1 * 1200 / 1000;
                    firstThick.Text = Convert.ToString(width1 / 100) + "." + Convert.ToString(width1 % 100) + "mm";
                    progressBar2.Value = width1;
                    int time2 = width2Dec + width2Int * 256;
                    int width2 = time2 * 1200 / 1000;
                    //if (!(width1 <= width2 + 100 || width1 >= width2Dec - 100))
                    //{
                        secondThick.Text = Convert.ToString(width2 / 100) + "." + Convert.ToString(width2 % 100) + "mm";
                        progressBar3.Value = width2;
                    //}
                }
            }
        }
        //发送请求测量信号，返回是否能够测量
        private void requestStatus_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "03" + "03" + "01" + "00";
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
            error_counter++;
        }
       
        int speedOnline = 0;
        private void motortimer1_Tick(object sender, EventArgs e)
        {
            if (Pcommand == null || Pcommand.Length < 13)
                return;
            string tmp = Pcommand;
            Pcommand = null;
            if (tmp.Substring(7, 2) != "00")
            {
                string rth = tmp.Substring(7, 2);
                ErrorProcessing(rth);
                return;
            }
            if (tmp.Substring(3, 2) != "02")
                return;
            speedOnline++;
            string rspd = tmp.Substring(5, 2);
            if(rspd == "01")
            {
                string success = tmp.Substring(11, 2);
                if (success == "00")
                    motorStatus.Text += "旋转方向设置失败\n";
                else
                    motorStatus.Text += "旋转方向设置成功\n";
            }
            if(rspd == "02")
            {
                string success = tmp.Substring(11, 2);
                if (success == "00")
                    motorStatus.Text += "转速设置失败\n";
                else
                    motorStatus.Text += "转速设置成功\n";
            }
            if (rspd == "06" && tmp.Length >= 15 && tmp.Substring(9, 2) == "02")
            {
                int speedDec = Convert.ToInt32(tmp.Substring(11, 2), 16);
                string stable = tmp.Substring(13, 2);
                int speed = speedDec;
                currentSpeed.Text = Convert.ToString(speed);
                if (stable == "00")
                {
                    //motorStable.Text = "不稳定";
                    CurrentDir.Text = "正转";
                }
                else
                {
                    //motorStable.Text = "稳定";
                    CurrentDir.Text = "反转";
                }
                    
            }
            if(rspd == "03")
            {
                string success = tmp.Substring(11, 2);
                if (success == "01")
                    motorStatus.Text += "复位成功\n";
                else
                    motorStatus.Text += "复位失败\n";
            }
            if(rspd == "04")
            {
                string success = tmp.Substring(11, 2);
                if (success == "01")
                    motorStatus.Text += "启动成功\n";
                else
                    motorStatus.Text += "启动失败\n";
            }
            if (rspd == "05")
            {
                string success = tmp.Substring(11, 2);
                if (success == "01")
                    motorStatus.Text += "停止成功\n";
                else
                    motorStatus.Text += "停止失败\n";
            }
            //根据协议判断返回值并输出到测试box
        }
        //发送启动电机信号

        private void motorStart_Process()
        {
            if (motorStart.Text == "启动")
            {
                string Message;
                Message = "10" + "02" + "02" + "04" + "00";
                Message = Message + CHECKSUM(Message);
                myscom.Write("~" + Message + "\r");
                motorStart.Text = "停止";
                currentSpeed.Text = "未知";
                motoronline.Text = "不在线";
                motorStatus.Text = "";
                progressBar5.Value = 0;
                motortimer1.Enabled = true;
                motortimer2.Enabled = true;
                motortimer3.Enabled = true;
                motortimer4.Enabled = true;
            }
            else
            {
                string Message;
                Message = "10" + "02" + "02" + "05" + "00";
                Message = Message + CHECKSUM(Message);
                myscom.Write("~" + Message + "\r");
                motorStart.Text = "启动";
                currentSpeed.Text = "未知";
                motoronline.Text = "不在线";
                motortimer1.Enabled = false;
                motortimer2.Enabled = false;
                motortimer3.Enabled = false;
                motortimer4.Enabled = false;
            }
        }

        private void motorStart_Click(object sender, EventArgs e)
        {
            motorStart_Process();
            error_counter = 2;
        }
        //发送重启电机信号，返回当前转速与方向
        private void motorRestart_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "02" + "02" + "03" + "00";
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
        }
        //发送电机转动方向信号，返回是否设置成功
        private void motorDir_Click(object sender, EventArgs e)
        {
            if(motorDir.Text == "正转")
            {
                string Message;
                Message = "10" + "02" + "02" + "01" + "01" + "00";
                Message = Message + CHECKSUM(Message);
                myscom.Write("~" + Message + "\r");
                motorDir.Text = "反转";
            }
            else
            {
                string Message;
                Message = "10" + "02" + "02" + "01" + "01" + "01";
                Message = Message + CHECKSUM(Message);
                myscom.Write("~" + Message + "\r");
                motorDir.Text = "正转";

              
            }
        }
        //发送转速信号，反馈当前转速及方向信号
        
        private void pingButton_Click(object sender, EventArgs e)
        {
            string Message = null;
            Message = "100101010101EB";
            myscom.Write("~" + Message + "\r");
        }

        private void motortimer2_Tick(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "02" + "02" + "06" + "00";
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
        }

        private void motortimer3_Tick(object sender, EventArgs e)
        {
            if (currentSpeed.Text != "未知")
            {
                if (progressBar5.Value < Convert.ToInt32(currentSpeed.Text))
                {
                    progressBar5.Increment(1);
                }
                else if (progressBar5.Value > Convert.ToInt32(currentSpeed.Text))
                {
                    progressBar5.Value -= 1;
                }
            }
        }

        private void motortimer4_Tick(object sender, EventArgs e)
        {
            if (speedOnline > 0)
            {
                speedOnline = 0;
                motoronline.Text = "在线";
                return;
            }
            else
            {
                speedOnline = 0;
                motoronline.Text = "不在线";
            }
        }

        private void FSButton_Click(object sender, EventArgs e)
        {
            string Message = generalCom.Text;
            myscom.Write("~" + Message + "\r");
        }

        private void speedUp_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "02" + "02" + "02" + "01" + "01";
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
        }

        private void speedDown_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "02" + "02" + "02" + "01" + "00";
            Message = Message + CHECKSUM(Message);
            myscom.Write("~" + Message + "\r");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Message;
            //string speed = speedText.Text;

            Message = "10" + "02" + "02" + "02" + "01";
            string speed;

            int set_speed;//步进加减和设置转速共用一个cmd2指令01, 当info 为01/00时表示步进，否则为直接设定温度
            try
            {
                speed = speedText.Text;
                set_speed = Convert.ToInt32(speed);
            }
            catch
            {
                MessageBox.Show("请输入整数。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (set_speed >= 5 && set_speed <= 75)
            {
                string tmp = Convert.ToString(set_speed, 16);
                tmp = tmp.ToUpper();
                Message = Message + tmp;
                Message = Message + CHECKSUM(Message);
                
                myscom.Write("~" + Message + "\r");
            }
            else
            {
                MessageBox.Show("请输入5-75之间的整数。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void StartListening_Click(object sender, EventArgs e)
        {
            string port = portBox.Text;
            IPAddress ip = IPAddress.Any;
            try
            {
                info.socketWatch = serverSocket;
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(port));
                
                if (!info.socketWatch.Connected)
                {
                    info.socketWatch.Bind(point);
                    ListenStatus.AppendText("尝试监听中...\r\n");
                    info.socketWatch.Listen(10);
                    ListenStatus.AppendText("监听成功！\r\n");

                    linkSocket = info.socketWatch.Accept();
                    ListenStatus.AppendText("监听到客户端：" + linkSocket.RemoteEndPoint.ToString() + "\r\n");
                    portBox.Enabled = false;
                    connected_to_clinent = true;
                    linkSocket.BeginReceive(info.buffer, 0, info.buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), info);
                }
            }
            catch
            {
                portBox.Enabled = true;
                MessageBox.Show("连接失败，请检查网络", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        void ReceiveCallback(IAsyncResult result)
        {
            SocketInfo info = (SocketInfo)result.AsyncState;
            try
            {
                int bytestoread = linkSocket.EndReceive(result);
                if (bytestoread > 0)
                {
                    string text = Encoding.ASCII.GetString(info.buffer, 0, bytestoread);
                    wifi wifiReceive = new wifi(this.WIFIData_Process);
                    this.Invoke(wifiReceive, text, ListenStatus); //用这个进程来更新当前Socket收到的数据
                    //this.Invoke(interfaceUpdate, text);
                    linkSocket.BeginReceive(info.buffer, 0, 255, SocketFlags.None, new AsyncCallback(ReceiveCallback), info);
                }
                else
                {
                    //WIFIReceive.Text = "Client finished normally.";
                    connected_to_clinent = false;
                    linkSocket.Close();
                    info.socketWatch.Close();
                }
            }
            catch (Exception)
            {
                //WIFIReceive.Text = "Client Disconnected.";
            }
        }
        //同步send，如果不行的话改成异步send
        public void wifi_Send_data(string msg)
        {
            try
            {
                if (linkSocket.Connected)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(msg);
                    linkSocket.Send(buffer, buffer.Length, SocketFlags.None);
                }
                else
                {
                    MessageBox.Show("未侦听到客户端IP！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("发生非连接错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //更新本地主机控制状态，并将wifi指令转发给串口总线
        public void Local_System_Update(string wifi_command)
        {
            string cmd_addr = wifi_command.Substring(3, 2);
            string cmd_1 = wifi_command.Substring(5, 2);
            string cmd_2 = wifi_command.Substring(7, 2);
            string cmd_length = wifi_command.Substring(9, 2);
            int length = Convert.ToInt32(cmd_length, 16);
            string cmd_info = wifi_command.Substring(11, 2*length);
            bool only_start = false;

            switch(cmd_addr)
            {
                case "01":
                    if(cmd_1=="00")
                    {
                        only_start = true;
                        waterStartButtom_Process();
                        error_counter = 2;
                    }
                    break;
                case "02":
                    if(cmd_2=="01")
                    {
                        if (motorDir.Text == "正转")
                        {
                            motorDir.Text = "反转";
                        }
                        else
                        {
                            motorDir.Text = "正转";
                        }
                    }
                    else if(cmd_2=="02"&&cmd_info.Substring(0,2)!="00"&&cmd_info.Substring(0,2)!="01")
                    {
                        int speed = Convert.ToInt32(cmd_info.Substring(0, 2),16);
                        speedText.Text = Convert.ToString(speed, 10);
                    }
                    else if(cmd_1=="00")
                    {
                        motorStart_Process();
                        error_counter = 2;
                    }
                    break;
                case "03":
                    if(cmd_1=="00")
                    {
                        only_start = true;
                        ulsoStart_Process();
                    }
                    else
                    {
                        error_counter++;
                    }
                    break;
                default: break;
            }

            if(!only_start)
            {
                myscom.Write(wifi_command);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (info.socketWatch.Connected)
            {
                connected_to_clinent = false;
                linkSocket.Close();
                info.socketWatch.Close();
                ListenStatus.AppendText("已断开与客户端IP的连接\r\n");
                portBox.Enabled = true;
            }
            else
            {
                connected_to_clinent = false;
                ListenStatus.AppendText("已断开与客户端IP的连接\r\n");
                portBox.Enabled = true;
            }
        }
    }
}
