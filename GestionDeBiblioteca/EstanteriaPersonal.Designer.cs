﻿namespace GestionDeBiblioteca
{
    partial class EstanteriaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstanteriaPersonal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            listViewLibros = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtBoxBuscarLector = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(listViewLibros);
            panel1.Controls.Add(txtBoxBuscarLector);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 449);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listViewLibros
            // 
            listViewLibros.BackColor = Color.FromArgb(251, 243, 232);
            listViewLibros.BorderStyle = BorderStyle.None;
            listViewLibros.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader2, columnHeader3 });
            listViewLibros.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewLibros.ForeColor = Color.FromArgb(166, 152, 128);
            listViewLibros.Location = new Point(104, 129);
            listViewLibros.Margin = new Padding(4, 5, 4, 5);
            listViewLibros.Name = "listViewLibros";
            listViewLibros.Size = new Size(634, 304);
            listViewLibros.TabIndex = 4;
            listViewLibros.UseCompatibleStateImageBehavior = false;
            listViewLibros.View = View.Details;
            listViewLibros.SelectedIndexChanged += listViewLibros_SelectedIndexChanged;
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
            // txtBoxBuscarLector
            // 
            txtBoxBuscarLector.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxBuscarLector.BorderStyle = BorderStyle.FixedSingle;
            txtBoxBuscarLector.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBuscarLector.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxBuscarLector.Location = new Point(590, 79);
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
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(140, 122, 91);
            label1.Location = new Point(225, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 41);
            label1.TabIndex = 1;
            label1.Text = "Mi Estanteria Personal";
            // 
            // EstanteriaPersonal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EstanteriaPersonal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EstanteriaPersonal";
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
        private TextBox txtBoxBuscarLector;
        private Label label1;
        private PictureBox pictureBox1;
    }
}