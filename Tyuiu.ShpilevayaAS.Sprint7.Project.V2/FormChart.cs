using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void buttonClose_SAS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            this.chartDepartments_SAS.ChartAreas[0].AxisY.Title = "Количество филиалов";
            this.chartDepartments_SAS.ChartAreas[0].AxisX.Title = "Год";

            chartDepartments_SAS.Series[0].Points.Clear();

            //string FilePath = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint7\Departments.csv";

            //string[] lines = File.ReadAllLines(FilePath);
            //string[] fifthColumnElements = new string[lines.Length];

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string[] columns = lines[i].Split(',');
            //    if (columns.Length >= 5)
            //    {
            //        fifthColumnElements[i] = columns[4];
            //    }
            //}
            string[] years = { "2019", "2020", "2021", "2022", "2023" } ;
            double[] kol = { 12, 28, 50, 68, 86 };
            //var total2019 = fifthColumnElements.Count(s => Convert.ToInt32(s) == 2019);
            //var total2020 = fifthColumnElements.Count(s => Convert.ToInt32(s) == 2020) + total2019;
            //var total2021 = fifthColumnElements.Count(s => Convert.ToInt32(s) == 2021) + total2020;
            //var total2022 = fifthColumnElements.Count(s => Convert.ToInt32(s) == 2022) + total2021;
            //var total2023 = fifthColumnElements.Count(s => Convert.ToInt32(s) == 2023) + total2022;
            //double[] kol = { total2019, total2020, total2021, total2022, total2023 };
            for (int i = 0; i < 5; i++)
            {
                double yValue = kol[i];
                string xValue = years[i];
                chartDepartments_SAS.Series[0].Points.AddXY(xValue, yValue);
            }

        }
    }
}
