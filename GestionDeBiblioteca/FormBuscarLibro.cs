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
        public FormBuscarLibro()
        {
            InitializeComponent();
        }

        private void FormBuscarLibro_Load(object sender, EventArgs e)
        {
            comboBoxBuscar.DataSource = DatosGlobales.Libros;
            comboBoxBuscar.DisplayMember = "MostrarInfo";
        }
        public void ActualizarListBox()
        {
            comboBoxBuscar.DataSource = null;
            comboBoxBuscar.DataSource = DatosGlobales.Libros;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBox1.Text.ToLower();
            var librosFiltrados = DatosGlobales.Libros.Where(l => l.Titulo.ToLower().Contains(textoBusqueda)).ToList();
            comboBoxBuscar.DataSource = librosFiltrados;
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.SelectedIndex >= 0)
            {
                Libro libroSeleccionado = (Libro)comboBoxBuscar.SelectedItem;
                // Mostrar detalles del libro seleccionado
                // ... (código para mostrar detalles)
                // Por ejemplo, en un MessageBox o en otros controles
                MessageBox.Show($"Título: {libroSeleccionado.Titulo}\nAutor: {libroSeleccionado.Autor}");
            }
        }
    }
}
