namespace LiskovSubstitution.App
{
    public class AlquilerMotocicleta : Alquiler
    {
        private readonly Usuario usuario;

        public AlquilerMotocicleta(Usuario usuario) : base(usuario)
        {
            this.usuario = usuario;
        }
        public void Arrancar()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha arrancado la motocicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void IncluirViajero()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha incluido un " +
                                            "viajero nuevo en la motocicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void Repostar()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha parado a repostar" +
                                            "la motocicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }
    }
}
