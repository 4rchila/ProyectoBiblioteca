namespace GestionDeBiblioteca
{
    partial class LibrosMasPrestados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrosMasPrestados));
            panel1 = new Panel();
            listViewLibros = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(listViewLibros);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(75, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 362);
            panel1.TabIndex = 6;
            // 
            // listViewLibros
            // 
            listViewLibros.BackColor = Color.FromArgb(251, 243, 232);
            listViewLibros.BorderStyle = BorderStyle.None;
            listViewLibros.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            listViewLibros.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewLibros.ForeColor = Color.FromArgb(166, 152, 128);
            listViewLibros.Location = new Point(33, 76);
            listViewLibros.Name = "listViewLibros";
            listViewLibros.Scrollable = false;
            listViewLibros.Size = new Size(603, 237);
            listViewLibros.TabIndex = 4;
            listViewLibros.UseCompatibleStateImageBehavior = false;
            listViewLibros.View = View.Details;
            listViewLibros.SelectedIndexChanged += listViewLibros_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cantidad Prestado";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(196, 14);
            label1.Name = "label1";
            label1.Size = new Size(290, 29);
            label1.TabIndex = 1;
            label1.Text = "Libros mas prestados!!!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 28);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LibrosMasPrestados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 211);
            ClientSize = new Size(790, 416);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "LibrosMasPrestados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibrosMasPrestados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView listViewLibros;
        private ColumnHeader columnHeader6;
        public ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}