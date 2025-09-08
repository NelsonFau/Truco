

using TrucoConsola.Cartas;
using TrucoConsola.Truco;

Repartidor PaqueteMazo = new Repartidor();



List<Carta> mazo = PaqueteMazo.BarajarCartas();

List<Jugador> jugadores = new List<Jugador>
        {
            new Jugador("pedro"),
            new Jugador("raul")
        };

// Supongamos que ya repartiste
Rabon rabon = PaqueteMazo.RepartirCartas(mazo, jugadores, 3);

// Calcular envido
CalculadoraEnvio calc = new CalculadoraEnvio();
Dictionary<Jugador, int> envidos = calc.CalcularEnvido(rabon);

foreach (var kvp in envidos)
{
    Console.WriteLine($"{kvp.Key.Nombre}: {kvp.Value} puntos de envido");
}
