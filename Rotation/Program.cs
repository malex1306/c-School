namespace Rotation
{



    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geben Sie eine Zeichenkette ein:");
            string input = Console.ReadLine();

            // Alle Rotationen ausgeben
            for (int i = 0; i < input.Length; i++)
            {
                string rotation = input.Substring(i) + input.Substring(0, i);
                Console.WriteLine(rotation);
            }
        }
    }
}