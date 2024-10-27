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

    public partial class CambioUsuario : Form
    {
        Usuario usuario;
        public CambioUsuario(Usuario n)
        {
            InitializeComponent();
            usuario = n;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CambiarUsuario_Click(object sender, EventArgs e)
        {
            string cambioNombre = CambioNombre.Text;
            string cambioPassword = CambioNombre.Text;

            Program.CambiarUsuario(cambioNombre,cambioPassword, usuario);
        }
    }
}
