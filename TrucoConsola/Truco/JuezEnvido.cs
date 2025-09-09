using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoConsola.Truco;

namespace TrucoConsola
{
    public class JuezEnvido
    {
        private readonly CalculadoraEnvio _calculadoraEnvido;

        public JuezEnvido(CalculadoraEnvio calculadoraEnvido)
        {
            _calculadoraEnvido = calculadoraEnvido;
        }

        public Jugador ResultadosDelEnvido(Dictionary<Jugador, int> manos)
        {
            if (manos.Count != 0)
            {

                List<KeyValuePair<Jugador, int>> resultado = manos.OrderByDescending(m => m.Value).ToList();


                int primer = resultado[0].Value;
                int segundo = resultado[1].Value;

                Jugador jugador1 = resultado[0].Key;
                Jugador jugador2 = resultado[1].Key;

                if (primer > segundo)
                {
                    return jugador1;
                }
                int jugador1Posicion = 0;
                int jugador2Posicion = 0;

                int posicion = 0;

                foreach (var jugador in manos)
                {
                    if(jugador.Key == jugador1) jugador1Posicion = posicion;
                    if(jugador.Key == jugador2) jugador2Posicion = posicion;
                    posicion++;

                }

                if (jugador1Posicion % 2 == 0) return jugador1;
                if (jugador1Posicion % 2 == 0) return jugador2;

            }
            else
            {
                throw new InvalidOperationException("El diccionario está vacío.");
            }
        }
    }
}
