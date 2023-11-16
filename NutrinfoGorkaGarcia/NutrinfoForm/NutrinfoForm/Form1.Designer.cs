namespace NutrinfoForm
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonInfoBistaratu = new System.Windows.Forms.Button();
            this.nutrinfoDll = new NutrinfoDll.NutrinfoDll();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(120, 207);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(340, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonInfoBistaratu
            // 
            this.buttonInfoBistaratu.BackColor = System.Drawing.Color.Purple;
            this.buttonInfoBistaratu.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfoBistaratu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInfoBistaratu.Location = new System.Drawing.Point(162, 406);
            this.buttonInfoBistaratu.Name = "buttonInfoBistaratu";
            this.buttonInfoBistaratu.Size = new System.Drawing.Size(248, 48);
            this.buttonInfoBistaratu.TabIndex = 1;
            this.buttonInfoBistaratu.Text = "Informazioa Bistaratu";
            this.buttonInfoBistaratu.UseVisualStyleBackColor = false;
            this.buttonInfoBistaratu.Click += new System.EventHandler(this.buttonInfoBistaratu_Click);
            // 
            // nutrinfoDll
            // 
            this.nutrinfoDll.BackColor = System.Drawing.Color.White;
            this.nutrinfoDll.Location = new System.Drawing.Point(566, 24);
            this.nutrinfoDll.Name = "nutrinfoDll";
            this.nutrinfoDll.Size = new System.Drawing.Size(550, 550);
            this.nutrinfoDll.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELIKAGAIEN ZERRENDA OSOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(85, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aukeratu kontsultatu nahi duzuna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nutrinfoDll);
            this.Controls.Add(this.buttonInfoBistaratu);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonInfoBistaratu;
        private NutrinfoDll.NutrinfoDll nutrinfoDll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

