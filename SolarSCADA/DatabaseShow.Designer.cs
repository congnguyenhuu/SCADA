namespace SolarSCADA
{
    partial class DatabaseShow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.refreshData = new XanderUI.XUISuperButton();
            this.showData = new XanderUI.XUISuperButton();
            this.datePick = new MetroFramework.Controls.MetroDateTime();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlDataShow = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.xuiFlatTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataShow)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.xuiGradientPanel1.Controls.Add(this.refreshData);
            this.xuiGradientPanel1.Controls.Add(this.showData);
            this.xuiGradientPanel1.Controls.Add(this.datePick);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1355, 40);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 2;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // refreshData
            // 
            this.refreshData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.refreshData.ButtonImage = global::SolarSCADA.Properties.Resources.icons8_data_backup_26px;
            this.refreshData.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.refreshData.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.refreshData.ButtonText = "REFRESH DATA";
            this.refreshData.CornerRadius = 5;
            this.refreshData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.refreshData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.refreshData.HoverTextColor = System.Drawing.Color.Red;
            this.refreshData.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.refreshData.Location = new System.Drawing.Point(397, 3);
            this.refreshData.Name = "refreshData";
            this.refreshData.SelectedBackColor = System.Drawing.Color.DarkGreen;
            this.refreshData.SelectedTextColor = System.Drawing.Color.Red;
            this.refreshData.Size = new System.Drawing.Size(177, 32);
            this.refreshData.SuperSelected = false;
            this.refreshData.TabIndex = 2;
            this.refreshData.TextColor = System.Drawing.Color.Red;
            this.refreshData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.refreshData.Click += new System.EventHandler(this.refreshData_Click);
            // 
            // showData
            // 
            this.showData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.showData.ButtonImage = global::SolarSCADA.Properties.Resources.icons8_database_view_26px;
            this.showData.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.showData.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.showData.ButtonText = "SHOW DATA";
            this.showData.CornerRadius = 5;
            this.showData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.showData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.showData.HoverTextColor = System.Drawing.Color.Red;
            this.showData.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.showData.Location = new System.Drawing.Point(233, 3);
            this.showData.Name = "showData";
            this.showData.SelectedBackColor = System.Drawing.Color.Green;
            this.showData.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.showData.Size = new System.Drawing.Size(146, 32);
            this.showData.SuperSelected = false;
            this.showData.TabIndex = 2;
            this.showData.TextColor = System.Drawing.Color.Red;
            this.showData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // datePick
            // 
            this.datePick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datePick.Location = new System.Drawing.Point(5, 5);
            this.datePick.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.datePick.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.datePick.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(212, 29);
            this.datePick.TabIndex = 0;
            this.datePick.Value = new System.DateTime(2020, 9, 29, 0, 0, 0, 0);
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Fuchsia;
            this.xuiGradientPanel2.Controls.Add(this.xuiFlatTab1);
            this.xuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(0, 40);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(1355, 718);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 3;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
            this.xuiFlatTab1.Controls.Add(this.tabPage2);
            this.xuiFlatTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatTab1.Multiline = true;
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.OnlyTopLine = true;
            this.xuiFlatTab1.PageColor = System.Drawing.Color.White;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.Size = new System.Drawing.Size(1355, 718);
            this.xuiFlatTab1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1347, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data GridView";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sqlDataShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 688);
            this.panel1.TabIndex = 2;
            // 
            // sqlDataShow
            // 
            this.sqlDataShow.AllowUserToAddRows = false;
            this.sqlDataShow.AllowUserToDeleteRows = false;
            this.sqlDataShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sqlDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlDataShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlDataShow.Location = new System.Drawing.Point(0, 0);
            this.sqlDataShow.Name = "sqlDataShow";
            this.sqlDataShow.ReadOnly = true;
            this.sqlDataShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sqlDataShow.Size = new System.Drawing.Size(1341, 688);
            this.sqlDataShow.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dataChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1347, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data ChartView";
            // 
            // dataChart
            // 
            this.dataChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.dataChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.dataChart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Red;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea2.AxisX.MajorTickMark.Size = 0.7F;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea2.AxisX.MinorTickMark.Size = 0.5F;
            chartArea2.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartArea2.AxisY.MajorTickMark.Size = 0.7F;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea2.AxisY.MinorTickMark.Size = 0.5F;
            chartArea2.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisY.Title = "W";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Red;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 88F;
            chartArea2.Position.Width = 96F;
            chartArea2.Position.Y = 10F;
            this.dataChart.ChartAreas.Add(chartArea2);
            this.dataChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.ForeColor = System.Drawing.Color.DarkGreen;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 4F;
            legend2.Position.Width = 10F;
            legend2.Position.X = 85F;
            legend2.Position.Y = 6.3F;
            this.dataChart.Legends.Add(legend2);
            this.dataChart.Location = new System.Drawing.Point(3, 3);
            this.dataChart.Name = "dataChart";
            this.dataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "PV";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "LOAD";
            this.dataChart.Series.Add(series3);
            this.dataChart.Series.Add(series4);
            this.dataChart.Size = new System.Drawing.Size(1341, 688);
            this.dataChart.TabIndex = 0;
            this.dataChart.Text = "chart1";
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "tille";
            title2.Text = "CÔNG SUẤT";
            this.dataChart.Titles.Add(title2);
            // 
            // DatabaseShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 758);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DatabaseShow";
            this.Text = "DatabaseShow";
            this.Load += new System.EventHandler(this.DatabaseShow_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel2.ResumeLayout(false);
            this.xuiFlatTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataShow)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUISuperButton refreshData;
        private XanderUI.XUISuperButton showData;
        private MetroFramework.Controls.MetroDateTime datePick;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView sqlDataShow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
    }
}