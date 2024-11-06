namespace GestionDeBiblioteca
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            txtBoxUsuario = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            txtBoxContraseña = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(73, 14);
            label1.Name = "label1";
            label1.Size = new Size(170, 29);
            label1.TabIndex = 2;
            label1.Text = "Iniciar Sesión";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.AccessibleName = "NombreUsuario";
            txtBoxUsuario.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxUsuario.Location = new Point(44, 111);
            txtBoxUsuario.MaxLength = 30;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            txtBoxUsuario.Size = new Size(223, 22);
            txtBoxUsuario.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(62, 44, 25);
            label4.Location = new Point(44, 84);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(140, 122, 91);
            label5.Location = new Point(161, 282);
            label5.Name = "label5";
            label5.Size = new Size(64, 13);
            label5.TabIndex = 19;
            label5.Text = "Registrarse";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(140, 122, 91);
            label2.Location = new Point(61, 43);
            label2.Name = "label2";
            label2.Size = new Size(216, 30);
            label2.TabIndex = 18;
            label2.Text = "Inicia sesión y entra como bibliotecario \r\n                   o como lector";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 44, 25);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 122, 91);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 122, 91);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(61, 235);
            button1.Name = "button1";
            button1.Size = new Size(194, 34);
            button1.TabIndex = 17;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.AccessibleName = "passwordUsuario";
            txtBoxContraseña.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxContraseña.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxContraseña.Location = new Point(44, 187);
            txtBoxContraseña.MaxLength = 30;
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.PlaceholderText = "Ingrese la contraseña";
            txtBoxContraseña.Size = new Size(223, 22);
            txtBoxContraseña.TabIndex = 16;
            txtBoxContraseña.TextChanged += txtBoxContraseña_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(62, 44, 25);
            label3.Location = new Point(44, 160);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 15;
            label3.Text = "Contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtBoxContraseña);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtBoxUsuario);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(27, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 317);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(385, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 371);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 361);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(62, 44, 25);
            panel3.Location = new Point(364, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 290);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(62, 44, 25);
            label6.Location = new Point(61, 282);
            label6.Name = "label6";
            label6.Size = new Size(104, 13);
            label6.TabIndex = 20;
            label6.Text = "¿No eres miembor?";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(699, 371);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca Central";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Label label1;
        private TextBox txtBoxUsuario;
        private Label label4;
        private TextBox txtBoxContraseña;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label6;
    }
}
