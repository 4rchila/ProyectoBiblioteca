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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarUsuarioEliminar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nombreUsuarioBuscarEliminar.Text;
            var busqueda = Program.BuscarUsuario(nombreUsuario);

            if (busqueda == null)
            {
                MessageBox.Show("Usuario no encontrado");
            }
            else
            {
                foreach (var c in Program.listaLectores)
                {
                    if (busqueda == c)
                    {
                        Program.listaLectores.Remove(c);
                        MessageBox.Show("Usuario eliminado existoamente");
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBibliotecario ventanaBibliotecario = new FormBibliotecario();
            ventanaBibliotecario.Show();
        }
    }
}
