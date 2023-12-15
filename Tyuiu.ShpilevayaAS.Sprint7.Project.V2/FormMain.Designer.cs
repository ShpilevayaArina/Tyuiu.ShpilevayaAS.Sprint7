
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BorderlessForm_SAS = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBoxLogo_SAS = new System.Windows.Forms.PictureBox();
            this.labelLogo_SAS = new System.Windows.Forms.Label();
            this.tabListOfSections_SAS = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageMainMenu_SAS = new System.Windows.Forms.TabPage();
            this.tabPageDepartments_SAS = new System.Windows.Forms.TabPage();
            this.tabPageEmployees_SAS = new System.Windows.Forms.TabPage();
            this.guna2ButtonInfo_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonHelp_SAS = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClose_SAS = new System.Windows.Forms.Button();
            this.buttonMinimize_SAS = new System.Windows.Forms.Button();
            this.buttonChange_SAS = new System.Windows.Forms.Button();
            this.tabPageProviders_SAS = new System.Windows.Forms.TabPage();
            this.toolTipButton_SAS = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxMainMenu_SAS = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_SAS)).BeginInit();
            this.tabListOfSections_SAS.SuspendLayout();
            this.tabPageMainMenu_SAS.SuspendLayout();
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
            // tabPageDepartments_SAS
            // 
            this.tabPageDepartments_SAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabPageDepartments_SAS.Location = new System.Drawing.Point(184, 4);
            this.tabPageDepartments_SAS.Name = "tabPageDepartments_SAS";
            this.tabPageDepartments_SAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartments_SAS.Size = new System.Drawing.Size(969, 613);
            this.tabPageDepartments_SAS.TabIndex = 1;
            this.tabPageDepartments_SAS.Text = "Филиалы";
            // 
            // tabPageEmployees_SAS
            // 
            this.tabPageEmployees_SAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabPageEmployees_SAS.Location = new System.Drawing.Point(184, 4);
            this.tabPageEmployees_SAS.Name = "tabPageEmployees_SAS";
            this.tabPageEmployees_SAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees_SAS.Size = new System.Drawing.Size(969, 613);
            this.tabPageEmployees_SAS.TabIndex = 2;
            this.tabPageEmployees_SAS.Text = "Сотрудники";
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
            this.buttonChange_SAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonChange_SAS.Image")));
            this.buttonChange_SAS.Location = new System.Drawing.Point(1046, 12);
            this.buttonChange_SAS.Name = "buttonChange_SAS";
            this.buttonChange_SAS.Size = new System.Drawing.Size(52, 45);
            this.buttonChange_SAS.TabIndex = 6;
            this.buttonChange_SAS.UseVisualStyleBackColor = true;
            this.buttonChange_SAS.Click += new System.EventHandler(this.buttonChange_SAS_Click);
            // 
            // tabPageProviders_SAS
            // 
            this.tabPageProviders_SAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.tabPageProviders_SAS.Location = new System.Drawing.Point(184, 4);
            this.tabPageProviders_SAS.Name = "tabPageProviders_SAS";
            this.tabPageProviders_SAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProviders_SAS.Size = new System.Drawing.Size(969, 613);
            this.tabPageProviders_SAS.TabIndex = 3;
            this.tabPageProviders_SAS.Text = "Поставщики";
            // 
            // toolTipButton_SAS
            // 
            this.toolTipButton_SAS.IsBalloon = true;
            this.toolTipButton_SAS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SAS.ToolTipTitle = "Подсказка";
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
    }
}

