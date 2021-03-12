using System.Collections.Generic;
using System.Linq;

namespace AlgoritmosCore
{
    public class Algoritmos
    {
        /// <summary>
        /// Agrupa números em intervalos
        /// </summary>
        /// <param name="numeros">lista com os números</param>
        /// <param name="interval">intervalo</param>
        /// <returns></returns>
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

        /// <summary>
        /// Método para ordernar números usando a fórmula quick sort para ordenação mais rápida, muito eficiente com listas maiores
        /// </summary>
        /// <param name="numbers">array com os numeros a serem ordenados</param>
        /// <param name="inicioVetor">inicio do vetor, geralmente o index 0</param>
        /// <param name="fimVetor">fim do vetor, tamanho do array - 1</param>
        /// <returns></returns>
        public static int[] OrderNumbersQuickSort(int[] numbers, int inicioVetor, int fimVetor)
        {
            int inicio = inicioVetor, fim = fimVetor;
            int pivo = numbers[(inicio + fim) / 2];
            while(inicio <= fim)
            {
                while (numbers[inicio] < pivo)
                    inicio++;
                while (numbers[fim] > pivo)
                    fim--;
                if(inicio <= fim)
                {
                    int aux = numbers[inicio];
                    numbers[inicio] = numbers[fim];
                    numbers[fim] = aux;
                    inicio++;
                    fim--;
                }
            }
            if (inicioVetor < fim)
                OrderNumbersQuickSort(numbers, inicioVetor, fim);
            if (inicio < fimVetor)
                OrderNumbersQuickSort(numbers, inicio, fimVetor);
            return numbers;
        }

        /// <summary>
        /// ordenação utilizando a formula insertion sort, melhor para listas pequenas, pode ser muito ineficiente com listas grandes
        /// </summary>
        /// <param name="vetor">array com os números</param>
        public static void OrderNumersInsertionSort(int[] vetor)
        {
            for (var i = 1; i < vetor.Length; i++)
            {
                var aux = vetor[i];
                var j = i - 1;

                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j -= 1;
                }
                vetor[j + 1] = aux;

            }
        }
    }
}
