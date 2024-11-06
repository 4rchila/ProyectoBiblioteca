using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionDeBiblioteca
{
    public partial class FormLogin : Form
    {
        public static FormLogin instancia;
        public FormLogin()
        {
            InitializeComponent();
            instancia = this;
        }
        //private void form1_Load(object sender, EventArgs e)
        //{
        // Configuramos el TextBox de Contraseña para que oculte el texto
        // Contraseña.UseSystemPasswordChar = true;
        //}
        /*
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void redbookpicture_Click(object sender, EventArgs e)
        {

        }

        private void controlBotones()
        {

            if (Contraseña.Text.Trim() != string.Empty && Usuario.Text.Trim() != string.Empty)
            {
                btnInicio.Enabled = true;
                errorProvider1.SetError(Usuario, "");
                errorProvider1.SetError(Contraseña, "");
            }
            else if (Usuario.Text.Trim() == string.Empty && Contraseña.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(Usuario, "Debe colocarse un caracter antes");
                Usuario.Focus();

                errorProvider1.SetError(Contraseña, "Debe colocarse un caracter antes");
                Contraseña.Focus();
            }
            else if (Usuario.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(Usuario, "Debe colocarse un caracter antes");
                Usuario.Focus();
                return;  // Aquí salimos del método después de enfocar
            }
            else if (Contraseña.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(Contraseña, "Debe colocarse un caracter antes");
                Contraseña.Focus();
                return;  // Salimos del método después de enfocar
            }
            btnInicio.Enabled = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Contraseña.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Program.ComprobarPassword(Usuario.Text, Contraseña.Text);

        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ComprobarPassword(txtBoxUsuario.Text, txtBoxContrase�a.Text);
        }

        private void txtBoxContrase�a_TextChanged(object sender, EventArgs e)
        {
            txtBoxContrase�a.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrarse formRegistrarse = new FormRegistrarse();
            formRegistrarse.Show();
        }
    }
}

