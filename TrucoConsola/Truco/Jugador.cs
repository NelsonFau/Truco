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
        public List<Carta> Cartas { get; set; } = new List<Carta>();

        //public Jugador(string nombre)
        //{
        //    Nombre = nombre;
        //}

        public void RecibirCartas(Carta carta)
        {
            Cartas.Add(carta);
        }

        public List<Carta> MostrarMano()
        {
            return Cartas;
        }
    }
}
