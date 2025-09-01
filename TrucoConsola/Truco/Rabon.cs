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
        public String? Ganador { get; set; }

        public Rabon(Carta muestra)
        {
            Muestra = muestra;
        }

      

        public void GanadorDelRabon(string nombre)
        {
            Ganador = nombre;
        }
    }
}
