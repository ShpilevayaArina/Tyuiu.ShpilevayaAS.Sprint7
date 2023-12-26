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
            this.chartDepartments_SAS.ChartAreas[0].AxisY.Title = "Количество новых филиалов";
            this.chartDepartments_SAS.ChartAreas[0].AxisX.Title = "Год";

            chartDepartments_SAS.Series[0].Points.Clear();
            DataService ds = new DataService();

            Dictionary<string, int> arrays = ds.GetNumberOfDepartments(@"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint7\Departments.csv");

            foreach (KeyValuePair<string, int> kvp in arrays)
            {
                string xValue = kvp.Key;
                double yValue = kvp.Value;
                chartDepartments_SAS.Series[0].Points.AddXY(xValue, yValue);
            }
        }
    }
}
