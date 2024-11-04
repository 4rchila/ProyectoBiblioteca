using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiblioteca
{
    public class Lector : Usuario
    {
        public List<Libro> EstanteriaPersonal = new List<Libro>();
        public Lector(string password, string name, string rol) : base(password, name, rol)
        {

        }
        public void PrestarLibro() 
        {
           
        }
    }
}
