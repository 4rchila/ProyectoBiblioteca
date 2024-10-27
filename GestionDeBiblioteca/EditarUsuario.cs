using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionDeBiblioteca
{
    public partial class EditarUsuario : Form
    {
        
        public EditarUsuario()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void registrarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nombreUsuarioBuscar.Text;
            var busqueda = Program.BuscarUsuario(nombreUsuario);

            if (busqueda == null)
            {
                MessageBox.Show("Usuario no encontrado");
            }
            else
            {
                this.Close();
                CambioUsuario cambioUsuario = new CambioUsuario(busqueda);
                cambioUsuario.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaDeBibliotecario ventanaBibliotecario = new ventanaDeBibliotecario();
            ventanaBibliotecario.Show();
        }
    }
}

