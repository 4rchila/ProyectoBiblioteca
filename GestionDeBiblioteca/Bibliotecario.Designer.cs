namespace GestionDeBiblioteca
{
    partial class Bibliotecario
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            SidePanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            agregarLibro1 = new AgregarLibro();
            catalogo1 = new Catalogo();
            editarLibro1 = new EditarLibro();
            eliminarLibro1 = new EliminarLibro();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 44, 25);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 522);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(14, 261);
            button4.Name = "button4";
            button4.Size = new Size(157, 40);
            button4.TabIndex = 4;
            button4.Text = "Eliminar Libro";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 201);
            button3.Name = "button3";
            button3.Size = new Size(157, 40);
            button3.TabIndex = 3;
            button3.Text = "Editar Libro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(14, 140);
            button2.Name = "button2";
            button2.Size = new Size(157, 40);
            button2.TabIndex = 2;
            button2.Text = "Agregar Libro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(249, 237, 226);
            SidePanel.Location = new Point(0, 79);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 40);
            SidePanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(159, 40);
            button1.TabIndex = 0;
            button1.Text = "Catalogo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "BiblioTech";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 237, 226);
            panel2.Controls.Add(eliminarLibro1);
            panel2.Controls.Add(editarLibro1);
            panel2.Controls.Add(agregarLibro1);
            panel2.Controls.Add(catalogo1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(171, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 522);
            panel2.TabIndex = 3;
            // 
            // agregarLibro1
            // 
            agregarLibro1.BackColor = Color.FromArgb(251, 243, 232);
            agregarLibro1.Location = new Point(0, 0);
            agregarLibro1.Name = "agregarLibro1";
            agregarLibro1.Size = new Size(718, 522);
            agregarLibro1.TabIndex = 1;
            // 
            // catalogo1
            // 
            catalogo1.BackColor = Color.FromArgb(251, 243, 232);
            catalogo1.Location = new Point(0, 0);
            catalogo1.Name = "catalogo1";
            catalogo1.Size = new Size(718, 522);
            catalogo1.TabIndex = 0;
            // 
            // editarLibro1
            // 
            editarLibro1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            editarLibro1.BackColor = Color.FromArgb(251, 243, 232);
            editarLibro1.Location = new Point(0, 0);
            editarLibro1.Name = "editarLibro1";
            editarLibro1.Size = new Size(718, 522);
            editarLibro1.TabIndex = 2;
            // 
            // eliminarLibro1
            // 
            eliminarLibro1.BackColor = Color.FromArgb(251, 243, 232);
            eliminarLibro1.Location = new Point(0, 0);
            eliminarLibro1.Name = "eliminarLibro1";
            eliminarLibro1.Size = new Size(718, 522);
            eliminarLibro1.TabIndex = 3;
            // 
            // Bibliotecario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bibliotecario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel SidePanel;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel panel2;
        private AgregarLibro agregarLibro1;
        private Catalogo catalogo1;
        private EliminarLibro eliminarLibro1;
        private EditarLibro editarLibro1;
    }
}