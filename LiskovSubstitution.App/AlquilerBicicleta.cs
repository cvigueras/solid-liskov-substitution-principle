namespace LiskovSubstitution.App
{
    public class AlquilerBicicleta : IAlquiler
    {
        private readonly Usuario usuario;

        public AlquilerBicicleta(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public void Alquiler()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de " +
                                            "alquilar una bicicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }
        public void IniciarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de iniciar " +
                                            "un viaje en bicicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void FinalizarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha finalizado " +
                                            "el viaje en bicicleta.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void Pedalear()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha comenzado a pedalear.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }
    }
}
