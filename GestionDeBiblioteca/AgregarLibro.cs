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
    public partial class AgregarLibro : Form
    {
        public AgregarLibro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaDeBibliotecario ventanaBibliotecario = new ventanaDeBibliotecario();
            ventanaBibliotecario.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
