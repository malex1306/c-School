

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie die Hoehe des Schachbretts ein: ");
        if (int.TryParse(Console.ReadLine(), out int hoehe) && hoehe > 0)
        {
            for (int i = 0; i < hoehe; i++)
            {
                for (int j = 0; j < hoehe; j++)
                {
                    // Prüft, ob die Summe der Indizes gerade oder ungerade ist
                    Console.Write((i + j) % 2 == 0 ? "#" : " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Bitte geben Sie eine gültige positive Zahl ein.");
        }
    }
}