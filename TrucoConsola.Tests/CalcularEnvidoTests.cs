using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoConsola.Cartas;
using TrucoConsola.Truco;

namespace TrucoConsola.Tests
{
    public class CalcularEnvidoTests
    {
        [Fact]
        public void CalcualrEnvido_ValidarQueSiSonDelMismoPaloElValorSea20()
        {


            // Arrange
            Repartidor PaqueteMazo = new Repartidor();


            List<Jugador> jugadores = new List<Jugador>
            {
                new Jugador("pedro"),
                new Jugador("raul")
            };

            List<Carta> mazo = new List<Carta>
            {
                     new Carta (12, "Basto"),
                     new Carta(7, "Oro"),
                     new Carta(10, "Copa"),
                     new Carta (3, "Basto"),
                     new Carta(12, "Copa"),
                     new Carta(4, "Espada"),
                     new Carta (10, "Oro")
            };

            Rabon rabon = PaqueteMazo.RepartirCartas(mazo, jugadores, 3);

            CalculadoraEnvio calc = new CalculadoraEnvio();
            Dictionary<Jugador, int> envidos = calc.CalcularEnvido(rabon);

            int valorPedro = envidos[jugadores[0]]; 
            
            Assert.Equal(20, valorPedro);

        }
    }
}


