using System.Collections.Generic;
using TrucoConsola.Truco;
using TrucoConsola.Cartas;
using Xunit;

namespace TrucoConsola.Tests
{
    public class CalculadoraEnvidoTests
    {
        [Fact]
        public void CalcularEnvido_JugadorConCartasDistintoPalo_DebeDevolverMayorValorSimple()
        {
            // Arrange
            Jugador jugador = new Jugador("Pedro");
            jugador.Mano = new List<Carta>
            {
                new Carta(7, "Espada"),
                new Carta(5, "Oro"),  
                new Carta(2, "Oro")     
            };

            Rabon rabon = new Rabon(new Carta(1, "Oro"), new List<Jugador> { jugador }); 
            CalculadoraEnvio calc = new CalculadoraEnvio();

            Dictionary<Jugador, int> resultados = calc.CalcularEnvido(rabon);

            Assert.Equal(37, resultados[jugador]); 
        }

        [Fact]
        public void CalcularEnvido_JugadorConDosCartasMismoPalo_DebeSumar20MasValores()
        {
            Jugador jugador = new Jugador("Raul");
            jugador.Mano = new List<Carta>
            {
                new Carta(7, "Oro"),
                new Carta(6, "Oro"),
                new Carta(12, "Espada")
            };

            Rabon rabon = new Rabon(new Carta(1, "Copa"), new List<Jugador> { jugador });
            CalculadoraEnvio calc = new CalculadoraEnvio();

            Dictionary<Jugador,int> resultados = calc.CalcularEnvido(rabon);

            Assert.Equal(20 + 7 + 6, resultados[jugador]);
        }

        [Fact]
        public void CalcularEnvido_JugadorConTresCartasMismoPalo_DebeDarCeroPorFlor()
        {
            Jugador jugador = new Jugador("Luis");
            jugador.Mano = new List<Carta>
            {
                new Carta(7, "Basto"),
                new Carta(6, "Basto"),
                new Carta(5, "Basto")
            };

            Rabon rabon = new Rabon( new Carta(1, "Copa"),new List<Jugador> { jugador });
            CalculadoraEnvio calc = new CalculadoraEnvio();

            var resultados = calc.CalcularEnvido(rabon);

            Assert.Equal(0, resultados[jugador]); 
        }

        [Fact]
        public void CalcularEnvido_VariosJugadores_DebeDevolverPuntajeParaCadaUno()
        {
            var jugador1 = new Jugador("Pedro")
            {
                Mano = new List<Carta>
                {
                    new Carta(7, "Espada"),
                    new Carta(5, "Oro"),
                    new Carta(3, "Copa")
                }
            };

            var jugador2 = new Jugador("Raul")
            {
                Mano = new List<Carta>
                {
                    new Carta(6, "Oro"),
                    new Carta(7, "Oro"),
                    new Carta(12, "Basto")
                }
            };

            Rabon rabon = new Rabon(new Carta(1, "Copa"), new List<Jugador> { jugador1, jugador2 });
            CalculadoraEnvio calc = new CalculadoraEnvio();

            Dictionary<Jugador,int> resultados = calc.CalcularEnvido(rabon);

            Assert.Equal(7, resultados[jugador1]);               // mayor simple
            Assert.Equal(20 + 6 + 7, resultados[jugador2]);      // envido con dos del mismo palo
        }
    }
}
