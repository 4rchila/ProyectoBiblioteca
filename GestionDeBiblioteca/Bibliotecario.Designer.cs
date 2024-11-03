namespace GestionDeBiblioteca
{
    partial class Bibliotecario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bibliotecario));
            panel1 = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            SidePanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            catalogo1 = new Catalogo();
            agregarLibro1 = new AgregarLibro();
            editarLibro1 = new EditarLibro();
            eliminarLibro1 = new EliminarLibro();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 44, 25);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 522);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(171, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(718, 27);
            panel3.TabIndex = 4;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(14, 261);
            button4.Name = "button4";
            button4.Size = new Size(157, 40);
            button4.TabIndex = 4;
            button4.Text = "      Eliminar Libro";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(14, 201);
            button3.Name = "button3";
            button3.Size = new Size(157, 40);
            button3.TabIndex = 3;
            button3.Text = "   Editar Libro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(14, 140);
            button2.Name = "button2";
            button2.Size = new Size(157, 40);
            button2.TabIndex = 2;
            button2.Text = "      Agregar Libro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(249, 237, 226);
            SidePanel.Location = new Point(0, 79);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 40);
            SidePanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(159, 40);
            button1.TabIndex = 0;
            button1.Text = "Catalogo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "     BiblioTech";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 237, 226);
            panel2.Controls.Add(eliminarLibro1);
            panel2.Controls.Add(editarLibro1);
            panel2.Controls.Add(agregarLibro1);
            panel2.Controls.Add(catalogo1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(171, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 522);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(62, 44, 25);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(8, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(698, 82);
            panel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(594, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(166, 152, 128);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(626, 22);
            label5.Name = "label5";
            label5.Size = new Size(30, 13);
            label5.TabIndex = 8;
            label5.Text = "User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(64, 31);
            label3.Name = "label3";
            label3.Size = new Size(204, 13);
            label3.TabIndex = 6;
            label3.Text = "Explora, añade y organiza tu colección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 10);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 5;
            label2.Text = "Gestión de Libros";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(140, 122, 91);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(0, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(698, 26);
            panel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(12, 7);
            label4.Name = "label4";
            label4.Size = new Size(295, 13);
            label4.TabIndex = 7;
            label4.Text = "Tienes  libros en tu catalogo | 2 disponibles | 1 prestado";
            // 
            // catalogo1
            // 
            catalogo1.BackColor = Color.FromArgb(251, 243, 232);
            catalogo1.Location = new Point(3, 90);
            catalogo1.Name = "catalogo1";
            catalogo1.Size = new Size(715, 432);
            catalogo1.TabIndex = 5;
            // 
            // agregarLibro1
            // 
            agregarLibro1.BackColor = Color.FromArgb(251, 243, 232);
            agregarLibro1.Location = new Point(6, 90);
            agregarLibro1.Name = "agregarLibro1";
            agregarLibro1.Size = new Size(712, 522);
            agregarLibro1.TabIndex = 6;
            // 
            // editarLibro1
            // 
            editarLibro1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            editarLibro1.BackColor = Color.FromArgb(251, 243, 232);
            editarLibro1.Location = new Point(8, 90);
            editarLibro1.Name = "editarLibro1";
            editarLibro1.Size = new Size(713, 432);
            editarLibro1.TabIndex = 7;
            // 
            // eliminarLibro1
            // 
            eliminarLibro1.BackColor = Color.FromArgb(251, 243, 232);
            eliminarLibro1.Location = new Point(8, 90);
            eliminarLibro1.Name = "eliminarLibro1";
            eliminarLibro1.Size = new Size(710, 432);
            eliminarLibro1.TabIndex = 8;
            // 
            // Bibliotecario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bibliotecario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel SidePanel;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private EliminarLibro eliminarLibro1;
        private EditarLibro editarLibro1;
        private AgregarLibro agregarLibro1;
        private Catalogo catalogo1;
    }
}