using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoConsola.Cartas;

namespace TrucoConsola.Truco
{
    public class Jugador
    {
        public int JugadorId { get; set; }
        public string Nombre { get; set; }= string.Empty;
        public List<Carta> Mano { get; set; } = new List<Carta>();
        public int Puntos { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

        public void ManoJugador(Carta carta)
        {
            Mano.Add(carta);
        }

        public List<Carta> MostrarMano()
        {
            return Mano;
        }
    }
}
