using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoConsola.Cartas
{
    public class Carta
    {
        public int Numero { get; set; }
        public string Palo { get; set; } = string.Empty;


        public Carta(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
        }

        public int ValorEnvido
        {
            get
            {
                if (Numero >= 10) return 0;
                return Numero;
            }
        }
    }
}

