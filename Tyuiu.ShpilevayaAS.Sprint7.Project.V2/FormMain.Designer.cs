
namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BorderlessForm_SAS = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBoxLogo_SAS = new System.Windows.Forms.PictureBox();
            this.labelLogo_SAS = new System.Windows.Forms.Label();
            this.tabListOfSections_SAS = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageMainMenu_SAS = new System.Windows.Forms.TabPage();
            this.TextBoxMainMenu_SAS = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPageDepartments_SAS = new System.Windows.Forms.TabPage();
            this.ButtonSearchDepartments_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonOpenDepartments_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxSearchDepartments_SAS = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewDepartments_SAS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPageEmployees_SAS = new System.Windows.Forms.TabPage();
            this.ButtonSearchEmpoyees_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonOpenEmployees_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxSearchEmpoyees_SAS = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPageProviders_SAS = new System.Windows.Forms.TabPage();
            this.ButtonSearchProviders_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonOpenProviders_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxSearchProviders_SAS = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonInfo_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonHelp_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClose_SAS = new System.Windows.Forms.Button();
            this.buttonMinimize_SAS = new System.Windows.Forms.Button();
            this.buttonChange_SAS = new System.Windows.Forms.Button();
            this.toolTipButton_SAS = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogChooseData_SAS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_SAS = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_SAS)).BeginInit();
            this.tabListOfSections_SAS.SuspendLayout();
            this.tabPageMainMenu_SAS.SuspendLayout();
            this.tabPageDepartments_SAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartments_SAS)).BeginInit();
            this.tabPageEmployees_SAS.SuspendLayout();
            this.tabPageProviders_SAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm_SAS
            // 
            this.BorderlessForm_SAS.BorderRadius = 30;
            this.BorderlessForm_SAS.ContainerControl = this;
            this.BorderlessForm_SAS.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm_SAS.TransparentWhileDrag = true;
            // 
            // pictureBoxLogo_SAS
            // 
            this.pictureBoxLogo_SAS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo_SAS.Image")));
            this.pictureBoxLogo_SAS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo_SAS.Name = "pictureBoxLogo_SAS";
            this.pictureBoxLogo_SAS.Size = new System.Drawing.Size(60, 53);
            this.pictureBoxLogo_SAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo_SAS.TabIndex = 0;
            this.pictureBoxLogo_SAS.TabStop = false;
            // 
            // labelLogo_SAS
            // 
            this.labelLogo_SAS.AutoSize = true;
            this.labelLogo_SAS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.labelLogo_SAS.Location = new System.Drawing.Point(78, 37);
            this.labelLogo_SAS.Name = "labelLogo_SAS";
            this.labelLogo_SAS.Size = new System.Drawing.Size(454, 28);
            this.labelLogo_SAS.TabIndex = 1;
            this.labelLogo_SAS.Text = "корпоративное приложение сети магазинов";
            // 
            // tabListOfSections_SAS
            // 
            this.tabListOfSections_SAS.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabListOfSections_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabListOfSections_SAS.Controls.Add(this.tabPageMainMenu_SAS);
            this.tabListOfSections_SAS.Controls.Add(this.tabPageDepartments_SAS);
            this.tabListOfSections_SAS.Controls.Add(this.tabPageEmployees_SAS);
            this.tabListOfSections_SAS.Controls.Add(this.tabPageProviders_SAS);
            this.tabListOfSections_SAS.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tabListOfSections_SAS.ItemSize = new System.Drawing.Size(180, 90);
            this.tabListOfSections_SAS.Location = new System.Drawing.Point(0, 112);
            this.tabListOfSections_SAS.Name = "tabListOfSections_SAS";
            this.tabListOfSections_SAS.SelectedIndex = 0;
            this.tabListOfSections_SAS.Size = new System.Drawing.Size(1157, 621);
            this.tabListOfSections_SAS.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabListOfSections_SAS.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabListOfSections_SAS.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabListOfSections_SAS.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabListOfSections_SAS.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabListOfSections_SAS.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabListOfSections_SAS.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabListOfSections_SAS.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabListOfSections_SAS.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabListOfSections_SAS.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabListOfSections_SAS.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabListOfSections_SAS.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.tabListOfSections_SAS.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabListOfSections_SAS.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabListOfSections_SAS.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.tabListOfSections_SAS.TabButtonSize = new System.Drawing.Size(180, 90);
            this.tabListOfSections_SAS.TabIndex = 2;
            this.tabListOfSections_SAS.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            // 
            // tabPageMainMenu_SAS
            // 
            this.tabPageMainMenu_SAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabPageMainMenu_SAS.Controls.Add(this.TextBoxMainMenu_SAS);
            this.tabPageMainMenu_SAS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageMainMenu_SAS.Location = new System.Drawing.Point(184, 4);
            this.tabPageMainMenu_SAS.Name = "tabPageMainMenu_SAS";
            this.tabPageMainMenu_SAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainMenu_SAS.Size = new System.Drawing.Size(969, 613);
            this.tabPageMainMenu_SAS.TabIndex = 0;
            this.tabPageMainMenu_SAS.Text = "Главное меню";
            // 
            // TextBoxMainMenu_SAS
            // 
            this.TextBoxMainMenu_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMainMenu_SAS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.TextBoxMainMenu_SAS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxMainMenu_SAS.DefaultText = resources.GetString("TextBoxMainMenu_SAS.DefaultText");
            this.TextBoxMainMenu_SAS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxMainMenu_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxMainMenu_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMainMenu_SAS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMainMenu_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.TextBoxMainMenu_SAS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxMainMenu_SAS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMainMenu_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.TextBoxMainMenu_SAS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxMainMenu_SAS.Location = new System.Drawing.Point(8, 9);
            this.TextBoxMainMenu_SAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxMainMenu_SAS.Multiline = true;
            this.TextBoxMainMenu_SAS.Name = "TextBoxMainMenu_SAS";
            this.TextBoxMainMenu_SAS.PasswordChar = '\0';
            this.TextBoxMainMenu_SAS.PlaceholderText = "";
            this.TextBoxMainMenu_SAS.ReadOnly = true;
            this.TextBoxMainMenu_SAS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMainMenu_SAS.SelectedText = "";
            this.TextBoxMainMenu_SAS.Size = new System.Drawing.Size(955, 597);
            this.TextBoxMainMenu_SAS.TabIndex = 0;
            // 
            // tabPageDepartments_SAS
            // 
            this.tabPageDepartments_SAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabPageDepartments_SAS.Controls.Add(this.ButtonSearchDepartments_SAS);
            this.tabPageDepartments_SAS.Controls.Add(this.ButtonOpenDepartments_SAS);
            this.tabPageDepartments_SAS.Controls.Add(this.TextBoxSearchDepartments_SAS);
            this.tabPageDepartments_SAS.Controls.Add(this.DataGridViewDepartments_SAS);
            this.tabPageDepartments_SAS.Location = new System.Drawing.Point(184, 4);
            this.tabPageDepartments_SAS.Name = "tabPageDepartments_SAS";
            this.tabPageDepartments_SAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartments_SAS.Size = new System.Drawing.Size(969, 613);
            this.tabPageDepartments_SAS.TabIndex = 1;
            this.tabPageDepartments_SAS.Text = "Филиалы";
            // 
            // ButtonSearchDepartments_SAS
            // 
            this.ButtonSearchDepartments_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearchDepartments_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearchDepartments_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSearchDepartments_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSearchDepartments_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ButtonSearchDepartments_SAS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearchDepartments_SAS.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchDepartments_SAS.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearchDepartments_SAS.Image")));
            this.ButtonSearchDepartments_SAS.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonSearchDepartments_SAS.Location = new System.Drawing.Point(6, 7);
            this.ButtonSearchDepartments_SAS.Name = "ButtonSearchDepartments_SAS";
            this.ButtonSearchDepartments_SAS.Size = new System.Drawing.Size(57, 45);
            this.ButtonSearchDepartments_SAS.TabIndex = 6;
            this.toolTipButton_SAS.SetToolTip(this.ButtonSearchDepartments_SAS, "Найти филиал по городу, в котором он расположен\r\n");
            this.ButtonSearchDepartments_SAS.Click += new System.EventHandler(this.ButtonSearchDepartments_SAS_Click);
            this.ButtonSearchDepartments_SAS.MouseEnter += new System.EventHandler(this.ButtonSearchDepartments_SAS_MouseEnter);
            // 
            // ButtonOpenDepartments_SAS
            // 
            this.ButtonOpenDepartments_SAS.BorderRadius = 10;
            this.ButtonOpenDepartments_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenDepartments_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenDepartments_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOpenDepartments_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOpenDepartments_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.ButtonOpenDepartments_SAS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonOpenDepartments_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ButtonOpenDepartments_SAS.Location = new System.Drawing.Point(452, 7);
            this.ButtonOpenDepartments_SAS.Name = "ButtonOpenDepartments_SAS";
            this.ButtonOpenDepartments_SAS.Size = new System.Drawing.Size(170, 43);
            this.ButtonOpenDepartments_SAS.TabIndex = 5;
            this.ButtonOpenDepartments_SAS.Text = "Открыть файл";
            this.ButtonOpenDepartments_SAS.Click += new System.EventHandler(this.ButtonOpenDepartments_SAS_Click);
            // 
            // TextBoxSearchDepartments_SAS
            // 
            this.TextBoxSearchDepartments_SAS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchDepartments_SAS.BorderRadius = 10;
            this.TextBoxSearchDepartments_SAS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearchDepartments_SAS.DefaultText = "";
            this.TextBoxSearchDepartments_SAS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearchDepartments_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearchDepartments_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearchDepartments_SAS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearchDepartments_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchDepartments_SAS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearchDepartments_SAS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearchDepartments_SAS.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSearchDepartments_SAS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearchDepartments_SAS.Location = new System.Drawing.Point(69, 7);
            this.TextBoxSearchDepartments_SAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearchDepartments_SAS.Name = "TextBoxSearchDepartments_SAS";
            this.TextBoxSearchDepartments_SAS.PasswordChar = '\0';
            this.TextBoxSearchDepartments_SAS.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchDepartments_SAS.PlaceholderText = "";
            this.TextBoxSearchDepartments_SAS.SelectedText = "";
            this.TextBoxSearchDepartments_SAS.Size = new System.Drawing.Size(350, 43);
            this.TextBoxSearchDepartments_SAS.TabIndex = 4;
            // 
            // DataGridViewDepartments_SAS
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.DataGridViewDepartments_SAS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.DataGridViewDepartments_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewDepartments_SAS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDepartments_SAS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.DataGridViewDepartments_SAS.ColumnHeadersHeight = 35;
            this.DataGridViewDepartments_SAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDepartments_SAS.DefaultCellStyle = dataGridViewCellStyle30;
            this.DataGridViewDepartments_SAS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.DataGridViewDepartments_SAS.Location = new System.Drawing.Point(69, 60);
            this.DataGridViewDepartments_SAS.Name = "DataGridViewDepartments_SAS";
            this.DataGridViewDepartments_SAS.ReadOnly = true;
            this.DataGridViewDepartments_SAS.RowHeadersVisible = false;
            this.DataGridViewDepartments_SAS.RowHeadersWidth = 51;
            this.DataGridViewDepartments_SAS.RowTemplate.Height = 24;
            this.DataGridViewDepartments_SAS.Size = new System.Drawing.Size(892, 545);
            this.DataGridViewDepartments_SAS.TabIndex = 3;
            this.DataGridViewDepartments_SAS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewDepartments_SAS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewDepartments_SAS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.DataGridViewDepartments_SAS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewDepartments_SAS.ThemeStyle.HeaderStyle.Height = 35;
            this.DataGridViewDepartments_SAS.ThemeStyle.ReadOnly = true;
            this.DataGridViewDepartments_SAS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDepartments_SAS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.DataGridViewDepartments_SAS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewDepartments_SAS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.DataGridViewDepartments_SAS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            // 
            // tabPageEmployees_SAS
            // 
            this.tabPageEmployees_SAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabPageEmployees_SAS.Controls.Add(this.ButtonSearchEmpoyees_SAS);
            this.tabPageEmployees_SAS.Controls.Add(this.ButtonOpenEmployees_SAS);
            this.tabPageEmployees_SAS.Controls.Add(this.TextBoxSearchEmpoyees_SAS);
            this.tabPageEmployees_SAS.Location = new System.Drawing.Point(184, 4);
            this.tabPageEmployees_SAS.Name = "tabPageEmployees_SAS";
            this.tabPageEmployees_SAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees_SAS.Size = new System.Drawing.Size(969, 613);
            this.tabPageEmployees_SAS.TabIndex = 2;
            this.tabPageEmployees_SAS.Text = "Сотрудники";
            // 
            // ButtonSearchEmpoyees_SAS
            // 
            this.ButtonSearchEmpoyees_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearchEmpoyees_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearchEmpoyees_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSearchEmpoyees_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSearchEmpoyees_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ButtonSearchEmpoyees_SAS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearchEmpoyees_SAS.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchEmpoyees_SAS.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearchEmpoyees_SAS.Image")));
            this.ButtonSearchEmpoyees_SAS.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonSearchEmpoyees_SAS.Location = new System.Drawing.Point(6, 7);
            this.ButtonSearchEmpoyees_SAS.Name = "ButtonSearchEmpoyees_SAS";
            this.ButtonSearchEmpoyees_SAS.Size = new System.Drawing.Size(57, 45);
            this.ButtonSearchEmpoyees_SAS.TabIndex = 7;
            this.toolTipButton_SAS.SetToolTip(this.ButtonSearchEmpoyees_SAS, "Найти сотрудника по ФИО\r\n");
            this.ButtonSearchEmpoyees_SAS.MouseEnter += new System.EventHandler(this.ButtonSearchDepartments_SAS_MouseEnter);
            // 
            // ButtonOpenEmployees_SAS
            // 
            this.ButtonOpenEmployees_SAS.BorderRadius = 10;
            this.ButtonOpenEmployees_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenEmployees_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenEmployees_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOpenEmployees_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOpenEmployees_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.ButtonOpenEmployees_SAS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonOpenEmployees_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ButtonOpenEmployees_SAS.Location = new System.Drawing.Point(452, 7);
            this.ButtonOpenEmployees_SAS.Name = "ButtonOpenEmployees_SAS";
            this.ButtonOpenEmployees_SAS.Size = new System.Drawing.Size(170, 43);
            this.ButtonOpenEmployees_SAS.TabIndex = 6;
            this.ButtonOpenEmployees_SAS.Text = "Открыть файл";
            // 
            // TextBoxSearchEmpoyees_SAS
            // 
            this.TextBoxSearchEmpoyees_SAS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchEmpoyees_SAS.BorderRadius = 10;
            this.TextBoxSearchEmpoyees_SAS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearchEmpoyees_SAS.DefaultText = "";
            this.TextBoxSearchEmpoyees_SAS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearchEmpoyees_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearchEmpoyees_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearchEmpoyees_SAS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearchEmpoyees_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchEmpoyees_SAS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearchEmpoyees_SAS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearchEmpoyees_SAS.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSearchEmpoyees_SAS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearchEmpoyees_SAS.Location = new System.Drawing.Point(69, 7);
            this.TextBoxSearchEmpoyees_SAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearchEmpoyees_SAS.Name = "TextBoxSearchEmpoyees_SAS";
            this.TextBoxSearchEmpoyees_SAS.PasswordChar = '\0';
            this.TextBoxSearchEmpoyees_SAS.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchEmpoyees_SAS.PlaceholderText = "";
            this.TextBoxSearchEmpoyees_SAS.SelectedText = "";
            this.TextBoxSearchEmpoyees_SAS.Size = new System.Drawing.Size(350, 43);
            this.TextBoxSearchEmpoyees_SAS.TabIndex = 2;
            // 
            // tabPageProviders_SAS
            // 
            this.tabPageProviders_SAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabPageProviders_SAS.Controls.Add(this.ButtonSearchProviders_SAS);
            this.tabPageProviders_SAS.Controls.Add(this.ButtonOpenProviders_SAS);
            this.tabPageProviders_SAS.Controls.Add(this.TextBoxSearchProviders_SAS);
            this.tabPageProviders_SAS.Location = new System.Drawing.Point(184, 4);
            this.tabPageProviders_SAS.Name = "tabPageProviders_SAS";
            this.tabPageProviders_SAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProviders_SAS.Size = new System.Drawing.Size(969, 613);
            this.tabPageProviders_SAS.TabIndex = 3;
            this.tabPageProviders_SAS.Text = "Поставщики";
            // 
            // ButtonSearchProviders_SAS
            // 
            this.ButtonSearchProviders_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearchProviders_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearchProviders_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSearchProviders_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSearchProviders_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ButtonSearchProviders_SAS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearchProviders_SAS.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchProviders_SAS.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearchProviders_SAS.Image")));
            this.ButtonSearchProviders_SAS.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonSearchProviders_SAS.Location = new System.Drawing.Point(6, 7);
            this.ButtonSearchProviders_SAS.Name = "ButtonSearchProviders_SAS";
            this.ButtonSearchProviders_SAS.Size = new System.Drawing.Size(57, 45);
            this.ButtonSearchProviders_SAS.TabIndex = 7;
            this.toolTipButton_SAS.SetToolTip(this.ButtonSearchProviders_SAS, "Найти поставщика по ФИО");
            this.ButtonSearchProviders_SAS.MouseEnter += new System.EventHandler(this.ButtonSearchDepartments_SAS_MouseEnter);
            // 
            // ButtonOpenProviders_SAS
            // 
            this.ButtonOpenProviders_SAS.BorderRadius = 10;
            this.ButtonOpenProviders_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenProviders_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenProviders_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOpenProviders_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOpenProviders_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(65)))), ((int)(((byte)(210)))));
            this.ButtonOpenProviders_SAS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonOpenProviders_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ButtonOpenProviders_SAS.Location = new System.Drawing.Point(452, 7);
            this.ButtonOpenProviders_SAS.Name = "ButtonOpenProviders_SAS";
            this.ButtonOpenProviders_SAS.Size = new System.Drawing.Size(170, 43);
            this.ButtonOpenProviders_SAS.TabIndex = 6;
            this.ButtonOpenProviders_SAS.Text = "Открыть файл";
            // 
            // TextBoxSearchProviders_SAS
            // 
            this.TextBoxSearchProviders_SAS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchProviders_SAS.BorderRadius = 10;
            this.TextBoxSearchProviders_SAS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearchProviders_SAS.DefaultText = "";
            this.TextBoxSearchProviders_SAS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearchProviders_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearchProviders_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearchProviders_SAS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearchProviders_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchProviders_SAS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearchProviders_SAS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearchProviders_SAS.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSearchProviders_SAS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearchProviders_SAS.Location = new System.Drawing.Point(69, 7);
            this.TextBoxSearchProviders_SAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearchProviders_SAS.Name = "TextBoxSearchProviders_SAS";
            this.TextBoxSearchProviders_SAS.PasswordChar = '\0';
            this.TextBoxSearchProviders_SAS.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.TextBoxSearchProviders_SAS.PlaceholderText = "";
            this.TextBoxSearchProviders_SAS.SelectedText = "";
            this.TextBoxSearchProviders_SAS.Size = new System.Drawing.Size(350, 43);
            this.TextBoxSearchProviders_SAS.TabIndex = 4;
            // 
            // guna2ButtonInfo_SAS
            // 
            this.guna2ButtonInfo_SAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ButtonInfo_SAS.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonInfo_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonInfo_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonInfo_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonInfo_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonInfo_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2ButtonInfo_SAS.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.guna2ButtonInfo_SAS.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonInfo_SAS.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonInfo_SAS.Image")));
            this.guna2ButtonInfo_SAS.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ButtonInfo_SAS.Location = new System.Drawing.Point(785, 20);
            this.guna2ButtonInfo_SAS.Name = "guna2ButtonInfo_SAS";
            this.guna2ButtonInfo_SAS.Size = new System.Drawing.Size(66, 53);
            this.guna2ButtonInfo_SAS.TabIndex = 3;
            this.toolTipButton_SAS.SetToolTip(this.guna2ButtonInfo_SAS, "Сведение о программе");
            this.guna2ButtonInfo_SAS.Click += new System.EventHandler(this.guna2ButtonInfo_SAS_Click);
            this.guna2ButtonInfo_SAS.MouseEnter += new System.EventHandler(this.guna2ButtonInfo_SAS_MouseEnter);
            // 
            // guna2ButtonHelp_SAS
            // 
            this.guna2ButtonHelp_SAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ButtonHelp_SAS.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonHelp_SAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonHelp_SAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonHelp_SAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonHelp_SAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonHelp_SAS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2ButtonHelp_SAS.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.guna2ButtonHelp_SAS.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonHelp_SAS.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonHelp_SAS.Image")));
            this.guna2ButtonHelp_SAS.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ButtonHelp_SAS.Location = new System.Drawing.Point(680, 20);
            this.guna2ButtonHelp_SAS.Name = "guna2ButtonHelp_SAS";
            this.guna2ButtonHelp_SAS.Size = new System.Drawing.Size(66, 53);
            this.guna2ButtonHelp_SAS.TabIndex = 3;
            this.toolTipButton_SAS.SetToolTip(this.guna2ButtonHelp_SAS, "Это руководство поможет вам ознакомиться с основными функциями приложения, которы" +
        "е позволят вам получить информацию о филиалах магазина, руководителях и поставщи" +
        "ках.");
            this.guna2ButtonHelp_SAS.Click += new System.EventHandler(this.guna2ButtonHelp_SAS_Click);
            this.guna2ButtonHelp_SAS.MouseEnter += new System.EventHandler(this.guna2ButtonHelp_SAS_MouseEnter);
            // 
            // buttonClose_SAS
            // 
            this.buttonClose_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.buttonClose_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose_SAS.Image")));
            this.buttonClose_SAS.Location = new System.Drawing.Point(1080, 4);
            this.buttonClose_SAS.Name = "buttonClose_SAS";
            this.buttonClose_SAS.Size = new System.Drawing.Size(73, 61);
            this.buttonClose_SAS.TabIndex = 4;
            this.buttonClose_SAS.UseVisualStyleBackColor = true;
            this.buttonClose_SAS.Click += new System.EventHandler(this.buttonClose_SAS_Click);
            // 
            // buttonMinimize_SAS
            // 
            this.buttonMinimize_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.buttonMinimize_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize_SAS.Image")));
            this.buttonMinimize_SAS.Location = new System.Drawing.Point(994, 12);
            this.buttonMinimize_SAS.Name = "buttonMinimize_SAS";
            this.buttonMinimize_SAS.Size = new System.Drawing.Size(46, 45);
            this.buttonMinimize_SAS.TabIndex = 5;
            this.buttonMinimize_SAS.UseVisualStyleBackColor = true;
            this.buttonMinimize_SAS.Click += new System.EventHandler(this.buttonMinimize_SAS_Click);
            // 
            // buttonChange_SAS
            // 
            this.buttonChange_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChange_SAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.buttonChange_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonChange_SAS.Image")));
            this.buttonChange_SAS.Location = new System.Drawing.Point(1046, 12);
            this.buttonChange_SAS.Name = "buttonChange_SAS";
            this.buttonChange_SAS.Size = new System.Drawing.Size(52, 45);
            this.buttonChange_SAS.TabIndex = 6;
            this.buttonChange_SAS.UseVisualStyleBackColor = true;
            this.buttonChange_SAS.Click += new System.EventHandler(this.buttonChange_SAS_Click);
            // 
            // toolTipButton_SAS
            // 
            this.toolTipButton_SAS.IsBalloon = true;
            this.toolTipButton_SAS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SAS.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogChooseData_SAS
            // 
            this.openFileDialogChooseData_SAS.FileName = "openFileDialogChooseData";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1157, 733);
            this.Controls.Add(this.buttonChange_SAS);
            this.Controls.Add(this.buttonMinimize_SAS);
            this.Controls.Add(this.buttonClose_SAS);
            this.Controls.Add(this.guna2ButtonHelp_SAS);
            this.Controls.Add(this.guna2ButtonInfo_SAS);
            this.Controls.Add(this.tabListOfSections_SAS);
            this.Controls.Add(this.labelLogo_SAS);
            this.Controls.Add(this.pictureBoxLogo_SAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1157, 686);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сеть магазинов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_SAS)).EndInit();
            this.tabListOfSections_SAS.ResumeLayout(false);
            this.tabPageMainMenu_SAS.ResumeLayout(false);
            this.tabPageDepartments_SAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDepartments_SAS)).EndInit();
            this.tabPageEmployees_SAS.ResumeLayout(false);
            this.tabPageProviders_SAS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm_SAS;
        private System.Windows.Forms.Label labelLogo_SAS;
        private System.Windows.Forms.PictureBox pictureBoxLogo_SAS;
        private Guna.UI2.WinForms.Guna2TabControl tabListOfSections_SAS;
        private System.Windows.Forms.TabPage tabPageMainMenu_SAS;
        private System.Windows.Forms.TabPage tabPageDepartments_SAS;
        private System.Windows.Forms.TabPage tabPageEmployees_SAS;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonInfo_SAS;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonHelp_SAS;
        private System.Windows.Forms.Button buttonClose_SAS;
        private System.Windows.Forms.Button buttonMinimize_SAS;
        private System.Windows.Forms.Button buttonChange_SAS;
        private System.Windows.Forms.TabPage tabPageProviders_SAS;
        private System.Windows.Forms.ToolTip toolTipButton_SAS;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxMainMenu_SAS;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearchEmpoyees_SAS;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearchProviders_SAS;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewDepartments_SAS;
        private Guna.UI2.WinForms.Guna2Button ButtonOpenDepartments_SAS;
        private Guna.UI2.WinForms.Guna2Button ButtonOpenEmployees_SAS;
        private Guna.UI2.WinForms.Guna2Button ButtonOpenProviders_SAS;
        private System.Windows.Forms.OpenFileDialog openFileDialogChooseData_SAS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_SAS;
        private Guna.UI2.WinForms.Guna2Button ButtonSearchDepartments_SAS;
        private Guna.UI2.WinForms.Guna2Button ButtonSearchEmpoyees_SAS;
        private Guna.UI2.WinForms.Guna2Button ButtonSearchProviders_SAS;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearchDepartments_SAS;
    }
}

