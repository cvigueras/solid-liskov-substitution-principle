using LiskovSubstitution.App;
var usuarioBicicleta = Usuario.Create("Juan", "Biciclista");
var alquilerBicicleta = new AlquilerBicicleta(usuarioBicicleta);
alquilerBicicleta.Alquilar();
alquilerBicicleta.IniciarViaje();
alquilerBicicleta.Pedalear();
alquilerBicicleta.FinalizarViaje();
Console.ReadKey();
