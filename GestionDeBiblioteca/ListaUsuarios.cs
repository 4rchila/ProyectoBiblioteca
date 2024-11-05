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
            CargarBibliotecarios(Program.ListaBibliotecarios);
            CargarUsuario(Program.ListaLectores);
            listViewUsuarios.Sorting = SortOrder.None;
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBoxBuscar.Text.ToUpper();

            // Filtrar los libros que coincidan con el texto ingresado en título, autor o ISBN
            var FiltradosLector = Program.ListaLectores
                .Where(usuario =>
                    usuario.Name.ToUpper().Contains(filtro) ||
                    usuario.Rol.ToUpper().Contains(filtro)) 
                .OrderBy(usuario => usuario.Name) // Ordenar por título
                .ToList();

             var FiltradosBibliotecarios = Program.ListaBibliotecarios
                .Where(bibliotecario =>
                    bibliotecario.Name.ToUpper().Contains(filtro) ||
                    bibliotecario.Rol.ToUpper().Contains(filtro))
                .OrderBy(bibliotecario => bibliotecario.Name) // Ordenar por título
                .ToList();

            CargarBibliotecarios(FiltradosBibliotecarios);
            CargarUsuario(FiltradosLector); 
        }
        public void CargarUsuario(IEnumerable<Lector> usuarioLector)
        {
            foreach (var usuario in usuarioLector)
            {
                ListViewItem item = new ListViewItem(usuario.Name);
                item.SubItems.Add(usuario.Rol);
                listViewUsuarios.Items.Add(item);
            }
        }
        public void CargarBibliotecarios(IEnumerable<Blibliotecario> usuarioBibliotecario)
        {
            listViewUsuarios.Items.Clear();
            foreach (var bibliotecario in usuarioBibliotecario)
            {
                ListViewItem item = new ListViewItem(bibliotecario.Name);
                item.SubItems.Add(bibliotecario.Rol);
                listViewUsuarios.Items.Add(item);
            }
        }
    }
}
