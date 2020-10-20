using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace winform_chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //一键读取抬头文件，需要添加到table里
        
        private void Get_column_name_Click(object sender, EventArgs e)
        {
            /*
            string table_name = "GENLAB";
            string[] column_name;
            string end_token = "VARUNIT";
            Regex regex = new Regex(table_name);
            Regex regex_1 = new Regex(end_token);

            string filePath_fron = @"C: \Users\Administrator\Desktop\012_2.5_182\012_2.5_182.%";
            string filePath;
            StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Desktop\column_name.txt", true);
            for (int i = 4; i < 70; i++)
            {


                string file_end_number = i.ToString("00");
                // Console.WriteLine(file_end_number);
                // Console.Read();

                filePath = filePath_fron + file_end_number;

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("没有.%" + file_end_number + "文件");
                    // Console.ReadKey();
                    continue;
                }
                StreamReader sr = new StreamReader(filePath, Encoding.Default);


                string line;
                sw.Write(".%" + file_end_number + "文件\t");
                while ((line = sr.ReadLine()) != null)
                {

                    if (regex.IsMatch(line))
                    {

                        // 字符串分割
                        string[] words = line.Split('\t');
                        //写入新文件
                        string table_1 = words[1].Replace("'", "");
                        sw.Write(table_1 + "\t");

                        //读取新一行
                        line = sr.ReadLine();

                        string[] cut_line = line.Split('\t');
                        //Regex c_cut_line = new Regex(cut_line[1]);
                        column_name = Regex.Split(cut_line[1], @"' '");

                        foreach (string x in column_name)
                        {
                            string single = x.Replace("'", "");
                            sw.Write(single + "\t");
                        }
                        sw.Write("\r\n\r\n");
                        break;

                    }
                }
                sr.Close();

                Console.WriteLine("读取.%" + file_end_number + "完毕");

            }

            //读取.%101文件、296、297文件，101文件特殊，不以“ 空格”分隔，所以要特殊处理
            filePath = filePath_fron + "101";
            sw.Write(".%101文件\t");
            using (StreamReader sr_1 = new StreamReader(filePath, Encoding.Default))
            {
                string line_1;
                while ((line_1 = sr_1.ReadLine()) != null)
                {

                    if (regex.IsMatch(line_1))
                    {

                        // 字符串分割

                        string[] words = Regex.Split(line_1, @"B  ");
                        //写入新文件
                        string table_1 = words[1].Replace("'", "");
                        sw.Write(table_1 + "\t");

                        //读取新一行
                        line_1 = sr_1.ReadLine();

                        // string[] cut_line = line_1.Split(' ');
                        //Regex c_cut_line = new Regex(cut_line[1]);
                        column_name = Regex.Split(line_1, @"' '");

                        foreach (string x in column_name)
                        {
                            string single = x.Replace("'", "");
                            sw.Write(single + "\t");
                        }
                        sw.Write("\r\n");
                        break;

                    }
                }
            }
            //296文件
            filePath = filePath_fron + "296";
            sw.Write(".%296文件\t");
            using (StreamReader sr_1 = new StreamReader(filePath, Encoding.Default))
            {
                string line_1;
                while ((line_1 = sr_1.ReadLine()) != null)
                {

                    if (regex.IsMatch(line_1))
                    {

                        // 字符串分割

                        string[] words = Regex.Split(line_1, "\t");
                        //写入新文件
                        string table_1 = words[1].Replace("'", "");
                        sw.Write(table_1 + "\t");

                        //读取新一行
                        line_1 = sr_1.ReadLine();

                        string[] cut_line = line_1.Split('\t');
                        //Regex c_cut_line = new Regex(cut_line[1]);
                        column_name = Regex.Split(cut_line[1], @"' '");

                        foreach (string x in column_name)
                        {
                            string single = x.Replace("'", "");
                            sw.Write(single + "\t");
                        }
                        sw.Write("\r\n");
                        break;

                    }
                }
            }
            //297文件
            filePath = filePath_fron + "297";
            sw.Write(".%297文件\t");
            using (StreamReader sr_1 = new StreamReader(filePath, Encoding.Default))
            {
                string line_1;
                while ((line_1 = sr_1.ReadLine()) != null)
                {

                    if (regex.IsMatch(line_1))
                    {

                        // 字符串分割

                        string[] words = Regex.Split(line_1, "\t");
                        //写入新文件
                        string table_1 = words[1].Replace("'", "");
                        sw.Write(table_1 + "\t");

                        //读取新一行
                        line_1 = sr_1.ReadLine();

                        string[] cut_line = line_1.Split('\t');
                        //Regex c_cut_line = new Regex(cut_line[1]);
                        column_name = Regex.Split(cut_line[1], @"' '");

                        foreach (string x in column_name)
                        {
                            string single = x.Replace("'", "");
                            sw.Write(single + "\t");
                        }
                        sw.Write("\r\n");
                        break;

                    }
                }
            }
            sw.Close();
            Console.ReadKey();
            */
        }
        //读取基础载荷二进制文件
        private void Foundation_loads_Click(object sender, EventArgs e)
        {
            /*
            string fileName = @"C:\Users\Administrator\Desktop\012_2.5_182.$07";
            string write_flie = @"C:\Users\Administrator\Desktop\binary_07.txt";
            //写入
            StreamWriter sw = new StreamWriter(write_flie);
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open), encoding: Encoding.GetEncoding(28591)))
            {
                // Encoding.GetEncoding(28591) = ISO-8859-1
                // ReadSingle()	 从当前流中读取 4 字节浮点值，并使流的当前位置提升 4 个字节。
                try
                {
                    float tenmi;
                    while (true)
                    {


                        //Console.WriteLine(tenmi);
                        // Console.ReadKey();
                        // i为列数目
                        for (int i = 1; i < 10; i++)
                        {
                            tenmi = reader.ReadSingle();
                            sw.Write(tenmi + "\t");
                        }
                        tenmi = reader.ReadSingle();
                        sw.Write(tenmi + "\r\n");

                    }
                }

                catch (EndOfStreamException)
                {
                    Console.Write("读取完毕");
                    Console.ReadKey();
                }
                sw.Close();

            }
            */
        }

        private void test_Click(object sender, EventArgs e)
        {
            //DataColumn column = new DataColumn();
            //column. ={ 1, 2, 5, 4, 10, 5, 6, 7, 4, 8, 9, 1, 8, 5, 1, 4};
            //title_Table.Clear();
            //title_Table.Columns.AddRange(arr);
            DataRow row;
            for (int i = 0; i < 10; i++)
            {
                row = title_Table.NewRow();
                row[0] = i + 1;
                row[1] = i + 2;
                row[2] = i + 3;

                // Be sure to add the new row to the
                // DataRowCollection.
                title_Table.Rows.Add(row);
            }
            comboBox4.Text = title_Table.Rows.Count.ToString();

            chart_value.Series.Clear();
            Series mySeries = new Series("myseries");
            mySeries.Points.DataBind(title_Table.AsEnumerable(),"","","");
            chart_value.Series.Add(mySeries);
            
            /*
            DataTable mytable = new DataTable("mytable");
            mytable.Columns.Add("column1", typeof(int));
            mytable.Columns.Add("column2", typeof(int));
            mytable.Columns.Add("column3", typeof(int));
            // my_dataSet.Tables.Add(mytable);
            DataRow row1 = mytable.NewRow();
            DataRow row2 = mytable.NewRow();
            row1[0] = 1;
            row1[1] = 2;
            row1[2] = 3;

            row2[0] = 1;
            row2[1] = 2;
            row2[2] = 3;
            mytable.Rows.Add(row1);
            mytable.Rows.Add(row2);
            //for(int i = 0; i<66; i++)
            //{
            // row1[i] = i + 1;
            //}
            // DataRow fuccc = binary_Table.NewRow();
            // int arr = my_dataSet.Tables.IndexOf(mytable);
            // comboBox4.Text = arr.ToString();

            chart_value.Series.Clear();
            Series mySeries = new Series("myseries");
            mySeries.Points.DataBind(mytable.AsEnumerable(),"column1", "column2","");
            mySeries.ChartType = SeriesChartType.Line;
            chart_value.Series.Add(mySeries);
            */

            /*
            chart_value.Series[0].Points.Clear();
            for(int i =0;i<720;i++)
            {
                chart_value.Series[0].Points.AddXY(i, Math.Sin(i * Math.PI / 180.0));
                chart_value.Series[0].Color = Color.Red;
                chart_value.ChartAreas[0].AxisX.Title = "X";

            }
            */
        }
    }
}
