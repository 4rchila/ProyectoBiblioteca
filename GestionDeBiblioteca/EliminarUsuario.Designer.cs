namespace GestionDeBiblioteca
{
    partial class EliminarUsuario
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
            BuscarUsuarioEliminar = new Button();
            nombreUsuarioBuscarEliminar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BuscarUsuarioEliminar);
            panel1.Controls.Add(nombreUsuarioBuscarEliminar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(201, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 643);
            panel1.TabIndex = 5;
            // 
            // BuscarUsuarioEliminar
            // 
            BuscarUsuarioEliminar.BackColor = Color.FromArgb(140, 122, 91);
            BuscarUsuarioEliminar.FlatStyle = FlatStyle.Flat;
            BuscarUsuarioEliminar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarUsuarioEliminar.ForeColor = Color.FromArgb(237, 226, 213);
            BuscarUsuarioEliminar.Location = new Point(59, 305);
            BuscarUsuarioEliminar.Margin = new Padding(4, 5, 4, 5);
            BuscarUsuarioEliminar.Name = "BuscarUsuarioEliminar";
            BuscarUsuarioEliminar.Size = new Size(453, 53);
            BuscarUsuarioEliminar.TabIndex = 18;
            BuscarUsuarioEliminar.Text = "Eliminar Usuario";
            BuscarUsuarioEliminar.UseVisualStyleBackColor = false;
            BuscarUsuarioEliminar.Click += BuscarUsuarioEliminar_Click;
            // 
            // nombreUsuarioBuscarEliminar
            // 
            nombreUsuarioBuscarEliminar.BackColor = SystemColors.Window;
            nombreUsuarioBuscarEliminar.BorderStyle = BorderStyle.FixedSingle;
            nombreUsuarioBuscarEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreUsuarioBuscarEliminar.ForeColor = Color.FromArgb(107, 91, 61);
            nombreUsuarioBuscarEliminar.Location = new Point(71, 231);
            nombreUsuarioBuscarEliminar.Margin = new Padding(4, 5, 4, 5);
            nombreUsuarioBuscarEliminar.MaxLength = 15;
            nombreUsuarioBuscarEliminar.Name = "nombreUsuarioBuscarEliminar";
            nombreUsuarioBuscarEliminar.Size = new Size(428, 30);
            nombreUsuarioBuscarEliminar.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(94, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(361, 128);
            label2.TabIndex = 11;
            label2.Text = "Escribe el nombre del usuario \r\nal cual quieras eliminar \r\n\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(141, 123, 95);
            label1.Location = new Point(158, 64);
            label1.Name = "label1";
            label1.Size = new Size(254, 41);
            label1.TabIndex = 0;
            label1.Text = "Buscar Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_10_27_190611_removebg_preview;
            pictureBox1.Location = new Point(-4, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 122, 91);
            ClientSize = new Size(915, 742);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EliminarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button BuscarUsuarioEliminar;
        private TextBox nombreUsuarioBuscarEliminar;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}