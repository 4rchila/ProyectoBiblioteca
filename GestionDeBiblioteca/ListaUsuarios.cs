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
    public partial class ListaUsuarios : UserControl
    {
        public ListaUsuarios()
        {
            InitializeComponent();
            CargarLibros(Program.ListaLibros);
            listViewUsuarios.Sorting = SortOrder.None;
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBoxBuscar.Text.ToUpper();

            // Filtrar los libros que coincidan con el texto ingresado en título, autor o ISBN
            var librosFiltrados = Program.ListaLibros
                .Where(libro =>
                    libro.Titulo.ToUpper().Contains(filtro) ||
                    libro.Autor.ToUpper().Contains(filtro) ||
                    libro.ISBN.ToUpper().Contains(filtro) ||
                    libro.Genero.ToUpper().Contains(filtro))
                .OrderBy(libro => libro.Titulo) // Ordenar por título
                .ToList();

            CargarLibros(librosFiltrados); // Mostrar solo los libros filtrados
        }
        public void CargarLibros(IEnumerable<Libro> libros)
        {
            listViewUsuarios.Items.Clear();
            foreach (var libro in libros)
            {
                ListViewItem item = new ListViewItem(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(libro.ISBN);
                item.SubItems.Add(libro.Genero);

                listViewUsuarios.Items.Add(item);
            }
        }
    }
}
