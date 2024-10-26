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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaDeBibliotecario ventanaBibliotecario = new ventanaDeBibliotecario();
            ventanaBibliotecario.Show();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rolUsuario.Text == "Lector") 
            {
                Lector nuevoLector = new Lector(paswordUsuario.Text,nombreUsuario.Text,rolUsuario.Text);
            }
            else
            {
                Blibliotecario nuevoBibliotecario = new Blibliotecario(paswordUsuario.Text,nombreUsuario.Text, rolUsuario.Text);
            }
        }
    }
}
