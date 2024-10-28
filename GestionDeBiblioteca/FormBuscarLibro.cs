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
            InitializeImageList();
            CargarLibros(DatosGlobales.Libros);
            listViewLibros.Sorting = SortOrder.None;
        }
        private void InitializeImageList()
        {
            imageList = new ImageList();
            try
            {
                // Cargar imágenes desde recursos
                //imageList.Images.Add(Properties.Resources.Editar); // Reemplaza con el nombre correcto
                //imageList.Images.Add(Properties.Resources.Eliminar);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar imágenes: {ex.Message}");
            }

            listViewLibros.SmallImageList = imageList; // Asignar el ImageList al ListView
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

                item.SubItems.Add(""); // Columna para las acciones
                item.Tag = libro;
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
            FormPrincipal ventanaBibliotecario = new FormPrincipal();
            ventanaBibliotecario.Show();
        }
        private void listViewLibros_MouseClick(object sender, MouseEventArgs e)
        {
            // Detectar clic en un ítem del ListView
            var item = listViewLibros.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                // Comprobar si se hace clic en la posición de la imagen
                var mousePosition = e.Location;
                if (item.Bounds.Contains(mousePosition))
                {
                    // Lógica para editar
                    if (item.ImageIndex == 0) // Índice del ícono de editar
                    {
                        // Aquí puedes abrir el formulario de edición
                        // Por ejemplo:
                        var libro = (Libro)item.Tag; // Recuperar el libro del Tag
                    }
                    // Lógica para eliminar
                    else if (item.ImageIndex == 1) // Índice del ícono de eliminar
                    {
                        // Aquí puedes implementar la lógica para eliminar
                        // Por ejemplo, mostrar un mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este libro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            // Eliminar el libro de DatosGlobales.Libros
                            DatosGlobales.Libros.Remove((Libro)item.Tag); // Supongamos que guardaste el libro en el Tag
                            CargarLibros(DatosGlobales.Libros); // Recargar la lista
                        }
                    }
                }
            }
        }
    }
}
