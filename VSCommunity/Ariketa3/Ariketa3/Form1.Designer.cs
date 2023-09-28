namespace Ariketa3
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
            labelNAN = new Label();
            labelIzena = new Label();
            labelAbizena = new Label();
            labelEmail = new Label();
            textBoxNAN = new TextBox();
            textBoxIzena = new TextBox();
            textBoxAbizena = new TextBox();
            textBoxEmail = new TextBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // labelNAN
            // 
            labelNAN.AutoSize = true;
            labelNAN.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelNAN.Location = new Point(33, 44);
            labelNAN.Name = "labelNAN";
            labelNAN.Size = new Size(63, 28);
            labelNAN.TabIndex = 0;
            labelNAN.Text = "NAN:";
            labelNAN.Click += label1_Click;
            // 
            // labelIzena
            // 
            labelIzena.AutoSize = true;
            labelIzena.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelIzena.Location = new Point(33, 85);
            labelIzena.Name = "labelIzena";
            labelIzena.Size = new Size(67, 28);
            labelIzena.TabIndex = 1;
            labelIzena.Text = "Izena:";
            labelIzena.Click += label2_Click;
            // 
            // labelAbizena
            // 
            labelAbizena.AutoSize = true;
            labelAbizena.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbizena.Location = new Point(33, 134);
            labelAbizena.Name = "labelAbizena";
            labelAbizena.Size = new Size(93, 28);
            labelAbizena.TabIndex = 2;
            labelAbizena.Text = "Abizena:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(33, 178);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(69, 28);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email:";
            // 
            // textBoxNAN
            // 
            textBoxNAN.Location = new Point(137, 49);
            textBoxNAN.Name = "textBoxNAN";
            textBoxNAN.Size = new Size(150, 23);
            textBoxNAN.TabIndex = 4;
            // 
            // textBoxIzena
            // 
            textBoxIzena.Location = new Point(137, 90);
            textBoxIzena.Name = "textBoxIzena";
            textBoxIzena.Size = new Size(209, 23);
            textBoxIzena.TabIndex = 5;
            // 
            // textBoxAbizena
            // 
            textBoxAbizena.Location = new Point(137, 139);
            textBoxAbizena.Name = "textBoxAbizena";
            textBoxAbizena.Size = new Size(209, 23);
            textBoxAbizena.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(137, 183);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(209, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(487, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 235);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mota";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 592);
            Controls.Add(groupBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAbizena);
            Controls.Add(textBoxIzena);
            Controls.Add(textBoxNAN);
            Controls.Add(labelEmail);
            Controls.Add(labelAbizena);
            Controls.Add(labelIzena);
            Controls.Add(labelNAN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNAN;
        private Label labelIzena;
        private Label labelAbizena;
        private Label labelEmail;
        private TextBox textBoxNAN;
        private TextBox textBoxIzena;
        private TextBox textBoxAbizena;
        private TextBox textBoxEmail;
        private GroupBox groupBox1;
    }
}