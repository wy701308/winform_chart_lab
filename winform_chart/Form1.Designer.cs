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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 5D);
            this.panel1 = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Foundation_loads = new System.Windows.Forms.Button();
            this.Get_column_name = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_value = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.my_dataSet = new System.Data.DataSet();
            this.title_Table = new System.Data.DataTable();
            this.dataColumn_04 = new System.Data.DataColumn();
            this.binary_Table = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binary_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
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
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(576, 18);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 20);
            this.comboBox6.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(500, 19);
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
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(786, 18);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(708, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(62, 21);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "名称";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(725, 87);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(637, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 21);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "参数单独显示";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(544, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(71, 20);
            this.comboBox3.TabIndex = 8;
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
            this.textBox2.Location = new System.Drawing.Point(319, 19);
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
            this.comboBox2.Location = new System.Drawing.Point(383, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 20);
            this.comboBox1.TabIndex = 2;
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
            chartArea1.Name = "ChartArea1";
            this.chart_value.ChartAreas.Add(chartArea1);
            this.chart_value.DataSource = this.my_dataSet;
            this.chart_value.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_value.Legends.Add(legend1);
            this.chart_value.Location = new System.Drawing.Point(0, 0);
            this.chart_value.Name = "chart_value";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderWidth = 6;
            series1.LabelForeColor = System.Drawing.Color.DarkRed;
            series1.Legend = "Legend1";
            series1.Name = "power";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chart_value.Series.Add(series1);
            this.chart_value.Size = new System.Drawing.Size(943, 403);
            this.chart_value.TabIndex = 0;
            this.chart_value.Text = "chart1";
            // 
            // my_dataSet
            // 
            this.my_dataSet.DataSetName = "NewDataSet";
            this.my_dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.title_Table,
            this.binary_Table});
            // 
            // title_Table
            // 
            this.title_Table.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_04,
            this.dataColumn3,
            this.dataColumn4});
            this.title_Table.MinimumCapacity = 20;
            this.title_Table.TableName = "title_Table";
            // 
            // dataColumn_04
            // 
            this.dataColumn_04.ColumnName = "file_%04";
            // 
            // binary_Table
            // 
            this.binary_Table.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.binary_Table.MinimumCapacity = 20;
            this.binary_Table.TableName = "binary_Table";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column2";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Column1";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Column2";
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
            ((System.ComponentModel.ISupportInitialize)(this.title_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binary_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_value;
        private System.Data.DataSet my_dataSet;
        public System.Data.DataTable title_Table;
        private System.Data.DataColumn dataColumn_04;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Foundation_loads;
        private System.Windows.Forms.Button Get_column_name;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Data.DataTable binary_Table;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Button test;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
    }
}

