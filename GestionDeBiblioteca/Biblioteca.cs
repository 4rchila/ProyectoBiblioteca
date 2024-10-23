using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiblioteca
{
    public class Libros 
    {
        public string Titulo {  get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public bool Disponibilidad { get; set; }
        public int TotalPrestamo { get; set; }
    

        public Libros(string titulo, string autor, string isbn, string genero, bool disponibilidad, int totalPrestamos)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.ISBN = isbn;
            this.Genero = genero;
            this.Disponibilidad = disponibilidad;
            this.TotalPrestamo = totalPrestamos;
        }
    }
}
