namespace LiskovSubstitution.App
{
    public class AlquilerCoche : Alquiler
    {
        private readonly Usuario usuario;
        public AlquilerCoche(Usuario usuario) : base(usuario)
        {
            this.usuario = usuario;
        }

        public void Arrancar()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha arrancado el coche.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void IncluirViajero()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha incluido un " +
                                            "viajero nuevo en el coche.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void Repostar()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha parado a repostar" +
                                            "el coche.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }
    }
}
