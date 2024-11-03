﻿using System;
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
    public partial class EliminarLibro : UserControl
    {
        public EliminarLibro()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscarIsbn = txtBoxIsbnEditar.Text.ToUpper();
            Libro existe = Program.ListaLibros.Find(p => p.ISBN == buscarIsbn);
            if (existe != null)
            {
                MostrarControles(true);

                txtBoxIsbnEditar.Tag = existe.ISBN;
                txtBoxTituloEditar.Text = existe.Titulo;
                txtBoxAutorEditar.Text = existe.Autor;
                txtBoxIsbnEditar.Text = existe.ISBN;
                comboBoxGeneroEdit.Text = existe.Genero;
                checkBox1.Checked = existe.Disponibilidad;

                button1.Enabled = true;
            }
            else
            {
                InicializarControles();
                MessageBox.Show("No hay libros con ese ISBN.");
            }
        }
        public void InicializarControles()
        {
            button1.Enabled = false;
            label3.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            txtBoxAutorEditar.Visible = false;
            txtBoxTituloEditar.Visible = false;
            comboBoxGeneroEdit.Visible = false;
            txtBoxIsbnEditar.Text = null;
            checkBox1.Visible = false;
        }
        public void MostrarControles(bool estado)
        {
            button1.Enabled = estado;
            label3.Visible = estado;
            label6.Visible = estado;
            label5.Visible = estado;
            txtBoxAutorEditar.Visible = estado;
            txtBoxTituloEditar.Visible = estado;
            comboBoxGeneroEdit.Visible = estado;
            checkBox1.Visible = estado;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string IsbnOriginal = txtBoxIsbnEditar.Tag?.ToString();
            string nuevoTitulo = txtBoxTituloEditar.Text.ToUpper();
            string nuevoAutor = txtBoxAutorEditar.Text.ToUpper();
            string nuevoISBN = txtBoxIsbnEditar.Text.ToUpper();
            string nuevoGenero = comboBoxGeneroEdit.Text.ToUpper();
            bool nuevaDisponibilidad = checkBox1.Checked;
            Libro existe = Program.ListaLibros.Find(p => p.ISBN == IsbnOriginal);
            if (existe != null)
            {
                Program.ListaLibros.Remove(existe);
                DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar el libro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Libro eliminado correctamente.");
                }
                else
                {
                }
            }
        }
    }
}
