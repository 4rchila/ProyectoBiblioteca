using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeBiblioteca
{
    public partial class AgregaUsuario : UserControl
    {
        public AgregaUsuario()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUsuario.Text;
            string contraseña = txtBoxContraseña.Text;
            string tipo = comboBoxTipo.Text;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) ||
                string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }
            Libro buscarTitulo = Program.ListaLibros.Find(p => p.Titulo == usuario);
            if (buscarTitulo == null)
            {
                //Libro nuevoLibro = new Libro(titulo, autor, isbn, genero, true, 0);
                // Program.ListaLibros.Add(nuevoLibro);
                MessageBox.Show("Libro agregado correctamente.");
                txtBoxUsuario.Clear();
                txtBoxContraseña.Clear();
                comboBoxTipo.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Ya existe un usuario con ese nombre.");
            }
        }
    }
}
