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
            pictureBox1.Location = new Point(36, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 67);
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
            listViewLibros.Location = new Point(105, 103);
            listViewLibros.Margin = new Padding(4, 5, 4, 5);
            listViewLibros.Name = "listViewLibros";
            listViewLibros.Size = new Size(634, 304);
            listViewLibros.TabIndex = 28;
            listViewLibros.UseCompatibleStateImageBehavior = false;
            listViewLibros.View = View.Details;
            listViewLibros.SelectedIndexChanged += listViewLibros_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(140, 122, 91);
            label1.Location = new Point(318, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 26;
            label1.Text = "Historial\r\n";
            // 
            // VentanPrestamosDevoluciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(listViewLibros);
            Controls.Add(label1);
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