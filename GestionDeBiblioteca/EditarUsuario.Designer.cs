namespace GestionDeBiblioteca
{
    partial class EditarUsuario
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
            panel1 = new Panel();
            label0 = new Label();
            textBox1BuscarUsuario = new TextBox();
            button3 = new Button();
            button1 = new Button();
            txtBoxContraseña = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBoxUsuario = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(label0);
            panel1.Controls.Add(textBox1BuscarUsuario);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtBoxContraseña);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 341);
            panel1.TabIndex = 4;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.ForeColor = Color.FromArgb(166, 152, 128);
            label0.Location = new Point(40, 125);
            label0.Name = "label0";
            label0.Size = new Size(47, 15);
            label0.TabIndex = 24;
            label0.Text = "Usuario";
            // 
            // textBox1BuscarUsuario
            // 
            textBox1BuscarUsuario.BackColor = Color.FromArgb(255, 249, 240);
            textBox1BuscarUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBox1BuscarUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1BuscarUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            textBox1BuscarUsuario.Location = new Point(40, 142);
            textBox1BuscarUsuario.MaxLength = 30;
            textBox1BuscarUsuario.Name = "textBox1BuscarUsuario";
            textBox1BuscarUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            textBox1BuscarUsuario.Size = new Size(191, 22);
            textBox1BuscarUsuario.TabIndex = 23;
            textBox1BuscarUsuario.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(140, 122, 91);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(237, 226, 213);
            button3.Location = new Point(30, 275);
            button3.Name = "button3";
            button3.Size = new Size(60, 32);
            button3.TabIndex = 22;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button1.Text = "Guardar cambios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxContraseña.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxContraseña.Location = new Point(373, 185);
            txtBoxContraseña.MaxLength = 30;
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.PlaceholderText = "Ingrese la contraseña";
            txtBoxContraseña.Size = new Size(223, 22);
            txtBoxContraseña.TabIndex = 14;
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
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(371, 161);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 13;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(237, 52);
            label2.Name = "label2";
            label2.Size = new Size(196, 15);
            label2.TabIndex = 2;
            label2.Text = "Actualiza la información del usuario";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxUsuario.Location = new Point(30, 185);
            txtBoxUsuario.MaxLength = 30;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            txtBoxUsuario.Size = new Size(223, 22);
            txtBoxUsuario.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(43, 163);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 11;
            label4.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(246, 13);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 1;
            label1.Text = "Editar Usuario";
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            Controls.Add(panel1);
            Name = "EditarUsuario";
            Size = new Size(718, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private Label label2;
        private Label label1;
        private TextBox txtBoxContraseña;
        private Label label3;
        private TextBox txtBoxUsuario;
        private Label label4;
        private Label label0;
        private TextBox textBox1BuscarUsuario;
    }
}
