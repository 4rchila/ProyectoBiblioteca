using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiblioteca
{
    public class Blibliotecario : Usuario
    {
        public Blibliotecario(string password, string name, string rol) : base(password, name, rol)
        {

        }
    }
}
