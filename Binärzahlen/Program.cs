

namespace Binärzahlen
{
    class Program
    {
        static void Main()
        {
            const int bit = 8;
            int[] Dezimalzahl = new int[bit];
            
            Console.Write("Bitte eine Dezimalzahl eingeben (0-255): ");
            int zahl = int.Parse(Console.ReadLine());

            if (zahl < 0 || zahl > 255)
            {
                Console.WriteLine("Bitte eine Zahl zwischen 0 und 255 eingeben.");
                return; // wird ausgegeben wenn die eingegeben zahl nicht im Bereich liegt
            }

            // Umrechnung von Dezimal zu Binär
            for (int i = bit - 1; i >= 0; i--) 
            {
                Dezimalzahl[i] = zahl % 2; // Letztes Bit (0 oder 1) speichern
                zahl /= 2; //verschiebt die Zahl eine Stelle nach rechts
            }

            // Ausgabe des Binärwerts
            Console.Write("Binärdarstellung: ");
            Console.WriteLine(string.Join("", Dezimalzahl));// wandelt Array in eine Zeichenkette um
        }
    }
}