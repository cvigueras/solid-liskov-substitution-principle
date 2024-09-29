namespace LiskovSubstitution.App
{
    public class AlquilerBicicleta : Alquiler
    {
        private readonly Usuario usuario;

        public AlquilerBicicleta(Usuario usuario) : base(usuario)
        {
            this.usuario = usuario;
        }

        public void Pedalear()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha comenzado a pedalear.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }
    }
}
