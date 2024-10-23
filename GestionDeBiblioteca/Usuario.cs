using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiblioteca
{
    public class Usuario
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }

        public Usuario(string id, string name, string rol)
        {
            this.ID = id;
            this.Name = name;
            this.Rol = rol;
        }
    }
}
