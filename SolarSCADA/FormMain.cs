using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Globalization;
using ZedGraph;

namespace SolarSCADA
{
    public partial class FormMain : Form
    {
        #region VAR define
        //process data define
        string portDataOut;
        string[] portDataIn;
        //sbyte indexofPV, indexofPC, indexofLV, indexofLC, indexofBV, indexofBC, indexofWS;
        string pvVoltage, pvCurrent, loadVoltage, loadCurrent, batteryVoltage, batteryCurrent, angel;
        double pvWattage, loadWattage, batteryLevel;
        //mySql define
        MySqlConnection mySqlCN = new MySqlConnection("server=localhost;username =root;password=solarscada;port=3306;database=scadadatabase");
        MySqlCommand mySqlCM;
        //
        string data;
        string SDatas = String.Empty; // Khai báo chuỗi để lưu dữ liệu 
        string SRealTime = String.Empty; // Khai báo chuỗi để lưu thời gian 
        int draw = 0; // Khai báo biến để xử lý sự kiện vẽ đồ thị
        double realtime = 0; //Khai báo biến thời gian để vẽ đồ thị
        double data_pv_power = 0; //Khai báo biến dữ liệu cảm biến để vẽ đồ thị
        double data_load_power = 0;
        int t = DateTime.Now.DayOfYear;
        //
        double req_data = -10;
        double req_date = -10;
        //
        int check = 0;

        #endregion

        public FormMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //loadChart();
            getWeather();
            timer1.Start();
            getPort();
            button_sendDate.Enabled = false;
            button_sendVitri.Enabled = false;
           // progressBar_status.Value = 1;
            status.Text = "DISCONECTED";
            status.ForeColor = Color.Red;            
            
            //display PV info first
            panelChart.BringToFront();
            angelpv1.ReadOnly = true;
            angelpv2.ReadOnly = true;
            angelpv3.ReadOnly = true;
            angelpv4.ReadOnly = true;
            angelpv5.ReadOnly = true;
            angelpv6.ReadOnly = true;
            angelpv7.ReadOnly = true;
            angelpv8.ReadOnly = true;
            angelpv9.ReadOnly = true;
            angelpv10.ReadOnly = true;
            //PVpanel11.Enabled = false;
            //PVpanel12.Enabled = false;
            // Khởi tạo ZedGraph
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "ĐỒ THỊ CÔNG SUẤT TRONG NGÀY";
            myPane.XAxis.Title.Text = "THỜI GIAN (h)";
            myPane.YAxis.Title.Text = "CÔNG SUẤT (W)";

            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve("P_PV", list, Color.Red, SymbolType.None);
            LineItem curve1 = myPane.AddCurve("P_LOAD", list1, Color.DarkGreen, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 24;
            myPane.XAxis.Scale.MinorStep = 0.5;
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 250;

            myPane.AxisChange();
        }

        #region Timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!checkCustom.Checked)
            {
                DateTime tn = DateTime.Now;
                textBox_ngay.Text = tn.ToString("dd");
                textBox_thang.Text = tn.ToString("MM");
                textBox_nam.Text = tn.ToString("yyyy");

                textBox_gio.Text = tn.ToString("HH");
                textBox_phut.Text = tn.ToString("mm");
                textBox_giay.Text = tn.ToString("ss");
            }
            if (Math.Abs(DateTime.Now.DayOfYear - req_date) >= 1)
            {
                ClearZedGraph();
                ResetValue();
            }
            if (serialPort1.IsOpen)
            {   
                if (Math.Abs(DateTime.Now.DayOfYear - req_date) >= 1)
                {
                    send_date();
                    req_date = DateTime.Now.DayOfYear;
                }
                if (Math.Abs(DateTime.Now.Hour* 60*60 +DateTime.Now.Minute*60+DateTime.Now.Second - req_data) >= 10.0)
                {
                    request_data();
                    req_data = DateTime.Now.Hour * 60 * 60 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
                }

                Draw();
                draw = 0;
            }
        }

        #endregion

        #region Chart
        // Vẽ đồ thị
        private void Draw()
        {

            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;

            if (curve == null)
                return;
            if (curve1 == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;
            IPointListEdit list1 = curve1.Points as IPointListEdit;

            if (list == null)
                return;
            if (list1 == null)
                return;

            list.Add(realtime, data_pv_power); // Thêm điểm trên đồ thị
            list1.Add(realtime, data_load_power);
            

            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (realtime > (xScale.Max - xScale.MajorStep))
            {
                xScale.Max = realtime + xScale.MajorStep;
                xScale.Min = xScale.Max - 24;
            }

            // Tự động Scale theo trục y
            if (data_pv_power > (yScale.Max - yScale.MajorStep))
            {
                yScale.Max = data_pv_power + yScale.MajorStep;
            }
            else if (data_pv_power < (yScale.Min + yScale.MajorStep))
            {
                yScale.Min = data_pv_power - yScale.MajorStep;
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

        // Xóa đồ thị, với ZedGraph thì phải khai báo lại như ở hàm Form1_Load, nếu không sẽ không hiển thị
        private void ClearZedGraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear(); // Xóa đường
            zedGraphControl1.GraphPane.GraphObjList.Clear(); // Xóa đối tượng

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "ĐỒ THỊ CÔNG SUẤT TRONG NGÀY";
            myPane.XAxis.Title.Text = "THỜI GIAN (h)";
            myPane.YAxis.Title.Text = "CÔNG SUẤT (W)";

            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve("P_PV", list, Color.Red, SymbolType.None);
              LineItem curve1 = myPane.AddCurve("P_LOAD", list1, Color.DarkGreen, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 24;
            myPane.XAxis.Scale.MinorStep = 0.5;
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 250;

            zedGraphControl1.AxisChange();
        }
        private void ResetValue()
        {

            SDatas = String.Empty;
            SRealTime = String.Empty;
            realtime = 0;
            data_pv_power = 0;
            data_load_power = 0;
            draw = 0; // Chuyển status về 0
        }
        #endregion

        #region Process Received Data
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            portDataIn = serialPort1.ReadLine().Split('|');
            if (portDataIn[2] == "3")
            {
                this.BeginInvoke(new EventHandler(processData));
                saveSqlData();
                check = 1;
            }

        }

        private void processData(object sender, EventArgs e)
        {
            try
            {
                pvVoltage = portDataIn[3];
                pvCurrent = portDataIn[4];
                loadVoltage = portDataIn[5];
                loadCurrent = portDataIn[7];
                batteryVoltage = portDataIn[5];
                batteryCurrent = portDataIn[6];
                angel = portDataIn[8];

                //
                pvVoltageShow.Text = pvVoltage;
                pvCurrentShow.Text = pvCurrent;                
                loadVoltageShow.Text = loadVoltage;
                loadCurrentShow.Text = loadCurrent;                
                batVoltageShow.Text = batteryVoltage;
                batCurrentShow.Text = batteryCurrent;
                //angelpv1.Text = angel;
                //PV1
                pv1VoltageShow.Text = pvVoltage;
                pv1CurrentShow.Text = pvCurrent;
                angelpv1.Text = angel;
                pv1WattageShow.Text = Convert.ToString(Double.Parse (pvVoltage, CultureInfo.InvariantCulture) * Double.Parse(pvCurrent, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
                //Gia lap 9 tam pin con lai
                //random
                Random rand = new Random();
                Random randV = new Random();
                Random randI = new Random();
                double rdV;
                double rdI;
                double rdA;
                //PV2
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv2VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV, CultureInfo.InvariantCulture);
                pv2CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv2WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI), CultureInfo.InvariantCulture);
                angelpv2.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA, CultureInfo.InvariantCulture);
                //PV3
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv3VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV, CultureInfo.InvariantCulture);
                pv3CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI, CultureInfo.InvariantCulture);
                pv3WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI), CultureInfo.InvariantCulture);
                angelpv3.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA, CultureInfo.InvariantCulture);
                //PV4
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv4VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV,CultureInfo.InvariantCulture);
                pv4CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv4WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI),CultureInfo.InvariantCulture);
                angelpv4.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA,CultureInfo.InvariantCulture);
                //PV5
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv5VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV,CultureInfo.InvariantCulture);
                pv5CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv5WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI),CultureInfo.InvariantCulture);
                angelpv5.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA,CultureInfo.InvariantCulture);
                //PV6
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv6VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV,CultureInfo.InvariantCulture);
                pv6CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv6WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI),CultureInfo.InvariantCulture);
                angelpv6.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA,CultureInfo.InvariantCulture);
                //PV7
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv7VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV,CultureInfo.InvariantCulture);
                pv7CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv7WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI),CultureInfo.InvariantCulture);
                angelpv7.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA,CultureInfo.InvariantCulture);
                //PV8
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv8VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV,CultureInfo.InvariantCulture);
                pv8CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv8WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI),CultureInfo.InvariantCulture);
                angelpv8.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA,CultureInfo.InvariantCulture);
                //PV9
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv9VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV,CultureInfo.InvariantCulture);
                pv9CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv9WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI),CultureInfo.InvariantCulture);
                angelpv9.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA,CultureInfo.InvariantCulture);
                //PV10
                rdV = randV.Next(-3, 3);
                rdI = randI.Next(-2, 2);
                rdA = rand.Next(-2, 2);
                pv10VoltageShow.Text = Convert.ToString(Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV,CultureInfo.InvariantCulture);
                pv10CurrentShow.Text = Convert.ToString(Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI,CultureInfo.InvariantCulture);
                pv10WattageShow.Text = Convert.ToString((Double.Parse(pvVoltage, CultureInfo.InvariantCulture) + rdV) * (Double.Parse(pvCurrent, CultureInfo.InvariantCulture) + rdI),CultureInfo.InvariantCulture);
                angelpv10.Text = Convert.ToString(Double.Parse(angel, CultureInfo.InvariantCulture) + rdA,CultureInfo.InvariantCulture);
                //end Gia lap
                pvWattage = Double.Parse (pvVoltage, CultureInfo.InvariantCulture) * Double.Parse(pvCurrent, CultureInfo.InvariantCulture);
                pvWattageShow.Text = pvWattage.ToString("0.0",CultureInfo.InvariantCulture);

                loadWattage = Double.Parse(loadVoltage, CultureInfo.InvariantCulture) * Double.Parse(loadCurrent, CultureInfo.InvariantCulture);
                loadWattageShow.Text = loadWattage.ToString("0.0",CultureInfo.InvariantCulture);
                batteryLevel = -1.4209 * Double.Parse(batteryVoltage, CultureInfo.InvariantCulture)* Double.Parse(batteryVoltage, CultureInfo.InvariantCulture)+84.779* Double.Parse(batteryVoltage, CultureInfo.InvariantCulture) - 1157.6;
                if (batteryLevel>100) batteryLevel = 100;
                if (batteryLevel<0) batteryLevel = 0;
                batLevelShow.Text = batteryLevel.ToString("0.0",CultureInfo.InvariantCulture);
                //upload to SQL              
                //saveSqlData();
                //Chart
                data_pv_power = pvWattage;
                data_load_power = loadWattage;
                realtime = Convert.ToDouble(DateTime.Now.Hour.ToString()) + Convert.ToDouble(DateTime.Now.Minute.ToString()) / 60.0;
                draw = 1;// Bắt sự kiện xử lý xong chuỗi, đổi starus về 1 để hiển thị dữ liệu trong ListView và vẽ đồ thị
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region SQL database process
        private void saveSqlData()
        {
            if (saveToMySqlDatabase.Checked)
            {
                try
                {

                    mySqlCN.Open();
                    string myCommandText = string.Format("INSERT INTO `scadadatabase`.`datatest` (`PV voltage`, `PV current`, `PV wattage`, `Load voltage`, `Load current`, `Load wattage`, `Battery voltage`, `Battery current`, `Battery level`, `Angle`) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", pvVoltage, pvCurrent, pvWattage.ToString("0.0",CultureInfo.InvariantCulture), loadVoltage, loadCurrent, loadWattage.ToString("0.0", CultureInfo.InvariantCulture), batteryVoltage, batteryCurrent, batteryLevel.ToString("0.0", CultureInfo.InvariantCulture), angel);
                    mySqlCM = new MySqlCommand(myCommandText, mySqlCN);
                    mySqlCM.ExecuteNonQuery();

                   
                    mySqlCN.Close();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseShow objectx = new DatabaseShow();
            objectx.Show();
        }
        #endregion

        #region Save file Excel
        private void savefileExcel_Click(object sender, EventArgs e)
        {
            mySqlCN.Open();
            saveFile.InitialDirectory = "C";
            saveFile.Title = "Save file to excel";
            saveFile.FileName = "SolarScadaData";
            saveFile.Filter = "Excel Files (2007|*.xls|Excel Files(.CSV)|*.csv";
            if(saveFile.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                mySqlCM = new MySqlCommand("SELECT * FROM `datatest`", mySqlCN);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = mySqlCM;
                DataTable dtt = new DataTable();
                sda.Fill(dtt);
                sda.Update(dtt);

                ws = ExcelApp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "information";

                for(int i = 0; i < dtt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dtt.Columns[i].ColumnName;
                }

                for(int i = 0; i < dtt.Rows.Count; i++)
                {
                    for(int j = 0; j < dtt.Columns.Count; j++)
                    {                        
                     ws.Cells[i + 2, j + 1] = dtt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFile.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                ExcelApp.Quit();
                MessageBox.Show("File Excel đã được xuất");

            }
        }
        #endregion

        #region Weather
        public void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = "http://api.openweathermap.org/data/2.5/weather?q=Hanoi&appid=e6fe7601e8a54db71f272bc4d480a53f";
                    var json = web.DownloadString(url);
                    if (json == null) MessageBox.Show("No internet connection");
                    var result = JsonConvert.DeserializeObject<ClassWeather.Root>(json);
                    ClassWeather.Root outPut = result;
                    weatherState.Text = string.Format("{0}", outPut.weather[0].main.ToUpper());
                    windSpeedShow.Text = string.Format("{0} m/s", outPut.wind.speed);
                    string iconUrl = string.Format("http://openweathermap.org/img/wn/{0}.png", outPut.weather[0].icon);
                    byte[] icon = web.DownloadData(iconUrl);
                    MemoryStream stre = new MemoryStream(icon);
                    Bitmap newbitmap = new Bitmap(stre);
                    Bitmap iconw = newbitmap;
                    iconWeather.Image = iconw;
                }
            }
            catch
            {
                MessageBox.Show("Không thể lấy thông tin thời tiết do chưa kết nối với mạng internet\nBấm RETRY để thử lại.", "No internet access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                weatherState.Text = "RETRY";
                iconWeather.Image = new Bitmap(Application.StartupPath + "\\Resources\\icons8_refresh_64px.png");
            }
        }


        #endregion

        #region PORT control
        private void getPort()
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.AddRange(portLists);
        }

        private void openPort()
        {
            try
            {
                serialPort1.PortName = comboBox_comPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);

                serialPort1.Open();
                status.Text = "CONNECTED";
                status.ForeColor = Color.Green;
                button_sendDate.Enabled = true;
                button_sendVitri.Enabled = true;
               // progressBar_status.Value = 1;
                //MessageBox.Show("PORT đã mở");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có lõi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  progressBar_status.Value = 0;
            }
        }

        private void closePort()
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    status.Text = "DISCONECTED";
                    status.ForeColor = Color.Red;
                 //   progressBar_status.Value = 0;
                    button_sendDate.Enabled = false;
                    button_sendVitri.Enabled = false;
                    //MessageBox.Show("PORT đã đóng");
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }
        #endregion

        #region Send data

        private void send_date()
        {

            if (serialPort1.IsOpen)
            {
                if (checkCustom.CheckState == CheckState.Unchecked)
                {
                    portDataOut = "g0|n0|0|" + DateTime.Now.ToString("HH|mm|ss|dd|MM|yy|");
                    serialPort1.WriteLine(portDataOut);
                }
                if (checkCustom.CheckState == CheckState.Checked)
                {

                    if (serialPort1.IsOpen)
                    {
                        
                        portDataOut = "g0|n0|0|" + textBox_gio.Text + "|" + textBox_phut.Text + "|" + textBox_giay.Text + "|" + textBox_ngay.Text + 
                            "|" + textBox_thang.Text + "|" + textBox_nam.Text+"|";
                        serialPort1.WriteLine(portDataOut);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy mở kết nối với PORT trước");
            }
        }

        private void send_location()
        {   
            if (serialPort1.IsOpen)
            {
               
                portDataOut = "g0|n0|1|" + textBox_viDo.Text + "|" + textBox_kinhDo.Text+"|" ;
                serialPort1.WriteLine(portDataOut);
            }
            else
            {
                MessageBox.Show("Mở kết nối với PORT trước");
            }

        }

        private void request_data()
        {
            if (serialPort1.IsOpen)
            {
                ///for (int i = 0; i < 10; i++)
                {
                    //portDataOut = String.Format("g0|n0|3|{0}|", i);
                    portDataOut = String.Format("g0|n0|3|");
                    serialPort1.WriteLine(portDataOut);
                    //int time_wait = DateTime.Now.Second;
                    //while (check == 0) {
                    //    if (DateTime.Now.Second - time_wait>=3)
                    //    {
                    //        check = 0;
                    //        MessageBox.Show(String.Format("Kiểm tra kết nối PV{0}",i+1));
                    //        continue;
                    //    }
                    //}
                    check = 0;
                }
            }
        }

        private void mode(string idgate,string idnode,string mode,string ang )
        {
            portDataOut = String.Format("{0}|{1}|2|{2}|{3}|",idgate,idnode,mode,ang);
            serialPort1.WriteLine(portDataOut);
        }

        #endregion

        #region Feedback

        #endregion

        #region Form Active setting
        private void button_sendVitri_Click(object sender, EventArgs e)
        {
            send_location();
        }

        private void checkCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustom.CheckState == CheckState.Checked)
            {
                checkCustom.Text = "CUSTOM";
                MessageBox.Show("Đã đổi sang chế độ gửi thời gian do người dùng đặt");
            }
            else
            {
                checkCustom.Text = "AUTO";
                MessageBox.Show("Đã đổi sang chế độ gửi thời gian tự động từ máy tính");
            }

        }

        private void openPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            req_data = -10;
            req_date = -10;
            openPort();
        }

        private void closePortToolStripMenuItem_Click(object sender, EventArgs e)
        {

            closePort();
        }

        private void button_sendDate_Click(object sender, EventArgs e)
        {
            send_date();
        }



        private void openChart_Click(object sender, EventArgs e)
        {
            panelChart.BringToFront();
        }

        private void openInfo_Click(object sender, EventArgs e)
        {
            panelInfo.BringToFront();
        }

        private void iconWeather_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void statepv1_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv1.CheckState == CheckState.Checked)
            {
                statepv1.Text = "CUSTOM TRACK";
                angelpv1.ReadOnly = false;
                MessageBox.Show("PV1 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv1.Text = "AUTO TRACK";
                angelpv1.ReadOnly = true;
                MessageBox.Show("PV1 chế độ điều hướng tự động");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (statepv1.Checked) mode("g0", "n0", "1", angelpv1.Text.ToString());
            else mode("g0", "n0", "0",angelpv1.Text.ToString());
        }

        private void open_port_Click(object sender, EventArgs e)
        {
            openPort();
        }

        private void close_port_Click(object sender, EventArgs e)
        {
            closePort();
        }

        private void refresh_port_Click(object sender, EventArgs e)
        {
            comboBox_comPort.Items.Clear();
            getPort();
        }

        private void statepv2_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv2.CheckState == CheckState.Checked)
            {
                statepv2.Text = "CUSTOM TRACK";
                angelpv2.ReadOnly = false;
                MessageBox.Show("PV2 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv2.Text = "AUTO TRACK";
                angelpv2.ReadOnly = true;
                MessageBox.Show("PV2 chế độ điều hướng tự động");
            }
        }

        private void batLevelShow_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void statepv3_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv3.CheckState == CheckState.Checked)
            {
                statepv3.Text = "CUSTOM TRACK";
                angelpv3.ReadOnly = false;
                MessageBox.Show("PV3 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv3.Text = "AUTO TRACK";
                angelpv3.ReadOnly = true;
                MessageBox.Show("PV3 chế độ điều hướng tự động");
            }
        }

        private void statepv4_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv4.CheckState == CheckState.Checked)
            {
                statepv4.Text = "CUSTOM TRACK";
                angelpv4.ReadOnly = false;
                MessageBox.Show("PV4 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv4.Text = "AUTO TRACK";
                angelpv4.ReadOnly = true;
                MessageBox.Show("PV4 chế độ điều hướng tự động");
            }
        }

        private void statepv5_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv5.CheckState == CheckState.Checked)
            {
                statepv5.Text = "CUSTOM TRACK";
                angelpv5.ReadOnly = false;
                MessageBox.Show("PV5 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv5.Text = "AUTO TRACK";
                angelpv5.ReadOnly = true;
                MessageBox.Show("PV5 chế độ điều hướng tự động");
            }
        }

        private void statepv6_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv6.CheckState == CheckState.Checked)
            {
                statepv6.Text = "CUSTOM TRACK";
                angelpv6.ReadOnly = false;
                MessageBox.Show("PV6 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv6.Text = "AUTO TRACK";
                angelpv6.ReadOnly = true;
                MessageBox.Show("PV6 chế độ điều hướng tự động");
            }
        }

        private void statepv7_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv7.CheckState == CheckState.Checked)
            {
                statepv7.Text = "CUSTOM TRACK";
                angelpv7.ReadOnly = false;
                MessageBox.Show("PV7 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv7.Text = "AUTO TRACK";
                angelpv7.ReadOnly = true;
                MessageBox.Show("PV7 chế độ điều hướng tự động");
            }
        }

        private void statepv8_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv8.CheckState == CheckState.Checked)
            {
                statepv8.Text = "CUSTOM TRACK";
                angelpv8.ReadOnly = false;
                MessageBox.Show("PV8 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv8.Text = "AUTO TRACK";
                angelpv8.ReadOnly = true;
                MessageBox.Show("PV8 chế độ điều hướng tự động");
            }
        }

        private void statepv9_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv9.CheckState == CheckState.Checked)
            {
                statepv9.Text = "CUSTOM TRACK";
                angelpv9.ReadOnly = false;
                MessageBox.Show("PV9 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv9.Text = "AUTO TRACK";
                angelpv9.ReadOnly = true;
                MessageBox.Show("PV9 chế độ điều hướng tự động");
            }
        }

        private void statepv10_CheckedChanged(object sender, EventArgs e)
        {
            if (statepv10.CheckState == CheckState.Checked)
            {
                statepv10.Text = "CUSTOM TRACK";
                angelpv10.ReadOnly = false;
                MessageBox.Show("PV10 chế độ điều hướng tùy chỉnh");
            }
            else
            {
                statepv10.Text = "AUTO TRACK";
                angelpv10.ReadOnly = true;
                MessageBox.Show("PV10 chế độ điều hướng tự động");
            }
        }
        #endregion

    }
}
