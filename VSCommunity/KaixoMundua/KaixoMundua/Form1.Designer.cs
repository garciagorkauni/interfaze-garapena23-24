namespace KaixoMundua
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
            btnKaixo = new Button();
            btnItxi = new Button();
            SuspendLayout();
            // 
            // btnKaixo
            // 
            btnKaixo.BackColor = Color.Yellow;
            btnKaixo.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaixo.Location = new Point(142, 137);
            btnKaixo.Name = "btnKaixo";
            btnKaixo.Size = new Size(150, 55);
            btnKaixo.TabIndex = 0;
            btnKaixo.Text = "Kaixo";
            btnKaixo.UseVisualStyleBackColor = false;
            btnKaixo.Click += btnKaixo_Click;
            // 
            // btnItxi
            // 
            btnItxi.BackColor = Color.Yellow;
            btnItxi.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnItxi.Location = new Point(501, 137);
            btnItxi.Name = "btnItxi";
            btnItxi.Size = new Size(150, 55);
            btnItxi.TabIndex = 2;
            btnItxi.Text = "Itxi";
            btnItxi.UseVisualStyleBackColor = false;
            btnItxi.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnItxi);
            Controls.Add(btnKaixo);
            ForeColor = Color.FromArgb(0, 0, 192);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKaixo;
        private Button btnItxi;
    }
}