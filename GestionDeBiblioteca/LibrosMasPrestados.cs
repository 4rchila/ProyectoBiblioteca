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
    public partial class LibrosMasPrestados : Form
    {
        private ImageList imageList;
        public Usuario Usuario;

        public LibrosMasPrestados(Usuario usuario)
        {
            InitializeComponent();
            this.Load += new EventHandler(FormLector_Load);
            listViewLibros.View = View.Details;
            this.Usuario = usuario;
        }

        private void FormLector_Load(object sender, EventArgs e)
        {
            // Cargar los libros desde Program.ListaLibros
            CargarLibros(Program.ListaLibros);
            listViewLibros.HideSelection = true;
        }

        private void listViewLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Método para cargar los libros ordenados por TotalPrestamo
        public void CargarLibros(IEnumerable<Libro> libros)
        {
            listViewLibros.Items.Clear();

            // Ordenar los libros por TotalPrestamo de mayor a menor
            var librosOrdenados = libros.OrderByDescending(libro => libro.TotalPrestamo).ToList();

            foreach (var libro in librosOrdenados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(libro.TotalPrestamo));
                item.SubItems.Add(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(libro.ISBN);
                item.SubItems.Add(EsDisponible(libro.Disponibilidad));

                // Añadir estilo al botón "Prestar"
                item.UseItemStyleForSubItems = false;
                item.SubItems[0].BackColor = Color.Green; // Fondo del botón "Prestar"
                item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold); // Estilo de letra
                item.SubItems[0].ForeColor = Color.White; // Color de texto del botón

                listViewLibros.Items.Add(item);
            }
        }

        private string EsDisponible(bool disponible)
        {
            return disponible ? "Sí" : "No";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLector ventanaLector = new FormLector(Usuario);
            ventanaLector.Show();
        }
    }
}

