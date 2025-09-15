using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucoConsola.Cartas;

namespace TrucoConsola.Truco
{
    public class CalculadoraEnvio
    {
        public Dictionary<Jugador, int> CalcularEnvido(Rabon rabon)
        {
            Dictionary<Jugador, int> resultados = new Dictionary<Jugador, int>();

            foreach (Jugador jugador in rabon.Jugadores)
            {
                List<Carta> mano = jugador.Mano;

                int maxEnvido = 0;
                bool tieneFlor = false;

                for (int i = 0; i < mano.Count; i++)
                {
                    int iguales = 1;
                    List<Carta> mismoPalo = new List<Carta> { mano[i] };

                    for (int j = 0; j < mano.Count; j++)
                    {
                        if (i != j && mano[i].Palo == mano[j].Palo)
                        {
                            iguales++;
                            mismoPalo.Add(mano[j]);
                        }
                    }

                    if (iguales == 3)
                    {
                        tieneFlor = true;
                        maxEnvido = 0;
                        break;
                    }
                    else if (iguales == 2)
                    {
                        int puntos = 20 + mismoPalo.Sum(c => c.ValorEnvido(rabon.Muestra));
                        if (puntos > maxEnvido)
                            maxEnvido = puntos;
                    }
                    else
                    {
                        int puntos = mano[i].ValorEnvido(rabon.Muestra);
                        if (puntos > maxEnvido)
                            maxEnvido = puntos;
                    }
                }
                resultados[jugador] = maxEnvido;
            }
            return resultados;

        }
    }
}
