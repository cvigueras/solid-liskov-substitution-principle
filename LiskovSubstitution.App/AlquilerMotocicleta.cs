namespace LiskovSubstitution.App
{
    public class AlquilerMotocicleta : Alquiler
    {
        private readonly Usuario _usuario;

        public AlquilerMotocicleta(Usuario usuario) : base(usuario)
        {
            this._usuario = usuario;
        }

        public void Pedalear()
        {
            throw new NotImplementedException("En una motocicleta no se pedalea.");
        }
    }
}
