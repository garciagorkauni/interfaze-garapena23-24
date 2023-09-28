namespace Ariketa02_Array
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
            btnGarbitu = new Button();
            btIrten = new Button();
            btnHurrengoa = new Button();
            tbEmaitza = new TextBox();
            lbZenbakia = new Label();
            SuspendLayout();
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(360, 168);
            btnGarbitu.Margin = new Padding(3, 2, 3, 2);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(82, 22);
            btnGarbitu.TabIndex = 9;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btIrten
            // 
            btIrten.Location = new Point(529, 168);
            btIrten.Margin = new Padding(3, 2, 3, 2);
            btIrten.Name = "btIrten";
            btIrten.Size = new Size(82, 22);
            btIrten.TabIndex = 8;
            btIrten.Text = "Irten";
            btIrten.UseVisualStyleBackColor = true;
            btIrten.Click += btIrten_Click;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(184, 168);
            btnHurrengoa.Margin = new Padding(3, 2, 3, 2);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(82, 22);
            btnHurrengoa.TabIndex = 7;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // tbEmaitza
            // 
            tbEmaitza.Location = new Point(245, 96);
            tbEmaitza.Margin = new Padding(3, 2, 3, 2);
            tbEmaitza.Name = "tbEmaitza";
            tbEmaitza.Size = new Size(402, 23);
            tbEmaitza.TabIndex = 6;
            // 
            // lbZenbakia
            // 
            lbZenbakia.AutoSize = true;
            lbZenbakia.BackColor = Color.Blue;
            lbZenbakia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbZenbakia.ForeColor = Color.Yellow;
            lbZenbakia.Location = new Point(138, 96);
            lbZenbakia.Name = "lbZenbakia";
            lbZenbakia.Size = new Size(94, 21);
            lbZenbakia.TabIndex = 5;
            lbZenbakia.Text = "Zenbakia 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 295);
            Controls.Add(btnGarbitu);
            Controls.Add(btIrten);
            Controls.Add(btnHurrengoa);
            Controls.Add(tbEmaitza);
            Controls.Add(lbZenbakia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGarbitu;
        private Button btIrten;
        private Button btnHurrengoa;
        private TextBox tbEmaitza;
        private Label lbZenbakia;
    }
}