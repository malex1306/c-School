namespace Temperatur_Konverter
{
    class Program
    {
        static void Main()
        {
            float t;
            char n;

            Console.WriteLine("Bedienungsanleitung: C, R, F, K als Temperatureinheiten eingeben.");
            Console.WriteLine("Mit 'q' beenden.");

            do
            {
                Console.Write("\nModus (K, C, F, R) eingeben: ");
                n = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                
                if (n == 'q') break; // Beenden
                
                Console.Write("Temperatur eingeben: ");
                if (!float.TryParse(Console.ReadLine(), out t))
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }
                
                float celsius;
                switch (n)
                {
                    case 'C':
                        celsius = t;
                        break;
                    case 'R':
                        celsius = t / 1.25f;
                        break;
                    case 'F':
                        celsius = (t - 32) * 5 / 9;
                        break;
                    case 'K':
                        celsius = t - 273.15f;
                        break;
                    default:
                        Console.WriteLine("Unbekannte Einheit! Bitte C, R, F oder K eingeben.");
                        continue;
                }
                
                Console.WriteLine($"\nAlle Temperaturen:");
                Console.WriteLine($"Celsius: {celsius:F2}°C");
                Console.WriteLine($"Reaumur: {celsius * 0.8:F2}°R");
                Console.WriteLine($"Fahrenheit: {(celsius * 9 / 5) + 32:F2}°F");
                Console.WriteLine($"Kelvin: {celsius + 273.15:F2} K");
                Console.WriteLine("Zum beenden q drücken");

            } while (true);
        }
    }
}