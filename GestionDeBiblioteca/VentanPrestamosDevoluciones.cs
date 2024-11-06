using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionDeBiblioteca
{
    public partial class VentanPrestamosDevoluciones : Form
    {
        public VentanPrestamosDevoluciones()
        {
            InitializeComponent();
            CargarHistorialPrestamos();
            CargarHistorialDevoluciones();
        }

        private void CargarHistorialPrestamos()
        {
            // Configura el ListView para mostrar el historial de préstamos
            listViewLibros.Items.Clear();
            listViewLibros.View = View.Details;
            listViewLibros.Columns.Clear();
            listViewLibros.Columns.Add("Usuario", 100);
            listViewLibros.Columns.Add("Libro", 150);
            listViewLibros.Columns.Add("Autor", 100);
            listViewLibros.Columns.Add("Fecha Préstamo", 120);

            foreach (var (libro, usuario) in Program.historialPrestamos)
            {
                ListViewItem item = new ListViewItem(usuario.Name); // Nombre del usuario
                item.SubItems.Add(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy")); // Fecha simulada, puede ser reemplazada si tienes un registro de fecha real

                listViewLibros.Items.Add(item);
            }
        }

        private void CargarHistorialDevoluciones()
        {
            // Añade los datos del historial de devoluciones al ListView
            listViewLibros.View = View.Details;

            // Ajusta las columnas si son distintas para las devoluciones
            listViewLibros.Columns.Clear();
            listViewLibros.Columns.Add("Usuario", 100);
            listViewLibros.Columns.Add("Libro", 150);
            listViewLibros.Columns.Add("Autor", 100);
            listViewLibros.Columns.Add("Fecha Devolución", 120);

            foreach (var (libro, usuario) in Program.historialDevueltos)
            {
                ListViewItem item = new ListViewItem(usuario.Name); // Nombre del usuario
                item.SubItems.Add(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy")); // Fecha simulada, puede ser reemplazada si tienes un registro de fecha real

                listViewLibros.Items.Add(item);
            }
        }

        private void listViewLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este evento puede quedar vacío si no necesitas seleccionar elementos específicos
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBibliotecario formBibliotecario = new FormBibliotecario();
            formBibliotecario.Show();
        }
    }
}

