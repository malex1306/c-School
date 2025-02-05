
namespace PasswortGenerator {
class program
{
    static void Main()
    {
        
        int[] zahlen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        
        int passwortLaenge = 10;

        
        Random random = new Random();

        
        string passwort = "";
        for (int i = 0; i < passwortLaenge; i++)
        {
            int zufälligeZahl = zahlen[random.Next(zahlen.Length)];
            passwort += zufälligeZahl.ToString();
        }

        
        Console.WriteLine("Generiertes Passwort: " + passwort);
    }
}
}