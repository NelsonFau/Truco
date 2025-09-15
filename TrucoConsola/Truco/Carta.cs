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

        public int ValorPieza(int numero) {
            if (numero == 2) { return 30; }
            if (numero == 4) { return 29; }
            if (numero == 5) { return 28; }
            if (numero == 10 || numero == 11) { return 27; }
            return numero;
        }

        public int ValorEnvido(Carta muestra)
        {
            if (muestra.Palo == Palo)
            {
                int valor = ValorPieza(Numero);
                if (Numero == 12)
                {
                    valor = ValorPieza(muestra.Numero);
                }
                return valor;
            }
            return ValorCarta();
        }


        public int ValorCarta()
        {
            
            if (Numero >= 10) return 0;
            return Numero;
            
        }
    }
}

