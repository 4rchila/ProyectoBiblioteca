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
    public partial class FormBibliotecario : Form
    {
        public FormBibliotecario()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GestionLibros ventanaBibliotecario = new GestionLibros();
            ventanaBibliotecario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionUsuarios gestionUsuarios = new GestionUsuarios();    
            gestionUsuarios.Show();
            this.Hide();
        }
    }
}
