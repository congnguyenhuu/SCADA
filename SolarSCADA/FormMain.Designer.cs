namespace SolarSCADA
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openChart = new System.Windows.Forms.Button();
            this.iconWeather = new System.Windows.Forms.PictureBox();
            this.openInfo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToMySqlDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savefileExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_port = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.pvWattageShow = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pvCurrentShow = new System.Windows.Forms.Button();
            this.showInfo = new System.Windows.Forms.Button();
            this.pvVoltageShow = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.loadWattageShow = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.loadCurrentShow = new System.Windows.Forms.Button();
            this.adafaaf = new System.Windows.Forms.Button();
            this.loadVoltageShow = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button19 = new System.Windows.Forms.Button();
            this.batVoltageShow = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.batCurrentShow = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.batLevelShow = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.weatherState = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.windSpeedShow = new System.Windows.Forms.Label();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ngay = new System.Windows.Forms.TextBox();
            this.textBox_thang = new System.Windows.Forms.TextBox();
            this.textBox_nam = new System.Windows.Forms.TextBox();
            this.textBox_gio = new System.Windows.Forms.TextBox();
            this.textBox_phut = new System.Windows.Forms.TextBox();
            this.textBox_giay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_kinhDo = new System.Windows.Forms.TextBox();
            this.textBox_viDo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel66 = new System.Windows.Forms.TableLayoutPanel();
            this.button_sendDate = new System.Windows.Forms.Button();
            this.checkCustom = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel67 = new System.Windows.Forms.TableLayoutPanel();
            this.button_sendVitri = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.open_port = new System.Windows.Forms.Button();
            this.close_port = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.layoutInfo = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel46 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel47 = new System.Windows.Forms.TableLayoutPanel();
            this.button104 = new System.Windows.Forms.Button();
            this.pv8WattageShow = new System.Windows.Forms.Button();
            this.button106 = new System.Windows.Forms.Button();
            this.pv8CurrentShow = new System.Windows.Forms.Button();
            this.button108 = new System.Windows.Forms.Button();
            this.pv8VoltageShow = new System.Windows.Forms.Button();
            this.button110 = new System.Windows.Forms.Button();
            this.button111 = new System.Windows.Forms.Button();
            this.button112 = new System.Windows.Forms.Button();
            this.tableLayoutPanel48 = new System.Windows.Forms.TableLayoutPanel();
            this.button113 = new System.Windows.Forms.Button();
            this.tableLayoutPanel49 = new System.Windows.Forms.TableLayoutPanel();
            this.button114 = new System.Windows.Forms.Button();
            this.angelpv8 = new System.Windows.Forms.TextBox();
            this.statepv8 = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel62 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel63 = new System.Windows.Forms.TableLayoutPanel();
            this.button159 = new System.Windows.Forms.Button();
            this.pv9WattageShow = new System.Windows.Forms.Button();
            this.button161 = new System.Windows.Forms.Button();
            this.pv9CurrentShow = new System.Windows.Forms.Button();
            this.button163 = new System.Windows.Forms.Button();
            this.pv9VoltageShow = new System.Windows.Forms.Button();
            this.button165 = new System.Windows.Forms.Button();
            this.button166 = new System.Windows.Forms.Button();
            this.button167 = new System.Windows.Forms.Button();
            this.tableLayoutPanel64 = new System.Windows.Forms.TableLayoutPanel();
            this.button168 = new System.Windows.Forms.Button();
            this.tableLayoutPanel65 = new System.Windows.Forms.TableLayoutPanel();
            this.button170 = new System.Windows.Forms.Button();
            this.angelpv9 = new System.Windows.Forms.TextBox();
            this.statepv9 = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel42 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel43 = new System.Windows.Forms.TableLayoutPanel();
            this.button93 = new System.Windows.Forms.Button();
            this.pv6WattageShow = new System.Windows.Forms.Button();
            this.button95 = new System.Windows.Forms.Button();
            this.pv6CurrentShow = new System.Windows.Forms.Button();
            this.button97 = new System.Windows.Forms.Button();
            this.pv6VoltageShow = new System.Windows.Forms.Button();
            this.button99 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.button101 = new System.Windows.Forms.Button();
            this.tableLayoutPanel44 = new System.Windows.Forms.TableLayoutPanel();
            this.button102 = new System.Windows.Forms.Button();
            this.tableLayoutPanel45 = new System.Windows.Forms.TableLayoutPanel();
            this.button103 = new System.Windows.Forms.Button();
            this.angelpv7 = new System.Windows.Forms.TextBox();
            this.statepv7 = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel38 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel39 = new System.Windows.Forms.TableLayoutPanel();
            this.button82 = new System.Windows.Forms.Button();
            this.pv7WattageShow = new System.Windows.Forms.Button();
            this.button84 = new System.Windows.Forms.Button();
            this.pv7CurrentShow = new System.Windows.Forms.Button();
            this.button86 = new System.Windows.Forms.Button();
            this.pv7VoltageShow = new System.Windows.Forms.Button();
            this.button88 = new System.Windows.Forms.Button();
            this.button89 = new System.Windows.Forms.Button();
            this.button90 = new System.Windows.Forms.Button();
            this.tableLayoutPanel40 = new System.Windows.Forms.TableLayoutPanel();
            this.button91 = new System.Windows.Forms.Button();
            this.tableLayoutPanel41 = new System.Windows.Forms.TableLayoutPanel();
            this.button92 = new System.Windows.Forms.Button();
            this.angelpv5 = new System.Windows.Forms.TextBox();
            this.statepv5 = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel34 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel35 = new System.Windows.Forms.TableLayoutPanel();
            this.button71 = new System.Windows.Forms.Button();
            this.pv5WattageShow = new System.Windows.Forms.Button();
            this.button73 = new System.Windows.Forms.Button();
            this.pv5CurrentShow = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.pv5VoltageShow = new System.Windows.Forms.Button();
            this.button77 = new System.Windows.Forms.Button();
            this.button78 = new System.Windows.Forms.Button();
            this.button79 = new System.Windows.Forms.Button();
            this.tableLayoutPanel36 = new System.Windows.Forms.TableLayoutPanel();
            this.button80 = new System.Windows.Forms.Button();
            this.tableLayoutPanel37 = new System.Windows.Forms.TableLayoutPanel();
            this.button81 = new System.Windows.Forms.Button();
            this.angelpv6 = new System.Windows.Forms.TextBox();
            this.statepv6 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel30 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            this.button60 = new System.Windows.Forms.Button();
            this.pv2WattageShow = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.pv2CurrentShow = new System.Windows.Forms.Button();
            this.button64 = new System.Windows.Forms.Button();
            this.pv2VoltageShow = new System.Windows.Forms.Button();
            this.button66 = new System.Windows.Forms.Button();
            this.button67 = new System.Windows.Forms.Button();
            this.button68 = new System.Windows.Forms.Button();
            this.tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            this.button69 = new System.Windows.Forms.Button();
            this.tableLayoutPanel33 = new System.Windows.Forms.TableLayoutPanel();
            this.button70 = new System.Windows.Forms.Button();
            this.angelpv2 = new System.Windows.Forms.TextBox();
            this.statepv2 = new System.Windows.Forms.CheckBox();
            this.PVpanel1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.button49 = new System.Windows.Forms.Button();
            this.pv1WattageShow = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.pv1CurrentShow = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.pv1VoltageShow = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.button58 = new System.Windows.Forms.Button();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.button59 = new System.Windows.Forms.Button();
            this.angelpv1 = new System.Windows.Forms.TextBox();
            this.statepv1 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.button38 = new System.Windows.Forms.Button();
            this.pv4WattageShow = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.pv4CurrentShow = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.pv4VoltageShow = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.button47 = new System.Windows.Forms.Button();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.button48 = new System.Windows.Forms.Button();
            this.angelpv4 = new System.Windows.Forms.TextBox();
            this.statepv4 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pv3WattageShow = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.pv3CurrentShow = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.pv3VoltageShow = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.button36 = new System.Windows.Forms.Button();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.button37 = new System.Windows.Forms.Button();
            this.angelpv3 = new System.Windows.Forms.TextBox();
            this.statepv3 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel58 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel59 = new System.Windows.Forms.TableLayoutPanel();
            this.button137 = new System.Windows.Forms.Button();
            this.pv10WattageShow = new System.Windows.Forms.Button();
            this.button139 = new System.Windows.Forms.Button();
            this.pv10CurrentShow = new System.Windows.Forms.Button();
            this.button141 = new System.Windows.Forms.Button();
            this.pv10VoltageShow = new System.Windows.Forms.Button();
            this.button143 = new System.Windows.Forms.Button();
            this.button144 = new System.Windows.Forms.Button();
            this.button145 = new System.Windows.Forms.Button();
            this.tableLayoutPanel60 = new System.Windows.Forms.TableLayoutPanel();
            this.button146 = new System.Windows.Forms.Button();
            this.tableLayoutPanel61 = new System.Windows.Forms.TableLayoutPanel();
            this.button147 = new System.Windows.Forms.Button();
            this.angelpv10 = new System.Windows.Forms.TextBox();
            this.statepv10 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChart = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.iconWeather)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel17.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel66.SuspendLayout();
            this.tableLayoutPanel67.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.layoutInfo.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tableLayoutPanel46.SuspendLayout();
            this.tableLayoutPanel47.SuspendLayout();
            this.tableLayoutPanel48.SuspendLayout();
            this.tableLayoutPanel49.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tableLayoutPanel62.SuspendLayout();
            this.tableLayoutPanel63.SuspendLayout();
            this.tableLayoutPanel64.SuspendLayout();
            this.tableLayoutPanel65.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tableLayoutPanel42.SuspendLayout();
            this.tableLayoutPanel43.SuspendLayout();
            this.tableLayoutPanel44.SuspendLayout();
            this.tableLayoutPanel45.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tableLayoutPanel38.SuspendLayout();
            this.tableLayoutPanel39.SuspendLayout();
            this.tableLayoutPanel40.SuspendLayout();
            this.tableLayoutPanel41.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tableLayoutPanel34.SuspendLayout();
            this.tableLayoutPanel35.SuspendLayout();
            this.tableLayoutPanel36.SuspendLayout();
            this.tableLayoutPanel37.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel30.SuspendLayout();
            this.tableLayoutPanel31.SuspendLayout();
            this.tableLayoutPanel32.SuspendLayout();
            this.tableLayoutPanel33.SuspendLayout();
            this.PVpanel1.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tableLayoutPanel58.SuspendLayout();
            this.tableLayoutPanel59.SuspendLayout();
            this.tableLayoutPanel60.SuspendLayout();
            this.tableLayoutPanel61.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            // 
            // openChart
            // 
            this.openChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openChart.Image = global::SolarSCADA.Properties.Resources.icons8_sun_64px;
            this.openChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openChart.Location = new System.Drawing.Point(0, 0);
            this.openChart.Name = "openChart";
            this.openChart.Size = new System.Drawing.Size(281, 82);
            this.openChart.TabIndex = 6;
            this.openChart.Text = "SOLAR SCADA SYSTEM";
            this.openChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.openChart, "Mở đồ thị");
            this.openChart.UseVisualStyleBackColor = false;
            this.openChart.Click += new System.EventHandler(this.openChart_Click);
            // 
            // iconWeather
            // 
            this.iconWeather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconWeather.Image = global::SolarSCADA.Properties.Resources.icons8_refresh_64px;
            this.iconWeather.Location = new System.Drawing.Point(4, 4);
            this.iconWeather.Name = "iconWeather";
            this.iconWeather.Size = new System.Drawing.Size(41, 49);
            this.iconWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconWeather.TabIndex = 2;
            this.iconWeather.TabStop = false;
            this.toolTip1.SetToolTip(this.iconWeather, "Tải lại thông tin thời tiết");
            this.iconWeather.Click += new System.EventHandler(this.iconWeather_Click);
            // 
            // openInfo
            // 
            this.openInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openInfo.Image = global::SolarSCADA.Properties.Resources.icons8_settings_32px;
            this.openInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openInfo.Location = new System.Drawing.Point(3, 3);
            this.openInfo.Name = "openInfo";
            this.openInfo.Size = new System.Drawing.Size(275, 32);
            this.openInfo.TabIndex = 4;
            this.openInfo.Text = "SYSTEM CONFIGURATION";
            this.toolTip1.SetToolTip(this.openInfo, "Mở bảng PV");
            this.openInfo.UseVisualStyleBackColor = false;
            this.openInfo.Click += new System.EventHandler(this.openInfo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem,
            this.vToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToMySqlDatabase,
            this.savefileExcel});
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.vToolStripMenuItem.Text = "File";
            // 
            // saveToMySqlDatabase
            // 
            this.saveToMySqlDatabase.Checked = true;
            this.saveToMySqlDatabase.CheckOnClick = true;
            this.saveToMySqlDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToMySqlDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDataToolStripMenuItem});
            this.saveToMySqlDatabase.Name = "saveToMySqlDatabase";
            this.saveToMySqlDatabase.Size = new System.Drawing.Size(223, 24);
            this.saveToMySqlDatabase.Text = "Save to mySql database";
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.showDataToolStripMenuItem.Text = "Show Database";
            this.showDataToolStripMenuItem.Click += new System.EventHandler(this.showDataToolStripMenuItem_Click);
            // 
            // savefileExcel
            // 
            this.savefileExcel.CheckOnClick = true;
            this.savefileExcel.Name = "savefileExcel";
            this.savefileExcel.Size = new System.Drawing.Size(223, 24);
            this.savefileExcel.Text = "Save to exel file";
            this.savefileExcel.Click += new System.EventHandler(this.savefileExcel_Click);
            // 
            // vToolStripMenuItem1
            // 
            this.vToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPORTToolStripMenuItem,
            this.closePortToolStripMenuItem,
            this.refresh_port});
            this.vToolStripMenuItem1.Name = "vToolStripMenuItem1";
            this.vToolStripMenuItem1.Size = new System.Drawing.Size(96, 23);
            this.vToolStripMenuItem1.Text = "Port Control";
            // 
            // openPORTToolStripMenuItem
            // 
            this.openPORTToolStripMenuItem.Name = "openPORTToolStripMenuItem";
            this.openPORTToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.openPORTToolStripMenuItem.Text = "Open PORT";
            this.openPORTToolStripMenuItem.Click += new System.EventHandler(this.openPORTToolStripMenuItem_Click);
            // 
            // closePortToolStripMenuItem
            // 
            this.closePortToolStripMenuItem.Name = "closePortToolStripMenuItem";
            this.closePortToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.closePortToolStripMenuItem.Text = "Close PORT";
            this.closePortToolStripMenuItem.Click += new System.EventHandler(this.closePortToolStripMenuItem_Click);
            // 
            // refresh_port
            // 
            this.refresh_port.Name = "refresh_port";
            this.refresh_port.Size = new System.Drawing.Size(160, 24);
            this.refresh_port.Text = "Refresh PORT";
            this.refresh_port.Click += new System.EventHandler(this.refresh_port_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.66667F));
            this.tableLayoutPanel1.Controls.Add(this.panelHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSetting, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMid, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.32194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 702);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.openChart);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(3, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(281, 82);
            this.panelHome.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.tableLayoutPanel4);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 91);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(281, 608);
            this.panelLeft.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.openInfo, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.67568F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53378F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.23993F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.24673F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(281, 608);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Blue;
            this.groupBox2.Controls.Add(this.tableLayoutPanel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(3, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PV PANEL";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.pvWattageShow, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.pvCurrentShow, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.showInfo, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pvVoltageShow, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(269, 131);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(230, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 34);
            this.button9.TabIndex = 15;
            this.button9.Text = "W";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pvWattageShow
            // 
            this.pvWattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pvWattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvWattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pvWattageShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvWattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pvWattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pvWattageShow.Location = new System.Drawing.Point(163, 91);
            this.pvWattageShow.Name = "pvWattageShow";
            this.pvWattageShow.Size = new System.Drawing.Size(58, 34);
            this.pvWattageShow.TabIndex = 14;
            this.pvWattageShow.Text = "200";
            this.pvWattageShow.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(230, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 33);
            this.button7.TabIndex = 13;
            this.button7.Text = "A";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // pvCurrentShow
            // 
            this.pvCurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pvCurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvCurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pvCurrentShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvCurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pvCurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pvCurrentShow.Location = new System.Drawing.Point(163, 49);
            this.pvCurrentShow.Name = "pvCurrentShow";
            this.pvCurrentShow.Size = new System.Drawing.Size(58, 33);
            this.pvCurrentShow.TabIndex = 12;
            this.pvCurrentShow.Text = "5";
            this.pvCurrentShow.UseVisualStyleBackColor = false;
            // 
            // showInfo
            // 
            this.showInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showInfo.AutoSize = true;
            this.showInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.showInfo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.showInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.showInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.showInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.showInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.showInfo.Location = new System.Drawing.Point(6, 6);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(148, 34);
            this.showInfo.TabIndex = 9;
            this.showInfo.Text = "PV VOLTAGE";
            this.showInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showInfo.UseVisualStyleBackColor = false;
            // 
            // pvVoltageShow
            // 
            this.pvVoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pvVoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvVoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pvVoltageShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvVoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pvVoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pvVoltageShow.Location = new System.Drawing.Point(163, 6);
            this.pvVoltageShow.Name = "pvVoltageShow";
            this.pvVoltageShow.Size = new System.Drawing.Size(58, 34);
            this.pvVoltageShow.TabIndex = 10;
            this.pvVoltageShow.Text = "40";
            this.pvVoltageShow.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(230, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "V";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Arial", 11F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(6, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "PV CURRENT";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Arial", 11F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(6, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "PV WATTAGE";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cyan;
            this.groupBox3.Controls.Add(this.tableLayoutPanel7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 161);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOAD";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Controls.Add(this.button10, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.loadWattageShow, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.button12, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.loadCurrentShow, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.adafaaf, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.loadVoltageShow, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.button16, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.button17, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button18, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(269, 142);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Yellow;
            this.button10.Location = new System.Drawing.Point(230, 98);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(33, 38);
            this.button10.TabIndex = 15;
            this.button10.Text = "W";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // loadWattageShow
            // 
            this.loadWattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loadWattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadWattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadWattageShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadWattageShow.ForeColor = System.Drawing.Color.Yellow;
            this.loadWattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadWattageShow.Location = new System.Drawing.Point(163, 98);
            this.loadWattageShow.Name = "loadWattageShow";
            this.loadWattageShow.Size = new System.Drawing.Size(58, 38);
            this.loadWattageShow.TabIndex = 14;
            this.loadWattageShow.Text = "200";
            this.loadWattageShow.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Yellow;
            this.button12.Location = new System.Drawing.Point(230, 53);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(33, 36);
            this.button12.TabIndex = 13;
            this.button12.Text = "A";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // loadCurrentShow
            // 
            this.loadCurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loadCurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadCurrentShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCurrentShow.ForeColor = System.Drawing.Color.Yellow;
            this.loadCurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadCurrentShow.Location = new System.Drawing.Point(163, 53);
            this.loadCurrentShow.Name = "loadCurrentShow";
            this.loadCurrentShow.Size = new System.Drawing.Size(58, 36);
            this.loadCurrentShow.TabIndex = 12;
            this.loadCurrentShow.Text = "5";
            this.loadCurrentShow.UseVisualStyleBackColor = false;
            // 
            // adafaaf
            // 
            this.adafaaf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adafaaf.AutoSize = true;
            this.adafaaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.adafaaf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adafaaf.Font = new System.Drawing.Font("Arial", 12F);
            this.adafaaf.ForeColor = System.Drawing.Color.Yellow;
            this.adafaaf.Location = new System.Drawing.Point(6, 6);
            this.adafaaf.Name = "adafaaf";
            this.adafaaf.Size = new System.Drawing.Size(148, 38);
            this.adafaaf.TabIndex = 9;
            this.adafaaf.Text = "LOAD VOLTAGE";
            this.adafaaf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adafaaf.UseVisualStyleBackColor = false;
            // 
            // loadVoltageShow
            // 
            this.loadVoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loadVoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadVoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadVoltageShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadVoltageShow.ForeColor = System.Drawing.Color.Yellow;
            this.loadVoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadVoltageShow.Location = new System.Drawing.Point(163, 6);
            this.loadVoltageShow.Name = "loadVoltageShow";
            this.loadVoltageShow.Size = new System.Drawing.Size(58, 38);
            this.loadVoltageShow.TabIndex = 10;
            this.loadVoltageShow.Text = "40";
            this.loadVoltageShow.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Yellow;
            this.button16.Location = new System.Drawing.Point(230, 6);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(33, 38);
            this.button16.TabIndex = 11;
            this.button16.Text = "V";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.AutoSize = true;
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button17.Font = new System.Drawing.Font("Arial", 11F);
            this.button17.ForeColor = System.Drawing.Color.Yellow;
            this.button17.Location = new System.Drawing.Point(6, 53);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(148, 36);
            this.button17.TabIndex = 9;
            this.button17.Text = "LOAD CURRENT";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.AutoSize = true;
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button18.Font = new System.Drawing.Font("Arial", 11F);
            this.button18.ForeColor = System.Drawing.Color.Yellow;
            this.button18.Location = new System.Drawing.Point(6, 98);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(148, 38);
            this.button18.TabIndex = 9;
            this.button18.Text = "LOAD WATTAGE";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Yellow;
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.Lime;
            this.groupBox4.Location = new System.Drawing.Point(3, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 159);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BATTERY";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.27819F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.18045F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.41353F));
            this.tableLayoutPanel8.Controls.Add(this.button19, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.batVoltageShow, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.button21, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.batCurrentShow, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.button23, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.batLevelShow, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.button25, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.button26, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.button27, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(269, 140);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button19.Location = new System.Drawing.Point(228, 97);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 37);
            this.button19.TabIndex = 15;
            this.button19.Text = "V";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // batVoltageShow
            // 
            this.batVoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.batVoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batVoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.batVoltageShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batVoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.batVoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batVoltageShow.Location = new System.Drawing.Point(168, 97);
            this.batVoltageShow.Name = "batVoltageShow";
            this.batVoltageShow.Size = new System.Drawing.Size(51, 37);
            this.batVoltageShow.TabIndex = 14;
            this.batVoltageShow.Text = "48";
            this.batVoltageShow.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button21.Location = new System.Drawing.Point(228, 52);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(35, 36);
            this.button21.TabIndex = 13;
            this.button21.Text = "A";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // batCurrentShow
            // 
            this.batCurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.batCurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batCurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.batCurrentShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batCurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.batCurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batCurrentShow.Location = new System.Drawing.Point(168, 52);
            this.batCurrentShow.Name = "batCurrentShow";
            this.batCurrentShow.Size = new System.Drawing.Size(51, 36);
            this.batCurrentShow.TabIndex = 12;
            this.batCurrentShow.Text = "5";
            this.batCurrentShow.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.AutoSize = true;
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button23.Font = new System.Drawing.Font("Arial", 12F);
            this.button23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button23.Location = new System.Drawing.Point(6, 6);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(153, 37);
            this.button23.TabIndex = 9;
            this.button23.Text = "BATTERY LEVEL";
            this.button23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // batLevelShow
            // 
            this.batLevelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.batLevelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batLevelShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.batLevelShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batLevelShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.batLevelShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batLevelShow.Location = new System.Drawing.Point(168, 6);
            this.batLevelShow.Name = "batLevelShow";
            this.batLevelShow.Size = new System.Drawing.Size(51, 37);
            this.batLevelShow.TabIndex = 10;
            this.batLevelShow.Text = "69";
            this.batLevelShow.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button25.Location = new System.Drawing.Point(228, 6);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(35, 37);
            this.button25.TabIndex = 11;
            this.button25.Text = "%";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button26.AutoSize = true;
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button26.Font = new System.Drawing.Font("Arial", 11F);
            this.button26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button26.Location = new System.Drawing.Point(6, 52);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(153, 36);
            this.button26.TabIndex = 9;
            this.button26.Text = "BATTERY CURENT";
            this.button26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button27.AutoSize = true;
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button27.Font = new System.Drawing.Font("Arial", 11F);
            this.button27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button27.Location = new System.Drawing.Point(6, 97);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(153, 37);
            this.button27.TabIndex = 9;
            this.button27.Text = "BATTERY VOLTAGE";
            this.button27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button27.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox5.Controls.Add(this.tableLayoutPanel9);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox5.Location = new System.Drawing.Point(3, 529);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 76);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "WHETHER";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91045F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.71642F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65672F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.08955F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.iconWeather, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel17, 3, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(269, 57);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel16.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.weatherState, 0, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(52, 4);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(77, 49);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "WEATHER";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherState
            // 
            this.weatherState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherState.AutoSize = true;
            this.weatherState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.weatherState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherState.ForeColor = System.Drawing.Color.Teal;
            this.weatherState.Location = new System.Drawing.Point(6, 26);
            this.weatherState.Name = "weatherState";
            this.weatherState.Size = new System.Drawing.Size(65, 20);
            this.weatherState.TabIndex = 0;
            this.weatherState.Text = "loading";
            this.weatherState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::SolarSCADA.Properties.Resources.icons8_marker_wind_64px;
            this.pictureBox3.Location = new System.Drawing.Point(136, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel17.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel17.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.windSpeedShow, 0, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(186, 4);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(79, 49);
            this.tableLayoutPanel17.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(5, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "WIND";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpeedShow
            // 
            this.windSpeedShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windSpeedShow.AutoSize = true;
            this.windSpeedShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.windSpeedShow.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedShow.ForeColor = System.Drawing.Color.Teal;
            this.windSpeedShow.Location = new System.Drawing.Point(5, 25);
            this.windSpeedShow.Name = "windSpeedShow";
            this.windSpeedShow.Size = new System.Drawing.Size(69, 22);
            this.windSpeedShow.TabIndex = 1;
            this.windSpeedShow.Text = "loading";
            this.windSpeedShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.groupBoxSetting);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetting.Location = new System.Drawing.Point(290, 3);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(1057, 82);
            this.panelSetting.TabIndex = 2;
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxSetting.Controls.Add(this.tableLayoutPanel12);
            this.groupBoxSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSetting.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSetting.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBoxSetting.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(1057, 82);
            this.groupBoxSetting.TabIndex = 5;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "CÀI ĐẶT HỆ THỐNG";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel12.ColumnCount = 6;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.78749F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.60342F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48577F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.00569F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.78558F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.155325F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel14, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel15, 4, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel66, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel67, 5, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1054, 64);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.16216F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.83784F));
            this.tableLayoutPanel13.Controls.Add(this.comboBox_comPort, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.comboBox_baudRate, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(234, 58);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(101, 3);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(130, 24);
            this.comboBox_comPort.TabIndex = 0;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(101, 32);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(130, 24);
            this.comboBox_baudRate.TabIndex = 1;
            this.comboBox_baudRate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "COMPORT:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "BAUDRATE:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel14.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.textBox_ngay, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_thang, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_nam, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_gio, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.textBox_phut, 2, 1);
            this.tableLayoutPanel14.Controls.Add(this.textBox_giay, 3, 1);
            this.tableLayoutPanel14.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(418, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(231, 58);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(3, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "TIME:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ngay
            // 
            this.textBox_ngay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ngay.Location = new System.Drawing.Point(72, 3);
            this.textBox_ngay.Name = "textBox_ngay";
            this.textBox_ngay.Size = new System.Drawing.Size(47, 22);
            this.textBox_ngay.TabIndex = 2;
            this.textBox_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_thang
            // 
            this.textBox_thang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_thang.Location = new System.Drawing.Point(125, 3);
            this.textBox_thang.Name = "textBox_thang";
            this.textBox_thang.Size = new System.Drawing.Size(47, 22);
            this.textBox_thang.TabIndex = 3;
            this.textBox_thang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_nam
            // 
            this.textBox_nam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nam.Location = new System.Drawing.Point(178, 3);
            this.textBox_nam.Name = "textBox_nam";
            this.textBox_nam.Size = new System.Drawing.Size(50, 22);
            this.textBox_nam.TabIndex = 4;
            this.textBox_nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_gio
            // 
            this.textBox_gio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_gio.Location = new System.Drawing.Point(72, 32);
            this.textBox_gio.Name = "textBox_gio";
            this.textBox_gio.Size = new System.Drawing.Size(47, 22);
            this.textBox_gio.TabIndex = 5;
            this.textBox_gio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_phut
            // 
            this.textBox_phut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_phut.Location = new System.Drawing.Point(125, 32);
            this.textBox_phut.Name = "textBox_phut";
            this.textBox_phut.Size = new System.Drawing.Size(47, 22);
            this.textBox_phut.TabIndex = 6;
            this.textBox_phut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_giay
            // 
            this.textBox_giay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_giay.Location = new System.Drawing.Point(178, 32);
            this.textBox_giay.Name = "textBox_giay";
            this.textBox_giay.Size = new System.Drawing.Size(50, 22);
            this.textBox_giay.TabIndex = 7;
            this.textBox_giay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "DATE:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.60784F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.39216F));
            this.tableLayoutPanel15.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.textBox_kinhDo, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.textBox_viDo, 1, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(771, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(192, 58);
            this.tableLayoutPanel15.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "LONGITUDE:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "LATITUDE:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_kinhDo
            // 
            this.textBox_kinhDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_kinhDo.Location = new System.Drawing.Point(88, 3);
            this.textBox_kinhDo.Name = "textBox_kinhDo";
            this.textBox_kinhDo.Size = new System.Drawing.Size(101, 22);
            this.textBox_kinhDo.TabIndex = 2;
            this.textBox_kinhDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_viDo
            // 
            this.textBox_viDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_viDo.Location = new System.Drawing.Point(88, 32);
            this.textBox_viDo.Name = "textBox_viDo";
            this.textBox_viDo.Size = new System.Drawing.Size(101, 22);
            this.textBox_viDo.TabIndex = 3;
            this.textBox_viDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel66
            // 
            this.tableLayoutPanel66.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel66.ColumnCount = 1;
            this.tableLayoutPanel66.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel66.Controls.Add(this.button_sendDate, 0, 0);
            this.tableLayoutPanel66.Controls.Add(this.checkCustom, 0, 1);
            this.tableLayoutPanel66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel66.Location = new System.Drawing.Point(655, 3);
            this.tableLayoutPanel66.Name = "tableLayoutPanel66";
            this.tableLayoutPanel66.RowCount = 2;
            this.tableLayoutPanel66.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel66.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel66.Size = new System.Drawing.Size(110, 58);
            this.tableLayoutPanel66.TabIndex = 8;
            // 
            // button_sendDate
            // 
            this.button_sendDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sendDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_sendDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_sendDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_sendDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_sendDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sendDate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sendDate.ForeColor = System.Drawing.Color.Blue;
            this.button_sendDate.Location = new System.Drawing.Point(3, 3);
            this.button_sendDate.Name = "button_sendDate";
            this.button_sendDate.Size = new System.Drawing.Size(104, 25);
            this.button_sendDate.TabIndex = 5;
            this.button_sendDate.Text = "SEND";
            this.button_sendDate.UseVisualStyleBackColor = true;
            this.button_sendDate.Click += new System.EventHandler(this.button_sendDate_Click);
            // 
            // checkCustom
            // 
            this.checkCustom.AutoSize = true;
            this.checkCustom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkCustom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkCustom.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCustom.ForeColor = System.Drawing.Color.Blue;
            this.checkCustom.Location = new System.Drawing.Point(3, 34);
            this.checkCustom.Name = "checkCustom";
            this.checkCustom.Size = new System.Drawing.Size(104, 21);
            this.checkCustom.TabIndex = 6;
            this.checkCustom.Text = "AUTO";
            this.checkCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCustom.UseVisualStyleBackColor = false;
            this.checkCustom.CheckedChanged += new System.EventHandler(this.checkCustom_CheckedChanged);
            // 
            // tableLayoutPanel67
            // 
            this.tableLayoutPanel67.ColumnCount = 1;
            this.tableLayoutPanel67.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel67.Controls.Add(this.button_sendVitri, 0, 0);
            this.tableLayoutPanel67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel67.Location = new System.Drawing.Point(969, 3);
            this.tableLayoutPanel67.Name = "tableLayoutPanel67";
            this.tableLayoutPanel67.RowCount = 1;
            this.tableLayoutPanel67.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel67.Size = new System.Drawing.Size(82, 58);
            this.tableLayoutPanel67.TabIndex = 9;
            // 
            // button_sendVitri
            // 
            this.button_sendVitri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_sendVitri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sendVitri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_sendVitri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_sendVitri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_sendVitri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_sendVitri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sendVitri.ForeColor = System.Drawing.Color.Blue;
            this.button_sendVitri.Location = new System.Drawing.Point(3, 3);
            this.button_sendVitri.Name = "button_sendVitri";
            this.button_sendVitri.Size = new System.Drawing.Size(76, 52);
            this.button_sendVitri.TabIndex = 6;
            this.button_sendVitri.Text = "SEND";
            this.button_sendVitri.UseVisualStyleBackColor = false;
            this.button_sendVitri.Click += new System.EventHandler(this.button_sendVitri_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.status, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(243, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 58);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel3.Controls.Add(this.open_port, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.close_port, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(163, 30);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // open_port
            // 
            this.open_port.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.open_port.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_port.Location = new System.Drawing.Point(3, 3);
            this.open_port.Name = "open_port";
            this.open_port.Size = new System.Drawing.Size(74, 24);
            this.open_port.TabIndex = 0;
            this.open_port.Text = "OPEN";
            this.open_port.UseVisualStyleBackColor = true;
            this.open_port.Click += new System.EventHandler(this.open_port_Click);
            // 
            // close_port
            // 
            this.close_port.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close_port.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_port.Location = new System.Drawing.Point(83, 3);
            this.close_port.Name = "close_port";
            this.close_port.Size = new System.Drawing.Size(77, 24);
            this.close_port.TabIndex = 1;
            this.close_port.Text = "CLOSE";
            this.close_port.UseVisualStyleBackColor = true;
            this.close_port.Click += new System.EventHandler(this.close_port_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(3, 36);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(163, 22);
            this.status.TabIndex = 1;
            this.status.Text = "DISCONNECTED";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.panelInfo);
            this.panelMid.Controls.Add(this.panelChart);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(290, 91);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1057, 608);
            this.panelMid.TabIndex = 6;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.layoutInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1057, 608);
            this.panelInfo.TabIndex = 5;
            // 
            // layoutInfo
            // 
            this.layoutInfo.ColumnCount = 3;
            this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutInfo.Controls.Add(this.groupBox13, 0, 2);
            this.layoutInfo.Controls.Add(this.groupBox17, 0, 2);
            this.layoutInfo.Controls.Add(this.groupBox12, 0, 1);
            this.layoutInfo.Controls.Add(this.groupBox11, 0, 1);
            this.layoutInfo.Controls.Add(this.groupBox10, 0, 1);
            this.layoutInfo.Controls.Add(this.groupBox9, 0, 0);
            this.layoutInfo.Controls.Add(this.PVpanel1, 0, 0);
            this.layoutInfo.Controls.Add(this.groupBox7, 0, 0);
            this.layoutInfo.Controls.Add(this.groupBox6, 0, 0);
            this.layoutInfo.Controls.Add(this.panel1, 1, 3);
            this.layoutInfo.Controls.Add(this.pictureBox1, 0, 3);
            this.layoutInfo.Controls.Add(this.pictureBox2, 2, 3);
            this.layoutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutInfo.Name = "layoutInfo";
            this.layoutInfo.RowCount = 4;
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutInfo.Size = new System.Drawing.Size(1057, 608);
            this.layoutInfo.TabIndex = 14;
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox13.Controls.Add(this.tableLayoutPanel46);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.ForeColor = System.Drawing.Color.Red;
            this.groupBox13.Location = new System.Drawing.Point(707, 307);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(347, 146);
            this.groupBox13.TabIndex = 24;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "PV 8";
            // 
            // tableLayoutPanel46
            // 
            this.tableLayoutPanel46.ColumnCount = 2;
            this.tableLayoutPanel46.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel46.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel46.Controls.Add(this.tableLayoutPanel47, 0, 0);
            this.tableLayoutPanel46.Controls.Add(this.tableLayoutPanel48, 1, 0);
            this.tableLayoutPanel46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel46.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel46.Name = "tableLayoutPanel46";
            this.tableLayoutPanel46.RowCount = 1;
            this.tableLayoutPanel46.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel46.Size = new System.Drawing.Size(341, 124);
            this.tableLayoutPanel46.TabIndex = 1;
            // 
            // tableLayoutPanel47
            // 
            this.tableLayoutPanel47.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel47.ColumnCount = 3;
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.28261F));
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86956F));
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel47.Controls.Add(this.button104, 2, 2);
            this.tableLayoutPanel47.Controls.Add(this.pv8WattageShow, 1, 2);
            this.tableLayoutPanel47.Controls.Add(this.button106, 2, 1);
            this.tableLayoutPanel47.Controls.Add(this.pv8CurrentShow, 1, 1);
            this.tableLayoutPanel47.Controls.Add(this.button108, 0, 0);
            this.tableLayoutPanel47.Controls.Add(this.pv8VoltageShow, 1, 0);
            this.tableLayoutPanel47.Controls.Add(this.button110, 2, 0);
            this.tableLayoutPanel47.Controls.Add(this.button111, 0, 1);
            this.tableLayoutPanel47.Controls.Add(this.button112, 0, 2);
            this.tableLayoutPanel47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel47.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel47.Name = "tableLayoutPanel47";
            this.tableLayoutPanel47.RowCount = 3;
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel47.Size = new System.Drawing.Size(188, 118);
            this.tableLayoutPanel47.TabIndex = 2;
            // 
            // button104
            // 
            this.button104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button104.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button104.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button104.Location = new System.Drawing.Point(160, 82);
            this.button104.Name = "button104";
            this.button104.Size = new System.Drawing.Size(22, 30);
            this.button104.TabIndex = 15;
            this.button104.Text = "W";
            this.button104.UseVisualStyleBackColor = false;
            // 
            // pv8WattageShow
            // 
            this.pv8WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv8WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv8WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv8WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv8WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv8WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv8WattageShow.Location = new System.Drawing.Point(93, 82);
            this.pv8WattageShow.Name = "pv8WattageShow";
            this.pv8WattageShow.Size = new System.Drawing.Size(58, 30);
            this.pv8WattageShow.TabIndex = 14;
            this.pv8WattageShow.Text = "200";
            this.pv8WattageShow.UseVisualStyleBackColor = false;
            // 
            // button106
            // 
            this.button106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button106.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button106.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button106.Location = new System.Drawing.Point(160, 44);
            this.button106.Name = "button106";
            this.button106.Size = new System.Drawing.Size(22, 29);
            this.button106.TabIndex = 13;
            this.button106.Text = "A";
            this.button106.UseVisualStyleBackColor = false;
            // 
            // pv8CurrentShow
            // 
            this.pv8CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv8CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv8CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv8CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv8CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv8CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv8CurrentShow.Location = new System.Drawing.Point(93, 44);
            this.pv8CurrentShow.Name = "pv8CurrentShow";
            this.pv8CurrentShow.Size = new System.Drawing.Size(58, 29);
            this.pv8CurrentShow.TabIndex = 12;
            this.pv8CurrentShow.Text = "5";
            this.pv8CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button108
            // 
            this.button108.AutoSize = true;
            this.button108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button108.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button108.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button108.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button108.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button108.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button108.Location = new System.Drawing.Point(6, 6);
            this.button108.Name = "button108";
            this.button108.Size = new System.Drawing.Size(78, 29);
            this.button108.TabIndex = 9;
            this.button108.Text = "VOLTAGE";
            this.button108.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button108.UseVisualStyleBackColor = false;
            // 
            // pv8VoltageShow
            // 
            this.pv8VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv8VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv8VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv8VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv8VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv8VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv8VoltageShow.Location = new System.Drawing.Point(93, 6);
            this.pv8VoltageShow.Name = "pv8VoltageShow";
            this.pv8VoltageShow.Size = new System.Drawing.Size(58, 29);
            this.pv8VoltageShow.TabIndex = 10;
            this.pv8VoltageShow.Text = "40";
            this.pv8VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button110
            // 
            this.button110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button110.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button110.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button110.Location = new System.Drawing.Point(160, 6);
            this.button110.Name = "button110";
            this.button110.Size = new System.Drawing.Size(22, 29);
            this.button110.TabIndex = 11;
            this.button110.Text = "V";
            this.button110.UseVisualStyleBackColor = false;
            // 
            // button111
            // 
            this.button111.AutoSize = true;
            this.button111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button111.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button111.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button111.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button111.Location = new System.Drawing.Point(6, 44);
            this.button111.Name = "button111";
            this.button111.Size = new System.Drawing.Size(78, 29);
            this.button111.TabIndex = 9;
            this.button111.Text = "CURRENT";
            this.button111.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button111.UseVisualStyleBackColor = false;
            // 
            // button112
            // 
            this.button112.AutoSize = true;
            this.button112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button112.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button112.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button112.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button112.Location = new System.Drawing.Point(6, 82);
            this.button112.Name = "button112";
            this.button112.Size = new System.Drawing.Size(78, 30);
            this.button112.TabIndex = 9;
            this.button112.Text = "WATTAGE";
            this.button112.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button112.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel48
            // 
            this.tableLayoutPanel48.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel48.ColumnCount = 1;
            this.tableLayoutPanel48.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel48.Controls.Add(this.button113, 0, 2);
            this.tableLayoutPanel48.Controls.Add(this.tableLayoutPanel49, 0, 0);
            this.tableLayoutPanel48.Controls.Add(this.statepv8, 0, 1);
            this.tableLayoutPanel48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel48.Location = new System.Drawing.Point(197, 3);
            this.tableLayoutPanel48.Name = "tableLayoutPanel48";
            this.tableLayoutPanel48.RowCount = 3;
            this.tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.62069F));
            this.tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.31034F));
            this.tableLayoutPanel48.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel48.TabIndex = 3;
            // 
            // button113
            // 
            this.button113.AutoSize = true;
            this.button113.BackColor = System.Drawing.Color.Yellow;
            this.button113.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button113.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button113.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button113.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button113.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button113.ForeColor = System.Drawing.Color.Red;
            this.button113.Location = new System.Drawing.Point(5, 86);
            this.button113.Name = "button113";
            this.button113.Size = new System.Drawing.Size(131, 27);
            this.button113.TabIndex = 11;
            this.button113.Text = "SET ANGLE NOW";
            this.button113.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel49
            // 
            this.tableLayoutPanel49.ColumnCount = 2;
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.14504F));
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.85496F));
            this.tableLayoutPanel49.Controls.Add(this.button114, 0, 0);
            this.tableLayoutPanel49.Controls.Add(this.angelpv8, 1, 0);
            this.tableLayoutPanel49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel49.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel49.Name = "tableLayoutPanel49";
            this.tableLayoutPanel49.RowCount = 1;
            this.tableLayoutPanel49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel49.Size = new System.Drawing.Size(131, 35);
            this.tableLayoutPanel49.TabIndex = 0;
            // 
            // button114
            // 
            this.button114.AutoSize = true;
            this.button114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button114.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button114.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button114.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button114.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button114.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button114.Location = new System.Drawing.Point(3, 3);
            this.button114.Name = "button114";
            this.button114.Size = new System.Drawing.Size(61, 29);
            this.button114.TabIndex = 9;
            this.button114.Text = "ANGLE";
            this.button114.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button114.UseVisualStyleBackColor = false;
            // 
            // angelpv8
            // 
            this.angelpv8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv8.Location = new System.Drawing.Point(70, 3);
            this.angelpv8.Name = "angelpv8";
            this.angelpv8.Size = new System.Drawing.Size(58, 28);
            this.angelpv8.TabIndex = 10;
            this.angelpv8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv8
            // 
            this.statepv8.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv8.AutoSize = true;
            this.statepv8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv8.Location = new System.Drawing.Point(5, 48);
            this.statepv8.Name = "statepv8";
            this.statepv8.Size = new System.Drawing.Size(131, 30);
            this.statepv8.TabIndex = 12;
            this.statepv8.Text = "AUTO TRACKING";
            this.statepv8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv8.UseVisualStyleBackColor = false;
            this.statepv8.CheckedChanged += new System.EventHandler(this.statepv8_CheckedChanged);
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox17.Controls.Add(this.tableLayoutPanel62);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.ForeColor = System.Drawing.Color.Red;
            this.groupBox17.Location = new System.Drawing.Point(355, 307);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(346, 146);
            this.groupBox17.TabIndex = 23;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "PV 9";
            // 
            // tableLayoutPanel62
            // 
            this.tableLayoutPanel62.ColumnCount = 2;
            this.tableLayoutPanel62.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel62.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel62.Controls.Add(this.tableLayoutPanel63, 0, 0);
            this.tableLayoutPanel62.Controls.Add(this.tableLayoutPanel64, 1, 0);
            this.tableLayoutPanel62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel62.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel62.Name = "tableLayoutPanel62";
            this.tableLayoutPanel62.RowCount = 1;
            this.tableLayoutPanel62.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel62.Size = new System.Drawing.Size(340, 124);
            this.tableLayoutPanel62.TabIndex = 1;
            // 
            // tableLayoutPanel63
            // 
            this.tableLayoutPanel63.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel63.ColumnCount = 3;
            this.tableLayoutPanel63.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.10811F));
            this.tableLayoutPanel63.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.13514F));
            this.tableLayoutPanel63.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel63.Controls.Add(this.button159, 2, 2);
            this.tableLayoutPanel63.Controls.Add(this.pv9WattageShow, 1, 2);
            this.tableLayoutPanel63.Controls.Add(this.button161, 2, 1);
            this.tableLayoutPanel63.Controls.Add(this.pv9CurrentShow, 1, 1);
            this.tableLayoutPanel63.Controls.Add(this.button163, 0, 0);
            this.tableLayoutPanel63.Controls.Add(this.pv9VoltageShow, 1, 0);
            this.tableLayoutPanel63.Controls.Add(this.button165, 2, 0);
            this.tableLayoutPanel63.Controls.Add(this.button166, 0, 1);
            this.tableLayoutPanel63.Controls.Add(this.button167, 0, 2);
            this.tableLayoutPanel63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel63.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel63.Name = "tableLayoutPanel63";
            this.tableLayoutPanel63.RowCount = 3;
            this.tableLayoutPanel63.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel63.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel63.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel63.Size = new System.Drawing.Size(187, 118);
            this.tableLayoutPanel63.TabIndex = 2;
            // 
            // button159
            // 
            this.button159.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button159.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button159.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button159.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button159.Location = new System.Drawing.Point(159, 82);
            this.button159.Name = "button159";
            this.button159.Size = new System.Drawing.Size(22, 30);
            this.button159.TabIndex = 15;
            this.button159.Text = "W";
            this.button159.UseVisualStyleBackColor = false;
            // 
            // pv9WattageShow
            // 
            this.pv9WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv9WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv9WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv9WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv9WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv9WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv9WattageShow.Location = new System.Drawing.Point(94, 82);
            this.pv9WattageShow.Name = "pv9WattageShow";
            this.pv9WattageShow.Size = new System.Drawing.Size(56, 30);
            this.pv9WattageShow.TabIndex = 14;
            this.pv9WattageShow.Text = "200";
            this.pv9WattageShow.UseVisualStyleBackColor = false;
            // 
            // button161
            // 
            this.button161.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button161.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button161.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button161.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button161.Location = new System.Drawing.Point(159, 44);
            this.button161.Name = "button161";
            this.button161.Size = new System.Drawing.Size(22, 29);
            this.button161.TabIndex = 13;
            this.button161.Text = "A";
            this.button161.UseVisualStyleBackColor = false;
            // 
            // pv9CurrentShow
            // 
            this.pv9CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv9CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv9CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv9CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv9CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv9CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv9CurrentShow.Location = new System.Drawing.Point(94, 44);
            this.pv9CurrentShow.Name = "pv9CurrentShow";
            this.pv9CurrentShow.Size = new System.Drawing.Size(56, 29);
            this.pv9CurrentShow.TabIndex = 12;
            this.pv9CurrentShow.Text = "5";
            this.pv9CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button163
            // 
            this.button163.AutoSize = true;
            this.button163.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button163.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button163.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button163.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button163.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button163.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button163.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button163.Location = new System.Drawing.Point(6, 6);
            this.button163.Name = "button163";
            this.button163.Size = new System.Drawing.Size(79, 29);
            this.button163.TabIndex = 9;
            this.button163.Text = "VOLTAGE";
            this.button163.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button163.UseVisualStyleBackColor = false;
            // 
            // pv9VoltageShow
            // 
            this.pv9VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv9VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv9VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv9VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv9VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv9VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv9VoltageShow.Location = new System.Drawing.Point(94, 6);
            this.pv9VoltageShow.Name = "pv9VoltageShow";
            this.pv9VoltageShow.Size = new System.Drawing.Size(56, 29);
            this.pv9VoltageShow.TabIndex = 10;
            this.pv9VoltageShow.Text = "40";
            this.pv9VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button165
            // 
            this.button165.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button165.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button165.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button165.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button165.Location = new System.Drawing.Point(159, 6);
            this.button165.Name = "button165";
            this.button165.Size = new System.Drawing.Size(22, 29);
            this.button165.TabIndex = 11;
            this.button165.Text = "V";
            this.button165.UseVisualStyleBackColor = false;
            // 
            // button166
            // 
            this.button166.AutoSize = true;
            this.button166.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button166.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button166.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button166.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button166.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button166.Location = new System.Drawing.Point(6, 44);
            this.button166.Name = "button166";
            this.button166.Size = new System.Drawing.Size(79, 29);
            this.button166.TabIndex = 9;
            this.button166.Text = "CURRENT";
            this.button166.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button166.UseVisualStyleBackColor = false;
            // 
            // button167
            // 
            this.button167.AutoSize = true;
            this.button167.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button167.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button167.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button167.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button167.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button167.Location = new System.Drawing.Point(6, 82);
            this.button167.Name = "button167";
            this.button167.Size = new System.Drawing.Size(79, 30);
            this.button167.TabIndex = 9;
            this.button167.Text = "WATTAGE";
            this.button167.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button167.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel64
            // 
            this.tableLayoutPanel64.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel64.ColumnCount = 1;
            this.tableLayoutPanel64.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel64.Controls.Add(this.button168, 0, 2);
            this.tableLayoutPanel64.Controls.Add(this.tableLayoutPanel65, 0, 0);
            this.tableLayoutPanel64.Controls.Add(this.statepv9, 0, 1);
            this.tableLayoutPanel64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel64.Location = new System.Drawing.Point(196, 3);
            this.tableLayoutPanel64.Name = "tableLayoutPanel64";
            this.tableLayoutPanel64.RowCount = 3;
            this.tableLayoutPanel64.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel64.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.62069F));
            this.tableLayoutPanel64.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.17241F));
            this.tableLayoutPanel64.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel64.TabIndex = 3;
            // 
            // button168
            // 
            this.button168.AutoSize = true;
            this.button168.BackColor = System.Drawing.Color.Yellow;
            this.button168.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button168.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button168.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button168.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button168.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button168.ForeColor = System.Drawing.Color.Red;
            this.button168.Location = new System.Drawing.Point(5, 85);
            this.button168.Name = "button168";
            this.button168.Size = new System.Drawing.Size(131, 28);
            this.button168.TabIndex = 11;
            this.button168.Text = "SET ANGLE NOW";
            this.button168.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel65
            // 
            this.tableLayoutPanel65.ColumnCount = 2;
            this.tableLayoutPanel65.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.9084F));
            this.tableLayoutPanel65.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0916F));
            this.tableLayoutPanel65.Controls.Add(this.button170, 0, 0);
            this.tableLayoutPanel65.Controls.Add(this.angelpv9, 1, 0);
            this.tableLayoutPanel65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel65.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel65.Name = "tableLayoutPanel65";
            this.tableLayoutPanel65.RowCount = 1;
            this.tableLayoutPanel65.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel65.Size = new System.Drawing.Size(131, 34);
            this.tableLayoutPanel65.TabIndex = 0;
            // 
            // button170
            // 
            this.button170.AutoSize = true;
            this.button170.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button170.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button170.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button170.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button170.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button170.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button170.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button170.Location = new System.Drawing.Point(3, 3);
            this.button170.Name = "button170";
            this.button170.Size = new System.Drawing.Size(62, 28);
            this.button170.TabIndex = 9;
            this.button170.Text = "ANGLE";
            this.button170.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button170.UseVisualStyleBackColor = false;
            // 
            // angelpv9
            // 
            this.angelpv9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv9.Location = new System.Drawing.Point(71, 3);
            this.angelpv9.Name = "angelpv9";
            this.angelpv9.Size = new System.Drawing.Size(57, 28);
            this.angelpv9.TabIndex = 10;
            this.angelpv9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv9
            // 
            this.statepv9.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv9.AutoSize = true;
            this.statepv9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv9.Location = new System.Drawing.Point(5, 47);
            this.statepv9.Name = "statepv9";
            this.statepv9.Size = new System.Drawing.Size(131, 30);
            this.statepv9.TabIndex = 12;
            this.statepv9.Text = "AUTO TRACKING";
            this.statepv9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv9.UseVisualStyleBackColor = false;
            this.statepv9.CheckedChanged += new System.EventHandler(this.statepv9_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox12.Controls.Add(this.tableLayoutPanel42);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.Red;
            this.groupBox12.Location = new System.Drawing.Point(707, 155);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(347, 146);
            this.groupBox12.TabIndex = 22;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "PV 6";
            // 
            // tableLayoutPanel42
            // 
            this.tableLayoutPanel42.ColumnCount = 2;
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel42.Controls.Add(this.tableLayoutPanel43, 0, 0);
            this.tableLayoutPanel42.Controls.Add(this.tableLayoutPanel44, 1, 0);
            this.tableLayoutPanel42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel42.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel42.Name = "tableLayoutPanel42";
            this.tableLayoutPanel42.RowCount = 1;
            this.tableLayoutPanel42.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel42.Size = new System.Drawing.Size(341, 124);
            this.tableLayoutPanel42.TabIndex = 1;
            // 
            // tableLayoutPanel43
            // 
            this.tableLayoutPanel43.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel43.ColumnCount = 3;
            this.tableLayoutPanel43.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.02703F));
            this.tableLayoutPanel43.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.21622F));
            this.tableLayoutPanel43.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel43.Controls.Add(this.button93, 2, 2);
            this.tableLayoutPanel43.Controls.Add(this.pv6WattageShow, 1, 2);
            this.tableLayoutPanel43.Controls.Add(this.button95, 2, 1);
            this.tableLayoutPanel43.Controls.Add(this.pv6CurrentShow, 1, 1);
            this.tableLayoutPanel43.Controls.Add(this.button97, 0, 0);
            this.tableLayoutPanel43.Controls.Add(this.pv6VoltageShow, 1, 0);
            this.tableLayoutPanel43.Controls.Add(this.button99, 2, 0);
            this.tableLayoutPanel43.Controls.Add(this.button100, 0, 1);
            this.tableLayoutPanel43.Controls.Add(this.button101, 0, 2);
            this.tableLayoutPanel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel43.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel43.Name = "tableLayoutPanel43";
            this.tableLayoutPanel43.RowCount = 3;
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel43.Size = new System.Drawing.Size(188, 118);
            this.tableLayoutPanel43.TabIndex = 2;
            // 
            // button93
            // 
            this.button93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button93.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button93.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button93.Location = new System.Drawing.Point(160, 82);
            this.button93.Name = "button93";
            this.button93.Size = new System.Drawing.Size(22, 30);
            this.button93.TabIndex = 15;
            this.button93.Text = "W";
            this.button93.UseVisualStyleBackColor = false;
            // 
            // pv6WattageShow
            // 
            this.pv6WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv6WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv6WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv6WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv6WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv6WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv6WattageShow.Location = new System.Drawing.Point(93, 82);
            this.pv6WattageShow.Name = "pv6WattageShow";
            this.pv6WattageShow.Size = new System.Drawing.Size(58, 30);
            this.pv6WattageShow.TabIndex = 14;
            this.pv6WattageShow.Text = "200";
            this.pv6WattageShow.UseVisualStyleBackColor = false;
            // 
            // button95
            // 
            this.button95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button95.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button95.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button95.Location = new System.Drawing.Point(160, 44);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(22, 29);
            this.button95.TabIndex = 13;
            this.button95.Text = "A";
            this.button95.UseVisualStyleBackColor = false;
            // 
            // pv6CurrentShow
            // 
            this.pv6CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv6CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv6CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv6CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv6CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv6CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv6CurrentShow.Location = new System.Drawing.Point(93, 44);
            this.pv6CurrentShow.Name = "pv6CurrentShow";
            this.pv6CurrentShow.Size = new System.Drawing.Size(58, 29);
            this.pv6CurrentShow.TabIndex = 12;
            this.pv6CurrentShow.Text = "5";
            this.pv6CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button97
            // 
            this.button97.AutoSize = true;
            this.button97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button97.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button97.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button97.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button97.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button97.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button97.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button97.Location = new System.Drawing.Point(6, 6);
            this.button97.Name = "button97";
            this.button97.Size = new System.Drawing.Size(78, 29);
            this.button97.TabIndex = 9;
            this.button97.Text = "VOLTAGE";
            this.button97.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button97.UseVisualStyleBackColor = false;
            // 
            // pv6VoltageShow
            // 
            this.pv6VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv6VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv6VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv6VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv6VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv6VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv6VoltageShow.Location = new System.Drawing.Point(93, 6);
            this.pv6VoltageShow.Name = "pv6VoltageShow";
            this.pv6VoltageShow.Size = new System.Drawing.Size(58, 29);
            this.pv6VoltageShow.TabIndex = 10;
            this.pv6VoltageShow.Text = "40";
            this.pv6VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button99
            // 
            this.button99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button99.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button99.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button99.Location = new System.Drawing.Point(160, 6);
            this.button99.Name = "button99";
            this.button99.Size = new System.Drawing.Size(22, 29);
            this.button99.TabIndex = 11;
            this.button99.Text = "V";
            this.button99.UseVisualStyleBackColor = false;
            // 
            // button100
            // 
            this.button100.AutoSize = true;
            this.button100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button100.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button100.Location = new System.Drawing.Point(6, 44);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(78, 29);
            this.button100.TabIndex = 9;
            this.button100.Text = "CURRENT";
            this.button100.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button100.UseVisualStyleBackColor = false;
            // 
            // button101
            // 
            this.button101.AutoSize = true;
            this.button101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button101.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button101.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button101.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button101.Location = new System.Drawing.Point(6, 82);
            this.button101.Name = "button101";
            this.button101.Size = new System.Drawing.Size(78, 30);
            this.button101.TabIndex = 9;
            this.button101.Text = "WATTAGE";
            this.button101.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button101.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel44
            // 
            this.tableLayoutPanel44.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel44.ColumnCount = 1;
            this.tableLayoutPanel44.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel44.Controls.Add(this.button102, 0, 2);
            this.tableLayoutPanel44.Controls.Add(this.tableLayoutPanel45, 0, 0);
            this.tableLayoutPanel44.Controls.Add(this.statepv7, 0, 1);
            this.tableLayoutPanel44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel44.Location = new System.Drawing.Point(197, 3);
            this.tableLayoutPanel44.Name = "tableLayoutPanel44";
            this.tableLayoutPanel44.RowCount = 3;
            this.tableLayoutPanel44.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel44.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.75862F));
            this.tableLayoutPanel44.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.17241F));
            this.tableLayoutPanel44.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel44.TabIndex = 3;
            // 
            // button102
            // 
            this.button102.AutoSize = true;
            this.button102.BackColor = System.Drawing.Color.Yellow;
            this.button102.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button102.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button102.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button102.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button102.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button102.ForeColor = System.Drawing.Color.Red;
            this.button102.Location = new System.Drawing.Point(5, 85);
            this.button102.Name = "button102";
            this.button102.Size = new System.Drawing.Size(131, 28);
            this.button102.TabIndex = 11;
            this.button102.Text = "SET ANGLE NOW";
            this.button102.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel45
            // 
            this.tableLayoutPanel45.ColumnCount = 2;
            this.tableLayoutPanel45.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.43512F));
            this.tableLayoutPanel45.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.56488F));
            this.tableLayoutPanel45.Controls.Add(this.button103, 0, 0);
            this.tableLayoutPanel45.Controls.Add(this.angelpv7, 1, 0);
            this.tableLayoutPanel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel45.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel45.Name = "tableLayoutPanel45";
            this.tableLayoutPanel45.RowCount = 1;
            this.tableLayoutPanel45.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel45.Size = new System.Drawing.Size(131, 35);
            this.tableLayoutPanel45.TabIndex = 0;
            // 
            // button103
            // 
            this.button103.AutoSize = true;
            this.button103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button103.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button103.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button103.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button103.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button103.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button103.Location = new System.Drawing.Point(3, 3);
            this.button103.Name = "button103";
            this.button103.Size = new System.Drawing.Size(64, 29);
            this.button103.TabIndex = 9;
            this.button103.Text = "ANGLE";
            this.button103.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button103.UseVisualStyleBackColor = false;
            // 
            // angelpv7
            // 
            this.angelpv7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv7.Location = new System.Drawing.Point(73, 3);
            this.angelpv7.Name = "angelpv7";
            this.angelpv7.Size = new System.Drawing.Size(55, 28);
            this.angelpv7.TabIndex = 10;
            this.angelpv7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv7
            // 
            this.statepv7.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv7.AutoSize = true;
            this.statepv7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv7.Location = new System.Drawing.Point(5, 48);
            this.statepv7.Name = "statepv7";
            this.statepv7.Size = new System.Drawing.Size(131, 29);
            this.statepv7.TabIndex = 12;
            this.statepv7.Text = "AUTO TRACKING";
            this.statepv7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv7.UseVisualStyleBackColor = false;
            this.statepv7.CheckedChanged += new System.EventHandler(this.statepv7_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox11.Controls.Add(this.tableLayoutPanel38);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.Red;
            this.groupBox11.Location = new System.Drawing.Point(355, 155);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(346, 146);
            this.groupBox11.TabIndex = 21;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "PV 7";
            // 
            // tableLayoutPanel38
            // 
            this.tableLayoutPanel38.ColumnCount = 2;
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel38.Controls.Add(this.tableLayoutPanel39, 0, 0);
            this.tableLayoutPanel38.Controls.Add(this.tableLayoutPanel40, 1, 0);
            this.tableLayoutPanel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel38.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel38.Name = "tableLayoutPanel38";
            this.tableLayoutPanel38.RowCount = 1;
            this.tableLayoutPanel38.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel38.Size = new System.Drawing.Size(340, 124);
            this.tableLayoutPanel38.TabIndex = 1;
            // 
            // tableLayoutPanel39
            // 
            this.tableLayoutPanel39.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel39.ColumnCount = 3;
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63044F));
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.06522F));
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel39.Controls.Add(this.button82, 2, 2);
            this.tableLayoutPanel39.Controls.Add(this.pv7WattageShow, 1, 2);
            this.tableLayoutPanel39.Controls.Add(this.button84, 2, 1);
            this.tableLayoutPanel39.Controls.Add(this.pv7CurrentShow, 1, 1);
            this.tableLayoutPanel39.Controls.Add(this.button86, 0, 0);
            this.tableLayoutPanel39.Controls.Add(this.pv7VoltageShow, 1, 0);
            this.tableLayoutPanel39.Controls.Add(this.button88, 2, 0);
            this.tableLayoutPanel39.Controls.Add(this.button89, 0, 1);
            this.tableLayoutPanel39.Controls.Add(this.button90, 0, 2);
            this.tableLayoutPanel39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel39.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel39.Name = "tableLayoutPanel39";
            this.tableLayoutPanel39.RowCount = 3;
            this.tableLayoutPanel39.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel39.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel39.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel39.Size = new System.Drawing.Size(187, 118);
            this.tableLayoutPanel39.TabIndex = 2;
            // 
            // button82
            // 
            this.button82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button82.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button82.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button82.Location = new System.Drawing.Point(159, 82);
            this.button82.Name = "button82";
            this.button82.Size = new System.Drawing.Size(22, 30);
            this.button82.TabIndex = 15;
            this.button82.Text = "W";
            this.button82.UseVisualStyleBackColor = false;
            // 
            // pv7WattageShow
            // 
            this.pv7WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv7WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv7WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv7WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv7WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv7WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv7WattageShow.Location = new System.Drawing.Point(100, 82);
            this.pv7WattageShow.Name = "pv7WattageShow";
            this.pv7WattageShow.Size = new System.Drawing.Size(50, 30);
            this.pv7WattageShow.TabIndex = 14;
            this.pv7WattageShow.Text = "200";
            this.pv7WattageShow.UseVisualStyleBackColor = false;
            // 
            // button84
            // 
            this.button84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button84.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button84.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button84.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button84.Location = new System.Drawing.Point(159, 44);
            this.button84.Name = "button84";
            this.button84.Size = new System.Drawing.Size(22, 29);
            this.button84.TabIndex = 13;
            this.button84.Text = "A";
            this.button84.UseVisualStyleBackColor = false;
            // 
            // pv7CurrentShow
            // 
            this.pv7CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv7CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv7CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv7CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv7CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv7CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv7CurrentShow.Location = new System.Drawing.Point(100, 44);
            this.pv7CurrentShow.Name = "pv7CurrentShow";
            this.pv7CurrentShow.Size = new System.Drawing.Size(50, 29);
            this.pv7CurrentShow.TabIndex = 12;
            this.pv7CurrentShow.Text = "5";
            this.pv7CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button86
            // 
            this.button86.AutoSize = true;
            this.button86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button86.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button86.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button86.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button86.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button86.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button86.Location = new System.Drawing.Point(6, 6);
            this.button86.Name = "button86";
            this.button86.Size = new System.Drawing.Size(85, 29);
            this.button86.TabIndex = 9;
            this.button86.Text = "VOLTAGE";
            this.button86.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button86.UseVisualStyleBackColor = false;
            // 
            // pv7VoltageShow
            // 
            this.pv7VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv7VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv7VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv7VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv7VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv7VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv7VoltageShow.Location = new System.Drawing.Point(100, 6);
            this.pv7VoltageShow.Name = "pv7VoltageShow";
            this.pv7VoltageShow.Size = new System.Drawing.Size(50, 29);
            this.pv7VoltageShow.TabIndex = 10;
            this.pv7VoltageShow.Text = "40";
            this.pv7VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button88
            // 
            this.button88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button88.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button88.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button88.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button88.Location = new System.Drawing.Point(159, 6);
            this.button88.Name = "button88";
            this.button88.Size = new System.Drawing.Size(22, 29);
            this.button88.TabIndex = 11;
            this.button88.Text = "V";
            this.button88.UseVisualStyleBackColor = false;
            // 
            // button89
            // 
            this.button89.AutoSize = true;
            this.button89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button89.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button89.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button89.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button89.Location = new System.Drawing.Point(6, 44);
            this.button89.Name = "button89";
            this.button89.Size = new System.Drawing.Size(85, 29);
            this.button89.TabIndex = 9;
            this.button89.Text = "CURRENT";
            this.button89.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button89.UseVisualStyleBackColor = false;
            // 
            // button90
            // 
            this.button90.AutoSize = true;
            this.button90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button90.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button90.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button90.Location = new System.Drawing.Point(6, 82);
            this.button90.Name = "button90";
            this.button90.Size = new System.Drawing.Size(85, 30);
            this.button90.TabIndex = 9;
            this.button90.Text = "WATTAGE";
            this.button90.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button90.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel40
            // 
            this.tableLayoutPanel40.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel40.ColumnCount = 1;
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel40.Controls.Add(this.button91, 0, 2);
            this.tableLayoutPanel40.Controls.Add(this.tableLayoutPanel41, 0, 0);
            this.tableLayoutPanel40.Controls.Add(this.statepv5, 0, 1);
            this.tableLayoutPanel40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel40.Location = new System.Drawing.Point(196, 3);
            this.tableLayoutPanel40.Name = "tableLayoutPanel40";
            this.tableLayoutPanel40.RowCount = 3;
            this.tableLayoutPanel40.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel40.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.89655F));
            this.tableLayoutPanel40.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel40.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel40.TabIndex = 3;
            // 
            // button91
            // 
            this.button91.AutoSize = true;
            this.button91.BackColor = System.Drawing.Color.Yellow;
            this.button91.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button91.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button91.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button91.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button91.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button91.ForeColor = System.Drawing.Color.Red;
            this.button91.Location = new System.Drawing.Point(5, 84);
            this.button91.Name = "button91";
            this.button91.Size = new System.Drawing.Size(131, 29);
            this.button91.TabIndex = 11;
            this.button91.Text = "SET ANGLE NOW";
            this.button91.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel41
            // 
            this.tableLayoutPanel41.ColumnCount = 2;
            this.tableLayoutPanel41.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.43512F));
            this.tableLayoutPanel41.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.56488F));
            this.tableLayoutPanel41.Controls.Add(this.button92, 0, 0);
            this.tableLayoutPanel41.Controls.Add(this.angelpv5, 1, 0);
            this.tableLayoutPanel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel41.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel41.Name = "tableLayoutPanel41";
            this.tableLayoutPanel41.RowCount = 1;
            this.tableLayoutPanel41.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel41.Size = new System.Drawing.Size(131, 35);
            this.tableLayoutPanel41.TabIndex = 0;
            // 
            // button92
            // 
            this.button92.AutoSize = true;
            this.button92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button92.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button92.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button92.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button92.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button92.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button92.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button92.Location = new System.Drawing.Point(3, 3);
            this.button92.Name = "button92";
            this.button92.Size = new System.Drawing.Size(64, 29);
            this.button92.TabIndex = 9;
            this.button92.Text = "ANGLE";
            this.button92.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button92.UseVisualStyleBackColor = false;
            // 
            // angelpv5
            // 
            this.angelpv5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv5.Location = new System.Drawing.Point(73, 3);
            this.angelpv5.Name = "angelpv5";
            this.angelpv5.Size = new System.Drawing.Size(55, 28);
            this.angelpv5.TabIndex = 10;
            this.angelpv5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv5
            // 
            this.statepv5.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv5.AutoSize = true;
            this.statepv5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv5.Location = new System.Drawing.Point(5, 48);
            this.statepv5.Name = "statepv5";
            this.statepv5.Size = new System.Drawing.Size(131, 28);
            this.statepv5.TabIndex = 12;
            this.statepv5.Text = "AUTO TRACKING";
            this.statepv5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv5.UseVisualStyleBackColor = false;
            this.statepv5.CheckedChanged += new System.EventHandler(this.statepv5_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox10.Controls.Add(this.tableLayoutPanel34);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.Red;
            this.groupBox10.Location = new System.Drawing.Point(3, 307);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(346, 146);
            this.groupBox10.TabIndex = 20;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "PV 5";
            // 
            // tableLayoutPanel34
            // 
            this.tableLayoutPanel34.ColumnCount = 2;
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel34.Controls.Add(this.tableLayoutPanel35, 0, 0);
            this.tableLayoutPanel34.Controls.Add(this.tableLayoutPanel36, 1, 0);
            this.tableLayoutPanel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel34.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel34.Name = "tableLayoutPanel34";
            this.tableLayoutPanel34.RowCount = 1;
            this.tableLayoutPanel34.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel34.Size = new System.Drawing.Size(340, 124);
            this.tableLayoutPanel34.TabIndex = 1;
            // 
            // tableLayoutPanel35
            // 
            this.tableLayoutPanel35.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel35.ColumnCount = 3;
            this.tableLayoutPanel35.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel35.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.32609F));
            this.tableLayoutPanel35.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel35.Controls.Add(this.button71, 2, 2);
            this.tableLayoutPanel35.Controls.Add(this.pv5WattageShow, 1, 2);
            this.tableLayoutPanel35.Controls.Add(this.button73, 2, 1);
            this.tableLayoutPanel35.Controls.Add(this.pv5CurrentShow, 1, 1);
            this.tableLayoutPanel35.Controls.Add(this.button75, 0, 0);
            this.tableLayoutPanel35.Controls.Add(this.pv5VoltageShow, 1, 0);
            this.tableLayoutPanel35.Controls.Add(this.button77, 2, 0);
            this.tableLayoutPanel35.Controls.Add(this.button78, 0, 1);
            this.tableLayoutPanel35.Controls.Add(this.button79, 0, 2);
            this.tableLayoutPanel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel35.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel35.Name = "tableLayoutPanel35";
            this.tableLayoutPanel35.RowCount = 3;
            this.tableLayoutPanel35.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel35.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel35.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel35.Size = new System.Drawing.Size(187, 118);
            this.tableLayoutPanel35.TabIndex = 2;
            // 
            // button71
            // 
            this.button71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button71.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button71.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button71.Location = new System.Drawing.Point(159, 82);
            this.button71.Name = "button71";
            this.button71.Size = new System.Drawing.Size(22, 30);
            this.button71.TabIndex = 15;
            this.button71.Text = "W";
            this.button71.UseVisualStyleBackColor = false;
            // 
            // pv5WattageShow
            // 
            this.pv5WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv5WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv5WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv5WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv5WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv5WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv5WattageShow.Location = new System.Drawing.Point(94, 82);
            this.pv5WattageShow.Name = "pv5WattageShow";
            this.pv5WattageShow.Size = new System.Drawing.Size(56, 30);
            this.pv5WattageShow.TabIndex = 14;
            this.pv5WattageShow.Text = "200";
            this.pv5WattageShow.UseVisualStyleBackColor = false;
            // 
            // button73
            // 
            this.button73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button73.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button73.Location = new System.Drawing.Point(159, 44);
            this.button73.Name = "button73";
            this.button73.Size = new System.Drawing.Size(22, 29);
            this.button73.TabIndex = 13;
            this.button73.Text = "A";
            this.button73.UseVisualStyleBackColor = false;
            // 
            // pv5CurrentShow
            // 
            this.pv5CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv5CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv5CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv5CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv5CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv5CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv5CurrentShow.Location = new System.Drawing.Point(94, 44);
            this.pv5CurrentShow.Name = "pv5CurrentShow";
            this.pv5CurrentShow.Size = new System.Drawing.Size(56, 29);
            this.pv5CurrentShow.TabIndex = 12;
            this.pv5CurrentShow.Text = "5";
            this.pv5CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button75
            // 
            this.button75.AutoSize = true;
            this.button75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button75.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button75.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button75.Location = new System.Drawing.Point(6, 6);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(79, 29);
            this.button75.TabIndex = 9;
            this.button75.Text = "VOLTAGE";
            this.button75.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button75.UseVisualStyleBackColor = false;
            // 
            // pv5VoltageShow
            // 
            this.pv5VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv5VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv5VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv5VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv5VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv5VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv5VoltageShow.Location = new System.Drawing.Point(94, 6);
            this.pv5VoltageShow.Name = "pv5VoltageShow";
            this.pv5VoltageShow.Size = new System.Drawing.Size(56, 29);
            this.pv5VoltageShow.TabIndex = 10;
            this.pv5VoltageShow.Text = "40";
            this.pv5VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button77
            // 
            this.button77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button77.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button77.Location = new System.Drawing.Point(159, 6);
            this.button77.Name = "button77";
            this.button77.Size = new System.Drawing.Size(22, 29);
            this.button77.TabIndex = 11;
            this.button77.Text = "V";
            this.button77.UseVisualStyleBackColor = false;
            // 
            // button78
            // 
            this.button78.AutoSize = true;
            this.button78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button78.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button78.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button78.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button78.Location = new System.Drawing.Point(6, 44);
            this.button78.Name = "button78";
            this.button78.Size = new System.Drawing.Size(79, 29);
            this.button78.TabIndex = 9;
            this.button78.Text = "CURRENT";
            this.button78.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button78.UseVisualStyleBackColor = false;
            // 
            // button79
            // 
            this.button79.AutoSize = true;
            this.button79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button79.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button79.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button79.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button79.Location = new System.Drawing.Point(6, 82);
            this.button79.Name = "button79";
            this.button79.Size = new System.Drawing.Size(79, 30);
            this.button79.TabIndex = 9;
            this.button79.Text = "WATTAGE";
            this.button79.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button79.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel36
            // 
            this.tableLayoutPanel36.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel36.ColumnCount = 1;
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel36.Controls.Add(this.button80, 0, 2);
            this.tableLayoutPanel36.Controls.Add(this.tableLayoutPanel37, 0, 0);
            this.tableLayoutPanel36.Controls.Add(this.statepv6, 0, 1);
            this.tableLayoutPanel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel36.Location = new System.Drawing.Point(196, 3);
            this.tableLayoutPanel36.Name = "tableLayoutPanel36";
            this.tableLayoutPanel36.RowCount = 3;
            this.tableLayoutPanel36.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel36.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.44828F));
            this.tableLayoutPanel36.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.34483F));
            this.tableLayoutPanel36.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel36.TabIndex = 3;
            // 
            // button80
            // 
            this.button80.AutoSize = true;
            this.button80.BackColor = System.Drawing.Color.Yellow;
            this.button80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button80.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button80.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button80.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button80.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button80.ForeColor = System.Drawing.Color.Red;
            this.button80.Location = new System.Drawing.Point(5, 80);
            this.button80.Name = "button80";
            this.button80.Size = new System.Drawing.Size(131, 33);
            this.button80.TabIndex = 11;
            this.button80.Text = "SET ANGLE NOW";
            this.button80.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel37
            // 
            this.tableLayoutPanel37.ColumnCount = 2;
            this.tableLayoutPanel37.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.67176F));
            this.tableLayoutPanel37.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.32824F));
            this.tableLayoutPanel37.Controls.Add(this.button81, 0, 0);
            this.tableLayoutPanel37.Controls.Add(this.angelpv6, 1, 0);
            this.tableLayoutPanel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel37.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel37.Name = "tableLayoutPanel37";
            this.tableLayoutPanel37.RowCount = 1;
            this.tableLayoutPanel37.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel37.Size = new System.Drawing.Size(131, 34);
            this.tableLayoutPanel37.TabIndex = 0;
            // 
            // button81
            // 
            this.button81.AutoSize = true;
            this.button81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button81.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button81.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button81.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button81.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button81.Location = new System.Drawing.Point(3, 3);
            this.button81.Name = "button81";
            this.button81.Size = new System.Drawing.Size(63, 28);
            this.button81.TabIndex = 9;
            this.button81.Text = "ANGLE";
            this.button81.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button81.UseVisualStyleBackColor = false;
            // 
            // angelpv6
            // 
            this.angelpv6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv6.Location = new System.Drawing.Point(72, 3);
            this.angelpv6.Name = "angelpv6";
            this.angelpv6.Size = new System.Drawing.Size(56, 28);
            this.angelpv6.TabIndex = 10;
            this.angelpv6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv6
            // 
            this.statepv6.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv6.AutoSize = true;
            this.statepv6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv6.Location = new System.Drawing.Point(5, 47);
            this.statepv6.Name = "statepv6";
            this.statepv6.Size = new System.Drawing.Size(131, 25);
            this.statepv6.TabIndex = 12;
            this.statepv6.Text = "AUTO TRACKING";
            this.statepv6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv6.UseVisualStyleBackColor = false;
            this.statepv6.CheckedChanged += new System.EventHandler(this.statepv6_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox9.Controls.Add(this.tableLayoutPanel30);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Red;
            this.groupBox9.Location = new System.Drawing.Point(707, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(347, 146);
            this.groupBox9.TabIndex = 19;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "PV 2";
            // 
            // tableLayoutPanel30
            // 
            this.tableLayoutPanel30.ColumnCount = 2;
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel30.Controls.Add(this.tableLayoutPanel31, 0, 0);
            this.tableLayoutPanel30.Controls.Add(this.tableLayoutPanel32, 1, 0);
            this.tableLayoutPanel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel30.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel30.Name = "tableLayoutPanel30";
            this.tableLayoutPanel30.RowCount = 1;
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel30.Size = new System.Drawing.Size(341, 124);
            this.tableLayoutPanel30.TabIndex = 1;
            // 
            // tableLayoutPanel31
            // 
            this.tableLayoutPanel31.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel31.ColumnCount = 3;
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36956F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.32609F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel31.Controls.Add(this.button60, 2, 2);
            this.tableLayoutPanel31.Controls.Add(this.pv2WattageShow, 1, 2);
            this.tableLayoutPanel31.Controls.Add(this.button62, 2, 1);
            this.tableLayoutPanel31.Controls.Add(this.pv2CurrentShow, 1, 1);
            this.tableLayoutPanel31.Controls.Add(this.button64, 0, 0);
            this.tableLayoutPanel31.Controls.Add(this.pv2VoltageShow, 1, 0);
            this.tableLayoutPanel31.Controls.Add(this.button66, 2, 0);
            this.tableLayoutPanel31.Controls.Add(this.button67, 0, 1);
            this.tableLayoutPanel31.Controls.Add(this.button68, 0, 2);
            this.tableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel31.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel31.Name = "tableLayoutPanel31";
            this.tableLayoutPanel31.RowCount = 3;
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel31.Size = new System.Drawing.Size(188, 118);
            this.tableLayoutPanel31.TabIndex = 2;
            // 
            // button60
            // 
            this.button60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button60.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button60.Location = new System.Drawing.Point(160, 82);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(22, 30);
            this.button60.TabIndex = 15;
            this.button60.Text = "W";
            this.button60.UseVisualStyleBackColor = false;
            // 
            // pv2WattageShow
            // 
            this.pv2WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv2WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv2WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv2WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv2WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv2WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv2WattageShow.Location = new System.Drawing.Point(95, 82);
            this.pv2WattageShow.Name = "pv2WattageShow";
            this.pv2WattageShow.Size = new System.Drawing.Size(56, 30);
            this.pv2WattageShow.TabIndex = 14;
            this.pv2WattageShow.Text = "200";
            this.pv2WattageShow.UseVisualStyleBackColor = false;
            // 
            // button62
            // 
            this.button62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button62.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button62.Location = new System.Drawing.Point(160, 44);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(22, 29);
            this.button62.TabIndex = 13;
            this.button62.Text = "A";
            this.button62.UseVisualStyleBackColor = false;
            // 
            // pv2CurrentShow
            // 
            this.pv2CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv2CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv2CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv2CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv2CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv2CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv2CurrentShow.Location = new System.Drawing.Point(95, 44);
            this.pv2CurrentShow.Name = "pv2CurrentShow";
            this.pv2CurrentShow.Size = new System.Drawing.Size(56, 29);
            this.pv2CurrentShow.TabIndex = 12;
            this.pv2CurrentShow.Text = "5";
            this.pv2CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button64
            // 
            this.button64.AutoSize = true;
            this.button64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button64.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button64.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button64.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button64.Location = new System.Drawing.Point(6, 6);
            this.button64.Name = "button64";
            this.button64.Size = new System.Drawing.Size(80, 29);
            this.button64.TabIndex = 9;
            this.button64.Text = "VOLTAGE";
            this.button64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button64.UseVisualStyleBackColor = false;
            // 
            // pv2VoltageShow
            // 
            this.pv2VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv2VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv2VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv2VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv2VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv2VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv2VoltageShow.Location = new System.Drawing.Point(95, 6);
            this.pv2VoltageShow.Name = "pv2VoltageShow";
            this.pv2VoltageShow.Size = new System.Drawing.Size(56, 29);
            this.pv2VoltageShow.TabIndex = 10;
            this.pv2VoltageShow.Text = "40";
            this.pv2VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button66
            // 
            this.button66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button66.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button66.Location = new System.Drawing.Point(160, 6);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(22, 29);
            this.button66.TabIndex = 11;
            this.button66.Text = "V";
            this.button66.UseVisualStyleBackColor = false;
            // 
            // button67
            // 
            this.button67.AutoSize = true;
            this.button67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button67.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button67.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button67.Location = new System.Drawing.Point(6, 44);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(80, 29);
            this.button67.TabIndex = 9;
            this.button67.Text = "CURRENT";
            this.button67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button67.UseVisualStyleBackColor = false;
            // 
            // button68
            // 
            this.button68.AutoSize = true;
            this.button68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button68.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button68.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button68.Location = new System.Drawing.Point(6, 82);
            this.button68.Name = "button68";
            this.button68.Size = new System.Drawing.Size(80, 30);
            this.button68.TabIndex = 9;
            this.button68.Text = "WATTAGE";
            this.button68.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button68.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel32
            // 
            this.tableLayoutPanel32.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel32.ColumnCount = 1;
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel32.Controls.Add(this.button69, 0, 2);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel33, 0, 0);
            this.tableLayoutPanel32.Controls.Add(this.statepv2, 0, 1);
            this.tableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel32.Location = new System.Drawing.Point(197, 3);
            this.tableLayoutPanel32.Name = "tableLayoutPanel32";
            this.tableLayoutPanel32.RowCount = 3;
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.75862F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel32.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel32.TabIndex = 3;
            // 
            // button69
            // 
            this.button69.AutoSize = true;
            this.button69.BackColor = System.Drawing.Color.Yellow;
            this.button69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button69.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button69.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button69.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button69.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button69.ForeColor = System.Drawing.Color.Red;
            this.button69.Location = new System.Drawing.Point(5, 84);
            this.button69.Name = "button69";
            this.button69.Size = new System.Drawing.Size(131, 29);
            this.button69.TabIndex = 11;
            this.button69.Text = "SET ANGLE NOW";
            this.button69.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel33
            // 
            this.tableLayoutPanel33.ColumnCount = 2;
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel33.Controls.Add(this.button70, 0, 0);
            this.tableLayoutPanel33.Controls.Add(this.angelpv2, 1, 0);
            this.tableLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel33.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel33.Name = "tableLayoutPanel33";
            this.tableLayoutPanel33.RowCount = 1;
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Size = new System.Drawing.Size(131, 34);
            this.tableLayoutPanel33.TabIndex = 0;
            // 
            // button70
            // 
            this.button70.AutoSize = true;
            this.button70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button70.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button70.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button70.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button70.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button70.Location = new System.Drawing.Point(3, 3);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(66, 28);
            this.button70.TabIndex = 9;
            this.button70.Text = "ANGLE";
            this.button70.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button70.UseVisualStyleBackColor = false;
            // 
            // angelpv2
            // 
            this.angelpv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv2.Location = new System.Drawing.Point(75, 3);
            this.angelpv2.Name = "angelpv2";
            this.angelpv2.Size = new System.Drawing.Size(53, 28);
            this.angelpv2.TabIndex = 10;
            this.angelpv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv2
            // 
            this.statepv2.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv2.AutoSize = true;
            this.statepv2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv2.Location = new System.Drawing.Point(5, 47);
            this.statepv2.Name = "statepv2";
            this.statepv2.Size = new System.Drawing.Size(131, 29);
            this.statepv2.TabIndex = 12;
            this.statepv2.Text = "AUTO TRACKING";
            this.statepv2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv2.UseVisualStyleBackColor = false;
            this.statepv2.CheckedChanged += new System.EventHandler(this.statepv2_CheckedChanged);
            // 
            // PVpanel1
            // 
            this.PVpanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PVpanel1.Controls.Add(this.tableLayoutPanel26);
            this.PVpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVpanel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVpanel1.ForeColor = System.Drawing.Color.Red;
            this.PVpanel1.Location = new System.Drawing.Point(3, 3);
            this.PVpanel1.Name = "PVpanel1";
            this.PVpanel1.Size = new System.Drawing.Size(346, 146);
            this.PVpanel1.TabIndex = 18;
            this.PVpanel1.TabStop = false;
            this.PVpanel1.Text = "PV 1";
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 2;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.58823F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.41177F));
            this.tableLayoutPanel26.Controls.Add(this.tableLayoutPanel27, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.tableLayoutPanel28, 1, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(340, 124);
            this.tableLayoutPanel26.TabIndex = 1;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel27.ColumnCount = 3;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83799F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.40223F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel27.Controls.Add(this.button49, 2, 2);
            this.tableLayoutPanel27.Controls.Add(this.pv1WattageShow, 1, 2);
            this.tableLayoutPanel27.Controls.Add(this.button51, 2, 1);
            this.tableLayoutPanel27.Controls.Add(this.pv1CurrentShow, 1, 1);
            this.tableLayoutPanel27.Controls.Add(this.button53, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.pv1VoltageShow, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.button55, 2, 0);
            this.tableLayoutPanel27.Controls.Add(this.button56, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.button57, 0, 2);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 3;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(182, 118);
            this.tableLayoutPanel27.TabIndex = 2;
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button49.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button49.Location = new System.Drawing.Point(155, 82);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(21, 30);
            this.button49.TabIndex = 15;
            this.button49.Text = "W";
            this.button49.UseVisualStyleBackColor = false;
            // 
            // pv1WattageShow
            // 
            this.pv1WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv1WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv1WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv1WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv1WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv1WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv1WattageShow.Location = new System.Drawing.Point(96, 82);
            this.pv1WattageShow.Name = "pv1WattageShow";
            this.pv1WattageShow.Size = new System.Drawing.Size(50, 30);
            this.pv1WattageShow.TabIndex = 14;
            this.pv1WattageShow.Text = "200";
            this.pv1WattageShow.UseVisualStyleBackColor = false;
            // 
            // button51
            // 
            this.button51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button51.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button51.Location = new System.Drawing.Point(155, 44);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(21, 29);
            this.button51.TabIndex = 13;
            this.button51.Text = "A";
            this.button51.UseVisualStyleBackColor = false;
            // 
            // pv1CurrentShow
            // 
            this.pv1CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv1CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv1CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv1CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv1CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv1CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv1CurrentShow.Location = new System.Drawing.Point(96, 44);
            this.pv1CurrentShow.Name = "pv1CurrentShow";
            this.pv1CurrentShow.Size = new System.Drawing.Size(50, 29);
            this.pv1CurrentShow.TabIndex = 12;
            this.pv1CurrentShow.Text = "5";
            this.pv1CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button53
            // 
            this.button53.AutoSize = true;
            this.button53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button53.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button53.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button53.Location = new System.Drawing.Point(6, 6);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(81, 29);
            this.button53.TabIndex = 9;
            this.button53.Text = "VOLTAGE";
            this.button53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button53.UseVisualStyleBackColor = false;
            // 
            // pv1VoltageShow
            // 
            this.pv1VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv1VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv1VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv1VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv1VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv1VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv1VoltageShow.Location = new System.Drawing.Point(96, 6);
            this.pv1VoltageShow.Name = "pv1VoltageShow";
            this.pv1VoltageShow.Size = new System.Drawing.Size(50, 29);
            this.pv1VoltageShow.TabIndex = 10;
            this.pv1VoltageShow.Text = "40";
            this.pv1VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button55
            // 
            this.button55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button55.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button55.Location = new System.Drawing.Point(155, 6);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(21, 29);
            this.button55.TabIndex = 11;
            this.button55.Text = "V";
            this.button55.UseVisualStyleBackColor = false;
            // 
            // button56
            // 
            this.button56.AutoSize = true;
            this.button56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button56.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button56.Location = new System.Drawing.Point(6, 44);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(81, 29);
            this.button56.TabIndex = 9;
            this.button56.Text = "CURRENT";
            this.button56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button56.UseVisualStyleBackColor = false;
            // 
            // button57
            // 
            this.button57.AutoSize = true;
            this.button57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button57.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button57.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button57.Location = new System.Drawing.Point(6, 82);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(81, 30);
            this.button57.TabIndex = 9;
            this.button57.Text = "WATTAGE";
            this.button57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button57.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel28.ColumnCount = 1;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.Controls.Add(this.button58, 0, 2);
            this.tableLayoutPanel28.Controls.Add(this.tableLayoutPanel29, 0, 0);
            this.tableLayoutPanel28.Controls.Add(this.statepv1, 0, 1);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(191, 3);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 3;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.75862F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(146, 118);
            this.tableLayoutPanel28.TabIndex = 3;
            // 
            // button58
            // 
            this.button58.AutoSize = true;
            this.button58.BackColor = System.Drawing.Color.Yellow;
            this.button58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button58.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button58.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button58.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button58.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button58.ForeColor = System.Drawing.Color.Red;
            this.button58.Location = new System.Drawing.Point(5, 82);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(136, 31);
            this.button58.TabIndex = 11;
            this.button58.Text = "SET ANGLE NOW";
            this.button58.UseVisualStyleBackColor = false;
            this.button58.Click += new System.EventHandler(this.button58_Click);
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 2;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.14706F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.85294F));
            this.tableLayoutPanel29.Controls.Add(this.button59, 0, 0);
            this.tableLayoutPanel29.Controls.Add(this.angelpv1, 1, 0);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 1;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(136, 34);
            this.tableLayoutPanel29.TabIndex = 0;
            // 
            // button59
            // 
            this.button59.AutoSize = true;
            this.button59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button59.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button59.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button59.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button59.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button59.Location = new System.Drawing.Point(3, 3);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(69, 28);
            this.button59.TabIndex = 9;
            this.button59.Text = "ANGLE";
            this.button59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button59.UseVisualStyleBackColor = false;
            // 
            // angelpv1
            // 
            this.angelpv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv1.Location = new System.Drawing.Point(78, 3);
            this.angelpv1.Name = "angelpv1";
            this.angelpv1.Size = new System.Drawing.Size(55, 28);
            this.angelpv1.TabIndex = 10;
            this.angelpv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv1
            // 
            this.statepv1.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv1.Location = new System.Drawing.Point(5, 47);
            this.statepv1.Name = "statepv1";
            this.statepv1.Size = new System.Drawing.Size(136, 27);
            this.statepv1.TabIndex = 12;
            this.statepv1.Text = "AUTO TRACKING";
            this.statepv1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv1.UseVisualStyleBackColor = false;
            this.statepv1.CheckedChanged += new System.EventHandler(this.statepv1_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox7.Controls.Add(this.tableLayoutPanel22);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Red;
            this.groupBox7.Location = new System.Drawing.Point(355, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(346, 146);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PV 4";
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 2;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel23, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel24, 1, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(340, 124);
            this.tableLayoutPanel22.TabIndex = 1;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel23.ColumnCount = 3;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.69565F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel23.Controls.Add(this.button38, 2, 2);
            this.tableLayoutPanel23.Controls.Add(this.pv4WattageShow, 1, 2);
            this.tableLayoutPanel23.Controls.Add(this.button40, 2, 1);
            this.tableLayoutPanel23.Controls.Add(this.pv4CurrentShow, 1, 1);
            this.tableLayoutPanel23.Controls.Add(this.button42, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.pv4VoltageShow, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.button44, 2, 0);
            this.tableLayoutPanel23.Controls.Add(this.button45, 0, 1);
            this.tableLayoutPanel23.Controls.Add(this.button46, 0, 2);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 3;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(187, 118);
            this.tableLayoutPanel23.TabIndex = 2;
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button38.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button38.Location = new System.Drawing.Point(159, 82);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(22, 30);
            this.button38.TabIndex = 15;
            this.button38.Text = "W";
            this.button38.UseVisualStyleBackColor = false;
            // 
            // pv4WattageShow
            // 
            this.pv4WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv4WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv4WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv4WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv4WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv4WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv4WattageShow.Location = new System.Drawing.Point(97, 82);
            this.pv4WattageShow.Name = "pv4WattageShow";
            this.pv4WattageShow.Size = new System.Drawing.Size(53, 30);
            this.pv4WattageShow.TabIndex = 14;
            this.pv4WattageShow.Text = "200";
            this.pv4WattageShow.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button40.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button40.Location = new System.Drawing.Point(159, 44);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(22, 29);
            this.button40.TabIndex = 13;
            this.button40.Text = "A";
            this.button40.UseVisualStyleBackColor = false;
            // 
            // pv4CurrentShow
            // 
            this.pv4CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv4CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv4CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv4CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv4CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv4CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv4CurrentShow.Location = new System.Drawing.Point(97, 44);
            this.pv4CurrentShow.Name = "pv4CurrentShow";
            this.pv4CurrentShow.Size = new System.Drawing.Size(53, 29);
            this.pv4CurrentShow.TabIndex = 12;
            this.pv4CurrentShow.Text = "5";
            this.pv4CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button42
            // 
            this.button42.AutoSize = true;
            this.button42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button42.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button42.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button42.Location = new System.Drawing.Point(6, 6);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(82, 29);
            this.button42.TabIndex = 9;
            this.button42.Text = "VOLTAGE";
            this.button42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button42.UseVisualStyleBackColor = false;
            // 
            // pv4VoltageShow
            // 
            this.pv4VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv4VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv4VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv4VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv4VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv4VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv4VoltageShow.Location = new System.Drawing.Point(97, 6);
            this.pv4VoltageShow.Name = "pv4VoltageShow";
            this.pv4VoltageShow.Size = new System.Drawing.Size(53, 29);
            this.pv4VoltageShow.TabIndex = 10;
            this.pv4VoltageShow.Text = "40";
            this.pv4VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button44.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button44.Location = new System.Drawing.Point(159, 6);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(22, 29);
            this.button44.TabIndex = 11;
            this.button44.Text = "V";
            this.button44.UseVisualStyleBackColor = false;
            // 
            // button45
            // 
            this.button45.AutoSize = true;
            this.button45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button45.Location = new System.Drawing.Point(6, 44);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(82, 29);
            this.button45.TabIndex = 9;
            this.button45.Text = "CURRENT";
            this.button45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button45.UseVisualStyleBackColor = false;
            // 
            // button46
            // 
            this.button46.AutoSize = true;
            this.button46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button46.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button46.Location = new System.Drawing.Point(6, 82);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(82, 30);
            this.button46.TabIndex = 9;
            this.button46.Text = "WATTAGE";
            this.button46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button46.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel24.ColumnCount = 1;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Controls.Add(this.button47, 0, 2);
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel25, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.statepv4, 0, 1);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(196, 3);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 3;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.75862F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel24.TabIndex = 3;
            // 
            // button47
            // 
            this.button47.AutoSize = true;
            this.button47.BackColor = System.Drawing.Color.Yellow;
            this.button47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button47.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button47.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button47.ForeColor = System.Drawing.Color.Red;
            this.button47.Location = new System.Drawing.Point(5, 82);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(131, 31);
            this.button47.TabIndex = 11;
            this.button47.Text = "SET ANGLE NOW";
            this.button47.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 2;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.96183F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.03817F));
            this.tableLayoutPanel25.Controls.Add(this.button48, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.angelpv4, 1, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(131, 34);
            this.tableLayoutPanel25.TabIndex = 0;
            // 
            // button48
            // 
            this.button48.AutoSize = true;
            this.button48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button48.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button48.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button48.Location = new System.Drawing.Point(3, 3);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(65, 28);
            this.button48.TabIndex = 9;
            this.button48.Text = "ANGLE";
            this.button48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button48.UseVisualStyleBackColor = false;
            // 
            // angelpv4
            // 
            this.angelpv4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv4.Location = new System.Drawing.Point(74, 3);
            this.angelpv4.Name = "angelpv4";
            this.angelpv4.Size = new System.Drawing.Size(54, 28);
            this.angelpv4.TabIndex = 10;
            this.angelpv4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv4
            // 
            this.statepv4.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv4.AutoSize = true;
            this.statepv4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv4.Location = new System.Drawing.Point(5, 47);
            this.statepv4.Name = "statepv4";
            this.statepv4.Size = new System.Drawing.Size(131, 27);
            this.statepv4.TabIndex = 12;
            this.statepv4.Text = "AUTO TRACKING";
            this.statepv4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv4.UseVisualStyleBackColor = false;
            this.statepv4.CheckedChanged += new System.EventHandler(this.statepv4_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox6.Controls.Add(this.tableLayoutPanel5);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(3, 155);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(346, 146);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PV 3";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel19, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel20, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(340, 124);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.13514F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel19.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel19.Controls.Add(this.pv3WattageShow, 1, 2);
            this.tableLayoutPanel19.Controls.Add(this.button29, 2, 1);
            this.tableLayoutPanel19.Controls.Add(this.pv3CurrentShow, 1, 1);
            this.tableLayoutPanel19.Controls.Add(this.button31, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.pv3VoltageShow, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.button33, 2, 0);
            this.tableLayoutPanel19.Controls.Add(this.button34, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.button35, 0, 2);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 3;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(187, 118);
            this.tableLayoutPanel19.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(160, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "W";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pv3WattageShow
            // 
            this.pv3WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv3WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv3WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv3WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv3WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv3WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv3WattageShow.Location = new System.Drawing.Point(95, 82);
            this.pv3WattageShow.Name = "pv3WattageShow";
            this.pv3WattageShow.Size = new System.Drawing.Size(56, 30);
            this.pv3WattageShow.TabIndex = 14;
            this.pv3WattageShow.Text = "200";
            this.pv3WattageShow.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button29.Location = new System.Drawing.Point(160, 44);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(21, 29);
            this.button29.TabIndex = 13;
            this.button29.Text = "A";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // pv3CurrentShow
            // 
            this.pv3CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv3CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv3CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv3CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv3CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv3CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv3CurrentShow.Location = new System.Drawing.Point(95, 44);
            this.pv3CurrentShow.Name = "pv3CurrentShow";
            this.pv3CurrentShow.Size = new System.Drawing.Size(56, 29);
            this.pv3CurrentShow.TabIndex = 12;
            this.pv3CurrentShow.Text = "5";
            this.pv3CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.AutoSize = true;
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button31.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button31.Location = new System.Drawing.Point(6, 6);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(80, 29);
            this.button31.TabIndex = 9;
            this.button31.Text = "VOLTAGE";
            this.button31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button31.UseVisualStyleBackColor = false;
            // 
            // pv3VoltageShow
            // 
            this.pv3VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv3VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv3VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv3VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv3VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv3VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv3VoltageShow.Location = new System.Drawing.Point(95, 6);
            this.pv3VoltageShow.Name = "pv3VoltageShow";
            this.pv3VoltageShow.Size = new System.Drawing.Size(56, 29);
            this.pv3VoltageShow.TabIndex = 10;
            this.pv3VoltageShow.Text = "40";
            this.pv3VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button33.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button33.Location = new System.Drawing.Point(160, 6);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(21, 29);
            this.button33.TabIndex = 11;
            this.button33.Text = "V";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.AutoSize = true;
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button34.Location = new System.Drawing.Point(6, 44);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(80, 29);
            this.button34.TabIndex = 9;
            this.button34.Text = "CURRENT";
            this.button34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.AutoSize = true;
            this.button35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button35.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button35.Location = new System.Drawing.Point(6, 82);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(80, 30);
            this.button35.TabIndex = 9;
            this.button35.Text = "WATTAGE";
            this.button35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button35.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.button36, 0, 2);
            this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel21, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.statepv3, 0, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(196, 3);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.7931F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel20.TabIndex = 3;
            // 
            // button36
            // 
            this.button36.AutoSize = true;
            this.button36.BackColor = System.Drawing.Color.Yellow;
            this.button36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button36.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.Red;
            this.button36.Location = new System.Drawing.Point(5, 84);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(131, 29);
            this.button36.TabIndex = 11;
            this.button36.Text = "SET ANGLE NOW";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.48855F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.51145F));
            this.tableLayoutPanel21.Controls.Add(this.button37, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.angelpv3, 1, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(131, 36);
            this.tableLayoutPanel21.TabIndex = 0;
            // 
            // button37
            // 
            this.button37.AutoSize = true;
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button37.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button37.Location = new System.Drawing.Point(3, 3);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(67, 30);
            this.button37.TabIndex = 9;
            this.button37.Text = "ANGLE";
            this.button37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button37.UseVisualStyleBackColor = false;
            // 
            // angelpv3
            // 
            this.angelpv3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv3.Location = new System.Drawing.Point(76, 4);
            this.angelpv3.Name = "angelpv3";
            this.angelpv3.Size = new System.Drawing.Size(52, 28);
            this.angelpv3.TabIndex = 10;
            this.angelpv3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv3
            // 
            this.statepv3.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv3.AutoSize = true;
            this.statepv3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv3.Location = new System.Drawing.Point(5, 49);
            this.statepv3.Name = "statepv3";
            this.statepv3.Size = new System.Drawing.Size(131, 27);
            this.statepv3.TabIndex = 12;
            this.statepv3.Text = "AUTO TRACKING";
            this.statepv3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv3.UseVisualStyleBackColor = false;
            this.statepv3.CheckedChanged += new System.EventHandler(this.statepv3_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(355, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 146);
            this.panel1.TabIndex = 28;
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox16.Controls.Add(this.tableLayoutPanel58);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.ForeColor = System.Drawing.Color.Red;
            this.groupBox16.Location = new System.Drawing.Point(0, 0);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(346, 146);
            this.groupBox16.TabIndex = 28;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "PV 10";
            // 
            // tableLayoutPanel58
            // 
            this.tableLayoutPanel58.ColumnCount = 2;
            this.tableLayoutPanel58.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel58.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel58.Controls.Add(this.tableLayoutPanel59, 0, 0);
            this.tableLayoutPanel58.Controls.Add(this.tableLayoutPanel60, 1, 0);
            this.tableLayoutPanel58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel58.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel58.Name = "tableLayoutPanel58";
            this.tableLayoutPanel58.RowCount = 1;
            this.tableLayoutPanel58.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel58.Size = new System.Drawing.Size(340, 124);
            this.tableLayoutPanel58.TabIndex = 1;
            // 
            // tableLayoutPanel59
            // 
            this.tableLayoutPanel59.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel59.ColumnCount = 3;
            this.tableLayoutPanel59.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel59.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.32609F));
            this.tableLayoutPanel59.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel59.Controls.Add(this.button137, 2, 2);
            this.tableLayoutPanel59.Controls.Add(this.pv10WattageShow, 1, 2);
            this.tableLayoutPanel59.Controls.Add(this.button139, 2, 1);
            this.tableLayoutPanel59.Controls.Add(this.pv10CurrentShow, 1, 1);
            this.tableLayoutPanel59.Controls.Add(this.button141, 0, 0);
            this.tableLayoutPanel59.Controls.Add(this.pv10VoltageShow, 1, 0);
            this.tableLayoutPanel59.Controls.Add(this.button143, 2, 0);
            this.tableLayoutPanel59.Controls.Add(this.button144, 0, 1);
            this.tableLayoutPanel59.Controls.Add(this.button145, 0, 2);
            this.tableLayoutPanel59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel59.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel59.Name = "tableLayoutPanel59";
            this.tableLayoutPanel59.RowCount = 3;
            this.tableLayoutPanel59.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel59.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel59.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel59.Size = new System.Drawing.Size(187, 118);
            this.tableLayoutPanel59.TabIndex = 2;
            // 
            // button137
            // 
            this.button137.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button137.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button137.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button137.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button137.Location = new System.Drawing.Point(159, 82);
            this.button137.Name = "button137";
            this.button137.Size = new System.Drawing.Size(22, 30);
            this.button137.TabIndex = 15;
            this.button137.Text = "W";
            this.button137.UseVisualStyleBackColor = false;
            // 
            // pv10WattageShow
            // 
            this.pv10WattageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv10WattageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv10WattageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv10WattageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv10WattageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv10WattageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv10WattageShow.Location = new System.Drawing.Point(94, 82);
            this.pv10WattageShow.Name = "pv10WattageShow";
            this.pv10WattageShow.Size = new System.Drawing.Size(56, 30);
            this.pv10WattageShow.TabIndex = 14;
            this.pv10WattageShow.Text = "200";
            this.pv10WattageShow.UseVisualStyleBackColor = false;
            // 
            // button139
            // 
            this.button139.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button139.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button139.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button139.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button139.Location = new System.Drawing.Point(159, 44);
            this.button139.Name = "button139";
            this.button139.Size = new System.Drawing.Size(22, 29);
            this.button139.TabIndex = 13;
            this.button139.Text = "A";
            this.button139.UseVisualStyleBackColor = false;
            // 
            // pv10CurrentShow
            // 
            this.pv10CurrentShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv10CurrentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv10CurrentShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv10CurrentShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv10CurrentShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv10CurrentShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv10CurrentShow.Location = new System.Drawing.Point(94, 44);
            this.pv10CurrentShow.Name = "pv10CurrentShow";
            this.pv10CurrentShow.Size = new System.Drawing.Size(56, 29);
            this.pv10CurrentShow.TabIndex = 12;
            this.pv10CurrentShow.Text = "5";
            this.pv10CurrentShow.UseVisualStyleBackColor = false;
            // 
            // button141
            // 
            this.button141.AutoSize = true;
            this.button141.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button141.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button141.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button141.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button141.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button141.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button141.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button141.Location = new System.Drawing.Point(6, 6);
            this.button141.Name = "button141";
            this.button141.Size = new System.Drawing.Size(79, 29);
            this.button141.TabIndex = 9;
            this.button141.Text = "VOLTAGE";
            this.button141.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button141.UseVisualStyleBackColor = false;
            // 
            // pv10VoltageShow
            // 
            this.pv10VoltageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pv10VoltageShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv10VoltageShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pv10VoltageShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv10VoltageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pv10VoltageShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv10VoltageShow.Location = new System.Drawing.Point(94, 6);
            this.pv10VoltageShow.Name = "pv10VoltageShow";
            this.pv10VoltageShow.Size = new System.Drawing.Size(56, 29);
            this.pv10VoltageShow.TabIndex = 10;
            this.pv10VoltageShow.Text = "40";
            this.pv10VoltageShow.UseVisualStyleBackColor = false;
            // 
            // button143
            // 
            this.button143.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button143.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button143.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button143.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button143.Location = new System.Drawing.Point(159, 6);
            this.button143.Name = "button143";
            this.button143.Size = new System.Drawing.Size(22, 29);
            this.button143.TabIndex = 11;
            this.button143.Text = "V";
            this.button143.UseVisualStyleBackColor = false;
            // 
            // button144
            // 
            this.button144.AutoSize = true;
            this.button144.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button144.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button144.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button144.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button144.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button144.Location = new System.Drawing.Point(6, 44);
            this.button144.Name = "button144";
            this.button144.Size = new System.Drawing.Size(79, 29);
            this.button144.TabIndex = 9;
            this.button144.Text = "CURRENT";
            this.button144.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button144.UseVisualStyleBackColor = false;
            // 
            // button145
            // 
            this.button145.AutoSize = true;
            this.button145.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button145.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button145.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button145.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button145.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button145.Location = new System.Drawing.Point(6, 82);
            this.button145.Name = "button145";
            this.button145.Size = new System.Drawing.Size(79, 30);
            this.button145.TabIndex = 9;
            this.button145.Text = "WATTAGE";
            this.button145.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button145.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel60
            // 
            this.tableLayoutPanel60.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel60.ColumnCount = 1;
            this.tableLayoutPanel60.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel60.Controls.Add(this.button146, 0, 2);
            this.tableLayoutPanel60.Controls.Add(this.tableLayoutPanel61, 0, 0);
            this.tableLayoutPanel60.Controls.Add(this.statepv10, 0, 1);
            this.tableLayoutPanel60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel60.Location = new System.Drawing.Point(196, 3);
            this.tableLayoutPanel60.Name = "tableLayoutPanel60";
            this.tableLayoutPanel60.RowCount = 3;
            this.tableLayoutPanel60.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel60.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.89655F));
            this.tableLayoutPanel60.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.89655F));
            this.tableLayoutPanel60.Size = new System.Drawing.Size(141, 118);
            this.tableLayoutPanel60.TabIndex = 3;
            // 
            // button146
            // 
            this.button146.AutoSize = true;
            this.button146.BackColor = System.Drawing.Color.Yellow;
            this.button146.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button146.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button146.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button146.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button146.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button146.ForeColor = System.Drawing.Color.Red;
            this.button146.Location = new System.Drawing.Point(5, 83);
            this.button146.Name = "button146";
            this.button146.Size = new System.Drawing.Size(131, 30);
            this.button146.TabIndex = 11;
            this.button146.Text = "SET ANGLE NOW";
            this.button146.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel61
            // 
            this.tableLayoutPanel61.ColumnCount = 2;
            this.tableLayoutPanel61.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.19847F));
            this.tableLayoutPanel61.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.80153F));
            this.tableLayoutPanel61.Controls.Add(this.button147, 0, 0);
            this.tableLayoutPanel61.Controls.Add(this.angelpv10, 1, 0);
            this.tableLayoutPanel61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel61.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel61.Name = "tableLayoutPanel61";
            this.tableLayoutPanel61.RowCount = 1;
            this.tableLayoutPanel61.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel61.Size = new System.Drawing.Size(131, 34);
            this.tableLayoutPanel61.TabIndex = 0;
            // 
            // button147
            // 
            this.button147.AutoSize = true;
            this.button147.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button147.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button147.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button147.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button147.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button147.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button147.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button147.Location = new System.Drawing.Point(3, 3);
            this.button147.Name = "button147";
            this.button147.Size = new System.Drawing.Size(64, 28);
            this.button147.TabIndex = 9;
            this.button147.Text = "ANGLE";
            this.button147.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button147.UseVisualStyleBackColor = false;
            // 
            // angelpv10
            // 
            this.angelpv10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.angelpv10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angelpv10.Location = new System.Drawing.Point(73, 3);
            this.angelpv10.Name = "angelpv10";
            this.angelpv10.Size = new System.Drawing.Size(55, 28);
            this.angelpv10.TabIndex = 10;
            this.angelpv10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statepv10
            // 
            this.statepv10.Appearance = System.Windows.Forms.Appearance.Button;
            this.statepv10.AutoSize = true;
            this.statepv10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statepv10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statepv10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statepv10.Location = new System.Drawing.Point(5, 47);
            this.statepv10.Name = "statepv10";
            this.statepv10.Size = new System.Drawing.Size(131, 28);
            this.statepv10.TabIndex = 12;
            this.statepv10.Text = "AUTO TRACKING";
            this.statepv10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statepv10.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SolarSCADA.Properties.Resources.Logo_Hust;
            this.pictureBox1.Location = new System.Drawing.Point(3, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::SolarSCADA.Properties.Resources.article;
            this.pictureBox2.Location = new System.Drawing.Point(707, 459);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.zedGraphControl1);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1057, 608);
            this.panelChart.TabIndex = 4;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1057, 608);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOLAR SCADA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconWeather)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.groupBoxSetting.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel66.ResumeLayout(false);
            this.tableLayoutPanel66.PerformLayout();
            this.tableLayoutPanel67.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.layoutInfo.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.tableLayoutPanel46.ResumeLayout(false);
            this.tableLayoutPanel47.ResumeLayout(false);
            this.tableLayoutPanel47.PerformLayout();
            this.tableLayoutPanel48.ResumeLayout(false);
            this.tableLayoutPanel48.PerformLayout();
            this.tableLayoutPanel49.ResumeLayout(false);
            this.tableLayoutPanel49.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.tableLayoutPanel62.ResumeLayout(false);
            this.tableLayoutPanel63.ResumeLayout(false);
            this.tableLayoutPanel63.PerformLayout();
            this.tableLayoutPanel64.ResumeLayout(false);
            this.tableLayoutPanel64.PerformLayout();
            this.tableLayoutPanel65.ResumeLayout(false);
            this.tableLayoutPanel65.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.tableLayoutPanel42.ResumeLayout(false);
            this.tableLayoutPanel43.ResumeLayout(false);
            this.tableLayoutPanel43.PerformLayout();
            this.tableLayoutPanel44.ResumeLayout(false);
            this.tableLayoutPanel44.PerformLayout();
            this.tableLayoutPanel45.ResumeLayout(false);
            this.tableLayoutPanel45.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.tableLayoutPanel38.ResumeLayout(false);
            this.tableLayoutPanel39.ResumeLayout(false);
            this.tableLayoutPanel39.PerformLayout();
            this.tableLayoutPanel40.ResumeLayout(false);
            this.tableLayoutPanel40.PerformLayout();
            this.tableLayoutPanel41.ResumeLayout(false);
            this.tableLayoutPanel41.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.tableLayoutPanel34.ResumeLayout(false);
            this.tableLayoutPanel35.ResumeLayout(false);
            this.tableLayoutPanel35.PerformLayout();
            this.tableLayoutPanel36.ResumeLayout(false);
            this.tableLayoutPanel36.PerformLayout();
            this.tableLayoutPanel37.ResumeLayout(false);
            this.tableLayoutPanel37.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel30.ResumeLayout(false);
            this.tableLayoutPanel31.ResumeLayout(false);
            this.tableLayoutPanel31.PerformLayout();
            this.tableLayoutPanel32.ResumeLayout(false);
            this.tableLayoutPanel32.PerformLayout();
            this.tableLayoutPanel33.ResumeLayout(false);
            this.tableLayoutPanel33.PerformLayout();
            this.PVpanel1.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.tableLayoutPanel28.ResumeLayout(false);
            this.tableLayoutPanel28.PerformLayout();
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel29.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.tableLayoutPanel58.ResumeLayout(false);
            this.tableLayoutPanel59.ResumeLayout(false);
            this.tableLayoutPanel59.PerformLayout();
            this.tableLayoutPanel60.ResumeLayout(false);
            this.tableLayoutPanel60.PerformLayout();
            this.tableLayoutPanel61.ResumeLayout(false);
            this.tableLayoutPanel61.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Button openChart;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ngay;
        private System.Windows.Forms.TextBox textBox_thang;
        private System.Windows.Forms.TextBox textBox_nam;
        private System.Windows.Forms.TextBox textBox_gio;
        private System.Windows.Forms.TextBox textBox_phut;
        private System.Windows.Forms.TextBox textBox_giay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_kinhDo;
        private System.Windows.Forms.TextBox textBox_viDo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel66;
        private System.Windows.Forms.Button button_sendDate;
        private System.Windows.Forms.CheckBox checkCustom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel67;
        private System.Windows.Forms.Button button_sendVitri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button pvWattageShow;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button pvCurrentShow;
        private System.Windows.Forms.Button showInfo;
        private System.Windows.Forms.Button pvVoltageShow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button loadWattageShow;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button loadCurrentShow;
        private System.Windows.Forms.Button adafaaf;
        private System.Windows.Forms.Button loadVoltageShow;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button batVoltageShow;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button batCurrentShow;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button batLevelShow;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label weatherState;
        private System.Windows.Forms.PictureBox iconWeather;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label windSpeedShow;
        private System.Windows.Forms.Button openInfo;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TableLayoutPanel layoutInfo;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel46;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel47;
        private System.Windows.Forms.Button button104;
        private System.Windows.Forms.Button pv8WattageShow;
        private System.Windows.Forms.Button button106;
        private System.Windows.Forms.Button pv8CurrentShow;
        private System.Windows.Forms.Button button108;
        private System.Windows.Forms.Button pv8VoltageShow;
        private System.Windows.Forms.Button button110;
        private System.Windows.Forms.Button button111;
        private System.Windows.Forms.Button button112;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel48;
        private System.Windows.Forms.Button button113;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel49;
        private System.Windows.Forms.Button button114;
        private System.Windows.Forms.TextBox angelpv8;
        private System.Windows.Forms.CheckBox statepv8;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel62;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel63;
        private System.Windows.Forms.Button button159;
        private System.Windows.Forms.Button pv9WattageShow;
        private System.Windows.Forms.Button button161;
        private System.Windows.Forms.Button pv9CurrentShow;
        private System.Windows.Forms.Button button163;
        private System.Windows.Forms.Button pv9VoltageShow;
        private System.Windows.Forms.Button button165;
        private System.Windows.Forms.Button button166;
        private System.Windows.Forms.Button button167;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel64;
        private System.Windows.Forms.Button button168;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel65;
        private System.Windows.Forms.Button button170;
        private System.Windows.Forms.TextBox angelpv9;
        private System.Windows.Forms.CheckBox statepv9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel42;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel43;
        private System.Windows.Forms.Button button93;
        private System.Windows.Forms.Button pv6WattageShow;
        private System.Windows.Forms.Button button95;
        private System.Windows.Forms.Button pv6CurrentShow;
        private System.Windows.Forms.Button button97;
        private System.Windows.Forms.Button pv6VoltageShow;
        private System.Windows.Forms.Button button99;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button button101;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel44;
        private System.Windows.Forms.Button button102;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel45;
        private System.Windows.Forms.Button button103;
        private System.Windows.Forms.TextBox angelpv7;
        private System.Windows.Forms.CheckBox statepv7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel38;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel39;
        private System.Windows.Forms.Button button82;
        private System.Windows.Forms.Button pv7WattageShow;
        private System.Windows.Forms.Button button84;
        private System.Windows.Forms.Button pv7CurrentShow;
        private System.Windows.Forms.Button button86;
        private System.Windows.Forms.Button pv7VoltageShow;
        private System.Windows.Forms.Button button88;
        private System.Windows.Forms.Button button89;
        private System.Windows.Forms.Button button90;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel40;
        private System.Windows.Forms.Button button91;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel41;
        private System.Windows.Forms.Button button92;
        private System.Windows.Forms.TextBox angelpv5;
        private System.Windows.Forms.CheckBox statepv5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel34;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel35;
        private System.Windows.Forms.Button button71;
        private System.Windows.Forms.Button pv5WattageShow;
        private System.Windows.Forms.Button button73;
        private System.Windows.Forms.Button pv5CurrentShow;
        private System.Windows.Forms.Button button75;
        private System.Windows.Forms.Button pv5VoltageShow;
        private System.Windows.Forms.Button button77;
        private System.Windows.Forms.Button button78;
        private System.Windows.Forms.Button button79;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel36;
        private System.Windows.Forms.Button button80;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel37;
        private System.Windows.Forms.Button button81;
        private System.Windows.Forms.TextBox angelpv6;
        private System.Windows.Forms.CheckBox statepv6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel30;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
        private System.Windows.Forms.Button button60;
        private System.Windows.Forms.Button pv2WattageShow;
        private System.Windows.Forms.Button button62;
        private System.Windows.Forms.Button pv2CurrentShow;
        private System.Windows.Forms.Button button64;
        private System.Windows.Forms.Button pv2VoltageShow;
        private System.Windows.Forms.Button button66;
        private System.Windows.Forms.Button button67;
        private System.Windows.Forms.Button button68;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private System.Windows.Forms.Button button69;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel33;
        private System.Windows.Forms.Button button70;
        private System.Windows.Forms.TextBox angelpv2;
        private System.Windows.Forms.CheckBox statepv2;
        private System.Windows.Forms.GroupBox PVpanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button pv1WattageShow;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button pv1CurrentShow;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button pv1VoltageShow;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.Button button57;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private System.Windows.Forms.Button button58;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private System.Windows.Forms.Button button59;
        private System.Windows.Forms.TextBox angelpv1;
        private System.Windows.Forms.CheckBox statepv1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button pv4WattageShow;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button pv4CurrentShow;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button pv4VoltageShow;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.TextBox angelpv4;
        private System.Windows.Forms.CheckBox statepv4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pv3WattageShow;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button pv3CurrentShow;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button pv3VoltageShow;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.TextBox angelpv3;
        private System.Windows.Forms.CheckBox statepv3;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.ToolStripMenuItem savefileExcel;
        private System.Windows.Forms.ToolStripMenuItem saveToMySqlDatabase;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closePortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button open_port;
        private System.Windows.Forms.Button close_port;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ToolStripMenuItem refresh_port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel58;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel59;
        private System.Windows.Forms.Button button137;
        private System.Windows.Forms.Button pv10WattageShow;
        private System.Windows.Forms.Button button139;
        private System.Windows.Forms.Button pv10CurrentShow;
        private System.Windows.Forms.Button button141;
        private System.Windows.Forms.Button pv10VoltageShow;
        private System.Windows.Forms.Button button143;
        private System.Windows.Forms.Button button144;
        private System.Windows.Forms.Button button145;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel60;
        private System.Windows.Forms.Button button146;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel61;
        private System.Windows.Forms.Button button147;
        private System.Windows.Forms.TextBox angelpv10;
        private System.Windows.Forms.CheckBox statepv10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

