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
    public partial class FormRegistrarse : Form
    {
        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxUsuario.Text;
            string password = txtBoxContraseña.Text;
            string rol;
            var existencia = Program.ComprobarExistencia(nombre, password);
            if (existencia != true)
            {
                MessageBox.Show($"El usuario con nombre: {nombre} existe");
            }
            else
            {
                Program.AgregarUsuario(nombre, "Lector", password);
                this.Close();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();

            }
        }
    }
}
