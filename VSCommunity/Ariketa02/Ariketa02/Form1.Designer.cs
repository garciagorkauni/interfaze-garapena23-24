namespace Ariketa02
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
            textBox = new TextBox();
            buttonHurrengoa = new Button();
            labelZenbakia = new Label();
            buttonGarbitu = new Button();
            buttonIrten = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(199, 104);
            textBox.Name = "textBox";
            textBox.Size = new Size(325, 39);
            textBox.TabIndex = 0;
            // 
            // buttonHurrengoa
            // 
            buttonHurrengoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHurrengoa.Location = new Point(65, 239);
            buttonHurrengoa.Name = "buttonHurrengoa";
            buttonHurrengoa.Size = new Size(108, 37);
            buttonHurrengoa.TabIndex = 1;
            buttonHurrengoa.Text = "Hurrengoa";
            buttonHurrengoa.UseVisualStyleBackColor = true;
            // 
            // labelZenbakia
            // 
            labelZenbakia.AutoSize = true;
            labelZenbakia.BackColor = SystemColors.MenuHighlight;
            labelZenbakia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelZenbakia.Location = new Point(33, 107);
            labelZenbakia.Name = "labelZenbakia";
            labelZenbakia.Size = new Size(140, 32);
            labelZenbakia.TabIndex = 4;
            labelZenbakia.Text = "1. zenbakia ";
            // 
            // buttonGarbitu
            // 
            buttonGarbitu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGarbitu.Location = new Point(220, 239);
            buttonGarbitu.Name = "buttonGarbitu";
            buttonGarbitu.Size = new Size(108, 37);
            buttonGarbitu.TabIndex = 5;
            buttonGarbitu.Text = "Garbitu";
            buttonGarbitu.UseVisualStyleBackColor = true;
            // 
            // buttonIrten
            // 
            buttonIrten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIrten.Location = new Point(382, 239);
            buttonIrten.Name = "buttonIrten";
            buttonIrten.Size = new Size(108, 37);
            buttonIrten.TabIndex = 6;
            buttonIrten.Text = "Irten";
            buttonIrten.UseVisualStyleBackColor = true;
            buttonIrten.Click += buttonIrten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 343);
            Controls.Add(buttonIrten);
            Controls.Add(buttonGarbitu);
            Controls.Add(labelZenbakia);
            Controls.Add(buttonHurrengoa);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "te";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button buttonHurrengoa;
        private Label labelZenbakia;
        private Button buttonGarbitu;
        private Button buttonIrten;
    }
}