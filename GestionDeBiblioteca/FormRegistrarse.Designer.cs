namespace GestionDeBiblioteca
{
    partial class FormRegistrarse
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
            label6 = new Label();
            buttonAgregar = new Button();
            txtBoxContraseña = new TextBox();
            label3 = new Label();
            txtBoxUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(txtBoxContraseña);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 433);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(166, 152, 128);
            label6.Location = new Point(105, 41);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 11;
            label6.Text = "Crea un nuevo usuario";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(140, 122, 91);
            buttonAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.ForeColor = Color.FromArgb(237, 226, 213);
            buttonAgregar.Location = new Point(29, 346);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(317, 32);
            buttonAgregar.TabIndex = 9;
            buttonAgregar.Text = "Crear Usuario";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxContraseña.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxContraseña.Location = new Point(29, 217);
            txtBoxContraseña.MaxLength = 30;
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.PasswordChar = '*';
            txtBoxContraseña.PlaceholderText = "Ingrese la contraseña";
            txtBoxContraseña.Size = new Size(300, 22);
            txtBoxContraseña.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(29, 190);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxUsuario.Location = new Point(29, 145);
            txtBoxUsuario.MaxLength = 30;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            txtBoxUsuario.Size = new Size(300, 22);
            txtBoxUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(29, 118);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(49, 12);
            label1.Name = "label1";
            label1.Size = new Size(280, 29);
            label1.TabIndex = 0;
            label1.Text = "Agregar Nuevo Usuario";
            // 
            // FormRegistrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            ClientSize = new Size(398, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button buttonAgregar;
        private TextBox txtBoxContraseña;
        private Label label3;
        private TextBox txtBoxUsuario;
        private Label label2;
        private Label label1;
    }
}