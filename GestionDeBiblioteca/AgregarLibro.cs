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
    public partial class AgregarLibro : UserControl
    {
        public AgregarLibro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtBoxTitulo.Text.ToUpper();
                string autor = txtBoxAutor.Text.ToUpper();
                string isbn = txtBoxIsbn.Text.ToUpper();
                string genero = comboBoxGenero.Text.ToUpper();

                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor) ||
                    string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(genero))
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return;
                }

                Libro nuevoLibro = new Libro(titulo, autor, isbn, genero, true, 0);
                Program.ListaLibros.Add(nuevoLibro);
                MessageBox.Show("Libro agregado correctamente.");

                txtBoxTitulo.Clear();
                txtBoxAutor.Clear();
                txtBoxIsbn.Clear();
                comboBoxGenero.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
