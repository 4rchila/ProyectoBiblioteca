namespace GestionDeBiblioteca
{
    partial class EditarUsuario
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
            BuscarUsuario = new Button();
            nombreUsuarioBuscar = new TextBox();
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
            panel1.Controls.Add(BuscarUsuario);
            panel1.Controls.Add(nombreUsuarioBuscar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(211, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 643);
            panel1.TabIndex = 3;
            // 
            // BuscarUsuario
            // 
            BuscarUsuario.BackColor = Color.FromArgb(140, 122, 91);
            BuscarUsuario.FlatStyle = FlatStyle.Flat;
            BuscarUsuario.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarUsuario.ForeColor = Color.FromArgb(237, 226, 213);
            BuscarUsuario.Location = new Point(59, 305);
            BuscarUsuario.Margin = new Padding(4, 5, 4, 5);
            BuscarUsuario.Name = "BuscarUsuario";
            BuscarUsuario.Size = new Size(453, 53);
            BuscarUsuario.TabIndex = 18;
            BuscarUsuario.Text = "Buscar Usuario";
            BuscarUsuario.UseVisualStyleBackColor = false;
            BuscarUsuario.Click += registrarUsuario_Click;
            // 
            // nombreUsuarioBuscar
            // 
            nombreUsuarioBuscar.BackColor = SystemColors.Window;
            nombreUsuarioBuscar.BorderStyle = BorderStyle.FixedSingle;
            nombreUsuarioBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreUsuarioBuscar.ForeColor = Color.FromArgb(107, 91, 61);
            nombreUsuarioBuscar.Location = new Point(71, 231);
            nombreUsuarioBuscar.Margin = new Padding(4, 5, 4, 5);
            nombreUsuarioBuscar.MaxLength = 15;
            nombreUsuarioBuscar.Name = "nombreUsuarioBuscar";
            nombreUsuarioBuscar.Size = new Size(428, 30);
            nombreUsuarioBuscar.TabIndex = 12;
            nombreUsuarioBuscar.TextChanged += nombreUsuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(71, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(398, 84);
            label2.TabIndex = 11;
            label2.Text = "Escribe el nombre del usuario al cual \r\nquieras modificara alguna caracteristica \r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(141, 123, 95);
            label1.Location = new Point(158, 64);
            label1.Name = "label1";
            label1.Size = new Size(227, 41);
            label1.TabIndex = 0;
            label1.Text = "Editar Usurio";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_10_27_190611_removebg_preview;
            pictureBox1.Location = new Point(13, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 122, 91);
            ClientSize = new Size(915, 742);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button BuscarUsuario;
        private TextBox nombreUsuarioBuscar;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}