using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionDeBiblioteca
{
    public partial class FormLector : Form
    {
        private ImageList imageList;
        public Usuario Lector { get; set; }

        public FormLector(Usuario lector)
        {
            InitializeComponent();
            this.Load += new EventHandler(FormLector_Load);
            listViewLibros.View = View.Details;
            this.Lector = lector;
        }

        private void FormLector_Load(object sender, EventArgs e)
        {
            CargarLibros(Program.listaDeLibros);
            listViewLibros.MouseClick += new MouseEventHandler(listViewLibros_MouseClick);
            listViewLibros.HideSelection = true;
        }

        private void txtBoxBuscarLector_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBoxBuscarLector.Text.ToUpper();

            var librosFiltrados = Program.listaDeLibros
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
                ListViewItem item = new ListViewItem("Prestar");
                item.SubItems.Add(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(libro.ISBN);
                item.SubItems.Add(EsDisponible(libro.Disponibilidad));
                listViewLibros.Items.Add(item);
            }
            CambiarColorDisponibilidadEnListView();
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
                    foreach (var libro in Program.listaDeLibros)
                    {
                        if (libro.Titulo == item.SubItems[1].Text)
                        {
                            if (libro.Disponibilidad)
                            {
                                if (!Lector.EstanteriaPersonal.Contains(libro))
                                {
                                    libro.Disponibilidad = false;
                                    Lector.EstanteriaPersonal.Add(libro);
                                    MessageBox.Show("El libro fue almacenado en tu Estantería Personal");
                                }
                                else
                                {
                                    MessageBox.Show("El libro ya está en tu Estantería Personal");
                                }
                            }
                            else if (!Lector.EstanteriaPersonal.Contains(libro))
                            {
                                // Este mensaje solo se mostrará si el libro está marcado como no disponible 
                                // y el usuario no lo tiene en su estantería personal.
                                MessageBox.Show("El libro no se encuentra disponible");
                            }
                        }
                    }

                    CargarLibros(Program.listaDeLibros);
                    listViewLibros.Invalidate();
                    listViewLibros.Update();
                }
            }
        }

        private string EsDisponible(bool disponible)
        {
            return disponible ? "Si" : "No";
        }

        private void CambiarColorDisponibilidadEnListView()
        {
            foreach (ListViewItem item in listViewLibros.Items)
            {
                string disponibilidad = item.SubItems[4].Text;

                if (disponibilidad == "Si")
                {
                    item.SubItems[4].ForeColor = Color.Green;
                }
                else if (disponibilidad == "No")
                {
                    item.SubItems[4].ForeColor = Color.Red;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Puedes añadir lógica de pintura aquí si es necesario
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            EstanteriaPersonal estanteriaPersonal = new EstanteriaPersonal(Lector);
            estanteriaPersonal.Show();
        }
    }
}





