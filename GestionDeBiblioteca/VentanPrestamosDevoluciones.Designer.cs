namespace GestionDeBiblioteca
{
    partial class VentanPrestamosDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanPrestamosDevoluciones));
            pictureBox1 = new PictureBox();
            listViewLibros = new ListView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 17);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listViewLibros
            // 
            listViewLibros.BackColor = Color.FromArgb(251, 243, 232);
            listViewLibros.BorderStyle = BorderStyle.None;
            listViewLibros.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewLibros.ForeColor = Color.FromArgb(166, 152, 128);
            listViewLibros.Location = new Point(74, 62);
            listViewLibros.Name = "listViewLibros";
            listViewLibros.Size = new Size(444, 182);
            listViewLibros.TabIndex = 28;
            listViewLibros.UseCompatibleStateImageBehavior = false;
            listViewLibros.View = View.Details;
            listViewLibros.SelectedIndexChanged += listViewLibros_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 44, 25);
            label1.Location = new Point(223, 17);
            label1.Name = "label1";
            label1.Size = new Size(104, 26);
            label1.TabIndex = 26;
            label1.Text = "Historial\r\n";
            // 
            // VentanPrestamosDevoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            ClientSize = new Size(560, 270);
            Controls.Add(pictureBox1);
            Controls.Add(listViewLibros);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "VentanPrestamosDevoluciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanPrestamosDevoluciones";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ListView listViewLibros;
        private Label label1;
    }
}