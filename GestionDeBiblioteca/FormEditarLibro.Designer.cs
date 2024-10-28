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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarLibro));
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBoxGeneroEdit = new ComboBox();
            label5 = new Label();
            txtBoxIsbnEditar = new TextBox();
            label4 = new Label();
            txtBoxAutorEditar = new TextBox();
            label3 = new Label();
            txtBoxTituloEditar = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBoxGeneroEdit);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxIsbnEditar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxAutorEditar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxTituloEditar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(79, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 341);
            panel1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.ForeColor = Color.FromArgb(166, 152, 128);
            checkBox1.Location = new Point(31, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 19);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Disponible";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(140, 122, 91);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(237, 226, 213);
            button3.Location = new Point(30, 275);
            button3.Name = "button3";
            button3.Size = new Size(60, 32);
            button3.TabIndex = 22;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(140, 122, 91);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(237, 226, 213);
            button2.Location = new Point(338, 275);
            button2.Name = "button2";
            button2.Size = new Size(104, 32);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 122, 91);
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(237, 226, 213);
            button1.Location = new Point(458, 275);
            button1.Name = "button1";
            button1.Size = new Size(138, 32);
            button1.TabIndex = 19;
            button1.Text = "Guardar cambios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBoxGeneroEdit
            // 
            comboBoxGeneroEdit.BackColor = Color.FromArgb(255, 249, 240);
            comboBoxGeneroEdit.ForeColor = Color.FromArgb(107, 91, 61);
            comboBoxGeneroEdit.FormattingEnabled = true;
            comboBoxGeneroEdit.Items.AddRange(new object[] { "Ciencia", "Cómico", "Drámatico ", "Fantasía", "Ficción", "Lírico", "Novela" });
            comboBoxGeneroEdit.Location = new Point(338, 205);
            comboBoxGeneroEdit.Name = "comboBoxGeneroEdit";
            comboBoxGeneroEdit.Size = new Size(260, 23);
            comboBoxGeneroEdit.TabIndex = 18;
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
            // txtBoxIsbnEditar
            // 
            txtBoxIsbnEditar.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxIsbnEditar.BorderStyle = BorderStyle.FixedSingle;
            txtBoxIsbnEditar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxIsbnEditar.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxIsbnEditar.Location = new Point(30, 205);
            txtBoxIsbnEditar.MaxLength = 10;
            txtBoxIsbnEditar.Name = "txtBoxIsbnEditar";
            txtBoxIsbnEditar.PlaceholderText = "Ingrese el ISBN";
            txtBoxIsbnEditar.Size = new Size(253, 22);
            txtBoxIsbnEditar.TabIndex = 16;
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
            // txtBoxAutorEditar
            // 
            txtBoxAutorEditar.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxAutorEditar.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAutorEditar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAutorEditar.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxAutorEditar.Location = new Point(338, 157);
            txtBoxAutorEditar.MaxLength = 30;
            txtBoxAutorEditar.Name = "txtBoxAutorEditar";
            txtBoxAutorEditar.PlaceholderText = "Ingrese el nombre del autor";
            txtBoxAutorEditar.Size = new Size(258, 22);
            txtBoxAutorEditar.TabIndex = 14;
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
            // txtBoxTituloEditar
            // 
            txtBoxTituloEditar.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxTituloEditar.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTituloEditar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTituloEditar.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxTituloEditar.Location = new Point(32, 157);
            txtBoxTituloEditar.MaxLength = 30;
            txtBoxTituloEditar.Name = "txtBoxTituloEditar";
            txtBoxTituloEditar.PlaceholderText = "Ingrese el titulo del libro";
            txtBoxTituloEditar.Size = new Size(251, 22);
            txtBoxTituloEditar.TabIndex = 12;
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
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormEditarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 211);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private ComboBox comboBoxGeneroEdit;
        private Label label5;
        private TextBox txtBoxIsbnEditar;
        private Label label4;
        private TextBox txtBoxAutorEditar;
        private Label label3;
        private TextBox txtBoxTituloEditar;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}