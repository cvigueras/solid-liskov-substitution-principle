namespace LiskovSubstitution.App
{
    public class AlquilerBicicleta : Alquiler
    {
        private readonly Usuario usuario;

        public AlquilerBicicleta(Usuario usuario) : base(usuario)
        {
            this.usuario = usuario;
        }

        public void Arrancar()
        {
            throw new NotImplementedException("Una bicicleta no se arranca");
        }

        public void IncluirViajero()
        {
            throw new NotImplementedException("A una bicicleta no se le puede añadir un viajero");
        }

        public void Repostar()
        {
            throw new NotImplementedException("Una bicicleta no reposta");
        }
    }
}
