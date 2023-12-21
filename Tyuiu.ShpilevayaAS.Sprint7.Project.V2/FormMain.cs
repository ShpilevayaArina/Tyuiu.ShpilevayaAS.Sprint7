using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string pathDepartments = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint7\Tyuiu.ShpilevayaAS.Sprint7.Project.V2\bin\Debug\Departments.csv";
        
        private void FormMain_Load(object sender, EventArgs e)
        {
           try
            {
                string[,] DataDepartments = ds.GetDataFromFile(pathDepartments);

                int rows = 86;
                int columns = 5;

                DataGridViewDepartments_SAS.RowCount = rows;
                DataGridViewDepartments_SAS.ColumnCount = columns;

                DataGridViewDepartments_SAS.Columns[0].HeaderText = "Номер филиала";
                DataGridViewDepartments_SAS.Columns[1].HeaderText = "Город";
                DataGridViewDepartments_SAS.Columns[2].HeaderText = "Улица";
                DataGridViewDepartments_SAS.Columns[3].HeaderText = "Номер здания";
                DataGridViewDepartments_SAS.Columns[4].HeaderText = "Номер телефона";

                for (int i = 0; i < columns; i++)
                {
                    DataGridViewDepartments_SAS.Columns[i].Width = 150;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        DataGridViewDepartments_SAS.Rows[r].Cells[c].Value = DataDepartments[r, c];
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2ButtonInfo_SAS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void guna2ButtonHelp_SAS_Click(object sender, EventArgs e)
        {
            FormUserGuide formUserGuide = new FormUserGuide();
            formUserGuide.ShowDialog();
        }

        private void buttonClose_SAS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_SAS_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool isFullscreen = false;
        private FormWindowState previousWindowState;
        private void buttonChange_SAS_Click(object sender, EventArgs e)
        {
            if (!isFullscreen)
            {
                previousWindowState = this.WindowState;
                this.WindowState = FormWindowState.Maximized;
                isFullscreen = true;
            }
            else
            {
                this.WindowState = previousWindowState;
                isFullscreen = false;
            }
        }

        private void guna2ButtonInfo_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Справка";
        }

        private void guna2ButtonHelp_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Краткое руководство пользователя";
        }

        private void TextBoxSearchDepartments_SAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBoxSearch_SAS_Click(object sender, EventArgs e)
        {

        }

        private void tabPageEmployees_SAS_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxSearchDepartments_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Поиск";
        }

        private void CheckBoxSearchDepartments_SAS_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void guna2CircleButton1_Click(object sender, EventArgs e)
        //{    this.Close();}
    }
}
