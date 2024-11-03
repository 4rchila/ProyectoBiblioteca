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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
            labelHeader.Text = Program.InfoLibros(Program.ListaLibros);
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            listaUsuarios1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelHeader.Text = Program.InfoLibros(Program.ListaLibros);
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            listaUsuarios1.CargarLibros(Program.ListaLibros);
            listaUsuarios1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelHeader.Text = Program.InfoLibros(Program.ListaLibros);
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            agregaUsuario1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelHeader.Text = Program.InfoLibros(Program.ListaLibros);
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            editarUsuario1.InicializarControles();
            eliminarUsuario1.InicializarControles();
            editarUsuario1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelHeader.Text = Program.InfoLibros(Program.ListaLibros);
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            editarUsuario1.InicializarControles();
            eliminarUsuario1.InicializarControles();
            eliminarUsuario1.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBibliotecario ventanaPrincipal = new FormBibliotecario();
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
