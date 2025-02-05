

class Eratosthenes
{
    public static void FindPrimes(int n)
    {
        // Erstellt eine Liste von Zahlen von 2 bis n
        var numbers = Enumerable.Range(2, n - 1).ToList();

        // Implementiert das Sieb des Eratosthenes mit LINQ
        var primes = numbers.Where(x => !numbers.Any(y => y < x && x % y == 0)).ToList();

        // Gib alle Primzahlen aus
        Console.WriteLine("Primzahlen bis " + n + ":");
        Console.WriteLine(string.Join(" ", primes));
    }

    static void Main()
    {
        Console.Write("Gib eine Zahl ein, bis zu der du Primzahlen finden möchtest: ");
        int n = int.Parse(Console.ReadLine());

        FindPrimes(n);
    }
}