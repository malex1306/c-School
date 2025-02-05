using System;
using System.Linq;

namespace Quadratzahlen
{
    class Program
    {
        static void Main()
        {
            int[] zahlen = new int[10];

            for (int i = 0; i < 10; i++)
            {
                zahlen[i] = (int) Math.Pow(i + 1, 2); // i + 1, um 1-10 statt 0-9 zu nutzen
            }

            Console.WriteLine(string.Join(",", zahlen.Reverse()));
        }
    }
}