namespace LiskovSubstitution.App
{
    public class Alquiler
    {
        private readonly Usuario usuario;

        public Alquiler(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public void Arrancar()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha arrancado el vehiculo.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void FinalizarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha finalizado el viaje",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void IncluirViajero()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha incluido un viajero nuevo.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void IniciarViaje()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha iniciado el viaje",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void Pedalear()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha comenzado a pedalear.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }

        public void Repostar()
        {
            Console.WriteLine(string.Format("El usuario {0} {1} ha parado a repostar.",
                              usuario.Nombre,
                              usuario.Apellidos));
        }
    }
}
