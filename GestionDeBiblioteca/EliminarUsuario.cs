using System;
using System.Collections;
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
    public partial class EliminarUsuario : UserControl
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtBoxUsuario.Text;
            var busqueda = Program.BuscarUsuario(nombreUsuario);

            if (busqueda == null)
            {
                MessageBox.Show("Usuario no encontrado");
            }
            else
            {
                MostrarControles(true);
                button1.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                label3.Visible = true;
                txtBoxContraseña.Visible = true;
                txtBoxContraseña.Enabled = true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtBoxUsuario.Text;
            var busqueda = Program.BuscarUsuario(nombreUsuario);

            if (busqueda == null)
            {
                MessageBox.Show("Usuario no encontrado");
            }
            else
            {

                var resultado = Program.ListaBibliotecarios.Find(x => x.Password == txtBoxContraseña.Text);

                if (resultado == null)
                {
                    MessageBox.Show("contraseña incorrecta");
                }
                else
                {
                    foreach (var c in Program.ListaBibliotecarios)
                    {
                        if (busqueda == c)
                        {
                            Program.ListaBibliotecarios.Remove(c);
                            MessageBox.Show("Usuario eliminado exitosamente");
                            break;
                        }
                    }
                    foreach (var c in Program.ListaLectores)
                    {
                        Program.ListaLectores.Remove(c);
                        MessageBox.Show("Usuario eliminado exitosamente");
                        break;
                    }
                    label3.Visible = false;
                    txtBoxContraseña.Visible = false;
                    button1.Visible = false;

                }
            }
        }
        public void InicializarControles()
        {
            button2.Enabled = true;
            button1.Visible = false;
            button1.Enabled = false;
            label3.Visible = false;
            txtBoxContraseña.Visible = false;
        }
        public void MostrarControles(bool estado)
        {
            button1.Enabled = estado;
            label3.Visible = estado;
            button1.Enabled = estado;
            label3.Visible = estado;
            txtBoxContraseña.Visible = estado;

        }

        private void txtBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
