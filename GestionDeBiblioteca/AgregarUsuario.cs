using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
        string rol;
        private void button1_Click(object sender, EventArgs e)
        {

            string password = passwordUsuario.Text;
            string nombre = nombreUsuario.Text;
            string rol;
            MessageBox.Show(rolUsuario.Text);
            if (rolUsuario.Text == "")
            {
                rol = "Lector";

            }
            else
            {
                rol = rolUsuario.Text;
                

            }
            Program.AgregarUsuario(nombre, rol, password);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
