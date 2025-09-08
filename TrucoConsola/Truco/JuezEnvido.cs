using System;
using System.Collections.Generic;
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
            int mayor = 0;
            Jugador ganador = new Jugador("raul");

            if (manos.Count != 0)
            {

                foreach (var mano in manos)
                {
                    if (mano.Value > mayor)
                    {
                        mayor = mano.Value;
                        ganador = mano.Key;
                    }
                }

                return ganador;
            }
            else
            {
                throw new InvalidOperationException("El diccionario está vacío.");
            }
        }
    }
}
