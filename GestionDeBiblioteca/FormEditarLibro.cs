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
    public partial class FormEditarLibro : Form
    {
        public FormEditarLibro()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tituloOriginal = txtBoxTituloEditar.Tag?.ToString();
            string nuevoTitulo = txtBoxTituloEditar.Text.ToUpper();
            string nuevoAutor = txtBoxAutorEditar.Text.ToUpper();
            string nuevoISBN = txtBoxIsbnEditar.Text.ToUpper();
            string nuevoGenero = comboBoxGeneroEdit.Text.ToUpper();
            bool nuevaDisponibilidad = checkBox1.Checked;
            Libro existe = DatosGlobales.Libros.Find(p => p.Titulo == tituloOriginal);
            if (existe != null)
            {
                existe.Titulo = nuevoTitulo;
                existe.Autor = nuevoAutor;
                existe.ISBN = nuevoISBN;
                existe.Genero = nuevoGenero;
                existe.Disponibilidad = nuevaDisponibilidad;
                MessageBox.Show("Libro actualizado correctamente.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string buscarTitulo = txtBoxTituloEditar.Text.ToUpper();
            Libro existe = DatosGlobales.Libros.Find(p => p.Titulo == buscarTitulo);
            if (existe != null)
            {
                MostrarControles(true);

                txtBoxTituloEditar.Tag = existe.Titulo; 
                txtBoxTituloEditar.Text = existe.Titulo;
                txtBoxAutorEditar.Text = existe.Autor;
                txtBoxIsbnEditar.Text = existe.ISBN;
                comboBoxGeneroEdit.Text = existe.Genero;
                checkBox1.Enabled = existe.Disponibilidad;

                button1.Enabled = true;
            }
            else
            {
                InicializarControles();
                MessageBox.Show("No hay libros con ese título.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
        public void InicializarControles()
        {
            button1.Enabled = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtBoxAutorEditar.Visible = false;
            txtBoxIsbnEditar.Visible = false;
            comboBoxGeneroEdit.Visible = false;
            checkBox1.Visible = false;

            button1.Enabled=false;
        }
        public void MostrarControles(bool estado)
        {
            button1.Enabled = estado;
            label3.Visible = estado;
            label4.Visible = estado;
            label5.Visible = estado;
            txtBoxAutorEditar.Visible = estado;
            txtBoxIsbnEditar.Visible = estado;
            comboBoxGeneroEdit.Visible = estado;
            checkBox1.Visible = estado;

        }
    }
}
