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
        static int columnsSearchDepartments = 5;

        static int rowsEmployees = 86;
        static int columnsEmployees = 6;
        static int rowsProviders = 86;
        static int columnsProviders = 6;
        static string openFilePath;
        DataService ds = new DataService();

        // задаём изначальное количество столбцов и строк в таблицах
        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGridViewDepartments_SAS.ColumnCount = 5;
            DataGridViewDepartments_SAS.RowCount = 88;

            DataGridViewEmployees_SAS.ColumnCount = 6;
            DataGridViewEmployees_SAS.RowCount = 88;

            DataGridViewProviders_SAS.ColumnCount = 6;
            DataGridViewProviders_SAS.RowCount = 88;
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
        private void iconButtonStatistic_SAS_Click(object sender, EventArgs e)
        {
            FormChart formChart = new FormChart();
            formChart.ShowDialog();
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
        private void iconButtonStatistic_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Статистика";
        }
        private void iconButtonAverage_SAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAS.ToolTipTitle = "Среднее значение";
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
        private void ButtonSearchEmpoyees_SAS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridViewEmployees_SAS.RowCount; i++)
            {
                DataGridViewEmployees_SAS.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewEmployees_SAS.ColumnCount; j++)
                    if (DataGridViewEmployees_SAS.Rows[i].Cells[j].Value != null)
                        if (DataGridViewEmployees_SAS.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchEmpoyees_SAS.Text))
                        {
                            DataGridViewEmployees_SAS.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        private void ButtonSearchProviders_SAS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridViewProviders_SAS.RowCount; i++)
            {
                DataGridViewProviders_SAS.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewProviders_SAS.ColumnCount; j++)
                    if (DataGridViewProviders_SAS.Rows[i].Cells[j].Value != null)
                        if (DataGridViewProviders_SAS.Rows[i].Cells[j].Value.ToString().Contains(TextBoxSearchProviders_SAS.Text))
                        {
                            DataGridViewProviders_SAS.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        // добавление базы данных филиалов и дизайн таблицы
        private void iconButtonOpenFile_SAS_Click(object sender, EventArgs e)
        {
            openFileDialogChooseData_SAS.ShowDialog();
            openFilePath = openFileDialogChooseData_SAS.FileName;
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
        private void iconButtonOpenFileEmployees_SAS_Click(object sender, EventArgs e)
        {
            openFileDialogChooseData_SAS.ShowDialog();
            openFilePath = openFileDialogChooseData_SAS.FileName;
            //TextBoxSearchDepartments_SAS.Enabled = true;
            try
            {
                Font newFont = new Font("Segoe UI", 10, FontStyle.Bold);
                DataGridViewEmployees_SAS.DefaultCellStyle.Font = newFont;
                string[,] MatrixEmployees = ds.LoadDataFromFile(openFilePath);


                DataGridViewEmployees_SAS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(118, 65, 210);
                DataGridViewEmployees_SAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 47, 59);

                DataGridViewEmployees_SAS.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewEmployees_SAS.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewEmployees_SAS.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewEmployees_SAS.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewEmployees_SAS.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewEmployees_SAS.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewEmployees_SAS.DefaultCellStyle.ForeColor = Color.Black;

                DataGridViewEmployees_SAS.Columns[0].Width = 5;
                DataGridViewEmployees_SAS.Columns[0].HeaderText = "№";

                DataGridViewEmployees_SAS.Columns[1].Width = 15;
                DataGridViewEmployees_SAS.Columns[1].HeaderText = "Фамилия";

                DataGridViewEmployees_SAS.Columns[2].Width = 5;
                DataGridViewEmployees_SAS.Columns[2].HeaderText = "И.О.";

                DataGridViewEmployees_SAS.Columns[3].Width = 15;
                DataGridViewEmployees_SAS.Columns[3].HeaderText = "Адрес";

                DataGridViewEmployees_SAS.Columns[4].Width = 15;
                DataGridViewEmployees_SAS.Columns[4].HeaderText = "Телефон";

                DataGridViewEmployees_SAS.Columns[5].Width = 20;
                DataGridViewEmployees_SAS.Columns[5].HeaderText = "Капитал";

                for (int r = 0; r < rowsEmployees; r++)
                {
                    for (int c = 0; c < columnsEmployees; c++)
                    {
                        DataGridViewEmployees_SAS.Rows[r + 1].Cells[c].Value = MatrixEmployees[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void iconButtonOpenFileProviders_SAS_Click(object sender, EventArgs e)
        {
            openFileDialogChooseData_SAS.ShowDialog();
            openFilePath = openFileDialogChooseData_SAS.FileName;
            //DataGridViewProviders_SAS
            try
            {
                Font newFont = new Font("Segoe UI", 10, FontStyle.Bold);
                DataGridViewProviders_SAS.DefaultCellStyle.Font = newFont;
                string[,] MatrixProviders = ds.LoadDataFromFile(openFilePath);


                DataGridViewProviders_SAS.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(118, 65, 210);
                DataGridViewProviders_SAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 47, 59);

                DataGridViewProviders_SAS.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewProviders_SAS.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewProviders_SAS.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewProviders_SAS.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewProviders_SAS.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewProviders_SAS.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(204, 187, 231);
                DataGridViewProviders_SAS.DefaultCellStyle.ForeColor = Color.Black;

                DataGridViewProviders_SAS.Columns[0].Width = 5;
                DataGridViewProviders_SAS.Columns[0].HeaderText = "№";

                DataGridViewProviders_SAS.Columns[1].Width = 15;
                DataGridViewProviders_SAS.Columns[1].HeaderText = "Фамилия";

                DataGridViewProviders_SAS.Columns[2].Width = 5;
                DataGridViewProviders_SAS.Columns[2].HeaderText = "И.О.";

                DataGridViewProviders_SAS.Columns[3].Width = 15;
                DataGridViewProviders_SAS.Columns[3].HeaderText = "Адрес";

                DataGridViewProviders_SAS.Columns[4].Width = 15;
                DataGridViewProviders_SAS.Columns[4].HeaderText = "Телефон";

                DataGridViewProviders_SAS.Columns[5].Width = 20;
                DataGridViewProviders_SAS.Columns[5].HeaderText = "Стоимость поставки";

                for (int r = 0; r < rowsProviders; r++)
                {
                    for (int c = 0; c < columnsProviders; c++)
                    {
                        DataGridViewProviders_SAS.Rows[r + 1].Cells[c].Value = MatrixProviders[r, c];
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
        private void iconButtonSaveFileEmployees_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTask_SAS.FileName = "NewEmployees.csv";
                saveFileDialogTask_SAS.InitialDirectory = @":C";
                if (saveFileDialogTask_SAS.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogTask_SAS.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = DataGridViewEmployees_SAS.RowCount;
                    int columns = DataGridViewEmployees_SAS.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(DataGridViewEmployees_SAS.Rows[i].Cells[j].Value);

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
        private void iconButtonSaveFileProviders_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTask_SAS.FileName = "NewProviders.csv";
                saveFileDialogTask_SAS.InitialDirectory = @":C";
                if (saveFileDialogTask_SAS.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogTask_SAS.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = DataGridViewProviders_SAS.RowCount;
                    int columns = DataGridViewProviders_SAS.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(DataGridViewProviders_SAS.Rows[i].Cells[j].Value);

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

        // открытие статистических данных
        private void iconButtonMin_SAS_Click(object sender, EventArgs e)
        {
            int minimum = 123456789;
            for (int i = 0; i < DataGridViewProviders_SAS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(DataGridViewProviders_SAS.Rows[i].Cells[5].Value) < minimum) && (Convert.ToInt32(DataGridViewProviders_SAS.Rows[i].Cells[5].Value) != 0))
                {
                    minimum = Convert.ToInt32(DataGridViewProviders_SAS.Rows[i].Cells[5].Value);
                }
            }
            TextBoxMinProviders_SAS.Text = minimum.ToString();
        }
        private void iconButtonMax_SAS_Click(object sender, EventArgs e)
        {
            int maximum = 0;
            for (int i = 0; i < DataGridViewProviders_SAS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(DataGridViewProviders_SAS.Rows[i].Cells[5].Value) > maximum) && (Convert.ToInt32(DataGridViewProviders_SAS.Rows[i].Cells[5].Value) != 0))
                {
                    maximum = Convert.ToInt32(DataGridViewProviders_SAS.Rows[i].Cells[5].Value);
                }
            }
            TextBoxMaxProviders_SAS.Text = maximum.ToString();
        }
        private void iconButtonMinEmployees_SAS_Click(object sender, EventArgs e)
        {
            int minimum = 123456789;
            for (int i = 0; i < DataGridViewEmployees_SAS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(DataGridViewEmployees_SAS.Rows[i].Cells[5].Value) < minimum)&&(Convert.ToInt32(DataGridViewEmployees_SAS.Rows[i].Cells[5].Value) != 0 ))
                {
                    minimum = Convert.ToInt32(DataGridViewEmployees_SAS.Rows[i].Cells[5].Value);
                }
            }
            TextBoxMinEmployees_SAS.Text = minimum.ToString();
        }
        private void iconButtonMaxEmployees_SAS_Click(object sender, EventArgs e)
        {
            int maximum = 0;
            for (int i = 0; i < DataGridViewEmployees_SAS.Rows.Count; i++)
            {
                if ((Convert.ToInt32(DataGridViewEmployees_SAS.Rows[i].Cells[5].Value) > maximum) && (Convert.ToInt32(DataGridViewEmployees_SAS.Rows[i].Cells[5].Value) != 0))
                {
                    maximum = Convert.ToInt32(DataGridViewEmployees_SAS.Rows[i].Cells[5].Value);
                }
            }
            TextBoxMaxEmployees_SAS.Text = maximum.ToString();
        }
    }
}
