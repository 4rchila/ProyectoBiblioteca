namespace GestionDeBiblioteca
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static List<Lector>ListaLectores = new List<Lector>();
        public static List<Blibliotecario> ListaBibliotecarios = new List<Blibliotecario>();
        public static List<Libro> ListaLibros = new List<Libro>();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ListaLectores.Add(new Lector("Gerl0Archila","4rchila","Lector"));
            ListaLectores.Add(new Lector("Gerlo", "Juanca", "Lector"));
            ListaLectores.Add(new Lector("Archil", "juancho", "Lector"));
            ListaLectores.Add(new Lector("carlos", "batz", "Lector"));
            ListaBibliotecarios.Add(new Blibliotecario("Pablito666","ApjLorenzo","Bibliotecario"));
            ListaBibliotecarios.Add(new Blibliotecario("tonnotos", "tonny", "Bibliotecario"));
            ListaLibros.Add(new Libro("don quijote", "robet piere", "123456", "historico", true, 2));
            ListaLibros.Add(new Libro("leyes del poder", "robert green", "234567", "Psicologico", false, 1));
            ListaLibros.Add(new Libro("Naturaleza humana", "robert green", "345678", "Filosofico", true, 0));
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
        public static string InfoLibros(List<Libro>libros)
        {
            int totalLibros = libros.Count;
            int disponibles = libros.Count(l => l.Disponibilidad);
            int prestados = totalLibros - disponibles;
            return $"Tienes {totalLibros} libros en tu cat�logo | {disponibles} disponibles | {prestados} prestado(s)";
        }
        public static string InfoUsuarios(List<Blibliotecario> bibliotecarios, List<Lector> lectores)
        {
            int totalBibliotecarios = bibliotecarios.Count;
            int totalLectores = lectores.Count;
            int totalUsuarios = totalBibliotecarios + totalLectores;

            return $"Total de usuarios: {totalUsuarios}\n" +
                   $"Bibliotecarios: {totalBibliotecarios}\n" +
                   $"Lectores: {totalLectores}";
        }
        public static void ComprobarPassword(string nombre, string password)
        {
            if (BuscarUsuario(nombre) != null)
            {
                var usuarioInicio = BuscarUsuario(nombre);


                if (usuarioInicio.Name == nombre && usuarioInicio.Password == password)
                {

                    if (usuarioInicio.Rol == "Bibliotecario")
                    {
                        FormLogin.instancia.Hide();
                        FormBibliotecario ventanaBibliotecario = new FormBibliotecario();
                        ventanaBibliotecario.Show();
                    }
                    else if (usuarioInicio.Rol == "Lector")
                    {
                        FormLogin.instancia.Hide();
                        FormLector ventanaLector = new FormLector(usuarioInicio);
                        ventanaLector.Show();

                    }

                }
                else if (usuarioInicio.Name != nombre || usuarioInicio.Password != password)
                {

                    MessageBox.Show("Alguno o ambos parametreos de inicio se encuentra incorrectos");

                }
                else
                {
                    MessageBox.Show("parametros incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Usuario no valido");
            }
        }
        public static void AgregarUsuario(string nombre, string rol, string password)
        {
            if (rol == "Lector")
            {
                Lector nuevoLector = new Lector(password, nombre, rol);
                ListaLectores.Add(nuevoLector); // Agrega el nuevo lector a la lista
                MessageBox.Show("Nuevo lector agregado: " + nombre);
            }
            else if (rol == "Bibliotecario")
            {
                Blibliotecario nuevoBibliotecario = new Blibliotecario(password, nombre, rol);
                ListaBibliotecarios.Add(nuevoBibliotecario); // Agrega el nuevo bibliotecario a la lista
                MessageBox.Show("Nuevo bibliotecario agregado: " + nombre);
            }

        }
        public static Usuario BuscarUsuario(string nombre)
        {
            foreach (var n in ListaLectores)
            {
                if (n.Name == nombre)
                {
                    return n;
                }
            }
            foreach (var n in ListaBibliotecarios)
            {
                if (n.Name == nombre)
                {
                    return n;
                }
            }
            return null;

        }

        public static void CambiarUsuario(string nombre, string password, Usuario n)
        {
            if (nombre == "")
            {
                BuscarUsuario(n.Name).Password = password;
            }
            else if (password == "")
            {
                BuscarUsuario(n.Name).Name = nombre;
            }
            else
            {
                BuscarUsuario(n.Name).Password = password;
                BuscarUsuario(n.Name).Name = nombre;
            }
            MessageBox.Show("Usuario editado exitosamente ");
        }
        public static bool ComprobarExistencia(string nombre, string password)
        {
            if (BuscarUsuario(nombre) == null)
            {
                return true;
            }
            else
            {
                var usuarioBusquedaNombre = BuscarUsuario(nombre).Name;


                if (nombre == usuarioBusquedaNombre)
                {
                    return false;
                }
                else return true;
            }
        }

    }
}