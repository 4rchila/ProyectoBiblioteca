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
    public partial class Bibliotecario : Form
    {
        public Bibliotecario()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            catalogo1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            catalogo1.CargarLibros(Program.ListaLibros);
            catalogo1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            agregarLibro1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            editarLibro1.InicializarControles();
            eliminarLibro1.InicializarControles();
            editarLibro1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            editarLibro1.InicializarControles();
            eliminarLibro1.InicializarControles();
            eliminarLibro1.BringToFront();
            
        }
    }
}
