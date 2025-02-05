

namespace ZahlenstatistikNew
{
    class Program
    {
        static void Main()
        {
            // Liste mit 10 Zufallszahlen erstellen
            List<int> zahlenListe = GeneriereZufallszahlen(10);

            // Liste sortieren
            zahlenListe.Sort();

            // Werte berechnen
            int summe = zahlenListe.Sum();
            double durchschnitt = BerechneDurchschnitt(zahlenListe);
            int kleinsterWert = zahlenListe.Min();
            int groessterWert = zahlenListe.Max();
            Dictionary<int, int> haeufigkeit = BerechneHaeufigkeit(zahlenListe);

            // Ausgabe der Liste
            Console.WriteLine("Sortierte Liste: " + string.Join(", ", zahlenListe));

            // Berechnung der Summe
            Console.WriteLine("Berechnung der Summe:");
            Console.WriteLine($"Die Summe dieser Zahlen ist: {summe}");

            // Berechnung des Durchschnitts
            Console.WriteLine("Berechnung des Durchschnittswerts:");
            Console.WriteLine($"Durchschnittswert = {durchschnitt:F2}");

            // Berechnung des kleinsten Werts
            Console.WriteLine("Berechnung des kleinsten Werts:");
            Console.WriteLine($"Kleinster Wert = {kleinsterWert}");

            // Berechnung des größten Werts
            Console.WriteLine("Berechnung des größten Werts:");
            Console.WriteLine($"Größter Wert = {groessterWert}");

            // Häufigkeit
            Console.WriteLine("Häufigkeit der Werte:");
            foreach (var item in haeufigkeit)
            {
                Console.Write($"Zahl {item.Key}: {item.Value} mal | "); 
            }
        }

        // Methode zur Generierung von Zufallszahlen
        static List<int> GeneriereZufallszahlen(int anzahl)
        {
            Random rand = new Random();
            List<int> zahlen = new List<int>();

            for (int i = 0; i < anzahl; i++)
            {
                zahlen.Add(rand.Next(1, 100)); // Zufallszahlen zwischen 1 und 100
            }

            return zahlen;
        }

        // Methode zur Berechnung des Durchschnitts
        static double BerechneDurchschnitt(List<int> zahlen)
        {
            if (zahlen.Count == 0)
                return 0;

            return (double)zahlen.Sum() / zahlen.Count;
        }

        // Methode zur Berechnung der Häufigkeit jedes Wertes
        static Dictionary<int, int> BerechneHaeufigkeit(List<int> zahlen)
        {
            Dictionary<int, int> haeufigkeit = new Dictionary<int, int>();

            foreach (int zahl in zahlen)
            {
                if (haeufigkeit.ContainsKey(zahl))
                    haeufigkeit[zahl]++;
                else
                    haeufigkeit[zahl] = 1;
            }

            return haeufigkeit;
        }
    }
}
