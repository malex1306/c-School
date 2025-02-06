namespace Quadratzahlen
{
    class Program
    {
        static void Main()
        {
            const int rows = 10;
            const int cols = 10;
            int[,] numbers = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    numbers[i, j] = rnd.Next(1, 100); // Bereich 1-99
                }
            }

            Console.Write("Bitte Zahl zum Suchen eingeben: ");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (numbers[i, j] == search)
                    {
                        Console.WriteLine($"Gefunden! Die Zahl {search} steht an Stelle ({i}, {j}).");
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine("Die Zahl wurde nicht gefunden.");

            Console.WriteLine("\nGenerierte Zahlen:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(numbers[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}