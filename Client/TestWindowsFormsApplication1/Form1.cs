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
        private delegate void Set(byte[] buffer, RichTextBox richTextBox);
        private delegate void wifi(string text, RichTextBox richTextBox);
        //private static int port;

        public class SocketInfo
        {
            public byte[] buffer = new byte[255];
            public Socket socketSend = null;
        }
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        SocketInfo info = new SocketInfo();

        public MainControl()
        {
            InitializeComponent();
            interfaceUpdate = new HandleInterfaceUpdate(UpdateTextBox);
        }

        private void WIFIData(string text, RichTextBox richTextBox)
        {
            richTextBox.Text += text;
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
                        this.Invoke(interfaceUpdate, new string[] { SerialPort_command });
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
            if (info.socketSend.Connected)
            {
                if (Message != "") //如果数据不为空
                {
                    wifi_Send_data('~' + Message + '\r');
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
                MessageBox.Show("发送失败！\n请先打开主机wifi确保Socket连接", "Warning", buttonType, iconType, 0, 0);
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
        //错误处理
        private void ErrorProcessing(string rth)
        {
            if (rth == "FF")
            {
                MessageBox.Show("命令过短或未收到\"~\"。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rth == "01")
            {
                MessageBox.Show("协议版本错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rth == "02")
            {
                MessageBox.Show("校验和不匹配。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rth == "03")
            {
                MessageBox.Show("未定义指令。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rth == "04")
            {
                MessageBox.Show("INFO与LENGTH不匹配。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rth == "05")
            {
                MessageBox.Show("超声波探伤失败，请检查探头位置。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //不断向单片机请求查询温度
        private void watertimer1_Tick(object sender, EventArgs e)
        {
            //string Message;
            //Message = "10" + "01" + "01" + "04" + "00";
            //Message = Message + CHECKSUM(Message);
            //wifi_Send_data("~" + Message + "\r");
        }

        int online = 0;
        private void watertimer2_Tick(object sender, EventArgs e)
        {
            if (Pcommand == null || Pcommand.Length < 15)
                return;
            string tmp = Pcommand;
            Pcommand = null;
            if (tmp.Substring(3, 2) != "01")
                return;
            online++;
            string rth = tmp.Substring(7, 2);
            if (rth != "00")
            {
                ErrorProcessing(rth);
                return;
            }
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

        private void waterStartButton_Click(object sender, EventArgs e)
        {
            if(waterStartButton.Text == "启动")
            {
                waterStartButton.Text = "停止";
                //watertimer1.Enabled = true;
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
                //watertimer1.Enabled = false;
                watertimer2.Enabled = false;
                watertimer3.Enabled = false;
                watertimer4.Enabled = false;
            }

            //发送启动、停止指令，仅仅控制本地主机的启动，停止，该帧不会转发给串口总线
            string Message = "10" + "01" + "00" + "00" + "00";
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");

        }

        private void waterStopButton_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "01" + "01" + "00" + "00";
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");
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
                wifi_Send_data("~" + Message + "\r");
            }
            else
            {
                stopHeat.Text = "开始加热";
                Message = "10" + "01" + "01" + "03" + "01" + "01";
                Message = Message + CHECKSUM(Message);
                wifi_Send_data("~" + Message + "\r");
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

            string tmp;
            Message = "10" + "01" + "01" + "01" + "01";
            tmp = Convert.ToString(upperTempreture, 16);
            tmp = tmp.ToUpper();
            Message = Message + tmp;
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");
            Thread.Sleep(100);
            Message = "10" + "01" + "01" + "02" + "01";
            tmp = Convert.ToString(lowerTempreture, 16);
            tmp = tmp.ToUpper();
            Message = Message + tmp;
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");

        }

        private void ulsoStart_Click(object sender, EventArgs e)
        {
            if(ulsoStart.Text == "启动")
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

            //发送启动、停止指令，仅仅控制本地主机的启动，停止，该帧不会转发给串口总线
            string Message = "10" + "03" + "00" + "00" + "00";
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");
        }

        private void ulsotimer1_Tick(object sender, EventArgs e)
        {
            if (Pcommand == null || Pcommand.Length < 15)
                return;
            string tmp = Pcommand;
            Pcommand = null;
            if (tmp.Substring(3, 2) != "03")
                return;
            string rth = tmp.Substring(7, 2);
            if (rth != "00")
            {
                ErrorProcessing(rth);
                return;
            }
            string rspd = tmp.Substring(5, 2);

            if (rspd == "01")
            {
                string length = tmp.Substring(9, 2);
                if (length == "02" && tmp.Length >= 15)
                {
                    int width1Int = Convert.ToInt32(tmp.Substring(11, 2), 16);
                    int width1Dec = Convert.ToInt32(tmp.Substring(13, 2), 16);
                    int time1 = width1Int * 256 + width1Dec;
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
                    int time1 = width1Int * 256 + width1Dec;
                    int time2 = width2Int * 256 + width2Dec;
                    int width1 = time1 * 1200 / 1000;
                    int width2 = time2 * 1200 / 1000;
                    firstThick.Text = Convert.ToString(width1/100) + "." + Convert.ToString(width1%100) + "mm";
                    secondThick.Text = Convert.ToString(width2/100) + "." + Convert.ToString(width2%100) + "mm";
                    progressBar2.Value = width1;
                    progressBar3.Value = width2;
                }
            }
        }
        //发送请求测量信号，返回是否能够测量
        private void requestStatus_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "03" + "03" + "01" + "00";
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");
        }

        int speedOnline = 0;
        private void motortimer1_Tick(object sender, EventArgs e)
        {
            if (Pcommand == null || Pcommand.Length < 15)
                return;
            string tmp = Pcommand;
            Pcommand = null;
            if (tmp.Substring(3, 2) != "02")
                return;
            speedOnline++;
            string rth = tmp.Substring(7, 2);
            if (rth != "00")
            {
                ErrorProcessing(rth);
                return;
            }
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
                    motorDir.Text = "正传";
                }
                else
                {
                    //motorStable.Text = "稳定";
                    motorDir.Text = "反转";
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
        private void motorStart_Click(object sender, EventArgs e)
        {
            if(motorStart.Text == "启动")
            {
                //string Message;
                //Message = "10" + "02" + "02" + "04" + "00";
                //Message = Message + CHECKSUM(Message);
                //wifi_Send_data("~" + Message + "\r");
                motorStart.Text = "停止";
                currentSpeed.Text = "未知";
                motoronline.Text = "不在线";
                motorStatus.Text = "";
                progressBar5.Value = 0;
                motortimer1.Enabled = true;
                //motortimer2.Enabled = true;
                motortimer3.Enabled = true;
                motortimer4.Enabled = true;
            }
            else
            {
               // string Message;
                //Message = "10" + "02" + "02" + "05" + "00";
                //Message = Message + CHECKSUM(Message);
                //wifi_Send_data("~" + Message + "\r");
                motorStart.Text = "启动";
                currentSpeed.Text = "未知";
                motoronline.Text = "不在线";
                motortimer1.Enabled = false;
                //motortimer2.Enabled = false;
                motortimer3.Enabled = false;
                motortimer4.Enabled = false;
            }

            //发送启动、停止指令，仅仅控制本地主机的启动，停止，该帧不会转发给串口总线
            string Message = "10" + "02" + "00" + "00" + "00";
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");
        }
        //发送重启电机信号，返回当前转速与方向
        private void motorRestart_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "02" + "02" + "03" + "00";
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");
        }
        //发送电机转动方向信号，返回是否设置成功
        private void motorDir_Click(object sender, EventArgs e)
        {
            if(motorDir.Text == "正转")
            {
                string Message;
                Message = "10" + "02" + "02" + "01" + "01" + "01";
                Message = Message + CHECKSUM(Message);
                wifi_Send_data("~" + Message + "\r");
                motorDir.Text = "反转";
            }
            else
            {
                string Message;
                Message = "10" + "02" + "02" + "01" + "01" + "00";
                Message = Message + CHECKSUM(Message);
                wifi_Send_data("~" + Message + "\r");
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
            wifi_Send_data("~" + Message + "\r");
        }

        private void speedDown_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "10" + "02" + "02" + "02" + "01" + "00";
            Message = Message + CHECKSUM(Message);
            wifi_Send_data("~" + Message + "\r");
        }

        private void speedText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Message;
            string speed = speedText.Text;

            Message = "10" + "02" + "02" + "02" + "01";
            int set_speed = Convert.ToInt32(speed, 10); //步进加减和设置转速共用一个cmd2指令01, 当info 为01/00时表示步进，否则为直接设定温度
            if (set_speed >= 5 && set_speed <= 75)
            {
                string tmp = Convert.ToString(set_speed, 16);
                tmp = tmp.ToUpper();
                Message = Message + tmp;
                Message = Message + CHECKSUM(Message);
                wifi_Send_data("~" + Message + "\r");
            }
            else
            {
                motorStatus.Text += "操作错误！！系统仅接受5--75 r/s的转速设定";
                return;
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            string ip_str = ipBox.Text;
            string port_str = portBox.Text;

            try
            {
                IPAddress ip = IPAddress.Parse(ip_str);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(port_str));
                if(info.socketSend==null) info.socketSend = clientSocket;
                connectStatus.AppendText("连接中...\r\n");
               // string address = point.Serialize().ToString();
                if(!clientSocket.Connected)
                {
                    info.socketSend.Connect(point);
                    info.socketSend.BeginReceive(info.buffer, 0, info.buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), info);
                    connectStatus.AppendText("连接成功！\r\n");
                    ipBox.Enabled = false;
                    portBox.Enabled = false;
                }
            }
            catch
            {
                ipBox.Enabled = true;
                portBox.Enabled = true;
                MessageBox.Show("连接失败，请检查网络！或核对远程主机是否开启", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        ///客户端接收服务端返回消息

        void ReceiveCallback(IAsyncResult result)
        {
            SocketInfo info = (SocketInfo)result.AsyncState;
            try
            {
                int bytestoread = info.socketSend.EndReceive(result);
                if (bytestoread > 0)
                {
                    string text = Encoding.ASCII.GetString(info.buffer, 0, bytestoread);
                    wifi wifiReceive = new wifi(this.WIFIData);
                    this.Invoke(wifiReceive, text, connectStatus); //用这个进程来更新当前Socket收到的数据
                    //this.Invoke(interfaceUpdate, text);
                    info.socketSend.BeginReceive(info.buffer, 0, 255, SocketFlags.None, new AsyncCallback(ReceiveCallback), info);
                }
                else
                {
                    //WIFIReceive.Text = "Client finished normally.";
                    info.socketSend.Close();
                }
            }
            catch (Exception)
            {
                //WIFIReceive.Text = "Client Disconnected.";
            }
        }
        /// <summary>
        /// 向服务器发送消息方法,同步send，如果不行的话改成异步send
        /// </summary>
        public void wifi_Send_data(string msg)
        {
            try
            {
                if (info.socketSend.Connected)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(msg);
                    info.socketSend.Send(buffer, buffer.Length, SocketFlags.None);
                }
                else
                {
                    MessageBox.Show("当前socket未连接！","错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("发生非连接错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (info.socketSend.Connected)
                {
                    info.socketSend.Close();
                    ipBox.Enabled = true;
                    portBox.Enabled = true;
                    connectStatus.AppendText("通信已关闭\r\n");
                }
            }
            catch { }
        }
    }
}
