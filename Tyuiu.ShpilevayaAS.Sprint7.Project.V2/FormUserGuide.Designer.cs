
namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2
{
    partial class FormUserGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserGuide));
            this.buttonClose_SAS = new System.Windows.Forms.Button();
            this.pictureBoxLogo_SAS = new System.Windows.Forms.PictureBox();
            this.labelLogo_SAS = new System.Windows.Forms.Label();
            this.textBoxGuide_SAS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose_SAS
            // 
            this.buttonClose_SAS.Location = new System.Drawing.Point(692, 415);
            this.buttonClose_SAS.Name = "buttonClose_SAS";
            this.buttonClose_SAS.Size = new System.Drawing.Size(96, 23);
            this.buttonClose_SAS.TabIndex = 0;
            this.buttonClose_SAS.Text = "Ок";
            this.buttonClose_SAS.UseVisualStyleBackColor = true;
            this.buttonClose_SAS.Click += new System.EventHandler(this.buttonClose_SAS_Click);
            // 
            // pictureBoxLogo_SAS
            // 
            this.pictureBoxLogo_SAS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo_SAS.Image")));
            this.pictureBoxLogo_SAS.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLogo_SAS.Name = "pictureBoxLogo_SAS";
            this.pictureBoxLogo_SAS.Size = new System.Drawing.Size(126, 94);
            this.pictureBoxLogo_SAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo_SAS.TabIndex = 1;
            this.pictureBoxLogo_SAS.TabStop = false;
            // 
            // labelLogo_SAS
            // 
            this.labelLogo_SAS.AutoSize = true;
            this.labelLogo_SAS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo_SAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.labelLogo_SAS.Location = new System.Drawing.Point(134, 68);
            this.labelLogo_SAS.Name = "labelLogo_SAS";
            this.labelLogo_SAS.Size = new System.Drawing.Size(454, 28);
            this.labelLogo_SAS.TabIndex = 2;
            this.labelLogo_SAS.Text = "корпоративное приложение сети магазинов";
            // 
            // textBoxGuide_SAS
            // 
            this.textBoxGuide_SAS.Location = new System.Drawing.Point(13, 103);
            this.textBoxGuide_SAS.Multiline = true;
            this.textBoxGuide_SAS.Name = "textBoxGuide_SAS";
            this.textBoxGuide_SAS.ReadOnly = true;
            this.textBoxGuide_SAS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGuide_SAS.Size = new System.Drawing.Size(775, 306);
            this.textBoxGuide_SAS.TabIndex = 3;
            this.textBoxGuide_SAS.Text = resources.GetString("textBoxGuide_SAS.Text");
            // 
            // FormUserGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxGuide_SAS);
            this.Controls.Add(this.labelLogo_SAS);
            this.Controls.Add(this.pictureBoxLogo_SAS);
            this.Controls.Add(this.buttonClose_SAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое руководство пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_SAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_SAS;
        private System.Windows.Forms.PictureBox pictureBoxLogo_SAS;
        private System.Windows.Forms.Label labelLogo_SAS;
        private System.Windows.Forms.TextBox textBoxGuide_SAS;
    }
}