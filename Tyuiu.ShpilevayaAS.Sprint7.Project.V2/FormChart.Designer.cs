
namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDepartments_SAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClose_SAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartments_SAS)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDepartments_SAS
            // 
            this.chartDepartments_SAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDepartments_SAS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDepartments_SAS.Legends.Add(legend1);
            this.chartDepartments_SAS.Location = new System.Drawing.Point(13, 13);
            this.chartDepartments_SAS.Name = "chartDepartments_SAS";
            this.chartDepartments_SAS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDepartments_SAS.Series.Add(series1);
            this.chartDepartments_SAS.Size = new System.Drawing.Size(775, 380);
            this.chartDepartments_SAS.TabIndex = 0;
            this.chartDepartments_SAS.Text = "chart1";
            // 
            // buttonClose_SAS
            // 
            this.buttonClose_SAS.Location = new System.Drawing.Point(677, 399);
            this.buttonClose_SAS.MaximumSize = new System.Drawing.Size(111, 42);
            this.buttonClose_SAS.MinimumSize = new System.Drawing.Size(111, 42);
            this.buttonClose_SAS.Name = "buttonClose_SAS";
            this.buttonClose_SAS.Size = new System.Drawing.Size(111, 42);
            this.buttonClose_SAS.TabIndex = 9;
            this.buttonClose_SAS.Text = "Ок";
            this.buttonClose_SAS.UseVisualStyleBackColor = true;
            this.buttonClose_SAS.Click += new System.EventHandler(this.buttonClose_SAS_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose_SAS);
            this.Controls.Add(this.chartDepartments_SAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика открытых филиалов";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartments_SAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartments_SAS;
        private System.Windows.Forms.Button buttonClose_SAS;
    }
}