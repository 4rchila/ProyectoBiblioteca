namespace GestionDeBiblioteca
{
    partial class FormLector
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLector));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            buttonFavoritos = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            listViewLibros = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            txtBoxBuscarLector = new TextBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-196, -76);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonFavoritos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(listViewLibros);
            panel1.Controls.Add(txtBoxBuscarLector);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(105, 39);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 603);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 122, 91);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(237, 226, 213);
            button1.Location = new Point(358, 522);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(159, 41);
            button1.TabIndex = 24;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonFavoritos
            // 
            buttonFavoritos.BackColor = Color.FromArgb(140, 122, 91);
            buttonFavoritos.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            buttonFavoritos.FlatStyle = FlatStyle.Flat;
            buttonFavoritos.ForeColor = Color.FromArgb(237, 226, 213);
            buttonFavoritos.Location = new Point(191, 522);
            buttonFavoritos.Margin = new Padding(4, 5, 4, 5);
            buttonFavoritos.Name = "buttonFavoritos";
            buttonFavoritos.Size = new Size(159, 41);
            buttonFavoritos.TabIndex = 23;
            buttonFavoritos.Text = "Libros Favoritos";
            buttonFavoritos.UseVisualStyleBackColor = false;
            buttonFavoritos.Click += buttonFavoritos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(140, 122, 91);
            label2.Location = new Point(750, 494);
            label2.Name = "label2";
            label2.Size = new Size(195, 24);
            label2.TabIndex = 6;
            label2.Text = "Estanteria Personal";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2024_11_03_125553_removebg_preview;
            pictureBox2.Location = new Point(789, 494);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // listViewLibros
            // 
            listViewLibros.BackColor = Color.FromArgb(251, 243, 232);
            listViewLibros.BorderStyle = BorderStyle.None;
            listViewLibros.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            listViewLibros.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewLibros.ForeColor = Color.FromArgb(166, 152, 128);
            listViewLibros.Location = new Point(87, 117);
            listViewLibros.Margin = new Padding(4, 5, 4, 5);
            listViewLibros.Name = "listViewLibros";
            listViewLibros.Size = new Size(787, 395);
            listViewLibros.TabIndex = 4;
            listViewLibros.UseCompatibleStateImageBehavior = false;
            listViewLibros.View = View.Details;
            listViewLibros.MouseClick += listViewLibros_MouseClick;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Acciones";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Título";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Autor";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ISBN";
            columnHeader3.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Disponible";
            columnHeader5.Width = 100;
            // 
            // txtBoxBuscarLector
            // 
            txtBoxBuscarLector.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxBuscarLector.BorderStyle = BorderStyle.FixedSingle;
            txtBoxBuscarLector.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBuscarLector.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxBuscarLector.Location = new Point(54, 68);
            txtBoxBuscarLector.Margin = new Padding(4, 5, 4, 5);
            txtBoxBuscarLector.MaxLength = 15;
            txtBoxBuscarLector.Name = "txtBoxBuscarLector";
            txtBoxBuscarLector.PlaceholderText = "Buscar libro...";
            txtBoxBuscarLector.Size = new Size(165, 30);
            txtBoxBuscarLector.TabIndex = 3;
            txtBoxBuscarLector.TextChanged += txtBoxBuscarLector_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(140, 122, 91);
            label1.Location = new Point(322, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 43);
            label1.TabIndex = 1;
            label1.Text = "Catálo de Libros";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(140, 122, 91);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(237, 226, 213);
            button2.Location = new Point(22, 522);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 41);
            button2.TabIndex = 25;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormLector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 211);
            ClientSize = new Size(1128, 694);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "FormLector";
            Text = "ventanaDeLector";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private ListView listViewLibros;
        public ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox txtBoxBuscarLector;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button buttonFavoritos;
        private Button button1;
        private Button button2;
    }
}
