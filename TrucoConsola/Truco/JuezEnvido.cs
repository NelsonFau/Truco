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
       
        public string ResultadosDelEnvido(Dictionary<Jugador, int> manos)
        {
            string ganador;
            if (manos.Count != 0)
            {

                List<KeyValuePair<Jugador, int>> resultado = manos.OrderByDescending(m => m.Value).ToList();


                int primer = resultado[0].Value;
                int segundo = resultado[1].Value;

                Jugador jugador1 = resultado[0].Key;
                Jugador jugador2 = resultado[1].Key;
                string mensajeJugador1 = $"el gandor es:{jugador1}";
                string mensajeJugador2 = $"el gandor es:{jugador2}";


                if (primer > segundo)
                {
                    Console.WriteLine(mensajeJugador1);
                    ganador = mensajeJugador1;
                    return ganador;

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

                if (jugador1Posicion % 2 == 0) return mensajeJugador1;
                if (jugador2Posicion % 2 == 0) return mensajeJugador2;

            }
            else
            {
                throw new InvalidOperationException("El diccionario está vacío.");
            }
            return ganador = "No hay jugadores";

        }
    }
}
