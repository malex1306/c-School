namespace Quersumme
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Gib eine positive Zahl ein: ");
                int zahl = int.Parse(Console.ReadLine()!);

                if (zahl < 0)
                {
                    Console.WriteLine("Fehler: Bitte geben Sie eine positive Zahl ein.");
                    return; 
                }

                int quersumme = 0;

                while (zahl > 0)
                {
                    quersumme += zahl % 10;
                    zahl /= 10;
                }

                Console.WriteLine("Die Quersumme ist: " + quersumme);
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie gültige Zahlen ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}