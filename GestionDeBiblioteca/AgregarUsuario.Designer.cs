namespace GestionDeBiblioteca
{
    partial class AgregarUsuario
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
            AgregarUser = new Panel();
            rolUsuario = new ListBox();
            passwordUsuario = new TextBox();
            label4 = new Label();
            registrarUsuario = new Button();
            label3 = new Label();
            nombreUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            AgregarUser.SuspendLayout();
            SuspendLayout();
            // 
            // AgregarUser
            // 
            AgregarUser.BackColor = Color.FromArgb(251, 243, 232);
            AgregarUser.BorderStyle = BorderStyle.FixedSingle;
            AgregarUser.Controls.Add(rolUsuario);
            AgregarUser.Controls.Add(passwordUsuario);
            AgregarUser.Controls.Add(label4);
            AgregarUser.Controls.Add(registrarUsuario);
            AgregarUser.Controls.Add(label3);
            AgregarUser.Controls.Add(nombreUsuario);
            AgregarUser.Controls.Add(label2);
            AgregarUser.Controls.Add(label1);
            AgregarUser.Location = new Point(169, 49);
            AgregarUser.Name = "AgregarUser";
            AgregarUser.Size = new Size(559, 643);
            AgregarUser.TabIndex = 0;
            // 
            // rolUsuario
            // 
            rolUsuario.BorderStyle = BorderStyle.FixedSingle;
            rolUsuario.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            rolUsuario.FormattingEnabled = true;
            rolUsuario.ItemHeight = 23;
            rolUsuario.Items.AddRange(new object[] { "Lector", "Bibliotecario" });
            rolUsuario.Location = new Point(52, 282);
            rolUsuario.Margin = new Padding(4, 5, 4, 5);
            rolUsuario.Name = "rolUsuario";
            rolUsuario.Size = new Size(428, 25);
            rolUsuario.TabIndex = 21;
            // 
            // passwordUsuario
            // 
            passwordUsuario.BackColor = SystemColors.Window;
            passwordUsuario.BorderStyle = BorderStyle.FixedSingle;
            passwordUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            passwordUsuario.Location = new Point(52, 385);
            passwordUsuario.Margin = new Padding(4, 5, 4, 5);
            passwordUsuario.MaxLength = 15;
            passwordUsuario.Name = "passwordUsuario";
            passwordUsuario.Size = new Size(428, 30);
            passwordUsuario.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(52, 335);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 19;
            label4.Text = "Contraseña";
            // 
            // registrarUsuario
            // 
            registrarUsuario.BackColor = Color.FromArgb(140, 122, 91);
            registrarUsuario.FlatStyle = FlatStyle.Flat;
            registrarUsuario.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrarUsuario.ForeColor = Color.FromArgb(237, 226, 213);
            registrarUsuario.Location = new Point(52, 499);
            registrarUsuario.Margin = new Padding(4, 5, 4, 5);
            registrarUsuario.Name = "registrarUsuario";
            registrarUsuario.Size = new Size(453, 53);
            registrarUsuario.TabIndex = 18;
            registrarUsuario.Text = "Registrar Usuario";
            registrarUsuario.UseVisualStyleBackColor = false;
            registrarUsuario.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(52, 229);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 28);
            label3.TabIndex = 13;
            label3.Text = "Rol";
            label3.Click += label3_Click;
            // 
            // nombreUsuario
            // 
            nombreUsuario.BackColor = SystemColors.Window;
            nombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            nombreUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreUsuario.ForeColor = Color.FromArgb(107, 91, 61);
            nombreUsuario.Location = new Point(52, 166);
            nombreUsuario.Margin = new Padding(4, 5, 4, 5);
            nombreUsuario.MaxLength = 15;
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Size = new Size(428, 30);
            nombreUsuario.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(52, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(141, 123, 95);
            label1.Location = new Point(142, 38);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 0;
            label1.Text = "Registrar Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 49);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 2;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 122, 91);
            ClientSize = new Size(915, 742);
            Controls.Add(button2);
            Controls.Add(AgregarUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarUsuario";
            Load += AgregarUsuario_Load;
            AgregarUser.ResumeLayout(false);
            AgregarUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AgregarUser;
        private Label label1;
        private Button registrarUsuario;
        private Label label3;
        private TextBox nombreUsuario;
        private Label label2;
        private TextBox passwordUsuario;
        private Label label4;
        private ListBox rolUsuario;
        private Button button2;
    }
}