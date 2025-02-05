namespace vorNachname
{



    class Program
    {
        static void Main()
        {
            Console.Write("Anzahl Personen: ");
            int anzahl = int.Parse(Console.ReadLine());

            string[] vornamen = new string[anzahl];
            string[] nachnamen = new string[anzahl];

            for (int i = 0; i < anzahl; i++)
            {
                Console.Write("Eingabe Vorname: ");
                vornamen[i] = Console.ReadLine();

                Console.Write("Eingabe Nachname: ");
                nachnamen[i] = Console.ReadLine();
            }

            Console.WriteLine("\nAusgabe der Namen:");
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine(vornamen[i] + " " + nachnamen[i]);
            }
        }
    }
}