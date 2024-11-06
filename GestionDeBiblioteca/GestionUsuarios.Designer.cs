namespace GestionDeBiblioteca
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            panel1 = new Panel();
            button5 = new Button();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            SidePanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            labelHeader = new Label();
            listaUsuarios1 = new ListaUsuarios();
            agregaUsuario1 = new AgregaUsuario();
            editarUsuario1 = new EditarUsuario();
            eliminarUsuario1 = new EliminarUsuario();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 44, 25);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 870);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(23, 767);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(224, 67);
            button5.TabIndex = 5;
            button5.Text = "Regresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(244, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1026, 45);
            panel3.TabIndex = 4;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(20, 435);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(224, 67);
            button4.TabIndex = 4;
            button4.Text = "        Eliminar Usuario";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(20, 335);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(224, 67);
            button3.TabIndex = 3;
            button3.Text = "       Editar Usuario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(20, 233);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(224, 67);
            button2.TabIndex = 2;
            button2.Text = "        Añadir Usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(249, 237, 226);
            SidePanel.Location = new Point(0, 132);
            SidePanel.Margin = new Padding(4, 5, 4, 5);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(14, 67);
            SidePanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(17, 132);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(227, 67);
            button1.TabIndex = 0;
            button1.Text = "Usuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(20, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 40);
            label1.TabIndex = 0;
            label1.Text = "     BiblioTech";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(62, 44, 25);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(257, 12);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(997, 137);
            panel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 28);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 45);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(166, 152, 128);
            label3.Location = new Point(91, 52);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(275, 23);
            label3.TabIndex = 6;
            label3.Text = "Administra los usuarios registrados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(91, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(242, 32);
            label2.TabIndex = 5;
            label2.Text = "Gestión de Usuarios";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(140, 122, 91);
            panel5.Controls.Add(labelHeader);
            panel5.Location = new Point(0, 93);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(997, 43);
            panel5.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = Color.FromArgb(166, 152, 128);
            labelHeader.Location = new Point(17, 12);
            labelHeader.Margin = new Padding(4, 0, 4, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(436, 46);
            labelHeader.TabIndex = 7;
            labelHeader.Text = "Hay 2 usuarios registrados | 2 bibliotecario(s) | 3 Lector(s\r\n)";
            // 
            // listaUsuarios1
            // 
            listaUsuarios1.BackColor = Color.FromArgb(251, 243, 232);
            listaUsuarios1.Location = new Point(244, 158);
            listaUsuarios1.Margin = new Padding(6, 8, 6, 8);
            listaUsuarios1.Name = "listaUsuarios1";
            listaUsuarios1.Size = new Size(1026, 712);
            listaUsuarios1.TabIndex = 6;
            // 
            // agregaUsuario1
            // 
            agregaUsuario1.BackColor = Color.FromArgb(251, 243, 232);
            agregaUsuario1.Location = new Point(244, 158);
            agregaUsuario1.Margin = new Padding(6, 8, 6, 8);
            agregaUsuario1.Name = "agregaUsuario1";
            agregaUsuario1.Size = new Size(1026, 712);
            agregaUsuario1.TabIndex = 7;
            // 
            // editarUsuario1
            // 
            editarUsuario1.BackColor = Color.FromArgb(251, 243, 232);
            editarUsuario1.Location = new Point(244, 158);
            editarUsuario1.Margin = new Padding(6, 8, 6, 8);
            editarUsuario1.Name = "editarUsuario1";
            editarUsuario1.Size = new Size(1026, 712);
            editarUsuario1.TabIndex = 8;
            // 
            // eliminarUsuario1
            // 
            eliminarUsuario1.BackColor = Color.FromArgb(251, 243, 232);
            eliminarUsuario1.Location = new Point(244, 158);
            eliminarUsuario1.Margin = new Padding(6, 8, 6, 8);
            eliminarUsuario1.Name = "eliminarUsuario1";
            eliminarUsuario1.Size = new Size(1026, 712);
            eliminarUsuario1.TabIndex = 9;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            ClientSize = new Size(1270, 870);
            Controls.Add(eliminarUsuario1);
            Controls.Add(editarUsuario1);
            Controls.Add(agregaUsuario1);
            Controls.Add(listaUsuarios1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionUsuarios";
            Text = "GestionUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel SidePanel;
        private Button button1;
        private Label label1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private Label labelHeader;
        private ListaUsuarios listaUsuarios1;
        private AgregaUsuario agregaUsuario1;
        private EditarUsuario editarUsuario1;
        private EliminarUsuario eliminarUsuario1;
    }
}