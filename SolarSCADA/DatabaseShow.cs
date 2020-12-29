using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SolarSCADA
{
    public partial class DatabaseShow : Form
    {
        MySqlConnection mysqlCN;
        MySqlCommand mysqlCM;
        MySqlDataAdapter myAdapter;

        MySqlConnection mysqlCN2;
        MySqlCommand mysqlCM2;
        MySqlDataAdapter myAdapter2;

        MySqlConnection mysqlCN3;

        private void clearChart()
        {
            dataChart.Series["PV"].Points.Clear();
            dataChart.Series["LOAD"].Points.Clear();
        }

        private void loadChart()
        {
            clearChart();
            try
            {
                mysqlCN3 = new MySqlConnection("server=localhost;username =root;password=solarscada;port=3306;database=scadadatabase");
                mysqlCN3.Open();
                //
                MySqlCommand cmd = mysqlCN3.CreateCommand();
                cmd.CommandText = "SELECT * FROM `datatest`";
                MySqlDataReader dataReadsql;
                dataReadsql = cmd.ExecuteReader();
                while (dataReadsql.Read())
                {
                    //string timestr = dataReadsql.GetString("Time");
                    //DateTime times = DateTime.ParseExact(timestr, "HH:mm:ss",null);

                    dataChart.Series["PV"].Points.AddXY(dataReadsql.GetDateTime("DateTime"), dataReadsql.GetDouble("PV wattage"));
                    dataChart.Series["LOAD"].Points.AddXY(dataReadsql.GetDateTime("DateTime"), dataReadsql.GetDouble("Load wattage"));
                }

                mysqlCN3.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void loadChartPick()
        {
            clearChart();
            try
            {
                string dateinpick2 = datePick.Value.ToString("yyyy-MM-dd");
                mysqlCN3 = new MySqlConnection("server=localhost;username =root;password=solarscada;port=3306;database=scadadatabase");
                mysqlCN3.Open();
                //
                MySqlCommand cmd = mysqlCN3.CreateCommand();
                cmd.CommandText = string.Format("SELECT * FROM datatest WHERE DateTime >= '{0}" + " 00:00:00'AND DateTime <='{1}" + " 23:59:59'", dateinpick2, dateinpick2);
                MySqlDataReader dataReadsql;
                dataReadsql = cmd.ExecuteReader();
                while (dataReadsql.Read())
                {

                    dataChart.Series["PV"].Points.AddXY(dataReadsql.GetDateTime("DateTime"), dataReadsql.GetDouble("PV wattage"));
                    dataChart.Series["LOAD"].Points.AddXY(dataReadsql.GetDateTime("DateTime"), dataReadsql.GetDouble("Load wattage"));
                }

                mysqlCN3.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void refreshAndShowData()
        {
            try
            {
                mysqlCN = new MySqlConnection("server=localhost;username =root;password=solarscada;port=3306;database=scadadatabase");
                mysqlCN.Open();
                mysqlCM = new MySqlCommand("SELECT * FROM `datatest`", mysqlCN);
                myAdapter = new MySqlDataAdapter(mysqlCM);
                DataTable dttb = new DataTable();
                myAdapter.Fill(dttb);

                sqlDataShow.DataSource = dttb;
                mysqlCN.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void refreshAndShowDataPick()
        {
            
            try
            {
                sqlDataShow.DataSource = null;
                string dateinpick = datePick.Value.ToString("yyyy-MM-dd");
                mysqlCN2 = new MySqlConnection("server=localhost;username =root;password=solarscada;port=3306;database=scadadatabase");
                mysqlCN2.Open();

                mysqlCM2 = new MySqlCommand(string.Format( "SELECT * FROM datatest WHERE DateTime >= '{0}"+" 00:00:00'AND DateTime<='{1}"+" 23:59:59'",dateinpick,dateinpick), mysqlCN2);

                myAdapter2 = new MySqlDataAdapter(mysqlCM2);
                DataTable dttb2 = new DataTable();
                myAdapter2.Fill(dttb2);

                sqlDataShow.DataSource = dttb2;
                mysqlCN2.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public DatabaseShow()
        {
            InitializeComponent();
            
        }

        private void DatabaseShow_Load(object sender, EventArgs e)
        {
            refreshAndShowData();
            loadChart();
        }

        private void showData_Click(object sender, EventArgs e)
        {
            refreshAndShowDataPick();
            
            loadChartPick();
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            refreshAndShowData();
            loadChart();
        }

    }
}
