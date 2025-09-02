using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoConsola.Cartas;

namespace TrucoConsola.Truco
{
    public class Repartidor
    {
        private PaqueteMazo InyeccionCartas = new PaqueteMazo();
        public List<Carta> BarajarCartas()
        {
            InyeccionCartas.CreacionCartas();
            Random rng = new Random();
            List<Carta> mazo = InyeccionCartas.MostrarCartas();
            List<Carta> mezclados = mazo.OrderBy(x=>rng.Next()).ToList();

            return mezclados;
        }

        public Rabon RepartirCartas(List<Carta> mazo, List<Jugador> jugadores, int cartasXJugador)
        {
            for (int i = 0; i < cartasXJugador; i++) {
                foreach (var jugador in jugadores)
                {
                    Carta carta = mazo[0];
                    jugador.ManoJugador(carta);
                    mazo.RemoveAt(0);
                }
            }

            Carta muestra = mazo[0];
            mazo.RemoveAt(0);            
            Rabon rabon = new Rabon(muestra,jugadores);
            return rabon;

        }

        



    }
}
