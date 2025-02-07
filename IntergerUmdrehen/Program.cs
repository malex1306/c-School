namespace IntergerUmdrehen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie eine Zahl ein!");
            int zahl = Convert.ToInt32(Console.ReadLine());

            int umgedrehteZahl = IntReverse(zahl);
            Console.WriteLine($"Die umgedrehte zahl ist: {umgedrehteZahl}");
        }


        static int IntReverse(int zahl)
        {
            int umgekehrt = 0;
            while (zahl != 0)
            {
                int ziffer = zahl % 10;
                umgekehrt = umgekehrt * 10 + ziffer;
                zahl /= 10;
            }

            return umgekehrt;
        }
    }
}