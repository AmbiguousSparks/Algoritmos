using AlgoritmosCore;
using System;
using System.Diagnostics;

namespace AlgoritmosConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100000];

            Random random = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 10000);
            }
            //foreach(int numero in numeros)
            //    Console.Write("primeira:" + numero + "\t");

            Stopwatch stopwatch = Stopwatch.StartNew();

            Algoritmos.OrderNumbersQuickSort(numeros, 0, numeros.Length - 1);
            //Algoritmos.OrderNumersInsertionSort(numeros);
            stopwatch.Stop();

            Console.WriteLine(TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).TotalSeconds);

            Console.ReadKey();

        }
    }
}
