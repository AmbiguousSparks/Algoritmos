using AlgoritmosCore;
using System;
using System.Collections.Generic;

namespace AlgoritmosConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };
            Dictionary<int, int> grupos = Algoritmos.GroupNumbersByIntervals(numeros, 7);
            foreach(KeyValuePair<int, int> grupo in grupos)
                System.Console.WriteLine(grupo);
            Console.ReadKey();
        }
    }
}
