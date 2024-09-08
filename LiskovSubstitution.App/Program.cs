using LiskovSubstitution.App;
var usuarioBicicleta = Usuario.Create("Juan", "Biciclista");
var alquilerBicicleta = new AlquilerBicicleta(usuarioBicicleta);
alquilerBicicleta.Pedalear();
Console.ReadKey();
