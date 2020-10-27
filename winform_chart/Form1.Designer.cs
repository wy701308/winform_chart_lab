namespace winform_chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 5D);
            this.panel1 = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.Button();
            this.cbo_choose_file = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cbo_nameof_file = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cbo_choose_series = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbo_numof_series = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbo_numof_file = new System.Windows.Forms.ComboBox();
            this.Foundation_loads = new System.Windows.Forms.Button();
            this.Get_column_name = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_value = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.my_dataSet = new System.Data.DataSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.cbo_choose_file);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.cbo_nameof_file);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.cbo_choose_series);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.cbo_numof_series);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.cbo_numof_file);
            this.panel1.Controls.Add(this.Foundation_loads);
            this.panel1.Controls.Add(this.Get_column_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 135);
            this.panel1.TabIndex = 0;
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.test.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.test.Location = new System.Drawing.Point(856, 66);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 58);
            this.test.TabIndex = 23;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // cbo_choose_file
            // 
            this.cbo_choose_file.FormattingEnabled = true;
            this.cbo_choose_file.Location = new System.Drawing.Point(520, 18);
            this.cbo_choose_file.Name = "cbo_choose_file";
            this.cbo_choose_file.Size = new System.Drawing.Size(75, 20);
            this.cbo_choose_file.TabIndex = 22;
            this.cbo_choose_file.SelectedIndexChanged += new System.EventHandler(this.cbo_nameof_file_SelectedIndexChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(444, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(70, 21);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "选取.%文件";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(328, 67);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 26);
            this.button12.TabIndex = 20;
            this.button12.Text = "主轴载荷";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(328, 99);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 26);
            this.button11.TabIndex = 19;
            this.button11.Text = "变桨驱动载荷";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 99);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 26);
            this.button10.TabIndex = 18;
            this.button10.Text = "叶片载荷";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(218, 99);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 26);
            this.button9.TabIndex = 17;
            this.button9.Text = "偏航轴承载荷";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(218, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 26);
            this.button8.TabIndex = 16;
            this.button8.Text = "轮毂载荷";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(108, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 26);
            this.button7.TabIndex = 15;
            this.button7.Text = "叶根载荷";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 26);
            this.button6.TabIndex = 14;
            this.button6.Text = "塔架载荷";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // cbo_nameof_file
            // 
            this.cbo_nameof_file.FormattingEnabled = true;
            this.cbo_nameof_file.Location = new System.Drawing.Point(711, 17);
            this.cbo_nameof_file.Name = "cbo_nameof_file";
            this.cbo_nameof_file.Size = new System.Drawing.Size(220, 20);
            this.cbo_nameof_file.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(611, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 21);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "数据文件表名";
            // 
            // cbo_choose_series
            // 
            this.cbo_choose_series.FormattingEnabled = true;
            this.cbo_choose_series.Location = new System.Drawing.Point(725, 87);
            this.cbo_choose_series.Name = "cbo_choose_series";
            this.cbo_choose_series.Size = new System.Drawing.Size(121, 20);
            this.cbo_choose_series.TabIndex = 10;
            this.cbo_choose_series.SelectedIndexChanged += new System.EventHandler(this.cbo_choose_series_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(637, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 21);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "参数单独显示";
            // 
            // cbo_numof_series
            // 
            this.cbo_numof_series.FormattingEnabled = true;
            this.cbo_numof_series.Location = new System.Drawing.Point(544, 86);
            this.cbo_numof_series.Name = "cbo_numof_series";
            this.cbo_numof_series.Size = new System.Drawing.Size(71, 20);
            this.cbo_numof_series.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(485, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 21);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "参数数量";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "时间步长";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "数据文件数目";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // cbo_numof_file
            // 
            this.cbo_numof_file.FormattingEnabled = true;
            this.cbo_numof_file.Location = new System.Drawing.Point(238, 18);
            this.cbo_numof_file.Name = "cbo_numof_file";
            this.cbo_numof_file.Size = new System.Drawing.Size(42, 20);
            this.cbo_numof_file.TabIndex = 2;
            // 
            // Foundation_loads
            // 
            this.Foundation_loads.Location = new System.Drawing.Point(12, 67);
            this.Foundation_loads.Name = "Foundation_loads";
            this.Foundation_loads.Size = new System.Drawing.Size(90, 26);
            this.Foundation_loads.TabIndex = 1;
            this.Foundation_loads.Text = "基础载荷";
            this.Foundation_loads.UseVisualStyleBackColor = true;
            this.Foundation_loads.Click += new System.EventHandler(this.Foundation_loads_Click);
            // 
            // Get_column_name
            // 
            this.Get_column_name.Location = new System.Drawing.Point(12, 12);
            this.Get_column_name.Name = "Get_column_name";
            this.Get_column_name.Size = new System.Drawing.Size(129, 30);
            this.Get_column_name.TabIndex = 0;
            this.Get_column_name.Text = "一键读取抬头文件";
            this.Get_column_name.UseVisualStyleBackColor = true;
            this.Get_column_name.Click += new System.EventHandler(this.Get_column_name_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart_value);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 403);
            this.panel2.TabIndex = 1;
            // 
            // chart_value
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_value.ChartAreas.Add(chartArea2);
            this.chart_value.DataSource = this.my_dataSet;
            this.chart_value.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_value.Legends.Add(legend2);
            this.chart_value.Location = new System.Drawing.Point(0, 0);
            this.chart_value.Name = "chart_value";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBorderWidth = 6;
            series2.LabelForeColor = System.Drawing.Color.DarkRed;
            series2.Legend = "Legend1";
            series2.Name = "power";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chart_value.Series.Add(series2);
            this.chart_value.Size = new System.Drawing.Size(943, 403);
            this.chart_value.TabIndex = 0;
            this.chart_value.Text = "chart1";
            // 
            // my_dataSet
            // 
            this.my_dataSet.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "后处理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_value;
        private System.Data.DataSet my_dataSet;
        private System.Windows.Forms.ComboBox cbo_numof_series;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbo_numof_file;
        private System.Windows.Forms.Button Foundation_loads;
        private System.Windows.Forms.Button Get_column_name;
        private System.Windows.Forms.ComboBox cbo_choose_series;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cbo_choose_file;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cbo_nameof_file;
        private System.Windows.Forms.Button test;
    }
}

