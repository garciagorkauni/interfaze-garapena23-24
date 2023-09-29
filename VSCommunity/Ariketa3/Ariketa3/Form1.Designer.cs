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
            radioButtonLangilea = new RadioButton();
            radioButtonKontaktua = new RadioButton();
            radioButtonBezeroa = new RadioButton();
            groupBox2 = new GroupBox();
            labelKategoria = new Label();
            comboBoxKategoria = new ComboBox();
            groupBox3 = new GroupBox();
            textBoxSegurtasunSoziala = new TextBox();
            textBoxSoldata = new TextBox();
            labelSoldata = new Label();
            labelSegurtasunSoziala = new Label();
            buttonGorde = new Button();
            buttonIrten = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            groupBox1.Controls.Add(radioButtonLangilea);
            groupBox1.Controls.Add(radioButtonKontaktua);
            groupBox1.Controls.Add(radioButtonBezeroa);
            groupBox1.Location = new Point(487, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 235);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mota";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButtonLangilea
            // 
            radioButtonLangilea.AutoSize = true;
            radioButtonLangilea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonLangilea.Location = new Point(33, 158);
            radioButtonLangilea.Name = "radioButtonLangilea";
            radioButtonLangilea.Size = new Size(86, 25);
            radioButtonLangilea.TabIndex = 11;
            radioButtonLangilea.TabStop = true;
            radioButtonLangilea.Text = "Langilea";
            radioButtonLangilea.UseVisualStyleBackColor = true;
            // 
            // radioButtonKontaktua
            // 
            radioButtonKontaktua.AutoSize = true;
            radioButtonKontaktua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonKontaktua.Location = new Point(33, 57);
            radioButtonKontaktua.Name = "radioButtonKontaktua";
            radioButtonKontaktua.Size = new Size(98, 25);
            radioButtonKontaktua.TabIndex = 9;
            radioButtonKontaktua.TabStop = true;
            radioButtonKontaktua.Text = "Kontaktua";
            radioButtonKontaktua.UseVisualStyleBackColor = true;
            // 
            // radioButtonBezeroa
            // 
            radioButtonBezeroa.AutoSize = true;
            radioButtonBezeroa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBezeroa.Location = new Point(33, 106);
            radioButtonBezeroa.Name = "radioButtonBezeroa";
            radioButtonBezeroa.Size = new Size(83, 25);
            radioButtonBezeroa.TabIndex = 10;
            radioButtonBezeroa.TabStop = true;
            radioButtonBezeroa.Text = "Bezeroa";
            radioButtonBezeroa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelKategoria);
            groupBox2.Controls.Add(comboBoxKategoria);
            groupBox2.Location = new Point(74, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 200);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bezeroa";
            // 
            // labelKategoria
            // 
            labelKategoria.AutoSize = true;
            labelKategoria.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelKategoria.Location = new Point(16, 65);
            labelKategoria.Name = "labelKategoria";
            labelKategoria.Size = new Size(109, 28);
            labelKategoria.TabIndex = 15;
            labelKategoria.Text = "Kategoria:";
            // 
            // comboBoxKategoria
            // 
            comboBoxKategoria.FormattingEnabled = true;
            comboBoxKategoria.Items.AddRange(new object[] { "Metala", "Plastikoa", "Elikagaiak" });
            comboBoxKategoria.Location = new Point(16, 109);
            comboBoxKategoria.Name = "comboBoxKategoria";
            comboBoxKategoria.Size = new Size(269, 23);
            comboBoxKategoria.TabIndex = 0;
            comboBoxKategoria.SelectedIndexChanged += comboBoxKategoria_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxSegurtasunSoziala);
            groupBox3.Controls.Add(textBoxSoldata);
            groupBox3.Controls.Add(labelSoldata);
            groupBox3.Controls.Add(labelSegurtasunSoziala);
            groupBox3.Location = new Point(458, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 200);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Langilea";
            // 
            // textBoxSegurtasunSoziala
            // 
            textBoxSegurtasunSoziala.Location = new Point(8, 152);
            textBoxSegurtasunSoziala.Name = "textBoxSegurtasunSoziala";
            textBoxSegurtasunSoziala.Size = new Size(279, 23);
            textBoxSegurtasunSoziala.TabIndex = 18;
            textBoxSegurtasunSoziala.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSoldata
            // 
            textBoxSoldata.Location = new Point(112, 70);
            textBoxSoldata.Name = "textBoxSoldata";
            textBoxSoldata.Size = new Size(175, 23);
            textBoxSoldata.TabIndex = 17;
            textBoxSoldata.TextChanged += textBox2_TextChanged;
            // 
            // labelSoldata
            // 
            labelSoldata.AutoSize = true;
            labelSoldata.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelSoldata.Location = new Point(8, 65);
            labelSoldata.Name = "labelSoldata";
            labelSoldata.Size = new Size(88, 28);
            labelSoldata.TabIndex = 15;
            labelSoldata.Text = "Soldata:";
            labelSoldata.Click += label2_Click_1;
            // 
            // labelSegurtasunSoziala
            // 
            labelSegurtasunSoziala.AutoSize = true;
            labelSegurtasunSoziala.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelSegurtasunSoziala.Location = new Point(8, 109);
            labelSegurtasunSoziala.Name = "labelSegurtasunSoziala";
            labelSegurtasunSoziala.Size = new Size(195, 28);
            labelSegurtasunSoziala.TabIndex = 16;
            labelSegurtasunSoziala.Text = "Segurtasun soziala:";
            labelSegurtasunSoziala.Click += label1_Click_1;
            // 
            // buttonGorde
            // 
            buttonGorde.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGorde.Location = new Point(260, 537);
            buttonGorde.Name = "buttonGorde";
            buttonGorde.Size = new Size(142, 43);
            buttonGorde.TabIndex = 0;
            buttonGorde.Text = "Gorde";
            buttonGorde.UseVisualStyleBackColor = true;
            buttonGorde.Click += buttonGorde_Click;
            // 
            // buttonIrten
            // 
            buttonIrten.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIrten.Location = new Point(426, 537);
            buttonIrten.Name = "buttonIrten";
            buttonIrten.Size = new Size(142, 43);
            buttonIrten.TabIndex = 14;
            buttonIrten.Text = "Irten";
            buttonIrten.UseVisualStyleBackColor = true;
            buttonIrten.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 596);
            Controls.Add(buttonIrten);
            Controls.Add(buttonGorde);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
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
            Text = "Kontaktuak gehitu";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private RadioButton radioButtonKontaktua;
        private RadioButton radioButtonBezeroa;
        private RadioButton radioButtonLangilea;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonGorde;
        private Button buttonIrten;
        private TextBox textBoxSegurtasunSoziala;
        private TextBox textBoxSoldata;
        private Label labelSegurtasunSoziala;
        private Label labelSoldata;
        private Label labelKategoria;
        private ComboBox comboBoxKategoria;
    }
}