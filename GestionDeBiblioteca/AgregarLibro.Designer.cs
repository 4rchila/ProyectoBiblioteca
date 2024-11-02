namespace GestionDeBiblioteca
{
    partial class AgregarLibro
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            comboBoxGenero = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            txtBoxIsbn = new TextBox();
            label4 = new Label();
            txtBoxAutor = new TextBox();
            label3 = new Label();
            txtBoxTitulo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxGenero);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxIsbn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxAutor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxTitulo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(148, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 433);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(166, 152, 128);
            label6.Location = new Point(85, 41);
            label6.Name = "label6";
            label6.Size = new Size(186, 15);
            label6.TabIndex = 11;
            label6.Text = "Agrega un nuevo libro al catálogo";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.BackColor = Color.FromArgb(255, 249, 240);
            comboBoxGenero.ForeColor = Color.FromArgb(107, 91, 61);
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Ciencia", "Cómico", "Drámatico ", "Fantasía", "Ficción", "Lírico", "Novela" });
            comboBoxGenero.Location = new Point(29, 313);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(300, 23);
            comboBoxGenero.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 122, 91);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 44, 25);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(237, 226, 213);
            button1.Location = new Point(29, 369);
            button1.Name = "button1";
            button1.Size = new Size(317, 32);
            button1.TabIndex = 9;
            button1.Text = "Agregar Libro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(166, 152, 128);
            label5.Location = new Point(29, 285);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Género";
            // 
            // txtBoxIsbn
            // 
            txtBoxIsbn.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxIsbn.BorderStyle = BorderStyle.FixedSingle;
            txtBoxIsbn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxIsbn.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxIsbn.Location = new Point(29, 243);
            txtBoxIsbn.MaxLength = 10;
            txtBoxIsbn.Name = "txtBoxIsbn";
            txtBoxIsbn.PlaceholderText = "Ingrese el ISBN";
            txtBoxIsbn.Size = new Size(300, 22);
            txtBoxIsbn.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(29, 216);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "ISBN";
            // 
            // txtBoxAutor
            // 
            txtBoxAutor.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxAutor.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAutor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAutor.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxAutor.Location = new Point(29, 171);
            txtBoxAutor.MaxLength = 30;
            txtBoxAutor.Name = "txtBoxAutor";
            txtBoxAutor.PlaceholderText = "Ingrese el nombre del autor";
            txtBoxAutor.Size = new Size(300, 22);
            txtBoxAutor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(29, 144);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Autor";
            // 
            // txtBoxTitulo
            // 
            txtBoxTitulo.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitulo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTitulo.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxTitulo.Location = new Point(29, 99);
            txtBoxTitulo.MaxLength = 30;
            txtBoxTitulo.Name = "txtBoxTitulo";
            txtBoxTitulo.PlaceholderText = "Ingrese el titulo del libro";
            txtBoxTitulo.Size = new Size(300, 22);
            txtBoxTitulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(29, 72);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(57, 12);
            label1.Name = "label1";
            label1.Size = new Size(252, 29);
            label1.TabIndex = 0;
            label1.Text = "Agregar Nuevo Libro";
            // 
            // AgregarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            Controls.Add(panel1);
            Name = "AgregarLibro";
            Size = new Size(718, 522);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private ComboBox comboBoxGenero;
        private Button button1;
        private Label label5;
        private TextBox txtBoxIsbn;
        private Label label4;
        private TextBox txtBoxAutor;
        private Label label3;
        private TextBox txtBoxTitulo;
        private Label label2;
        private Label label1;
    }
}
