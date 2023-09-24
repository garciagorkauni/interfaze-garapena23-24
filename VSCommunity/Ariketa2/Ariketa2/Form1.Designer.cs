namespace Ariketa2
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
            lbZenbakia = new Label();
            tbEmaitza = new TextBox();
            btnHurrengoa = new Button();
            btIrten = new Button();
            btnGarbitu = new Button();
            SuspendLayout();
            // 
            // lbZenbakia
            // 
            lbZenbakia.AutoSize = true;
            lbZenbakia.BackColor = Color.Blue;
            lbZenbakia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbZenbakia.ForeColor = Color.Yellow;
            lbZenbakia.Location = new Point(102, 70);
            lbZenbakia.Name = "lbZenbakia";
            lbZenbakia.Size = new Size(116, 28);
            lbZenbakia.TabIndex = 0;
            lbZenbakia.Text = "Zenbakia 1";
            lbZenbakia.Click += lbZenbakia_Click;
            // 
            // tbEmaitza
            // 
            tbEmaitza.Location = new Point(224, 70);
            tbEmaitza.Name = "tbEmaitza";
            tbEmaitza.Size = new Size(459, 27);
            tbEmaitza.TabIndex = 1;
            tbEmaitza.TextChanged += tbEmaitza_TextChanged;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(154, 165);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(94, 29);
            btnHurrengoa.TabIndex = 2;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btIrten
            // 
            btIrten.Location = new Point(549, 165);
            btIrten.Name = "btIrten";
            btIrten.Size = new Size(94, 29);
            btIrten.TabIndex = 3;
            btIrten.Text = "Irten";
            btIrten.UseVisualStyleBackColor = true;
            btIrten.Click += btIrten_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(355, 165);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(94, 29);
            btnGarbitu.TabIndex = 4;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 261);
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

        private Label lbZenbakia;
        private TextBox tbEmaitza;
        private Button btnHurrengoa;
        private Button btIrten;
        private Button btnGarbitu;
    }
}