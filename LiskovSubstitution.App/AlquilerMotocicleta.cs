namespace LiskovSubstitution.App
{
    public class AlquilerMotocicleta : IAlquiler
    {
        private readonly Usuario usuario;

        public AlquilerMotocicleta(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public void Alquiler()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de " +
                                            "alquilar una motocicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void IniciarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de iniciar " +
                                            "un viaje en motocicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void FinalizarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha finalizado el viaje",
                              usuario.Nombre,
                              usuario.Apellidos));
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
