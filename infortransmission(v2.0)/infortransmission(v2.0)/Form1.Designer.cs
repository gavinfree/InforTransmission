namespace infortransmission_v2._0_
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.btnCheckCOM = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ListAdapters = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerCounter = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LableDownloadValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelUploadValue = new System.Windows.Forms.Label();
            this.btnUsage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctcheck = new System.Windows.Forms.ToolStripMenuItem();
            this.cpuoccheck = new System.Windows.Forms.ToolStripMenuItem();
            this.memtotalcheck = new System.Windows.Forms.ToolStripMenuItem();
            this.memavailcheck = new System.Windows.Forms.ToolStripMenuItem();
            this.memoccucheck = new System.Windows.Forms.ToolStripMenuItem();
            this.dncheck = new System.Windows.Forms.ToolStripMenuItem();
            this.upcheck = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsave = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerSend = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(106, 37);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(90, 23);
            this.cbxCOMPort.TabIndex = 2;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(106, 76);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(90, 23);
            this.cbxBaudRate.TabIndex = 3;
            // 
            // btnCheckCOM
            // 
            this.btnCheckCOM.Location = new System.Drawing.Point(29, 133);
            this.btnCheckCOM.Name = "btnCheckCOM";
            this.btnCheckCOM.Size = new System.Drawing.Size(84, 38);
            this.btnCheckCOM.TabIndex = 4;
            this.btnCheckCOM.Text = "串口检测";
            this.btnCheckCOM.UseVisualStyleBackColor = true;
            this.btnCheckCOM.Click += new System.EventHandler(this.btnCheckCOM_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(29, 201);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 38);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(29, 269);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(84, 38);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "隐藏窗体";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(155, 133);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(84, 38);
            this.btnOpenCom.TabIndex = 7;
            this.btnOpenCom.Text = "打开串口";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(155, 201);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 38);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "更新时间(H)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ListAdapters
            // 
            this.ListAdapters.FormattingEnabled = true;
            this.ListAdapters.ItemHeight = 15;
            this.ListAdapters.Location = new System.Drawing.Point(267, 31);
            this.ListAdapters.Name = "ListAdapters";
            this.ListAdapters.Size = new System.Drawing.Size(427, 169);
            this.ListAdapters.TabIndex = 9;
            this.ListAdapters.SelectedIndexChanged += new System.EventHandler(this.ListAdapters_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HideAndSeek";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // TimerCounter
            // 
            this.TimerCounter.Interval = 1000;
            this.TimerCounter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Download";
            // 
            // LableDownloadValue
            // 
            this.LableDownloadValue.AutoSize = true;
            this.LableDownloadValue.Location = new System.Drawing.Point(366, 230);
            this.LableDownloadValue.Name = "LableDownloadValue";
            this.LableDownloadValue.Size = new System.Drawing.Size(0, 15);
            this.LableDownloadValue.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Upload";
            // 
            // LabelUploadValue
            // 
            this.LabelUploadValue.AutoSize = true;
            this.LabelUploadValue.Location = new System.Drawing.Point(615, 231);
            this.LabelUploadValue.Name = "LabelUploadValue";
            this.LabelUploadValue.Size = new System.Drawing.Size(0, 15);
            this.LabelUploadValue.TabIndex = 13;
            // 
            // btnUsage
            // 
            this.btnUsage.Location = new System.Drawing.Point(155, 269);
            this.btnUsage.Name = "btnUsage";
            this.btnUsage.Size = new System.Drawing.Size(84, 38);
            this.btnUsage.TabIndex = 14;
            this.btnUsage.Text = "使用说明";
            this.btnUsage.UseVisualStyleBackColor = true;
            this.btnUsage.Click += new System.EventHandler(this.btnUsage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据选择ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据选择ToolStripMenuItem
            // 
            this.数据选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctcheck,
            this.cpuoccheck,
            this.memtotalcheck,
            this.memavailcheck,
            this.memoccucheck,
            this.dncheck,
            this.upcheck,
            this.btnsave});
            this.数据选择ToolStripMenuItem.Name = "数据选择ToolStripMenuItem";
            this.数据选择ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.数据选择ToolStripMenuItem.Text = "数据选择";
            // 
            // ctcheck
            // 
            this.ctcheck.Checked = true;
            this.ctcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctcheck.Name = "ctcheck";
            this.ctcheck.Size = new System.Drawing.Size(175, 24);
            this.ctcheck.Text = "CPU温度(A)";
            this.ctcheck.Click += new System.EventHandler(this.ctcheck_Click);
            // 
            // cpuoccheck
            // 
            this.cpuoccheck.Checked = true;
            this.cpuoccheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cpuoccheck.Name = "cpuoccheck";
            this.cpuoccheck.Size = new System.Drawing.Size(175, 24);
            this.cpuoccheck.Text = "CPU占用率(B)";
            this.cpuoccheck.Click += new System.EventHandler(this.cpuoccheck_Click);
            // 
            // memtotalcheck
            // 
            this.memtotalcheck.Checked = true;
            this.memtotalcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.memtotalcheck.Name = "memtotalcheck";
            this.memtotalcheck.Size = new System.Drawing.Size(175, 24);
            this.memtotalcheck.Text = "总内存(C)";
            this.memtotalcheck.Click += new System.EventHandler(this.memtotalcheck_Click);
            // 
            // memavailcheck
            // 
            this.memavailcheck.Checked = true;
            this.memavailcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.memavailcheck.Name = "memavailcheck";
            this.memavailcheck.Size = new System.Drawing.Size(175, 24);
            this.memavailcheck.Text = "可用内存(D)";
            this.memavailcheck.Click += new System.EventHandler(this.memavailcheck_Click);
            // 
            // memoccucheck
            // 
            this.memoccucheck.Checked = true;
            this.memoccucheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.memoccucheck.Name = "memoccucheck";
            this.memoccucheck.Size = new System.Drawing.Size(175, 24);
            this.memoccucheck.Text = "内存使用率(E)";
            this.memoccucheck.Click += new System.EventHandler(this.memoccucheck_Click);
            // 
            // dncheck
            // 
            this.dncheck.Checked = true;
            this.dncheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dncheck.Name = "dncheck";
            this.dncheck.Size = new System.Drawing.Size(175, 24);
            this.dncheck.Text = "下载速度(F)";
            this.dncheck.Click += new System.EventHandler(this.dncheck_Click);
            // 
            // upcheck
            // 
            this.upcheck.Checked = true;
            this.upcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upcheck.Name = "upcheck";
            this.upcheck.Size = new System.Drawing.Size(175, 24);
            this.upcheck.Text = "上传速度(G)";
            this.upcheck.Click += new System.EventHandler(this.upcheck_Click);
            // 
            // btnsave
            // 
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(190, 24);
            this.btnsave.Text = "保存设置";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // TimerSend
            // 
            this.TimerSend.Enabled = true;
            this.TimerSend.Interval = 1000;
            this.TimerSend.Tick += new System.EventHandler(this.TimerSend_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 375);
            this.Controls.Add(this.btnUsage);
            this.Controls.Add(this.LabelUploadValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LableDownloadValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListAdapters);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenCom);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCheckCOM);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxCOMPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "infortransmission(v2.0)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Button btnCheckCOM;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox ListAdapters;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer TimerCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LableDownloadValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelUploadValue;
        private System.Windows.Forms.Button btnUsage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctcheck;
        private System.Windows.Forms.ToolStripMenuItem cpuoccheck;
        private System.Windows.Forms.ToolStripMenuItem memtotalcheck;
        private System.Windows.Forms.ToolStripMenuItem memavailcheck;
        private System.Windows.Forms.ToolStripMenuItem memoccucheck;
        private System.Windows.Forms.ToolStripMenuItem dncheck;
        private System.Windows.Forms.ToolStripMenuItem upcheck;
        private System.Windows.Forms.ToolStripMenuItem btnsave;
        private System.Windows.Forms.Timer TimerSend;
    }
}

