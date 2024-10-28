namespace GestionDeBiblioteca
{
    partial class FormBibliotecario
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
            label1 = new Label();
            label2 = new Label();
            AgregarLibro = new Button();
            GestionL = new Label();
            EditarLibro = new Button();
            EliminarLibro = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            GestionU = new Label();
            AgregarUsuario = new Button();
            EliminarUsuario = new Button();
            EditarUsuario = new Button();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(134, 32);
            label1.Name = "label1";
            label1.Size = new Size(620, 36);
            label1.TabIndex = 0;
            label1.Text = "Hola!!. Bienvenido al menu de bibliotecario ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 152);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // AgregarLibro
            // 
            AgregarLibro.BackColor = Color.DarkRed;
            AgregarLibro.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgregarLibro.ForeColor = Color.White;
            AgregarLibro.Location = new Point(47, 142);
            AgregarLibro.Name = "AgregarLibro";
            AgregarLibro.Size = new Size(176, 33);
            AgregarLibro.TabIndex = 2;
            AgregarLibro.Text = "Agregar Libro";
            AgregarLibro.UseVisualStyleBackColor = false;
            AgregarLibro.Click += AgregarLibro_Click;
            // 
            // GestionL
            // 
            GestionL.AutoSize = true;
            GestionL.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GestionL.ForeColor = SystemColors.ButtonHighlight;
            GestionL.Location = new Point(19, 12);
            GestionL.Name = "GestionL";
            GestionL.Size = new Size(227, 32);
            GestionL.TabIndex = 3;
            GestionL.Text = "Gestion de Libros";
            GestionL.Click += Gestion_Click;
            // 
            // EditarLibro
            // 
            EditarLibro.BackColor = Color.DarkRed;
            EditarLibro.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarLibro.ForeColor = Color.White;
            EditarLibro.Location = new Point(47, 183);
            EditarLibro.Name = "EditarLibro";
            EditarLibro.Size = new Size(176, 33);
            EditarLibro.TabIndex = 4;
            EditarLibro.Text = "Buscar Libro";
            EditarLibro.UseVisualStyleBackColor = false;
            EditarLibro.Click += EditarLibro_Click;
            // 
            // EliminarLibro
            // 
            EliminarLibro.BackColor = Color.DarkRed;
            EliminarLibro.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EliminarLibro.ForeColor = Color.White;
            EliminarLibro.Location = new Point(47, 228);
            EliminarLibro.Name = "EliminarLibro";
            EliminarLibro.Size = new Size(176, 33);
            EliminarLibro.TabIndex = 5;
            EliminarLibro.Text = "Eliminar Libro";
            EliminarLibro.UseVisualStyleBackColor = false;
            EliminarLibro.Click += EliminarLibro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Brown;
            pictureBox1.Image = Properties.Resources.Book_free_icons_designed_by_Smashicons_removebg_preview;
            pictureBox1.Location = new Point(79, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ffrf_removebg_preview1;
            pictureBox2.Location = new Point(54, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // GestionU
            // 
            GestionU.AutoSize = true;
            GestionU.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GestionU.ForeColor = SystemColors.ButtonHighlight;
            GestionU.Location = new Point(16, 12);
            GestionU.Name = "GestionU";
            GestionU.Size = new Size(243, 32);
            GestionU.TabIndex = 8;
            GestionU.Text = "Gestion de Usuario";
            GestionU.Click += GestionU_Click;
            // 
            // AgregarUsuario
            // 
            AgregarUsuario.BackColor = Color.DarkRed;
            AgregarUsuario.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgregarUsuario.ForeColor = Color.White;
            AgregarUsuario.Location = new Point(46, 147);
            AgregarUsuario.Name = "AgregarUsuario";
            AgregarUsuario.Size = new Size(189, 33);
            AgregarUsuario.TabIndex = 9;
            AgregarUsuario.Text = "Agregar Usuario";
            AgregarUsuario.UseVisualStyleBackColor = false;
            AgregarUsuario.Click += AgregarUsuario_Click;
            // 
            // EliminarUsuario
            // 
            EliminarUsuario.BackColor = Color.DarkRed;
            EliminarUsuario.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EliminarUsuario.ForeColor = Color.White;
            EliminarUsuario.Location = new Point(46, 232);
            EliminarUsuario.Name = "EliminarUsuario";
            EliminarUsuario.Size = new Size(189, 33);
            EliminarUsuario.TabIndex = 10;
            EliminarUsuario.Text = "Eliminar Usuario";
            EliminarUsuario.UseVisualStyleBackColor = false;
            EliminarUsuario.Click += EliminarUsuario_Click;
            // 
            // EditarUsuario
            // 
            EditarUsuario.BackColor = Color.DarkRed;
            EditarUsuario.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarUsuario.ForeColor = Color.White;
            EditarUsuario.Location = new Point(46, 188);
            EditarUsuario.Name = "EditarUsuario";
            EditarUsuario.Size = new Size(189, 33);
            EditarUsuario.TabIndex = 11;
            EditarUsuario.Text = "Editar Usuario";
            EditarUsuario.UseVisualStyleBackColor = false;
            EditarUsuario.Click += EditarUsuario_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Brown;
            pictureBox3.Image = Properties.Resources.Captura_de_pantalla_2024_10_22_203527_removebg_preview;
            pictureBox3.Location = new Point(73, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(119, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AgregarLibro);
            panel1.Controls.Add(GestionU);
            panel1.Controls.Add(EditarLibro);
            panel1.Controls.Add(EliminarLibro);
            panel1.Location = new Point(103, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 287);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Brown;
            panel2.Controls.Add(GestionL);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(AgregarUsuario);
            panel2.Controls.Add(EliminarUsuario);
            panel2.Controls.Add(EditarUsuario);
            panel2.Location = new Point(421, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 287);
            panel2.TabIndex = 15;
            // 
            // ventanaDeBibliotecario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(799, 443);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ventanaDeBibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ventanaDeBibliotecario";
            Load += ventanaDeBibliotecario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button AgregarLibro;
        private Label GestionL;
        private Button EditarLibro;
        private Button EliminarLibro;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label GestionU;
        private Button AgregarUsuario;
        private Button EliminarUsuario;
        private Button EditarUsuario;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
    }
}