namespace GestionDeBiblioteca
{
    partial class AgregaUsuario
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
            label6 = new Label();
            comboBoxTipo = new ComboBox();
            buttonAgregar = new Button();
            label5 = new Label();
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
            panel1.Controls.Add(comboBoxTipo);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxContraseña);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(164, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 433);
            panel1.TabIndex = 2;
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
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.FromArgb(255, 249, 240);
            comboBoxTipo.ForeColor = Color.FromArgb(107, 91, 61);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Lector", "Bibliotecario" });
            comboBoxTipo.Location = new Point(29, 290);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(300, 23);
            comboBoxTipo.TabIndex = 10;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(166, 152, 128);
            label5.Location = new Point(29, 262);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 7;
            label5.Text = "Tipo de usuario";
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
            // AgregaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            Controls.Add(panel1);
            Name = "AgregaUsuario";
            Size = new Size(718, 439);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private ComboBox comboBoxTipo;
        private Button buttonAgregar;
        private Label label5;
        private TextBox txtBoxContraseña;
        private Label label3;
        private TextBox txtBoxUsuario;
        private Label label2;
        private Label label1;
    }
}
