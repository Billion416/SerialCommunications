namespace Uart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sendButton = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.BaudrateBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RxBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.TxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StopBitsBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DataBitBox = new System.Windows.Forms.ComboBox();
            this.ParityBitBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RxHexBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxHexBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RGB2312Button = new System.Windows.Forms.RadioButton();
            this.RUTF8Button = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TGB2312Button = new System.Windows.Forms.RadioButton();
            this.TUTF8Button = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存接收数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浅色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.深色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeNowLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sendButton.Font = new System.Drawing.Font("华文新魏", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendButton.ForeColor = System.Drawing.Color.Green;
            this.sendButton.Location = new System.Drawing.Point(724, 396);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(157, 89);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "发送";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.PeachPuff;
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(90, 17);
            this.PortBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(169, 23);
            this.PortBox.TabIndex = 3;
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // BaudrateBox
            // 
            this.BaudrateBox.BackColor = System.Drawing.Color.PeachPuff;
            this.BaudrateBox.FormattingEnabled = true;
            this.BaudrateBox.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudrateBox.Location = new System.Drawing.Point(90, 49);
            this.BaudrateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BaudrateBox.Name = "BaudrateBox";
            this.BaudrateBox.Size = new System.Drawing.Size(169, 23);
            this.BaudrateBox.TabIndex = 4;
            this.BaudrateBox.SelectedIndexChanged += new System.EventHandler(this.BaudrateBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "波特率";
            // 
            // RxBox
            // 
            this.RxBox.BackColor = System.Drawing.Color.LightYellow;
            this.RxBox.Location = new System.Drawing.Point(292, 43);
            this.RxBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RxBox.Multiline = true;
            this.RxBox.Name = "RxBox";
            this.RxBox.ReadOnly = true;
            this.RxBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RxBox.Size = new System.Drawing.Size(597, 349);
            this.RxBox.TabIndex = 15;
            this.RxBox.TextChanged += new System.EventHandler(this.RxBox_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(6, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 55);
            this.button2.TabIndex = 16;
            this.button2.Text = "打开串口\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Coral;
            this.clearButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(177, 249);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 32);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "清空";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TxBox
            // 
            this.TxBox.BackColor = System.Drawing.Color.OldLace;
            this.TxBox.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxBox.Location = new System.Drawing.Point(292, 396);
            this.TxBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxBox.Multiline = true;
            this.TxBox.Name = "TxBox";
            this.TxBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxBox.Size = new System.Drawing.Size(423, 169);
            this.TxBox.TabIndex = 18;
            this.TxBox.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "等待发送";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // StopBitsBox
            // 
            this.StopBitsBox.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.StopBitsBox.BackColor = System.Drawing.Color.PeachPuff;
            this.StopBitsBox.FormattingEnabled = true;
            this.StopBitsBox.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.StopBitsBox.Location = new System.Drawing.Point(90, 81);
            this.StopBitsBox.Margin = new System.Windows.Forms.Padding(4);
            this.StopBitsBox.Name = "StopBitsBox";
            this.StopBitsBox.Size = new System.Drawing.Size(168, 23);
            this.StopBitsBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "停止位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "数据位";
            // 
            // DataBitBox
            // 
            this.DataBitBox.BackColor = System.Drawing.Color.PeachPuff;
            this.DataBitBox.FormattingEnabled = true;
            this.DataBitBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.DataBitBox.Location = new System.Drawing.Point(90, 112);
            this.DataBitBox.Margin = new System.Windows.Forms.Padding(4);
            this.DataBitBox.Name = "DataBitBox";
            this.DataBitBox.Size = new System.Drawing.Size(168, 23);
            this.DataBitBox.TabIndex = 23;
            // 
            // ParityBitBox
            // 
            this.ParityBitBox.BackColor = System.Drawing.Color.PeachPuff;
            this.ParityBitBox.FormattingEnabled = true;
            this.ParityBitBox.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.ParityBitBox.Location = new System.Drawing.Point(90, 145);
            this.ParityBitBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParityBitBox.Name = "ParityBitBox";
            this.ParityBitBox.Size = new System.Drawing.Size(168, 23);
            this.ParityBitBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "奇偶校验";
            // 
            // RxHexBox
            // 
            this.RxHexBox.AutoSize = true;
            this.RxHexBox.Location = new System.Drawing.Point(196, 178);
            this.RxHexBox.Margin = new System.Windows.Forms.Padding(4);
            this.RxHexBox.Name = "RxHexBox";
            this.RxHexBox.Size = new System.Drawing.Size(59, 49);
            this.RxHexBox.TabIndex = 26;
            this.RxHexBox.Text = "十六\r\n进制\r\n显示";
            this.RxHexBox.UseVisualStyleBackColor = true;
            this.RxHexBox.CheckedChanged += new System.EventHandler(this.RxHexBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TxHexBox
            // 
            this.TxHexBox.AutoSize = true;
            this.TxHexBox.Location = new System.Drawing.Point(177, 32);
            this.TxHexBox.Margin = new System.Windows.Forms.Padding(4);
            this.TxHexBox.Name = "TxHexBox";
            this.TxHexBox.Size = new System.Drawing.Size(59, 49);
            this.TxHexBox.TabIndex = 28;
            this.TxHexBox.Text = "十六\r\n进制\r\n发送";
            this.TxHexBox.UseVisualStyleBackColor = true;
            this.TxHexBox.CheckedChanged += new System.EventHandler(this.TxHexBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RGB2312Button);
            this.panel1.Controls.Add(this.RUTF8Button);
            this.panel1.Location = new System.Drawing.Point(8, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 45);
            this.panel1.TabIndex = 29;
            // 
            // RGB2312Button
            // 
            this.RGB2312Button.AutoSize = true;
            this.RGB2312Button.Location = new System.Drawing.Point(82, 13);
            this.RGB2312Button.Name = "RGB2312Button";
            this.RGB2312Button.Size = new System.Drawing.Size(76, 19);
            this.RGB2312Button.TabIndex = 1;
            this.RGB2312Button.Text = "GB2312";
            this.RGB2312Button.UseVisualStyleBackColor = true;
            // 
            // RUTF8Button
            // 
            this.RUTF8Button.AutoSize = true;
            this.RUTF8Button.Checked = true;
            this.RUTF8Button.Location = new System.Drawing.Point(4, 13);
            this.RUTF8Button.Name = "RUTF8Button";
            this.RUTF8Button.Size = new System.Drawing.Size(60, 19);
            this.RUTF8Button.TabIndex = 0;
            this.RUTF8Button.TabStop = true;
            this.RUTF8Button.Text = "UTF8";
            this.RUTF8Button.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TGB2312Button);
            this.panel2.Controls.Add(this.TUTF8Button);
            this.panel2.Location = new System.Drawing.Point(173, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 56);
            this.panel2.TabIndex = 30;
            // 
            // TGB2312Button
            // 
            this.TGB2312Button.AutoSize = true;
            this.TGB2312Button.Location = new System.Drawing.Point(3, 28);
            this.TGB2312Button.Name = "TGB2312Button";
            this.TGB2312Button.Size = new System.Drawing.Size(76, 19);
            this.TGB2312Button.TabIndex = 1;
            this.TGB2312Button.Text = "GB2312";
            this.TGB2312Button.UseVisualStyleBackColor = true;
            // 
            // TUTF8Button
            // 
            this.TUTF8Button.AutoSize = true;
            this.TUTF8Button.Checked = true;
            this.TUTF8Button.Location = new System.Drawing.Point(3, 3);
            this.TUTF8Button.Name = "TUTF8Button";
            this.TUTF8Button.Size = new System.Drawing.Size(60, 19);
            this.TUTF8Button.TabIndex = 0;
            this.TUTF8Button.TabStop = true;
            this.TUTF8Button.Text = "UTF8";
            this.TUTF8Button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PortBox);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.BaudrateBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.RxHexBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.StopBitsBox);
            this.groupBox1.Controls.Add(this.ParityBitBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DataBitBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 361);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.TxHexBox);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 169);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送设置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存接收数据ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存接收数据ToolStripMenuItem
            // 
            this.保存接收数据ToolStripMenuItem.Name = "保存接收数据ToolStripMenuItem";
            this.保存接收数据ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.保存接收数据ToolStripMenuItem.Text = "保存接收数据";
            this.保存接收数据ToolStripMenuItem.Click += new System.EventHandler(this.保存接收数据ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浅色ToolStripMenuItem,
            this.深色ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.视图ToolStripMenuItem.Text = "主题";
            // 
            // 浅色ToolStripMenuItem
            // 
            this.浅色ToolStripMenuItem.Name = "浅色ToolStripMenuItem";
            this.浅色ToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.浅色ToolStripMenuItem.Text = "√浅色";
            this.浅色ToolStripMenuItem.Click += new System.EventHandler(this.浅色ToolStripMenuItem_Click);
            // 
            // 深色ToolStripMenuItem
            // 
            this.深色ToolStripMenuItem.Name = "深色ToolStripMenuItem";
            this.深色ToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.深色ToolStripMenuItem.Text = "  深色";
            this.深色ToolStripMenuItem.Click += new System.EventHandler(this.深色ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // TimeNowLabel
            // 
            this.TimeNowLabel.Name = "TimeNowLabel";
            this.TimeNowLabel.Size = new System.Drawing.Size(84, 20);
            this.TimeNowLabel.Text = "现在时间：";
            this.TimeNowLabel.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeNowLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(901, 26);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(901, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBox);
            this.Controls.Add(this.RxBox);
            this.Controls.Add(this.sendButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "串口助手(连接亿万个梦想)";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.ComboBox BaudrateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RxBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox TxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StopBitsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DataBitBox;
        private System.Windows.Forms.ComboBox ParityBitBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox RxHexBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox TxHexBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RUTF8Button;
        private System.Windows.Forms.RadioButton RGB2312Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton TGB2312Button;
        private System.Windows.Forms.RadioButton TUTF8Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浅色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 深色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TimeNowLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存接收数据ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

