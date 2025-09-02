using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoConsola.Cartas;

namespace TrucoConsola.Truco
{
    public class Rabon
    {
        public int RabonId { get; set; }
        public Carta Muestra { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Jugador? Ganador { get; set; }

        public Rabon(Carta muestra, List<Jugador> jugadores)
        {
            Muestra = muestra;
            Jugadores = jugadores;

        }

        public List<Carta> ManosDeJugadores(List<Jugador> jugadores)
        {
            foreach (var jugador in jugadores)
            {
                return jugador.MostrarMano();

            }
        }
        
        //public void guardarMano(List<Carta> mano, )
        //{

        //}
        public void GanadorDelRabon(Jugador jugador)
        {
            Ganador = jugador;
        }
    }
}
