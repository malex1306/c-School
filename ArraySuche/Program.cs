
namespace Quadratzahlen
{
    class Program
    {
        static void Main()
        {
            const int numCount = 50;
            int[] numbers = new int[numCount];
            Random rnd = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(1, 100); // Bereich 1-99
            
            Console.Write("Bitte Zahl zum Suchen eingeben: ");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = false; //dient als Flag, um zu prüfen, ob die Zahl im Array existiert

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search) // serach sucht nach der Zahl und übergibt zum index i
                {
                    Console.WriteLine($"Gefunden! Die Zahl {search} steht an Stelle {i}.");
                    found = true;
                    
                }
            }

            if (!found)
                Console.WriteLine("Die Zahl wurde nicht gefunden.");// nach der schleife noch false Zahl wurde nicht gefunden

            
            Console.WriteLine("\nGenerierte Zahlen:"); // zeigt die generierten zahlen
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}