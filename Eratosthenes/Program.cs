namespace Eratosthenes
{
    class program
    
    {
        public static void FindPrimes(int n)
        {
            // Erstellt ein Array von Booleans, das anzeigt, ob eine Zahl eine Primzahl ist.
            bool[] array = new bool[n + 1];

            // Setzt alle Zahlen von 2 bis n als potentiell Primzahlen
            for (int i = 2; i <= n; i++)
            {
                array[i] = true;
            }

            // Implementiert das Sieb des Eratosthenes
            for (int i = 2; i * i <= n; i++)
            {
                if (array[i])
                {
                    // Markiere alle Vielfachen von i als nicht prim
                    for (int j = i * i; j <= n; j += i)
                    {
                        array[j] = false;
                    }
                }
            }

            // Gib alle Primzahlen aus
            Console.WriteLine("Primzahlen bis " + n + ":");
            for (int i = 2; i <= n; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Gib eine Zahl ein, bis zu der du Primzahlen finden möchtest: ");
            int n = int.Parse(Console.ReadLine()!);

            FindPrimes(n);
        }
    }
}