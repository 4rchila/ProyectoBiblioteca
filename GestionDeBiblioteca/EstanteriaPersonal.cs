using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionDeBiblioteca
{
    public partial class EstanteriaPersonal : Form
    {
        private Usuario Lector;

        public EstanteriaPersonal(Usuario lector)
        {
            InitializeComponent();
            this.Load += FormLector_Load;
            listViewLibros.View = View.Details;
            Lector = lector;
        }

        private void FormLector_Load(object sender, EventArgs e)
        {
            CargarLibros(Lector.EstanteriaPersonal);
            listViewLibros.MouseClick += listViewLibros_MouseClick;
            listViewLibros.HideSelection = true;
        }

        private void txtBoxBuscarLector_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBoxBuscarLector.Text.ToUpper();
            var librosFiltrados = Lector.EstanteriaPersonal
                .Where(libro =>
                    libro.Titulo.ToUpper().Contains(filtro) ||
                    libro.Autor.ToUpper().Contains(filtro) ||
                    libro.ISBN.ToUpper().Contains(filtro) ||
                    libro.Genero.ToUpper().Contains(filtro))
                .OrderBy(libro => libro.Titulo)
                .ToList();

            CargarLibros(librosFiltrados);
        }

        public void CargarLibros(IEnumerable<Libro> libros)
        {
            listViewLibros.Items.Clear();
            foreach (var libro in libros)
            {
                ListViewItem item = new ListViewItem("Devolver");
                item.SubItems.Add(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(libro.ISBN);

                // Decorar el botón de devolución con un fondo de color que contraste
                item.UseItemStyleForSubItems = false;
                item.SubItems[0].BackColor = Color.FromArgb(225, 240, 255); // Fondo azul claro suave
                item.SubItems[0].ForeColor = Color.DarkSlateBlue; // Texto en azul oscuro
                item.SubItems[0].Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente más visible

                listViewLibros.Items.Add(item);
            }
            CambiarColorDisponibilidadEnListView();
        }

        private void listViewLibros_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listViewLibros.GetItemAt(e.X, e.Y);
            if (item != null && item.SubItems[0].Text == "Devolver")
            {
                var libroParaDevolver = Lector.EstanteriaPersonal.FirstOrDefault(libro => libro.Titulo == item.SubItems[1].Text);
                if (libroParaDevolver != null)
                {
                    var libroEnListaGeneral = Program.listaDeLibros.FirstOrDefault(libro => libro.Titulo == libroParaDevolver.Titulo);
                    if (libroEnListaGeneral != null && !libroEnListaGeneral.Disponibilidad)
                    {
                        libroEnListaGeneral.Disponibilidad = true;
                        Lector.EstanteriaPersonal.Remove(libroParaDevolver);
                        MessageBox.Show("El libro fue devuelto correctamente");

                        // Refrescar la lista de libros en el ListView
                        CargarLibros(Lector.EstanteriaPersonal);
                    }
                    else
                    {
                        MessageBox.Show("Este libro ya ha sido devuelto");
                    }
                }
                else
                {
                    MessageBox.Show("El libro no está en tu estantería personal");
                }
            }
        }

        private void CambiarColorDisponibilidadEnListView()
        {
            // Cambia el color de fondo para hacer el contraste
            foreach (ListViewItem item in listViewLibros.Items)
            {
                item.BackColor = Color.FromArgb(245, 245, 245); // Fondo gris claro para todos los elementos
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLector ventanaLector = new FormLector(Lector);
            ventanaLector.Show();
        }
        private void listViewLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }

}

