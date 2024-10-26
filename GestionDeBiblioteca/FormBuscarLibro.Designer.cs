namespace GestionDeBiblioteca
{
    partial class FormBuscarLibro
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            txtBoxBuscar = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 243, 232);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(txtBoxBuscar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 327);
            panel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(251, 243, 232);
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(36, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(618, 187);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Titulo";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Autor";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ISBN";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Disponibilidad";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Acciones";
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBoxBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBuscar.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxBuscar.Location = new Point(33, 55);
            txtBoxBuscar.MaxLength = 15;
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Ingrese el titulo del libro";
            txtBoxBuscar.Size = new Size(621, 22);
            txtBoxBuscar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(140, 122, 91);
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(224, 29);
            label1.TabIndex = 1;
            label1.Text = "Catalogo de libros";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // FormBuscarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 211);
            ClientSize = new Size(803, 409);
            Controls.Add(panel1);
            Name = "FormBuscarLibro";
            Text = "FormBuscarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBoxBuscar;
        private Label label1;
        private ListView listView1;
        private ComboBox comboBoxBuscar;
        private TextBox textBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}