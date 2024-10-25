namespace GestionDeBiblioteca
{
    partial class ventanaDeBibliotecario
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
            SalirBibliotecario = new Button();
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
            label1.Location = new Point(94, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 25);
            label1.TabIndex = 0;
            label1.Text = "Hola!!. Bienvenido al menu de bibliotecario ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // AgregarLibro
            // 
            AgregarLibro.BackColor = Color.DarkRed;
            AgregarLibro.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgregarLibro.ForeColor = Color.White;
            AgregarLibro.Location = new Point(33, 85);
            AgregarLibro.Margin = new Padding(2);
            AgregarLibro.Name = "AgregarLibro";
            AgregarLibro.Size = new Size(123, 20);
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
            GestionL.Location = new Point(13, 7);
            GestionL.Margin = new Padding(2, 0, 2, 0);
            GestionL.Name = "GestionL";
            GestionL.Size = new Size(155, 22);
            GestionL.TabIndex = 3;
            GestionL.Text = "Gestion de Libros";
            GestionL.Click += Gestion_Click;
            // 
            // EditarLibro
            // 
            EditarLibro.BackColor = Color.DarkRed;
            EditarLibro.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarLibro.ForeColor = Color.White;
            EditarLibro.Location = new Point(33, 110);
            EditarLibro.Margin = new Padding(2);
            EditarLibro.Name = "EditarLibro";
            EditarLibro.Size = new Size(123, 20);
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
            EliminarLibro.Location = new Point(33, 137);
            EliminarLibro.Margin = new Padding(2);
            EliminarLibro.Name = "EliminarLibro";
            EliminarLibro.Size = new Size(123, 20);
            EliminarLibro.TabIndex = 5;
            EliminarLibro.Text = "Eliminar Libro";
            EliminarLibro.UseVisualStyleBackColor = false;
            EliminarLibro.Click += EliminarLibro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Brown;
            pictureBox1.Image = Properties.Resources.Book_free_icons_designed_by_Smashicons_removebg_preview;
            pictureBox1.Location = new Point(55, 28);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ffrf_removebg_preview1;
            pictureBox2.Location = new Point(38, 7);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // GestionU
            // 
            GestionU.AutoSize = true;
            GestionU.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GestionU.ForeColor = SystemColors.ButtonHighlight;
            GestionU.Location = new Point(11, 7);
            GestionU.Margin = new Padding(2, 0, 2, 0);
            GestionU.Name = "GestionU";
            GestionU.Size = new Size(166, 22);
            GestionU.TabIndex = 8;
            GestionU.Text = "Gestion de Usuario";
            GestionU.Click += GestionU_Click;
            // 
            // AgregarUsuario
            // 
            AgregarUsuario.BackColor = Color.DarkRed;
            AgregarUsuario.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgregarUsuario.ForeColor = Color.White;
            AgregarUsuario.Location = new Point(32, 88);
            AgregarUsuario.Margin = new Padding(2);
            AgregarUsuario.Name = "AgregarUsuario";
            AgregarUsuario.Size = new Size(132, 20);
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
            EliminarUsuario.Location = new Point(32, 139);
            EliminarUsuario.Margin = new Padding(2);
            EliminarUsuario.Name = "EliminarUsuario";
            EliminarUsuario.Size = new Size(132, 20);
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
            EditarUsuario.Location = new Point(32, 113);
            EditarUsuario.Margin = new Padding(2);
            EditarUsuario.Name = "EditarUsuario";
            EditarUsuario.Size = new Size(132, 20);
            EditarUsuario.TabIndex = 11;
            EditarUsuario.Text = "Editar Usuario";
            EditarUsuario.UseVisualStyleBackColor = false;
            EditarUsuario.Click += EditarUsuario_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Brown;
            pictureBox3.Image = Properties.Resources.Captura_de_pantalla_2024_10_22_203527_removebg_preview;
            pictureBox3.Location = new Point(51, 28);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // SalirBibliotecario
            // 
            SalirBibliotecario.BackColor = Color.Red;
            SalirBibliotecario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalirBibliotecario.ForeColor = SystemColors.ButtonHighlight;
            SalirBibliotecario.Location = new Point(472, 242);
            SalirBibliotecario.Margin = new Padding(2);
            SalirBibliotecario.Name = "SalirBibliotecario";
            SalirBibliotecario.Size = new Size(78, 20);
            SalirBibliotecario.TabIndex = 13;
            SalirBibliotecario.Text = "Salir";
            SalirBibliotecario.UseVisualStyleBackColor = false;
            SalirBibliotecario.Click += SalirBibliotecario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AgregarLibro);
            panel1.Controls.Add(GestionU);
            panel1.Controls.Add(EditarLibro);
            panel1.Controls.Add(EliminarLibro);
            panel1.Location = new Point(72, 66);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 172);
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
            panel2.Location = new Point(295, 66);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 172);
            panel2.TabIndex = 15;
            // 
            // ventanaDeBibliotecario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(559, 266);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(SalirBibliotecario);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
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
        private Button SalirBibliotecario;
        private Panel panel1;
        private Panel panel2;
    }
}