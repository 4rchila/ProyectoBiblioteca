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
    public partial class ventanaDeBibliotecario : Form
    {
        public ventanaDeBibliotecario()
        {
            InitializeComponent();
        }

        private void ventanaDeBibliotecario_Load(object sender, EventArgs e)
        {

        }

        //Gestion de biblioteca 
        private void Gestion_Click(object sender, EventArgs e)
        {

        }

        private void AgregarLibro_Click(object sender, EventArgs e)
        {
            AgregarLibro agregarLibro = new AgregarLibro();
            agregarLibro.Show();
            this.Hide();
        }

        private void EditarLibro_Click(object sender, EventArgs e)
        {
            EditarLibro editarLibro = new EditarLibro();
            editarLibro.Show();
            this.Close();
        }

        private void EliminarLibro_Click(object sender, EventArgs e)
        {

        }

        //Gestion de usuarios

        private void GestionU_Click(object sender, EventArgs e)
        {

        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario= new AgregarUsuario();
            agregarUsuario.Show();
            this.Close();
        }

        private void EditarUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.Show();
            this.Close();
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            eliminarUsuario.Show();
            this.Close();
        }
    }
}
