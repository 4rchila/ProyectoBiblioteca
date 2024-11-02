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
    public partial class FormBibliotecario : Form
    {
        public FormBibliotecario()
        {
            InitializeComponent();
        }

        private void ventanaDeBibliotecario_Load(object sender, EventArgs e)
        {

        }

        //Gestion de biblioteca 
        private void Gestion_Click(object sender, EventArgs e)
        {

        }

        private void AgregarLibro_Click(object sender, EventArgs e)
        {
            FormAgregarLibro agregarLibro = new FormAgregarLibro();
            agregarLibro.Show();
            this.Hide();
        }
        private void EliminarLibro_Click(object sender, EventArgs e)
        {
            FormEditarLibro ventanaEditar = new FormEditarLibro();
            ventanaEditar.Show();
            this.Hide();
        }

        //Gestion de usuarios

        private void GestionU_Click(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void SalirBibliotecario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarLibro_Click(object sender, EventArgs e)
        {
            FormBuscarLibro formBuscarLibro = new FormBuscarLibro();
            formBuscarLibro.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bibliotecario ventanaBiblio = new Bibliotecario();
            ventanaBiblio.Show();
            this.Hide();
        }
    }
}
