

namespace Arraydimension
{
    class Program
    {
        static void Main()
        {
            Console.Write("Geben Sie die Anzahl der Zeilen ein: ");
            int rows = int.Parse(Console.ReadLine()!);

            Console.Write("Geben Sie die Anzahl der Spalten ein: ");
            int cols = int.Parse(Console.ReadLine()!);

            int[,] array = new int[rows, cols];
            Random rand = new Random();

            Console.WriteLine("Das zufällig generierte Array ist:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(1, 100); // Zufallszahlen zwischen 1 und 100
                }
            }

            PrintArray(array);
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}