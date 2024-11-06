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
            CargarLibros(Program.ListaLibros);
            listViewLibros.MouseClick += new MouseEventHandler(listViewLibros_MouseClick);
            listViewLibros.HideSelection = true;
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

                // Añadir estilo al botón "Prestar"
                item.UseItemStyleForSubItems = false;
                item.SubItems[0].BackColor = Color.LightBlue; // Fondo del botón "Prestar"
                item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold); // Estilo de letra
                item.SubItems[0].ForeColor = Color.White; // Color de texto del botón

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
                    var libroSeleccionado = Program.ListaLibros
                        .FirstOrDefault(libro => libro.Titulo == item.SubItems[1].Text);

                    if (libroSeleccionado != null)
                    {
                        if (libroSeleccionado.Disponibilidad)
                        {
                            if (!Lector.EstanteriaPersonal.Contains(libroSeleccionado))
                            {
                                libroSeleccionado.Disponibilidad = false;
                                Lector.EstanteriaPersonal.Add(libroSeleccionado);
                                libroSeleccionado.TotalPrestamo += 1;

                                // Guardar el libro y el usuario en el historial
                                Program.historialPrestamos.Push((libroSeleccionado, Lector));

                                MessageBox.Show("El libro fue almacenado en tu Estantería Personal");
                            }
                            else
                            {
                                MessageBox.Show("El libro ya está en tu Estantería Personal");
                            }
                        }
                        else if (!Lector.EstanteriaPersonal.Contains(libroSeleccionado))
                        {
                            MessageBox.Show("El libro no se encuentra disponible");
                        }
                    }

                    CargarLibros(Program.ListaLibros);
                    listViewLibros.Invalidate();
                    listViewLibros.Update();
                }
            }
        }

        private string EsDisponible(bool disponible)
        {
            return disponible ? "Sí" : "No";
        }

        private void CambiarColorDisponibilidadEnListView()
        {
            foreach (ListViewItem item in listViewLibros.Items)
            {
                string disponibilidad = item.SubItems[4].Text;

                if (disponibilidad == "Sí")
                {
                    item.SubItems[4].ForeColor = Color.Green;
                    item.SubItems[4].BackColor = Color.LightGreen;
                }
                else if (disponibilidad == "No")
                {
                    item.SubItems[4].ForeColor = Color.Red;
                    item.SubItems[4].BackColor = Color.LightCoral;
                }
            }
        }

        // Método para revertir la última acción de préstamo
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.historialPrestamos.Count > 0)
            {
                var (ultimoLibroPrestado, usuarioPrestamo) = Program.historialPrestamos.Pop(); // Recuperar el último préstamo

                // Verificar que el préstamo corresponde al usuario actual
                if (usuarioPrestamo == Lector && Lector.EstanteriaPersonal.Contains(ultimoLibroPrestado))
                {
                    Lector.EstanteriaPersonal.Remove(ultimoLibroPrestado);
                    ultimoLibroPrestado.Disponibilidad = true; // Marcar como disponible
                    MessageBox.Show("Se ha revertido la acción de préstamo. El libro está disponible nuevamente.");
                }
                CargarLibros(Program.ListaLibros);
            }
            else
            {
                MessageBox.Show("No hay acciones de préstamo que se puedan deshacer.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            EstanteriaPersonal estanteriaPersonal = new EstanteriaPersonal(Lector);
            estanteriaPersonal.Show();
        }

        private void buttonFavoritos_Click(object sender, EventArgs e)
        {
            this.Close();
            LibrosMasPrestados librosMasPrestados = new LibrosMasPrestados(Lector);
            librosMasPrestados.Show();
        }

        private void txtBoxBuscarLector_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBoxBuscarLector.Text.ToUpper();

            var librosFiltrados = Program.ListaLibros
                .Where(libro =>
                    libro.Titulo.ToUpper().Contains(filtro) ||
                    libro.Autor.ToUpper().Contains(filtro))
                .OrderBy(libro => libro.Titulo)
                .ToList();

            CargarLibros(librosFiltrados);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}



