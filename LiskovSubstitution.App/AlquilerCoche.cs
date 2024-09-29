namespace LiskovSubstitution.App
{
    public class AlquilerCoche : IAlquiler
    {
        private readonly Usuario usuario;
        public AlquilerCoche(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public void Alquiler()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de " +
                                            "alquilar un coche.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void IniciarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de iniciar " +
                                            "un viaje en coche.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void FinalizarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha " +
                                            "finalizado el viaje",
                              usuario.Nombre,
                              usuario.Apellidos));
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
