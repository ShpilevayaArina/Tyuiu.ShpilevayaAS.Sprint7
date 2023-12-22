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
using System.IO;

namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogChooseData_SAS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_SAS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rowsDepartmens = 86;
        static int columnsDepartmens = 4;
        static string openFilePath;
        DataService ds = new DataService();

        // задаём изначальное количество столбцов и строк в таблицах
        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGridViewDepartments_SAS.ColumnCount = 4;
            DataGridViewDepartments_SAS.RowCount = 87;
        }

        // открытие других форм
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

        // кнопки управления
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

        // заголовки тултипов
        private void guna2ButtonInfo_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Справка";
        }
        private void guna2ButtonHelp_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Краткое руководство пользователя";
        }
        private void ButtonSearchDepartments_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Поиск";
        }

        // добавление базы данных филиалов и дизайн таблицы
        private void ButtonOpenDepartments_SAS_Click(object sender, EventArgs e)
        {
            openFileDialogChooseData_SAS.ShowDialog();
            openFilePath = openFileDialogChooseData_SAS.FileName;
            //TextBoxSearchDepartments_SAS.Enabled = true;
            try
            {
                Font newFont = new Font("Segoe UI", 10, FontStyle.Bold);
                DataGridViewDepartments_SAS.DefaultCellStyle.Font = newFont;
                string[,] MatrixDepartmens = ds.LoadDataFromFile(openFilePath);


                DataGridViewDepartments_SAS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(118, 65, 210);
                DataGridViewDepartments_SAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 47, 59);

                DataGridViewDepartments_SAS.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewDepartments_SAS.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewDepartments_SAS.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewDepartments_SAS.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewDepartments_SAS.DefaultCellStyle.ForeColor = Color.Black;

                DataGridViewDepartments_SAS.Columns[0].Width = 5;
                DataGridViewDepartments_SAS.Columns[0].HeaderText = "№";

                DataGridViewDepartments_SAS.Columns[1].Width = 15;
                DataGridViewDepartments_SAS.Columns[1].HeaderText = "Город";

                DataGridViewDepartments_SAS.Columns[2].Width = 15;
                DataGridViewDepartments_SAS.Columns[2].HeaderText = "Адрес";

                DataGridViewDepartments_SAS.Columns[3].Width = 90;
                DataGridViewDepartments_SAS.Columns[3].HeaderText = "Телефон";

                for (int r = 0; r < rowsDepartmens; r++)
                {
                    for (int c = 0; c < columnsDepartmens; c++)
                    {
                        DataGridViewDepartments_SAS.Rows[r + 1].Cells[c].Value = MatrixDepartmens[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // осуществляем поиск по таблице филиалов
        private void ButtonSearchDepartments_SAS_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
