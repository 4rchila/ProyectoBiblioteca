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
    public partial class AgregaUsuario : UserControl
    {
        public AgregaUsuario()
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
                if (comboBoxTipo.Text == "")
                {
                    rol = "Lector";

                }
                else
                {
                    rol = comboBoxTipo.Text;


                }
                Program.AgregarUsuario(nombre, rol, password);

            }
        }

    }
}

