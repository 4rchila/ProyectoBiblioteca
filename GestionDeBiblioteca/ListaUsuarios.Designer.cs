namespace GestionDeBiblioteca
{
    partial class ListaUsuarios
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
            panel2 = new Panel();
            listViewUsuarios = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            txtBoxBuscar = new TextBox();
            label7 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(251, 243, 232);
            panel2.Controls.Add(listViewUsuarios);
            panel2.Controls.Add(txtBoxBuscar);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(31, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 414);
            panel2.TabIndex = 3;
            // 
            // listViewUsuarios
            // 
            listViewUsuarios.BackColor = Color.FromArgb(251, 243, 232);
            listViewUsuarios.BorderStyle = BorderStyle.None;
            listViewUsuarios.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1 });
            listViewUsuarios.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewUsuarios.ForeColor = Color.FromArgb(166, 152, 128);
            listViewUsuarios.Location = new Point(16, 95);
            listViewUsuarios.Name = "listViewUsuarios";
            listViewUsuarios.Scrollable = false;
            listViewUsuarios.Size = new Size(594, 306);
            listViewUsuarios.TabIndex = 4;
            listViewUsuarios.UseCompatibleStateImageBehavior = false;
            listViewUsuarios.View = View.Details;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "Usuario";
            columnHeader0.Width = 300;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Rol";
            columnHeader1.Width = 300;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.BackColor = Color.FromArgb(255, 249, 240);
            txtBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBoxBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBuscar.ForeColor = Color.FromArgb(107, 91, 61);
            txtBoxBuscar.Location = new Point(14, 55);
            txtBoxBuscar.MaxLength = 15;
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Ingrese el nombre de usuario o el rol";
            txtBoxBuscar.Size = new Size(596, 22);
            txtBoxBuscar.TabIndex = 3;
            txtBoxBuscar.TextChanged += txtBoxBuscar_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(62, 44, 25);
            label7.Location = new Point(14, 12);
            label7.Name = "label7";
            label7.Size = new Size(260, 29);
            label7.TabIndex = 1;
            label7.Text = "Usuarios Registrados";
            // 
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 243, 232);
            Controls.Add(panel2);
            Name = "ListaUsuarios";
            Size = new Size(718, 420);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ListView listViewUsuarios;
        private TextBox txtBoxBuscar;
        private Label label7;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
    }
}
