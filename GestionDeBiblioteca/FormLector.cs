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
    public partial class FormLector : Form
    {
        Usuario Lector;
        public FormLector(Usuario lector)
        {
            InitializeComponent();
            Lector = lector;
        }
    }
}
