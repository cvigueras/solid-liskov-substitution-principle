namespace LiskovSubstitution.App
{
    public class Alquiler : IAlquiler
    {
        private readonly Usuario usuario;
        public Alquiler(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public void Alquilar()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de " +
                                            "alquilar un vehiculo.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void IniciarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha acaba de iniciar " +
                                            "un viaje.",
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
    }
}
