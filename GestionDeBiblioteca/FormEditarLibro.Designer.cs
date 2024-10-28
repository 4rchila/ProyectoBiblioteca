namespace GestionDeBiblioteca
{
    partial class FormEditarLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            button2 = new Button();
            button1 = new Button();
            comboBoxGenero = new ComboBox();
            label5 = new Label();
            txtBoxIsbn = new TextBox();
            label4 = new Label();
            txtBoxAutor = new TextBox();
            label3 = new Label();
            txtBoxTitulo = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBoxGenero);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxIsbn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxAutor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxTitulo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(79, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 341);
            panel1.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.FromArgb(166, 152, 128);
            radioButton1.Location = new Point(32, 250);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Disponible ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(140, 122, 91);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(237, 226, 213);
            button2.Location = new Point(338, 268);
            button2.Name = "button2";
            button2.Size = new Size(104, 32);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 122, 91);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(237, 226, 213);
            button1.Location = new Point(458, 268);
            button1.Name = "button1";
            button1.Size = new Size(138, 32);
            button1.TabIndex = 19;
            button1.Text = "Guardar cambios";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.BackColor = Color.FromArgb(255, 249, 240);
            comboBoxGenero.ForeColor = Color.FromArgb(107, 91, 61);
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Ciencia", "Cómico", "Drámatico ", "Fantasía", "Ficción", "Lírico", "Novela" });
            comboBoxGenero.Location = new Point(338, 205);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(260, 23);
            comboBoxGenero.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(166, 152, 128);
            label5.Location = new Point(338, 187);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 17;
            label5.Text = "Género";
            // 
            // txtBoxIsbn
            // 
            txtBoxIsbn.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxIsbn.BorderStyle = BorderStyle.FixedSingle;
            txtBoxIsbn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxIsbn.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxIsbn.Location = new Point(30, 205);
            txtBoxIsbn.MaxLength = 10;
            txtBoxIsbn.Name = "txtBoxIsbn";
            txtBoxIsbn.PlaceholderText = "Ingrese el ISBN";
            txtBoxIsbn.Size = new Size(253, 22);
            txtBoxIsbn.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(30, 187);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 15;
            label4.Text = "ISBN";
            // 
            // txtBoxAutor
            // 
            txtBoxAutor.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxAutor.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAutor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAutor.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxAutor.Location = new Point(338, 157);
            txtBoxAutor.MaxLength = 30;
            txtBoxAutor.Name = "txtBoxAutor";
            txtBoxAutor.PlaceholderText = "Ingrese el nombre del autor";
            txtBoxAutor.Size = new Size(258, 22);
            txtBoxAutor.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(338, 139);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 13;
            label3.Text = "Autor";
            // 
            // txtBoxTitulo
            // 
            txtBoxTitulo.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitulo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTitulo.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxTitulo.Location = new Point(32, 157);
            txtBoxTitulo.MaxLength = 30;
            txtBoxTitulo.Name = "txtBoxTitulo";
            txtBoxTitulo.PlaceholderText = "Ingrese el titulo del libro";
            txtBoxTitulo.Size = new Size(251, 22);
            txtBoxTitulo.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(166, 152, 128);
            label6.Location = new Point(30, 139);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 11;
            label6.Text = "Título";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 213, 192);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(30, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 35);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(251, 243, 232);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(13, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 39);
            panel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(166, 152, 128);
            label7.Location = new Point(55, 3);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 19;
            label7.Text = "Detalles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(237, 52);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 2;
            label2.Text = "Actualiza la información del libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(140, 122, 91);
            label1.Location = new Point(254, 13);
            label1.Name = "label1";
            label1.Size = new Size(149, 29);
            label1.TabIndex = 1;
            label1.Text = "Editar Libro";
            // 
            // FormEditarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 211);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private ComboBox comboBoxGenero;
        private Label label5;
        private TextBox txtBoxIsbn;
        private Label label4;
        private TextBox txtBoxAutor;
        private Label label3;
        private TextBox txtBoxTitulo;
        private Label label6;
        private Label label7;
        private RadioButton radioButton1;
        private Button button2;
        private Button button1;
    }
}