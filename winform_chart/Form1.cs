using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//对序列、数组等的查询功能
using System.Linq;
//字符编码类，encode需要用
using System.Text;
//正则化
using System.Text.RegularExpressions;
//文件读取接口
using System.IO;
//调用chart,方便子属性series等使用
using System.Windows.Forms.DataVisualization.Charting;

namespace winform_chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //***定义全局变量        
        DataTable table_title;  //存储%文件里表头、列名、时间步等信息，触发事件后需调用，所以为全局变量

        DataTable table_summary;    //存贮%07摘要信息数据文件，主要有仿真时间、风速等10列数据，触发绘制表格事件需调用仿真时间作为X轴

        List<string> simulation_time  = new List<string>(); // 将仿真时间列tolist存贮，方便调用绑定chart X轴

        //***一键读取抬头文件，信息到table_title里        
        private void Get_column_name_Click(object sender, EventArgs e)
        {
            //***创建列，添加入table
            table_title = new DataTable("数据文件的表头列头");   //设置表name
            //创建2列，为文件的基本信息，其中“%文件名称”为主键（在后），用来索引查找
            DataColumn column1 = new DataColumn("%文件名称");
            DataColumn column2 = new DataColumn("仿真变量数据的表头");
            table_title.Columns.Add(column1);
            table_title.Columns.Add(column2);
            //创建数据列
            for (int i = 1; i<36; i++)  //由于事先不知道各个文件中最多的列数，所以i的最大值为人工设置，因为101、296、297文件列数太多，暂不予考虑在内
            {
                DataColumn column_i = new DataColumn("数据列"+i.ToString());
                column_i.DataType = System.Type.GetType("System.String");
                table_title.Columns.Add(column_i);
            }

            //***创建读取流，读取文件的信息，存储到table_title，和txt文件（可删）
            //建立读取%文件的起始、终止位置标识
            string table_name_token = "GENLAB";
            string[] column_name;
            string end_token = "VARUNIT";
            Regex regex = new Regex(table_name_token);  //正则化
            Regex regex_1 = new Regex(end_token);

            //此处是代码输入，应该优化成用户选择路径，或者更换成bladed默认存储路径
            string filePath_fron = @"C: \Users\Administrator\Desktop\012_2.5_182\012_2.5_182.%";
            string filePath;
            //如不需要单独写入一个txt文件，写入流可删除
            StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Desktop\column_name1.txt", true);

            //***读取%04--%69文件
            DataRow row;    //创建行
            for (int i = 4; i < 70; i++)    //04--69的递增
            {                
                string file_end_number = i.ToString("00");  //将i，format为00格式的两位数
                filePath = filePath_fron + file_end_number; //合成文件路径
                //判断文件存在,跳过没有的文件
                if (!File.Exists(filePath))
                {
                    // MessageBox.Show("没有.%" + file_end_number + "文件");                    
                    continue;
                }
                //创建写入流
                StreamReader sr = new StreamReader(filePath, Encoding.Default);
                string line;    //存入读取的行
                sw.Write(".%" + file_end_number + "文件\t");  //写入txt
                //创建new row
                row = table_title.NewRow(); //创建新row，必须采用table.newrow()方法，而且row属性不支持添加“name”属性，所以需要寻找row必须利用colunmn的主键属性
                row[0] = ".%" + file_end_number + "文件"; //datarow类似数组属性，但是单独的row无遍历方法，需转换成list或数组
                
                int j = 1;  //j用来标识写入row的索引
                while ((line = sr.ReadLine()) != null)  //如果文件没有token存在，则读到最后也不会有写入table操作
                {
                    if (regex.IsMatch(line))    //起始token判定
                    {
                        // 字符串分割、去除多余符号
                        string[] words = line.Split('\t');                        
                        string table_title_name = words[1].Replace("'", "");
                        //写入数据表头table_name
                        sw.Write(table_title_name + "\t");
                        row[j] = table_title_name;                        
                        j++;    //索引递增

                        //读取新一行
                        line = sr.ReadLine();
                        // 字符串分割、去除多余符号
                        string[] cut_line = line.Split('\t');
                        //Regex c_cut_line = new Regex(cut_line[1]);    //不需要正则
                        column_name = Regex.Split(cut_line[1], @"' '"); //此正则方法能用于多符号，而spilt只能用单独符号分隔
                        //***从分割数组中提取单个信息写入
                        foreach (string x in column_name)
                        {
                            string single = x.Replace("'", "");
                            sw.Write(single + "\t");

                            row[j] = single;
                            j++;
                        }
                        sw.Write("\r\n\r\n");
                        table_title.Rows.Add(row);  //谨记添加row到table
                        break;  //需要的信息读取完毕
                    }
                }
                sr.Close();                                
            }
            sw.Close();
            //***用某列作为table的主键，主键是标识、查找row的方法，一个table只能存在一个主键
            DataColumn[] keys = new DataColumn[1];  //创建一个长度的datacolumn数组，一个长度就是单独列作为主键，如果数组长度>1，则是，两列或者多列作为联合主键，来确定标识唯一一条表信息
            keys[0] = table_title.Columns["%文件名称"];     //此列必须可以作为唯一标识行的字段
            table_title.PrimaryKey = keys;
            //***dataset在form1设计时已经插入，作为全局变量，所以不需再创建
            my_dataSet.Tables.Add(table_title); //将table添加入dataset
            
            //***测试用
            //foreach (DataColumn column in table_title.Columns)
            //MessageBox.Show(column.ColumnName);
            //DataRow mee = table_title.Rows[5];
            //MessageBox.Show(mee[1].ToString());

            //***combobox下拉框，显示读取到的文件名和数目
            foreach (DataRow item in table_title.Rows)
            {
                cbo_choose_file.Items.Add(item["%文件名称"]);                
            }
            cbo_numof_file.Text = cbo_choose_file.Items.Count.ToString();
            
            //***读取摘要.%07文件，因为里面的time数据需要作为chart的X轴
            DataRow row_07 = table_title.Rows.Find(".%07文件");   //找到列头
            //row不提供count属性，所以需要一个循环确定row的数组大小
            int row_count = 0;
            while(true)
            {
                if (row_07.IsNull(row_count))
                    break;
                row_count ++;
            }
            //***将table_title的摘要行的信息，作为table_summary的列头
            table_summary = new DataTable(row_07[1].ToString());    //表头
            DataColumn column;            
            for (int i = 2; i < row_count; i++)
            {
                column = new DataColumn(row_07[i].ToString());        //列头        
                table_summary.Columns.Add(column);
            }
            //***读取二进制文件
            string fileName = @"C:\Users\Administrator\Desktop\012_2.5_182.$07";    //路径
            //二进制读取，写入摘要表
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open), encoding: Encoding.GetEncoding(28591)))
            {
                // Encoding.GetEncoding(28591) = ISO-8859-1         //二进制文件的编码格式
                // ReadSingle()	 从当前流中读取 4 字节浮点值，并使流的当前位置提升 4 个字节。
                try
                {
                    float tenmi;    //二进制文件存储的数据为，浮点float类型
                    while (true)
                    {                                            
                        row = table_summary.NewRow();
                        for (int i = 0; i < row_count-2; i++)   // i为索引，从[0]开始写入
                        {
                            tenmi = reader.ReadSingle();
                            string tenmi_1 = tenmi.ToString();  //row默认为string类型，若需直接存储float，需要设定row的datatype
                            row[i] = tenmi_1;                            
                        }
                        table_summary.Rows.Add(row);
                    }
                }
                catch (EndOfStreamException)    //获取报错，可知文件读取完毕
                {
                    MessageBox.Show("读取%07完毕");
                }
            }
            //***添加入dataset
            my_dataSet.Tables.Add(table_summary);
            //测试
            //comboBox3.Text = (table_summary.Rows[5][0].ToString());

            //***将time数据提取出，到list中，便于绑定X轴
            foreach(DataRow row_single in table_summary.Rows)
            {
                simulation_time.Add(row_single[0].ToString());         
            }
        }

        //***基础载荷二进制数据 提取+绘图
        private void Foundation_loads_Click(object sender, EventArgs e)
        {
            //***基础载荷暂时为，.%69文件
            //***提取数据方法同    %07摘要文件 的提取
            DataRow row_69 = table_title.Rows.Find(".%69文件");
            int row_count = 0;
            while (true)
            {
                if (row_69.IsNull(row_count))
                    break;
                row_count++;
            }
            //***显示曲线的数目
            cbo_numof_series.Text = (row_count -2).ToString();
            //***表头、列头
            DataTable table_69 = new DataTable(row_69[1].ToString());
            DataColumn column;
            for (int i = 2; i < row_count; i++)
            {
                column = new DataColumn(row_69[i].ToString());      //列头
                table_69.Columns.Add(column);
                cbo_choose_series.Items.Add(row_69[i].ToString());      //将列头加入下拉框
            }
            //路径
            string fileName = @"C:\Users\Administrator\Desktop\012_2.5_182.$69";
            //写入
            DataRow row;
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open), encoding: Encoding.GetEncoding(28591)))
            {
                // Encoding.GetEncoding(28591) = ISO-8859-1
                // ReadSingle()	 从当前流中读取 4 字节浮点值，并使流的当前位置提升 4 个字节。
                try
                {
                    float tenmi;
                    while (true)
                    {
                        row = table_69.NewRow();
                        for (int i = 0; i < row_count - 2; i++)
                        {
                            tenmi = reader.ReadSingle();
                            string tenmi_1 = tenmi.ToString();
                            row[i] = tenmi_1;                            
                        }
                        table_69.Rows.Add(row);
                    }
                }
                catch (EndOfStreamException)
                {
                    MessageBox.Show("读取%69完毕");
                }
            }
            my_dataSet.Tables.Add(table_69);

            //***数据图表显示
            //***chart清空
            chart_value.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("myarea");
            chart_value.ChartAreas.Add(chartArea1);     //chart添加area
            chart_value.Series.Clear();
            //***从table读取到series.points绑定
            for (int i = 0; i < row_count - 2; i++)       //i < row_count-2
            {
                Series s = new Series(row_69[i+2].ToString());  //列头信息作为series的名称，也可以利用table69的column_name，一样
                s.ChartArea = "myarea";     //添加入area
                s.BorderWidth = 1;          //线粗
                s.ChartType = SeriesChartType.Line;         //chart类型为折线图型
                List<string> xyData1 = new List<string>();  //list和arry便于绑定points
                List<string> yData1 = new List<string>();

                // List<string> xData1 = new List<string>();        //test
                //***读取table中的一列数据到list
                for (int j = 0; j < table_69.Rows.Count-1; j++)     
                {                    
                    if (table_69 != null)       //else可以写入报错提示
                    {
                        yData1.Add(table_69.Rows[j][i].ToString());
                        //xData1.Add(j.ToString());     //测试，X轴坐标，为y的计数单位
                    }
                }
                //***???会产生time的X轴，和读取的ydata的Y轴，长度不匹配的情况
                //处理办法为：将长的list数据，截取到和短的，一样的长度
                //系统已报错是X轴短，所以截取Y轴数据
                //可以增加一个判读循环，先判断哪个长，再截取，***或者找出更好的方法?

                //***不确定两者谁长谁短，怎么样处理到一样长？   //需要优化
                //xyData1 = yData1.Skip(0).Take(simulation_time.Count()).ToList();      //这个是y轴数据，长度大于，时间步的长度                
                xyData1 = simulation_time.Skip(0).Take(yData1.Count()).ToList();        //时间步长度大于，y轴长度

                //***将数据绑定为一个个的点集
                //databind还有databindY和databind两种方法，需学习             
                //
                //s.Points.DataBindXY(simulation_time,"time",xyData1, "value");
                s.Points.DataBindXY(xyData1,"time",yData1, "value");
                chart_value.Series.Add(s);  //添加入series
            }
            //***表格图样的设置，可以放大X轴
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.Interval = 0;
            chartArea1.CursorX.IntervalOffset = 0;
            //可放大X轴
            
            chartArea1.AxisX.ScaleView.Zoomable = true;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = true;

            //***隐藏legend图例
            //chart_value.Series[0].IsVisibleInLegend = false;
            //chart_value.Series[1].IsVisibleInLegend = false;
            //chart_value.Series[2].IsVisibleInLegend = false;
            //chart_value.Series[3].IsVisibleInLegend = false;
            //chart_value.Series[5].IsVisibleInLegend = false;

            //***隐藏series曲线
            //chart_value.Series[0].Enabled = false;
            //chart_value.Series[2].Enabled = false;
            //chart_value.Series[3].Enabled = false;
            //chart_value.Series[4].Enabled = false;
            //chart_value.Series[5].Enabled = false;
        }

        //***测试
        private void test_Click(object sender, EventArgs e)
        {                            
            //写入table
            DataTable table2 = new DataTable("基础载荷");
            DataColumn column;
            DataRow row;
            for (int i =0; i<6; i++)
            {
                column = new DataColumn();
                column.ColumnName = i.ToString();
                table2.Columns.Add(column);
            }
            //地址
            string fileName = @"C:\Users\Administrator\Desktop\012_2.5_182.$69";            
            //写入            
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open), encoding: Encoding.GetEncoding(28591)))
            {
                // Encoding.GetEncoding(28591) = ISO-8859-1
                // ReadSingle()	 从当前流中读取 4 字节浮点值，并使流的当前位置提升 4 个字节。
                try
                {
                    float tenmi;
                    while (true)
                    {                                               
                        row = table2.NewRow();
                        for (int i = 0; i < 6; i++)
                        {
                            tenmi = reader.ReadSingle();
                            string tenmi_1 = tenmi.ToString();
                            row[i.ToString()] = tenmi_1;                            
                        }
                        table2.Rows.Add(row);                       
                    }
                }

                catch (EndOfStreamException)
                {
                    MessageBox.Show("读取完毕");                    
                }                
            }
            //加入dataset
            my_dataSet.Tables.Add(table2);
            //图表设置
            chart_value.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("myarea");
            chart_value.ChartAreas.Add(chartArea1);
            chart_value.Series.Clear();
            //数据读取，绑定
            for (int i = 0; i < 6; i++)
            {
                Series s = new Series();
                s.ChartArea = "myarea";
                s.BorderWidth = 1;
                s.ChartType = SeriesChartType.Line;
                List<string> xData1 = new List<string>();
                List<string> yData1 = new List<string>();
                for (int j = 0; j < table2.Rows.Count-1; j++)
                {                    
                    if(table2 != null)
                    {
                        yData1.Add(table2.Rows[j][i].ToString());
                    }
                }
                s.Points.DataBindY(yData1, "");
                chart_value.Series.Add(s);                
            }
            //图样设置
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.Interval = 0;
            chartArea1.CursorX.IntervalOffset = 0;
            chartArea1.AxisX.ScaleView.Zoomable = true;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = true;
            //图例隐藏
            //chart_value.Series[0].IsVisibleInLegend = false;
            //chart_value.Series[1].IsVisibleInLegend = false;
            //chart_value.Series[2].IsVisibleInLegend = false;
            //chart_value.Series[3].IsVisibleInLegend = false;
            //chart_value.Series[5].IsVisibleInLegend = false;
        }
        
        //***下拉框选中后，显示该文件的数据参数是什么总体信息
        private void cbo_nameof_file_SelectedIndexChanged(object sender, EventArgs e)
        {            
            DataRow dr = table_title.Rows.Find(cbo_choose_file.SelectedItem.ToString());
            // int drIndex = table_title.Rows.IndexOf(dr);
            cbo_nameof_file.Text = dr[1].ToString();            
        }

        //***下拉框选中后，图表显示选择的数据曲线
        private void cbo_choose_series_SelectedIndexChanged(object sender, EventArgs e)
        {
            //***循环，隐藏全部数据曲线
            for(int i=0 ; i< cbo_choose_series.Items.Count; i++)
            {
                chart_value.Series[i].Enabled = false;
            }			
            //***单独显示选中的曲线
            chart_value.Series[cbo_choose_series.SelectedIndex].Enabled = true;
        }

		

	}
}
