

using TrucoConsola.Truco;

PaqueteMazo mazo = new PaqueteMazo();

mazo.CreacionCartas();

foreach (var carta in mazo.MostrarCartas())
{
    Console.WriteLine( carta.Numero + carta.Palo);
    
}