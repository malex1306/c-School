namespace WeiterEingabe
{

    class Program
    {
        static void Main()
        {
            double doubleValue = ReadDouble("Kommazahl eingeben:");
            decimal decimalValue = ReadDecimal("Dezimalzahl eingeben:");
            bool boolValue = ReadBoolean("Fortfahren? (ja/nein)");

            Console.WriteLine($"Double: {doubleValue}, Decimal: {decimalValue}, Boolean: {boolValue}");
        }

        static double ReadDouble(string prompt)
        {
            double result;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine()!;
                if (double.TryParse(input, out result))
                {
                    return result;
                }

                Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Kommazahl eingeben.");
            }
        }

        static decimal ReadDecimal(string prompt)
        {
            decimal result;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine()!;
                if (decimal.TryParse(input, out result))
                {
                    return result;
                }

                Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Dezimalzahl eingeben.");
            }
        }

        static bool ReadBoolean(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt + " (ja/nein)");
                string input = Console.ReadLine()!.Trim().ToLower();
                if (input == "ja" || input == "true")
                {
                    return true;
                }

                if (input == "nein" || input == "false")
                {
                    return false;
                }

                Console.WriteLine("Ungültige Eingabe. Bitte 'ja' oder 'nein' eingeben.");
            }
        }
    }
}