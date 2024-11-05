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
            textBox1BuscarUsuario = new TextBox();
            label0 = new Label();
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
            panel1.Location = new Point(53, 77);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 568);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(140, 122, 91);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 44, 25);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(237, 226, 213);
            button3.Location = new Point(43, 458);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(86, 53);
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
            button1.Location = new Point(654, 458);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(197, 53);
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
            txtBoxContraseña.Location = new Point(533, 309);
            txtBoxContraseña.Margin = new Padding(4, 5, 4, 5);
            txtBoxContraseña.MaxLength = 30;
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.PlaceholderText = "Ingrese la contraseña";
            txtBoxContraseña.Size = new Size(318, 30);
            txtBoxContraseña.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 213, 192);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(43, 143);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(811, 58);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(251, 243, 232);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(19, 18);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 65);
            panel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(166, 152, 128);
            label7.Location = new Point(79, 5);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 32);
            label7.TabIndex = 19;
            label7.Text = "Detalles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(530, 269);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 13;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(339, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 2;
            label2.Text = "Actualiza la información del usuario";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxUsuario.Location = new Point(43, 308);
            txtBoxUsuario.Margin = new Padding(4, 5, 4, 5);
            txtBoxUsuario.MaxLength = 30;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            txtBoxUsuario.Size = new Size(318, 30);
            txtBoxUsuario.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(62, 271);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 11;
            label4.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(351, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 43);
            label1.TabIndex = 1;
            label1.Text = "Editar Usuario";
            // 
            // textBox1BuscarUsuario
            // 
            textBox1BuscarUsuario.BackColor = Color.FromArgb(255, 249, 240);
            textBox1BuscarUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBox1BuscarUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1BuscarUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            textBox1BuscarUsuario.Location = new Point(57, 236);
            textBox1BuscarUsuario.Margin = new Padding(4, 5, 4, 5);
            textBox1BuscarUsuario.MaxLength = 30;
            textBox1BuscarUsuario.Name = "textBox1BuscarUsuario";
            textBox1BuscarUsuario.PlaceholderText = "Ingrese el nombre de usuario";
            textBox1BuscarUsuario.Size = new Size(272, 30);
            textBox1BuscarUsuario.TabIndex = 23;
            textBox1BuscarUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.ForeColor = Color.FromArgb(166, 152, 128);
            label0.Location = new Point(57, 209);
            label0.Margin = new Padding(4, 0, 4, 0);
            label0.Name = "label0";
            label0.Size = new Size(72, 25);
            label0.TabIndex = 24;
            label0.Text = "Usuario";
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditarUsuario";
            Size = new Size(1026, 732);
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
