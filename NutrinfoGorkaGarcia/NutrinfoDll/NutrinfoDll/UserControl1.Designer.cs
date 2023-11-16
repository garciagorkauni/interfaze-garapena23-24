namespace NutrinfoDll
{
    partial class NutrinfoDll
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutrinfoDll));
            this.chartOsagaiak = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelChartTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartOsagaiak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chartOsagaiak
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOsagaiak.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOsagaiak.Legends.Add(legend1);
            this.chartOsagaiak.Location = new System.Drawing.Point(3, 180);
            this.chartOsagaiak.Name = "chartOsagaiak";
            this.chartOsagaiak.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartOsagaiak.Series.Add(series1);
            this.chartOsagaiak.Size = new System.Drawing.Size(544, 367);
            this.chartOsagaiak.TabIndex = 0;
            this.chartOsagaiak.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Purple;
            title1.Name = "Elikagaiaren nutrizio balioen informazioa";
            this.chartOsagaiak.Titles.Add(title1);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.ImageLocation = "System.Drawing.Bitmap";
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(43, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(309, 64);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelChartTitle
            // 
            this.labelChartTitle.AutoSize = true;
            this.labelChartTitle.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartTitle.ForeColor = System.Drawing.Color.Purple;
            this.labelChartTitle.Location = new System.Drawing.Point(26, 114);
            this.labelChartTitle.Name = "labelChartTitle";
            this.labelChartTitle.Size = new System.Drawing.Size(506, 31);
            this.labelChartTitle.TabIndex = 2;
            this.labelChartTitle.Text = "Elikagaiaren nutrizio balioen informazioa";
            // 
            // NutrinfoDll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelChartTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.chartOsagaiak);
            this.Name = "NutrinfoDll";
            this.Size = new System.Drawing.Size(550, 550);
            ((System.ComponentModel.ISupportInitialize)(this.chartOsagaiak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartOsagaiak;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelChartTitle;
    }
}
