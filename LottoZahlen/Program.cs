namespace LottoZahlen
{
    class Program
    {
        static void Main()
        {
            bool[] arrayZahlen = new bool[50]; // Index 1-49 nutzen 
            int[] lottozahlen = new int[6];
            Random rnd = new Random();
            int count = 0;

            while (count < 6)
            {
                int zahl = rnd.Next(1, 50); // Zahl zwischen 1 und 49
                if (!arrayZahlen[zahl]) // Falls die Zahl noch nicht verwendet wurde
                {
                    lottozahlen[count] = zahl; // Speichern
                    arrayZahlen[zahl] = true; // Als verwendet markieren
                    count++; // Nächste Zahl
                }
            }

            Array.Sort(lottozahlen); // Lottozahlen sortieren

            Console.WriteLine($"Ihre Lottozahlen sind: {string.Join(", ", lottozahlen)}");
        }
    }
}