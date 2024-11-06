namespace GestionDeBiblioteca
{
    partial class EliminarUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            txtBoxContraseña = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            label3 = new Label();
            txtBoxUsuario = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(234, 47);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 8;
            label2.Text = "Elimina un libro del sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(219, 18);
            label1.Name = "label1";
            label1.Size = new Size(204, 29);
            label1.TabIndex = 7;
            label1.Text = "Eliminar Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtBoxContraseña);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxUsuario);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(41, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 341);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(140, 122, 91);
            button2.Enabled = false;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(237, 226, 213);
            button2.Location = new Point(43, 265);
            button2.Name = "button2";
            button2.Size = new Size(138, 32);
            button2.TabIndex = 20;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 122, 91);
            button1.Enabled = false;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(237, 226, 213);
            button1.Location = new Point(458, 275);
            button1.Name = "button1";
            button1.Size = new Size(138, 32);
            button1.TabIndex = 19;
            button1.Text = "Eliminar Usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContraseña.Enabled = false;
            txtBoxContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxContraseña.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxContraseña.Location = new Point(373, 188);
            txtBoxContraseña.MaxLength = 30;
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.PlaceholderText = "Ingrese la contraseña";
            txtBoxContraseña.Size = new Size(223, 22);
            txtBoxContraseña.TabIndex = 14;
            txtBoxContraseña.TextChanged += txtBoxContraseña_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 213, 192);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(30, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 35);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(251, 243, 232);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(13, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 39);
            panel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(166, 152, 128);
            label7.Location = new Point(55, 3);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 19;
            label7.Text = "Detalles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(388, 152);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 13;
            label3.Text = "Ingresa tu contraseña";
            label3.Click += label3_Click;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxUsuario.Location = new Point(43, 188);
            txtBoxUsuario.MaxLength = 30;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            txtBoxUsuario.Size = new Size(223, 22);
            txtBoxUsuario.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(166, 152, 128);
            label6.Location = new Point(40, 151);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Usuario";
            // 
            // EliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            Controls.Add(panel1);
            Name = "EliminarUsuario";
            Size = new Size(718, 393);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox txtBoxContraseña;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private Label label3;
        private TextBox txtBoxUsuario;
        private Label label6;
        private Button button2;
    }
}
