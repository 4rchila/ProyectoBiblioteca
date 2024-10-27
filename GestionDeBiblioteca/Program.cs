namespace GestionDeBiblioteca
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static List<Usuario> listaLectores = new List<Usuario>();
        public static List<Usuario> listaBibliotecarios = new List<Usuario>();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new form1());



        }
        public static void AgregarUsuario(string nombre, string rol, string password)
        {
            if (rol == "Lector")
            {
                Lector nuevoLector = new Lector(password,nombre, rol);
                listaLectores.Add(nuevoLector); // Agrega el nuevo lector a la lista
                MessageBox.Show("Nuevo lector agregado: " + nombre);
            }
            else if (rol == "Bibliotecario")
            {
                Blibliotecario nuevoBibliotecario = new Blibliotecario(password, nombre, rol);
                listaBibliotecarios.Add(nuevoBibliotecario); // Agrega el nuevo bibliotecario a la lista
                MessageBox.Show("Nuevo bibliotecario agregado: " + nombre);
            }

        }
        public static Usuario BuscarUsuario(string nombre)
        {
                foreach (var n in listaLectores)
                {
                    if (n.Name == nombre)
                    {
                        return n;
                    }
                }
            foreach (var n in listaBibliotecarios)
            {
                if (n.Name == nombre)
                {
                    return n;
                }
            }
            return null;

        }

        public static void CambiarUsuario(string nombre, string password,Usuario n) 
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