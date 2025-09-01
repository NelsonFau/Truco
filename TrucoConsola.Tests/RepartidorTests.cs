using System.Collections.Generic;
using System.Linq;
using TrucoConsola.Truco;
using TrucoConsola.Cartas;
using Xunit;

namespace TrucoConsola.Tests;

public class RepartidorTests
{
    [Fact]
    public void BarajarCartas_Debe_DevolverTodasLasCartas_Mezcladas()
    {
        Repartidor repartidor = new Repartidor();

        List<Carta> barajadas = repartidor.BarajarCartas();

        Assert.Equal(40, barajadas.Count);

        PaqueteMazo original = new PaqueteMazo();
        original.CreacionCartas();
        List<Carta> originalCartas = original.MostrarCartas();

        bool ordenIgual = originalCartas
            .Select(c => $"{c.Numero}-{c.Palo}")
            .SequenceEqual(barajadas.Select(c => $"{c.Numero}-{c.Palo}"));

        Assert.False(ordenIgual, "El mazo no parece haber sido mezclado");
    }


    [Fact]
    public void RepartirCartas_Debe_RepartirCorrectamenteYAsignarRabon()
    {
        Repartidor repartidor = new Repartidor();
        List<Carta> mazo = repartidor.BarajarCartas();

        List<Jugador> jugadores = new List<Jugador>
        {
            new Jugador("Jugador1"),
            new Jugador("Jugador2")
        };

        int cartasXJugador = 3;

      
        Rabon rabon = repartidor.RepartirCartas(mazo, jugadores, cartasXJugador);

        foreach (var jugador in jugadores)
        {
            Assert.Equal(cartasXJugador, jugador.MostrarMano().Count());
        }

        Assert.NotNull(rabon);

        int cartasEsperadasEnMazo = 40 - (cartasXJugador * jugadores.Count) - 1;
        Assert.Equal(cartasEsperadasEnMazo, mazo.Count);
    }

}
