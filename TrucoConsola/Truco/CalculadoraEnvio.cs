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
        public void CalcularEnvido(Rabon rabon)
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

                    if(cartas.Count> 2)
                    {
                        
                    }
                }
            }
        }
}
