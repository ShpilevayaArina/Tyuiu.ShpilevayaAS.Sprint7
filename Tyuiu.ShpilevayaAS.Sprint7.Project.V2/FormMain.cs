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
        private void FormMain_Load(object sender, EventArgs e)
        {

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

        //private void guna2CircleButton1_Click(object sender, EventArgs e)
        //{    this.Close();}
    }
}
