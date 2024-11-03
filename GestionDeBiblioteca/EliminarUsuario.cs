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
    public partial class EliminarUsuario : UserControl
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscarUsuario = txtBoxUsuario.Text.ToUpper();
            Libro existe = Program.ListaLibros.Find(p => p.ISBN == buscarUsuario);
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
        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
