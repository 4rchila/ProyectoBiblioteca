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
        Usuario LectorBibliotecario;
        public EditarUsuario()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1BuscarUsuario.Text;
            var busqueda = Program.BuscarUsuario(nombreUsuario);

            if (busqueda == null)
            {
                MessageBox.Show("Usuario no encontrado");

            }
            else
            {
                MessageBox.Show("Usuario encontrado");
                MostrarControles(true);
                label0.Visible = false;
                textBox1BuscarUsuario.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                txtBoxUsuario.Visible = true;
                txtBoxContraseña.Visible = true;
                button1.Visible = true;
                button1.Enabled = true;
                LectorBibliotecario = busqueda;
                
            }

        }
        public void InicializarControles()
        {
            button1.Enabled = false;
            button1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtBoxContraseña.Visible = false;
            txtBoxUsuario.Visible = false; 
        }
        public void MostrarControles(bool estado)
        {
            button1.Enabled = estado;
            label3.Visible = estado;
            label4.Visible= estado;
            txtBoxUsuario.Visible = estado;
            txtBoxContraseña.Visible = estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LectorBibliotecario == null)
            {
                MessageBox.Show("Usuario no existe");
            }
            else
            {
                string cambioNombre = txtBoxUsuario.Text;
                string cambioPassword = txtBoxContraseña.Text;

                if (cambioNombre == "" && cambioPassword == "")
                {
                    MessageBox.Show("No hay parametros que editar, vuelve a intentarlo");
                }
                else
                {
                    Program.CambiarUsuario(cambioNombre, cambioPassword, LectorBibliotecario);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
