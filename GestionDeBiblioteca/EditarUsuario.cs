using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GestionDeBiblioteca
{
    public partial class EditarUsuario : UserControl
    {
        public EditarUsuario()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscarTitulo = txtBoxUsuario.Text.ToUpper();
            Libro existe = Program.ListaLibros.Find(p => p.ISBN == buscarTitulo);
            if (existe != null)
            {
                MostrarControles(true);

                //txtBoxUsuario.Tag = existe.ISBN;
                //txtBoxUsuario.Text = existe.Usuario;
                //txtBoxContraseña.Text = existe.Contraseña;
                //comboBoxTipo.Text = existe.Tipo;

                button1.Enabled = true;
            }
            else
            {
                InicializarControles();
                MessageBox.Show("No hay libros con ese ISBN.");
            }
        }
        public void InicializarControles()
        {
            button1.Enabled = false;
            label3.Visible = false;
            label5.Visible = false;
            txtBoxContraseña.Visible = false;
            comboBoxTipo.Visible = false;
        }
        public void MostrarControles(bool estado)
        {
            button1.Enabled = estado;
            label3.Visible = estado;
            label5.Visible = estado;
            txtBoxContraseña.Visible = estado;
            comboBoxTipo.Visible = estado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioOriginal = txtBoxUsuario.Tag?.ToString();
            string nuevoUsuario = txtBoxUsuario.Text.ToUpper();
            string nuevaContraseña = txtBoxContraseña.Text.ToUpper();
            string nuevoTipo = comboBoxTipo.Text.ToUpper();
            Libro existe = Program.ListaLibros.Find(p => p.ISBN == usuarioOriginal);
            if (existe != null)
            {
                //existe.Usuario = nuevoUsuario;
                //existe.Contraseña = nuevaContraseña;
                //existe.Tipo = nuevoTipo;
                MessageBox.Show("Usuario actualizado correctamente.");
            }
        }
    }
}
