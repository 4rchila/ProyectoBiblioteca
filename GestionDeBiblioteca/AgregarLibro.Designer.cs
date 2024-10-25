namespace GestionDeBiblioteca
{
    partial class AgregarLibro
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
            listBox1 = new ListBox();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(136, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 433);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.FromArgb(107, 91, 61);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Items.AddRange(new object[] { "Ficción", "Ciencia", "Lírico", "Drámatico ", "Cómico", "Fantasía", "Novela" });
            listBox1.Location = new Point(29, 299);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 19);
            listBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 122, 91);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(237, 226, 213);
            button1.Location = new Point(29, 369);
            button1.Name = "button1";
            button1.Size = new Size(317, 32);
            button1.TabIndex = 9;
            button1.Text = "Agregar Libro";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(166, 152, 128);
            label5.Location = new Point(29, 280);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Género";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 249, 240);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(107, 91, 61);
            textBox3.Location = new Point(29, 238);
            textBox3.MaxLength = 15;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 22);
            textBox3.TabIndex = 6;
            textBox3.Text = "Ingrese el ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(166, 152, 128);
            label4.Location = new Point(29, 211);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "ISBN";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 249, 240);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(107, 91, 61);
            textBox2.Location = new Point(29, 166);
            textBox2.MaxLength = 15;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 22);
            textBox2.TabIndex = 4;
            textBox2.Text = "Ingrese el nombre del autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(29, 139);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Autor";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 249, 240);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(107, 91, 61);
            textBox1.Location = new Point(29, 94);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 22);
            textBox1.TabIndex = 2;
            textBox1.Text = "Ingrese el titulo del libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(166, 152, 128);
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(140, 122, 91);
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(252, 29);
            label1.TabIndex = 0;
            label1.Text = "Agregar Nuevo Libro";
            // 
            // button2
            // 
            button2.Location = new Point(12, 23);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AgregarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 211);
            ClientSize = new Size(656, 479);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarLibro";
            Text = "AgregarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label5;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button2;
    }
}