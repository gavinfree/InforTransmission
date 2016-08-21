using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using Echevil;
using System.Runtime.InteropServices;

namespace infortransmission_v2._0_
{
    public partial class Form1 : Form
    {

        PerformanceCounter pc = new PerformanceCounter("Processor", "% Processor Time", "_Total");   //利用性能计数器获取CPU占有率
        private NetworkAdapter[] adapters;
        private NetworkMonitor monitor;
        SerialPort sp = null;
        bool isOpen = false;
        bool ifSend = false;
        bool ifSelected = false;
        bool isSetProperty = false;

        bool cputem = true;
        bool cpuoccu = true;
        bool memtot = true;
        bool memavail = true;
        bool memoccu = true;
        bool dnspeed = true;
        bool upspeed = true;

        //默认都以ASCII码的形式发送
        bool sendTime = false;
        private bool windowCreate = true;
        Double temp = 0;
        long xx = 0;
        long availablebytes = 0;
        double taken = 0;
        float cpuLoad = 0;
        double DownloadSpeed = 0;
        double UploadSpeed = 0;
        public Form1()
        {
            InitializeComponent();
            ReadSetting();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            monitor = new NetworkMonitor();
            this.adapters = monitor.Adapters;

            if (adapters.Length == 0)
            {
                this.ListAdapters.Enabled = false;
                MessageBox.Show("No network adapters found on this computer.");
                return;
            }

            this.ListAdapters.Items.AddRange(this.adapters);
            for (int i = 0; i < 40; i++) //最大支持到串口40，可根据自己需求增加
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            }
            cbxCOMPort.SelectedIndex = 0;
            //列出常用的波特率，默认115200
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("43000");
            cbxBaudRate.Items.Add("56000");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 9;
            //默认停止位  1
            //默认数据位  8
            //默认奇偶校验位  无
        }

        private void btnCheckCOM_Click(object sender, EventArgs e)
        {
            bool comExistence = false;
            cbxCOMPort.Items.Clear();
            for (int i = 0; i < 40; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0; //使ListBox显示第1个添加的索引
            }
            else
            {
                MessageBox.Show("没有找到可用串口！", "错误提示");
            }
        }

        private bool CheckPortSetting()//检查串口是否设置
        {
            if (cbxCOMPort.Text.Trim() == "") return false;
            if (cbxBaudRate.Text.Trim() == "") return false;
            return true;
        }

        private void SetPortProperty()//设置串口的属性
        {
            sp = new SerialPort();
            sp.PortName = cbxCOMPort.Text.Trim(); //设置串口名
            sp.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim()); //设置串口的波特率
            sp.StopBits = StopBits.One;
            sp.DataBits = 8; //设置数据位
            sp.Parity = Parity.None;
            sp.ReadTimeout = -1; //设置超时读取时间
            sp.RtsEnable = true;
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())//检测串口设置
                {
                    MessageBox.Show("串口未设置！", "错误提示");
                    return;
                }
                if (!isSetProperty)//串口未设置则设置串口
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try//打开串口
                {
                    sp.Open();
                    isOpen = true;
                    btnOpenCom.Text = "关闭串口";
                    //串口打开后则相关的串口设置按钮便不可再用
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;

                }
                catch (Exception)
                {
                    //打开串口失败后，相应标志位取消
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用！", "错误提示");
                }
            }
            else
            {
                try//关闭串口
                {
                    sp.Close();
                    isOpen = false;
                    isSetProperty = false;
                    btnOpenCom.Text = "打开串口";
                    //关闭串口后，串口设置选项便可以继续使用
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误");
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ifSend = true;
            Thread T1 = new Thread(infor_get);
            T1.IsBackground = true;
            T1.Start();

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (windowCreate)
            {
                base.Visible = false;
                windowCreate = false;
            }
            this.Hide();
            base.OnActivated(e);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
                windowCreate = true;
            }
        }

        private void infor_get()
        {


            while (true)
            {



                string CPUtemp = "MSAcpi_ThermalZoneTemperature";


                ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(@"root\WMI", "Select * From " + CPUtemp);
                foreach (System.Management.ManagementObject mo in mos.Get())
                {
                    temp = Convert.ToDouble(Convert.ToDouble(mo.GetPropertyValue("CurrentTemperature").ToString()) - 2732) / 10;
                }

                ManagementClass mc = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    if (mo["TotalVisibleMemorySize"] != null)
                    {
                        xx = long.Parse(mo["TotalVisibleMemorySize"].ToString());
                        xx /= 1024;
                    }

                    if (mo["FreePhysicalMemory"] != null)
                    {
                        availablebytes = long.Parse(mo["FreePhysicalMemory"].ToString());
                        availablebytes /= 1024;
                    }
                    taken = (double)availablebytes / xx;
                    taken *= 100;
                    taken = 100 - taken;
                }


                Thread.Sleep(1000); // wait for 1 second
                cpuLoad = pc.NextValue();


            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sendTime = true;
        }

        private void ListAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ifSelected = true;
            monitor.StopMonitoring();
            monitor.StartMonitoring(adapters[this.ListAdapters.SelectedIndex]);
            this.TimerCounter.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NetworkAdapter adapter = this.adapters[this.ListAdapters.SelectedIndex];
            this.LableDownloadValue.Text = String.Format("{0:n} kBps", adapter.DownloadSpeedKbps);
            DownloadSpeed = adapter.DownloadSpeedKbps;
            this.LabelUploadValue.Text = String.Format("{0:n} kBps", adapter.UploadSpeedKbps);
            UploadSpeed = adapter.UploadSpeedKbps;
           
        }

        private void ctcheck_Click(object sender, EventArgs e)
        {
            if (this.ctcheck.Checked)
            {
                this.ctcheck.Checked = false;
                cputem = false;
            }
            else
            {
                this.ctcheck.Checked = true;
                cputem = true;
            }
        }

        private void cpuoccheck_Click(object sender, EventArgs e)
        {
            if (this.cpuoccheck.Checked)
            {
                this.cpuoccheck.Checked = false;
                cpuoccu = false;
            }
            else
            {
                this.cpuoccheck.Checked = true;
                cpuoccu = true;
            }
        }

        private void memtotalcheck_Click(object sender, EventArgs e)
        {
            if (this.memtotalcheck.Checked)
            {
                this.memtotalcheck.Checked = false;
                memtot = false;
            }
            else
            {
                this.memtotalcheck.Checked = true;
                memtot = true;
            }
        }

        private void memavailcheck_Click(object sender, EventArgs e)
        {
            if (this.memavailcheck.Checked)
            {
                this.memavailcheck.Checked = false;
                memavail = false;
            }
            else
            {
                this.memavailcheck.Checked = true;
                memavail = true;
            }
        }

        private void memoccucheck_Click(object sender, EventArgs e)
        {
            if (this.memoccucheck.Checked)
            {
                this.memoccucheck.Checked = false;
                memoccu = false;
            }
            else
            {
                this.memoccucheck.Checked = true;
                memoccu = true;
            }
        }

        private void dncheck_Click(object sender, EventArgs e)
        {
            if (this.dncheck.Checked)
            {
                this.dncheck.Checked = false;
                dnspeed = false;
            }
            else
            {
                this.dncheck.Checked = true;
                dnspeed = true;
            }
        }

        private void upcheck_Click(object sender, EventArgs e)
        {
            if (this.upcheck.Checked)
            {
                this.upcheck.Checked = false;
                upspeed = false;
            }
            else
            {
                this.upcheck.Checked = true;
                upspeed = true;
            }
        }


        private void ReadSetting()
        {
            this.ctcheck.Checked = data.Default.ctcheck;
            this.cpuoccheck.Checked = data.Default.cpuoccheck;
            this.memtotalcheck.Checked = data.Default.memtotalcheck;
            this.memavailcheck.Checked = data.Default.memavailcheck;
            this.memoccucheck.Checked = data.Default.memoccucheck;
            this.dncheck.Checked = data.Default.dncheck;
            this.upcheck.Checked = data.Default.upcheck;
            this.Update();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            data.Default.ctcheck = this.ctcheck.Checked;
            data.Default.cpuoccheck = this.cpuoccheck.Checked;
            data.Default.memtotalcheck = this.memtotalcheck.Checked;
            data.Default.memavailcheck = this.memavailcheck.Checked;
            data.Default.memoccucheck = this.memoccucheck.Checked;
            data.Default.dncheck = this.dncheck.Checked;
            data.Default.upcheck = this.upcheck.Checked;
            data.Default.Save();
            MessageBox.Show("保存设置成功！", "提示");
        }

        private void btnUsage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("详细使用说明请移步我的帖子：http://bbs.mydigit.cn/read.php?tid=1785154", "使用说明");
        }

        private void TimerSend_Tick(object sender, EventArgs e)
        {
            if (ifSend)
            {
                if (isOpen)//写串口数据
                {
                    if ((dnspeed == true || upspeed == true)&&ifSelected == false)
                    {
                        ifSend = false;
                        MessageBox.Show("请先选择网卡", "错误提示");
                    }
                    else
                    {
                        
                        try
                        {
                            System.DateTime currentTime = new System.DateTime();
                            currentTime = System.DateTime.Now;
                            sp.Write("$");
                            if (sendTime)
                            {
                                sp.Write("H" + currentTime.ToString("yyMMddHHmmss"));
                                sp.Write(currentTime.DayOfWeek.ToString("D") + "@");
                                sendTime = false;
                            }
                            else
                            {
                               
                                if (cputem) { sp.Write("A" + temp.ToString() + "@"); }
                                if (cpuoccu) { sp.Write("B" + (int)cpuLoad + "@"); }          //保留整数部分 或者.ToString("#.##")
                                if (memtot) { sp.Write("C" + xx + "@"); }
                                if (memavail) { sp.Write("D" + availablebytes + "@"); }
                                if (memoccu) { sp.Write("E" + (int)taken + "@"); }
                                if (dnspeed) { sp.Write("F" + (int)DownloadSpeed + "@"); }
                                if (upspeed) { sp.Write("G" + (int)(UploadSpeed) + "@"); }

                            }
                            sp.Write("&");

                        }
                        catch (Exception)
                        {
                            ifSend = false;
                            if (isOpen)
                            {
                                MessageBox.Show("发送数据时发生错误！", "错误提示");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("串口已关闭！", "提示");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    ifSend = false;
                    MessageBox.Show("串口未打开！", "错误提示");
                    return;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isOpen)
            {
                sp.Close();
            }
        }









    }
}
