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
    public partial class FormBuscarLibro : Form
    {
        private ImageList imageList;
        public FormBuscarLibro()
        {
            InitializeComponent();
            CargarLibros(DatosGlobales.Libros);
            listViewLibros.Sorting = SortOrder.None;
        }
        public void CargarLibros(IEnumerable<Libro> libros)
        {
            listViewLibros.Items.Clear();
            foreach (var libro in libros)
            {
                ListViewItem item = new ListViewItem(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(libro.ISBN);
                item.SubItems.Add(libro.Genero);
                item.SubItems.Add(EsDisponible(libro.Disponibilidad));

                listViewLibros.Items.Add(item);
            }
        }
        private string EsDisponible(bool disponible)
        {
            return disponible ? "Si" : "No";
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBoxBuscar.Text.ToUpper();

            // Filtrar los libros que coincidan con el texto ingresado en título, autor o ISBN
            var librosFiltrados = DatosGlobales.Libros
                .Where(libro =>
                    libro.Titulo.ToUpper().Contains(filtro) ||
                    libro.Autor.ToUpper().Contains(filtro) ||
                    libro.ISBN.ToUpper().Contains(filtro) ||
                    libro.Genero.ToUpper().Contains(filtro))
                .OrderBy(libro => libro.Titulo) // Ordenar por título
                .ToList();

            CargarLibros(librosFiltrados); // Mostrar solo los libros filtrados
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBibliotecario ventanaBibliotecario = new FormBibliotecario();
            ventanaBibliotecario.Show();
        }
    }
}
