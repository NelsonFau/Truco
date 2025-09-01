using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrucoConsola.Cartas;

namespace TrucoConsola.Truco
{
    public class PaqueteMazo
    {
        private List<Carta> Mazo = new List<Carta>();
        private List<string> Palos = new List<string> { "Oro", "Basto", "Copa", "Espada" };

        public void CreacionCartas()
        {

            foreach (var palo in Palos)
            {
                int cantidadXMazo = 12;
                for (int i = 1; i <= cantidadXMazo; i++)
                {
                    if (i != 8 && i != 9)
                    {
                        Carta carta = new Carta(i, palo);
                        AgregarCarta(carta);
                    }
                }
            }

        }

        public List<Carta> MostrarCartas()
        {
            return Mazo;
        } 

        public void AgregarCarta (Carta carta)
        {
            Mazo.Add(carta);
        }
    
    }
}
