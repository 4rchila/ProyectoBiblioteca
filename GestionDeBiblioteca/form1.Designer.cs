namespace GestionDeBiblioteca
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            redbookpicture = new PictureBox();
            Usuario = new TextBox();
            Contraseña = new TextBox();
            label4 = new Label();
            label6 = new Label();
            btnInicio = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)redbookpicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(74, 177);
            label1.Name = "label1";
            label1.Size = new Size(177, 36);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(37, 213);
            label2.Name = "label2";
            label2.Size = new Size(266, 36);
            label2.TabIndex = 1;
            label2.Text = "Biblioteca Central\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(158, 402);
            label3.Name = "label3";
            label3.Size = new Size(560, 78);
            label3.TabIndex = 2;
            label3.Text = "Puedes iniciar sesion como bibliotecario o \r\ncomo lector al sistema de gestion y prestamo de libros\r\n\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkRed;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(525, 73);
            label5.Name = "label5";
            label5.Size = new Size(245, 30);
            label5.TabIndex = 4;
            label5.Text = "INICIO DE SESION";
            // 
            // redbookpicture
            // 
            redbookpicture.BackColor = Color.DarkRed;
            redbookpicture.BackgroundImageLayout = ImageLayout.None;
            redbookpicture.Image = Properties.Resources.Download_free_png_of_Red_book_png_sticker__reading_image_on_transparent_background_by_Chim__about_red__closed_book__book__red_book__and_closed_6542627_removebg_preview;
            redbookpicture.Location = new Point(37, 62);
            redbookpicture.Name = "redbookpicture";
            redbookpicture.Size = new Size(178, 101);
            redbookpicture.SizeMode = PictureBoxSizeMode.Zoom;
            redbookpicture.TabIndex = 5;
            redbookpicture.TabStop = false;
            redbookpicture.Click += redbookpicture_Click;
            // 
            // Usuario
            // 
            Usuario.BackColor = SystemColors.ControlLightLight;
            Usuario.BorderStyle = BorderStyle.FixedSingle;
            Usuario.Cursor = Cursors.IBeam;
            Usuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usuario.Location = new Point(24, 52);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(256, 35);
            Usuario.TabIndex = 6;
            Usuario.TextChanged += textBox1_TextChanged;
            // 
            // Contraseña
            // 
            Contraseña.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contraseña.Location = new Point(25, 151);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(256, 35);
            Contraseña.TabIndex = 7;
            Contraseña.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(101, 14);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 8;
            label4.Text = "Usuario";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(91, 107);
            label6.Name = "label6";
            label6.Size = new Size(142, 30);
            label6.TabIndex = 9;
            label6.Text = "Contraseña";
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.Location = new Point(101, 210);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(112, 34);
            btnInicio.TabIndex = 10;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Contraseña);
            panel1.Controls.Add(Usuario);
            panel1.Location = new Point(500, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 263);
            panel1.TabIndex = 11;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(828, 469);
            Controls.Add(panel1);
            Controls.Add(redbookpicture);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca Central";
            Load += form1_Load;
            ((System.ComponentModel.ISupportInitialize)redbookpicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private PictureBox redbookpicture;
        private TextBox Usuario;
        private TextBox Contraseña;
        private Label label4;
        private Label label6;
        private Button btnInicio;
        private ErrorProvider errorProvider1;
        private Panel panel1;
    }
}
