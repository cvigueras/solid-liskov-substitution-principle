namespace LiskovSubstitution.App
{
    public class Usuario
    {
        public string Nombre { get; }
        public string Apellidos { get; }

        public static Usuario Create(string nombre, string apellidos)
        {
            return new Usuario(nombre, apellidos);
        }

        private Usuario(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }
    }
}
