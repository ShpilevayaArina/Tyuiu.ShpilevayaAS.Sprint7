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
using FontAwesome.Sharp;

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
        static int columnsDepartmens = 5;
        static string openFilePath;
        DataService ds = new DataService();

        // задаём изначальное количество столбцов и строк в таблицах
        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGridViewDepartments_SAS.ColumnCount = 5;
            DataGridViewDepartments_SAS.RowCount = 88;
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
        private void iconButtonOpenFile_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Открыть файл";
        }
        private void iconButtonSave_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Сохранить файл";
        }

        // осуществляем поиск по таблице филиалов
        private void ButtonSearchDepartments_SAS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridViewDepartments_SAS.RowCount; i++)
            {
                DataGridViewDepartments_SAS.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewDepartments_SAS.ColumnCount; j++)
                    if (DataGridViewDepartments_SAS.Rows[i].Cells[j].Value != null)
                        if (DataGridViewDepartments_SAS.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchDepartments_SAS.Text))
                        {
                            DataGridViewDepartments_SAS.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        // добавление базы данных филиалов и дизайн таблицы
        private void iconButtonOpenFile_SAS_Click(object sender, EventArgs e)
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
                DataGridViewDepartments_SAS.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewDepartments_SAS.DefaultCellStyle.ForeColor = Color.Black;

                DataGridViewDepartments_SAS.Columns[0].Width = 5;
                DataGridViewDepartments_SAS.Columns[0].HeaderText = "№";

                DataGridViewDepartments_SAS.Columns[1].Width = 15;
                DataGridViewDepartments_SAS.Columns[1].HeaderText = "Город";

                DataGridViewDepartments_SAS.Columns[2].Width = 15;
                DataGridViewDepartments_SAS.Columns[2].HeaderText = "Адрес";

                DataGridViewDepartments_SAS.Columns[3].Width = 15;
                DataGridViewDepartments_SAS.Columns[3].HeaderText = "Телефон";

                DataGridViewDepartments_SAS.Columns[4].Width = 20;
                DataGridViewDepartments_SAS.Columns[4].HeaderText = "Год открытия филиала";

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

        // добавление информации и сохранение нового файла
        private void iconButtonSave_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTask_SAS.FileName = "NewDepartments.csv";
                saveFileDialogTask_SAS.InitialDirectory = @":C";
                if (saveFileDialogTask_SAS.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogTask_SAS.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = DataGridViewDepartments_SAS.RowCount;
                    int columns = DataGridViewDepartments_SAS.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(DataGridViewDepartments_SAS.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(",");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
