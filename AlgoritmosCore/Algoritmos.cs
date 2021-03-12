using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosCore
{
    public class Algoritmos
    {
        public static Dictionary<int, int> GroupNumbersByIntervals(List<int> numeros, int interval)
        {
            //Determinando o número de grupos a serem criados
            int numGroups = numeros.Count / interval;
            //Determinando se sobram numeros
            int leftovers = numeros.Count % interval;
            Dictionary<int, int> groups = new Dictionary<int, int>(numGroups);
            //Enquanto ainda existirem grupos à serem criados
            while (numGroups > 0)
            {
                groups.Add(numeros[0], numeros[interval - 1]);
                numeros.RemoveRange(0, interval);
                numGroups--;
            }
            //Se sobrarem números, adicione-os a um novo grupo
            if (leftovers > 0)
                groups.Add(numeros.First(), numeros.ElementAt(leftovers - 1));

            return groups;
        }
    }
}
