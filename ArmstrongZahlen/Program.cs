namespace ArmstrongZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie die Startzahl ein: ");
            int start = int.Parse(Console.ReadLine());
            
            Console.Write("Geben Sie die Endzahl ein: ");
            int ende = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Armstrong-Zahlen im Bereich {start} bis {ende}:");
            for (int i = start; i <= ende; i++)
            {
                if (IstArmstrongZahl(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int Potenziere(int basis, int exponent)
        {
            int ergebnis = 1;
            for (int i = 0; i < exponent; i++)
            {
                ergebnis *= basis;
            }
            return ergebnis;
        }

        static bool IstArmstrongZahl(int zahl)
        {
            int originalZahl = zahl;
            int summe = 0;
            int anzahlZiffern = zahl.ToString().Length;
            int temp = zahl;
            
            while (temp > 0)
            {
                int ziffer = temp % 10;
                summe += Potenziere(ziffer, anzahlZiffern);
                temp /= 10;
            }
            return summe == originalZahl;
        }
    }
}