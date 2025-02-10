using System;

namespace nSchoenheit
{
    class Program
    {
        static bool IsBeautifulNumber(int number)
        {
            int sum = 0;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digit);
                temp /= 10;
            }

            return sum == number;
        }

        static void Main()
        {
            Console.Write("Gib die untere Grenze ein: ");
            int lower = int.Parse(Console.ReadLine());

            Console.Write("Gib die obere Grenze ein: ");
            int upper = int.Parse(Console.ReadLine());

            Console.WriteLine($"Schöne Zahlen im Bereich {lower} bis {upper}:");

            bool found = false;
            for (int i = lower; i <= upper; i++)
            {
                if (IsBeautifulNumber(i))
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Keine schönen Zahlen in diesem Bereich gefunden.");
        }
    }
}