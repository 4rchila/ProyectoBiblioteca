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

                item.UseItemStyleForSubItems = false;
                item.SubItems[0].BackColor = Color.FromArgb(225, 240, 255);
                item.SubItems[0].ForeColor = Color.DarkSlateBlue;
                item.SubItems[0].Font = new Font("Segoe UI", 10, FontStyle.Bold);

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
                    var libroEnListaGeneral = Program.ListaLibros.FirstOrDefault(libro => libro.Titulo == libroParaDevolver.Titulo);
                    if (libroEnListaGeneral != null && !libroEnListaGeneral.Disponibilidad)
                    {
                        libroEnListaGeneral.Disponibilidad = true;
                        Lector.EstanteriaPersonal.Remove(libroParaDevolver);

                        // Guardar el libro y el usuario en el historial de devoluciones
                        Program.historialDevueltos.Push((libroParaDevolver, Lector));

                        MessageBox.Show("El libro fue devuelto correctamente");

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
            foreach (ListViewItem item in listViewLibros.Items)
            {
                item.BackColor = Color.FromArgb(245, 245, 245);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.historialDevueltos.Count > 0)
            {
                var (libroRestaurado, usuarioDevolucion) = Program.historialDevueltos.Pop(); // Recuperar el último libro devuelto

                // Verificar que la devolución corresponde al usuario actual
                if (usuarioDevolucion == Lector)
                {
                    Lector.EstanteriaPersonal.Add(libroRestaurado);

                    var libroEnListaGeneral = Program.ListaLibros.FirstOrDefault(libro => libro.Titulo == libroRestaurado.Titulo);
                    if (libroEnListaGeneral != null)
                    {
                        libroEnListaGeneral.Disponibilidad = false;
                    }

                    MessageBox.Show("El libro ha sido restaurado a tu estantería personal.");
                    CargarLibros(Lector.EstanteriaPersonal);
                }
                else
                {
                    MessageBox.Show("No tienes libros que puedas restaurar de la devolución.");
                }
            }
            else
            {
                MessageBox.Show("No hay libros para deshacer la devolución.");
            }
        }
    }
}

