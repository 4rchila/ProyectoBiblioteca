namespace GestionDeBiblioteca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static List<Libro> ListaLibros = new List<Libro>();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());


        }
        public static string InfoLibros(List<Libro>libros)
        {
            int totalLibros = libros.Count;
            int disponibles = libros.Count(l => l.Disponibilidad);
            int prestados = totalLibros - disponibles;
            return $"Tienes {totalLibros} libros en tu catálogo | {disponibles} disponibles | {prestados} prestado(s)";
        }

    }
}