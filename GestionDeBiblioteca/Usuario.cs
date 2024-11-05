using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiblioteca
{
    public class Usuario
    {
        public List<Libro> EstanteriaPersonal = new List<Libro>();
        public string Password { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }

        public Usuario(string password, string name, string rol)
        {
            this.Password = password;
            this.Name = name;
            this.Rol = rol;
        }
    }
}
