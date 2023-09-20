namespace Oinarrizko_kalkulagailua
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbZenbaki1 = new TextBox();
            tbZenbaki2 = new TextBox();
            btnGehiketa = new Button();
            btnZatiketa = new Button();
            btnKenketa = new Button();
            btnBiderketa = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbZenbaki1
            // 
            tbZenbaki1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbZenbaki1.Location = new Point(165, 78);
            tbZenbaki1.Name = "tbZenbaki1";
            tbZenbaki1.Size = new Size(125, 38);
            tbZenbaki1.TabIndex = 0;
            tbZenbaki1.TextChanged += tbZenbaki1_TextChanged;
            // 
            // tbZenbaki2
            // 
            tbZenbaki2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbZenbaki2.Location = new Point(536, 78);
            tbZenbaki2.Name = "tbZenbaki2";
            tbZenbaki2.Size = new Size(125, 38);
            tbZenbaki2.TabIndex = 1;
            tbZenbaki2.TextChanged += tbZenbaki2_TextChanged;
            // 
            // btnGehiketa
            // 
            btnGehiketa.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGehiketa.Location = new Point(276, 186);
            btnGehiketa.Name = "btnGehiketa";
            btnGehiketa.Size = new Size(94, 90);
            btnGehiketa.TabIndex = 2;
            btnGehiketa.Text = "+";
            btnGehiketa.UseVisualStyleBackColor = true;
            btnGehiketa.Click += btnGehiketa_Click;
            // 
            // btnZatiketa
            // 
            btnZatiketa.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnZatiketa.Location = new Point(453, 314);
            btnZatiketa.Name = "btnZatiketa";
            btnZatiketa.Size = new Size(94, 90);
            btnZatiketa.TabIndex = 3;
            btnZatiketa.Text = "/";
            btnZatiketa.UseVisualStyleBackColor = true;
            btnZatiketa.Click += btnZatiketa_Click;
            // 
            // btnKenketa
            // 
            btnKenketa.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKenketa.Location = new Point(453, 186);
            btnKenketa.Name = "btnKenketa";
            btnKenketa.Size = new Size(94, 90);
            btnKenketa.TabIndex = 4;
            btnKenketa.Text = "-";
            btnKenketa.UseVisualStyleBackColor = true;
            btnKenketa.Click += btnKenketa_Click;
            // 
            // btnBiderketa
            // 
            btnBiderketa.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBiderketa.Location = new Point(276, 314);
            btnBiderketa.Name = "btnBiderketa";
            btnBiderketa.Size = new Size(94, 90);
            btnBiderketa.TabIndex = 5;
            btnBiderketa.Text = "x";
            btnBiderketa.UseVisualStyleBackColor = true;
            btnBiderketa.Click += btnBiderketa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 45);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 6;
            label1.Text = "Zenbaki bat sartu:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(395, 45);
            label2.Name = "label2";
            label2.Size = new Size(217, 25);
            label2.TabIndex = 7;
            label2.Text = "Beste zenbaki bat sartu:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBiderketa);
            Controls.Add(btnKenketa);
            Controls.Add(btnZatiketa);
            Controls.Add(btnGehiketa);
            Controls.Add(tbZenbaki2);
            Controls.Add(tbZenbaki1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbZenbaki1;
        private TextBox tbZenbaki2;
        private Button btnGehiketa;
        private Button btnZatiketa;
        private Button btnKenketa;
        private Button btnBiderketa;
        private Label label1;
        private Label label2;
    }
}