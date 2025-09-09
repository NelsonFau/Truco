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

                Dictionary<Jugador,int> resultado = manos
                    .OrderByDescending(m => m.Value)
                    .ToDictionary(m => m.Key, m => m.Value);

                int primer = resultado.Values.ElementAt(0);
                int segundo = resultado.Values.ElementAt(1);

                Jugador jugador1 = resultado.Keys.ElementAt(0);
                Jugador jugador2 = resultado.Keys.ElementAt(1);

                Jugador ganador;
                if (primer > segundo)
                {
                    ganador = resultado.Keys.ElementAt(0);
                    return ganador;
                }

                int indexJugador1 = manos.Keys.ToList().IndexOf(jugador1);
                int indexJugador2 = manos.Keys.ToList().IndexOf(jugador2);
               
                if (indexJugador1 % 2 == 0) return ganador = jugador1;
                if (indexJugador2 % 2 == 0) return ganador = jugador2;



            }
            else
            {
                throw new InvalidOperationException("El diccionario está vacío.");
            }
        }
    }
}
