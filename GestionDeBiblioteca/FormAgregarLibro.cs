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
    public partial class FormAgregarLibro : Form
    {
        public FormAgregarLibro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal ventanaBibliotecario = new FormPrincipal();
            ventanaBibliotecario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtBoxTitulo.Text;
                string autor = txtBoxAutor.Text;
                string isbn = txtBoxIsbn.Text;
                string genero = comboBoxGenero.Text;

                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor) ||
                    string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(genero))
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return;
                }

                Libro nuevoLibro = new Libro(titulo, autor, isbn, genero, true, 0);
                DatosGlobales.Libros.Add(nuevoLibro);
                // Agregar el objeto Libro completo al ListBox

                MessageBox.Show("Libro agregado correctamente.");

                // Clear textboxes for next entry
                txtBoxTitulo.Text = "";
                txtBoxAutor.Text = "";
                txtBoxIsbn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}
