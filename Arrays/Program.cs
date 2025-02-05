

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            try
            {
                const int numCount = 10; // 10 Zahlen generieren
                int[] numbers = new int[numCount];
                Random rnd = new Random();

                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] = rnd.Next(1, 101); // Zahlen zwischen 1 und 100
                   
                Array.Sort(numbers);
                // Zahlen ausgeben
                Console.WriteLine("Zufällige Zahlen:");
                foreach (int num in numbers)
                    Console.Write(num + " ");

                Console.WriteLine(); // Zeilenumbruch für bessere Lesbarkeit
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie gültige Zahlen ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}


