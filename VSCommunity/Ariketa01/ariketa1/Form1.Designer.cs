namespace ariketa1
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
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonLotu = new Button();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(347, 185);
            button2.Name = "button2";
            button2.Size = new Size(105, 47);
            button2.TabIndex = 1;
            button2.Text = "Esaldi 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(149, 292);
            button4.Name = "button4";
            button4.Size = new Size(105, 47);
            button4.TabIndex = 2;
            button4.Text = "Esaldi 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button3_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(347, 292);
            button5.Name = "button5";
            button5.Size = new Size(105, 47);
            button5.TabIndex = 3;
            button5.Text = "Esaldi 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button4_Click;
            // 
            // buttonLotu
            // 
            buttonLotu.Enabled = false;
            buttonLotu.Location = new Point(534, 292);
            buttonLotu.Name = "buttonLotu";
            buttonLotu.Size = new Size(105, 47);
            buttonLotu.TabIndex = 4;
            buttonLotu.Text = "Lotu";
            buttonLotu.UseVisualStyleBackColor = true;
            buttonLotu.Click += button5_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(534, 185);
            button3.Name = "button3";
            button3.Size = new Size(105, 47);
            button3.TabIndex = 5;
            button3.Text = "Esaldi 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(409, 391);
            button7.Name = "button7";
            button7.Size = new Size(365, 47);
            button7.TabIndex = 6;
            button7.Text = "Irten";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(131, 391);
            button8.Name = "button8";
            button8.Size = new Size(249, 47);
            button8.TabIndex = 7;
            button8.Text = "Garbitu";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 101);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(149, 185);
            button1.Name = "button1";
            button1.Size = new Size(105, 47);
            button1.TabIndex = 9;
            button1.Text = "Esaldi 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(buttonLotu);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button4;
        private Button button5;
        private Button buttonLotu;
        private Button button3;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
        private Button button1;
    }
}