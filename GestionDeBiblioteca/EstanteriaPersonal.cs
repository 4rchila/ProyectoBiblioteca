using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionDeBiblioteca
{
    public partial class EstanteriaPersonal : Form
    {
        Usuario Lector;

        public EstanteriaPersonal(Usuario lector)
        {
            InitializeComponent();
            this.Load += new EventHandler(FormLector_Load);
            listViewLibros.View = View.Details;
            Lector = lector;
        }

        private void FormLector_Load(object sender, EventArgs e)
        {
            CargarLibros(Lector.EstanteriaPersonal);
            listViewLibros.MouseClick += new MouseEventHandler(listViewLibros_MouseClick);
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
                listViewLibros.Items.Add(item);
            }
        }

        private void listViewLibros_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listViewLibros.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                int columnIndex = -1;
                int subItemX = 0;

                for (int i = 0; i < listViewLibros.Columns.Count; i++)
                {
                    subItemX += listViewLibros.Columns[i].Width;
                    if (e.X < subItemX)
                    {
                        columnIndex = i;
                        break;
                    }
                }

                if (columnIndex == 0)
                {
                    var libroParaDevolver = Lector.EstanteriaPersonal.FirstOrDefault(libro => libro.Titulo == item.SubItems[1].Text);
                    if (libroParaDevolver != null)
                    {
                        var libroEnListaGeneral = Program.listaDeLibros.FirstOrDefault(libro => libro.Titulo == libroParaDevolver.Titulo);
                        if (libroEnListaGeneral != null)
                        {
                            libroEnListaGeneral.Disponibilidad = true;
                        }

                        Lector.EstanteriaPersonal.Remove(libroParaDevolver);
                        MessageBox.Show("El libro fue devuelto correctamente");
                    }

                    CargarLibros(Lector.EstanteriaPersonal);
                    listViewLibros.Invalidate();
                    listViewLibros.Update();
                }
            }
        }

        private void listViewLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLector ventanaLector = new FormLector(Lector);
            ventanaLector.Show();
        }
    }
}

