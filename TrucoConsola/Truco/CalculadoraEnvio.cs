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
            Dictionary<Jugador,int> resultados = new Dictionary<Jugador, int>();

            foreach (var jugador in rabon.Jugadores)
            {
                List<Carta> mano = jugador.Mano;

                IEnumerable<IGrouping<string,Carta>> agruparXMano = mano.GroupBy((c) => c.Palo);
                int maxEnvido = 0;

                foreach(var grupo in agruparXMano)
                {
                    List<Carta> cartas = grupo.ToList();
                    if(cartas.Count >= 2)
                    {
                        //ordeno de mayo a menor el valor de carta del metodo ValorEnvido, y caputo las primeras 2
                        List<Carta> mejoresCartas = cartas.OrderByDescending((c) => c.ValorEnvido).Take(2).ToList();
                        int puntos = 20 + mejoresCartas.Sum((c) => c.ValorEnvido);
                        if (puntos > maxEnvido)
                        {
                            maxEnvido = puntos;
                        }
                    }
                    else
                    {
                        int puntos = cartas.Max((c => c.ValorEnvido));
                        if (puntos > maxEnvido)
                        {
                            maxEnvido = puntos;
                        }
                    }
                    resultados[jugador] = maxEnvido;
                }
            }
            return resultados;

        }
    }
