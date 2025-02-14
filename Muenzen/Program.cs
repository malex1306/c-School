
class Muenzwechsel
{
    static void Main()
    {
        Console.WriteLine("Geben Sie den Betrag ein, den Sie zurück bekommen: ");
        int betrag = Convert.ToInt32(Console.ReadLine());
        int[] geld = { 1, 2, 5, 10, 20, 50, 100, 200};
        int[] minCoins = new int[betrag + 1]; // Array zur Speicherung der minimalen Münzen für jeden Betrag bis zum gegebenen Betrag
        int[] lastCoin = new int[betrag + 1]; // Array zur Speicherung der letzten verwendeten Münze für jeden Betrag

        // Initialisierung: Für Betrag 0 werden 0 Münzen benötigt
        minCoins[0] = 0;

        // Berechnung der minimalen Münzen für jeden Betrag von 1 bis amount
        for (int i = 1; i <= betrag; i++)
        {
            minCoins[i] = int.MaxValue; // Setze den Wert zuerst auf ein sehr großes Integer

            // Iteriere über alle Münzarten
            for (int j = 0; j < geld.Length; j++)
            {
                // Überprüfe, ob die Münzart j verwendet werden kann
                if (geld[j] <= i && minCoins[i - geld[j]] + 1 < minCoins[i])
                {
                    minCoins[i] = minCoins[i - geld[j]] + 1;
                    lastCoin[i] = geld[j];
                }
            }
        }

        // Ausgabe der minimalen Anzahl von Münzen und der verwendeten Münzen
        Console.WriteLine($"Minimale Anzahl von Münzen für den Betrag {betrag} Cent: {minCoins[betrag]}");

        // Ausgabe der verwendeten Münzen
        Console.Write("Verwendete Münzen: ");
        int remaining = betrag;
        while (remaining > 0)
        {
            Console.Write(lastCoin[remaining] + " ");
            remaining -= lastCoin[remaining];
        }

    }
}