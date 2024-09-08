namespace LiskovSubstitution.App
{
    public class AlquilerCoche : Alquiler
    {
        private readonly Usuario usuario;
        public AlquilerCoche(Usuario usuario) : base(usuario)
        {
            this.usuario = usuario;
        }

        public void Pedalear()
        {
            throw new NotImplementedException("En un coche no se pedalea.");
        }
    }
}
