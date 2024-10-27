namespace GestionDeBiblioteca
{
    partial class CambioUsuario
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            CambioNombre = new TextBox();
            CambiarUsuario = new Button();
            label4 = new Label();
            cambioPasword = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(58, 50);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 4;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(141, 123, 95);
            label1.Location = new Point(143, 54);
            label1.Name = "label1";
            label1.Size = new Size(245, 41);
            label1.TabIndex = 0;
            label1.Text = "Editar Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(52, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // CambioNombre
            // 
            CambioNombre.BackColor = SystemColors.Window;
            CambioNombre.BorderStyle = BorderStyle.FixedSingle;
            CambioNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CambioNombre.ForeColor = Color.FromArgb(107, 91, 61);
            CambioNombre.Location = new Point(52, 215);
            CambioNombre.Margin = new Padding(4, 5, 4, 5);
            CambioNombre.MaxLength = 15;
            CambioNombre.Name = "CambioNombre";
            CambioNombre.Size = new Size(428, 30);
            CambioNombre.TabIndex = 12;
            // 
            // CambiarUsuario
            // 
            CambiarUsuario.BackColor = Color.FromArgb(140, 122, 91);
            CambiarUsuario.FlatStyle = FlatStyle.Flat;
            CambiarUsuario.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CambiarUsuario.ForeColor = Color.FromArgb(237, 226, 213);
            CambiarUsuario.Location = new Point(52, 454);
            CambiarUsuario.Margin = new Padding(4, 5, 4, 5);
            CambiarUsuario.Name = "CambiarUsuario";
            CambiarUsuario.Size = new Size(453, 53);
            CambiarUsuario.TabIndex = 18;
            CambiarUsuario.Text = "Editar Usuario";
            CambiarUsuario.UseVisualStyleBackColor = false;
            CambiarUsuario.Click += CambiarUsuario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(52, 289);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 19;
            label4.Text = "Contraseña";
            // 
            // cambioPasword
            // 
            cambioPasword.BackColor = SystemColors.Window;
            cambioPasword.BorderStyle = BorderStyle.FixedSingle;
            cambioPasword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cambioPasword.ForeColor = Color.FromArgb(107, 91, 61);
            cambioPasword.Location = new Point(52, 357);
            cambioPasword.Margin = new Padding(4, 5, 4, 5);
            cambioPasword.MaxLength = 15;
            cambioPasword.Name = "cambioPasword";
            cambioPasword.Size = new Size(428, 30);
            cambioPasword.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cambioPasword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CambiarUsuario);
            panel1.Controls.Add(CambioNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(201, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 643);
            panel1.TabIndex = 3;
            // 
            // CambioUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 122, 91);
            ClientSize = new Size(915, 742);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CambioUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CambioUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox CambioNombre;
        private Button CambiarUsuario;
        private Label label4;
        private TextBox cambioPasword;
        private Panel panel1;
    }
}