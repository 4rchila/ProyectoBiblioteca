using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionDeBiblioteca
{
    public partial class form1 : Form
    {
        public  static form1 instancia;
        public form1()
        {
            InitializeComponent();
            instancia = this;
        }
        //private void form1_Load(object sender, EventArgs e)
        //{
        // Configuramos el TextBox de Contrase�a para que oculte el texto
        // Contrase�a.UseSystemPasswordChar = true;
        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void redbookpicture_Click(object sender, EventArgs e)
        {

        }

        private void controlBotones()
        {

            if (Contrase�a.Text.Trim() != string.Empty && Usuario.Text.Trim() != string.Empty)
            {
                btnInicio.Enabled = true;
                errorProvider1.SetError(Usuario, "");
                errorProvider1.SetError(Contrase�a, "");
            }
            else if (Usuario.Text.Trim() == string.Empty && Contrase�a.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(Usuario, "Debe colocarse un caracter antes");
                Usuario.Focus();

                errorProvider1.SetError(Contrase�a, "Debe colocarse un caracter antes");
                Contrase�a.Focus();
            }
            else if (Usuario.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(Usuario, "Debe colocarse un caracter antes");
                Usuario.Focus();
                return;  // Aqu� salimos del m�todo despu�s de enfocar
            }
            else if (Contrase�a.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(Contrase�a, "Debe colocarse un caracter antes");
                Contrase�a.Focus();
                return;  // Salimos del m�todo despu�s de enfocar
            }
            btnInicio.Enabled = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Contrase�a.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Program.ComprobarPassword(Usuario.Text, Contrase�a.Text);
            
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}

