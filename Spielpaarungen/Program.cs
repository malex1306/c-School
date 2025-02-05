namespace LottoZahlen
{
    class Program
    {
        static void Main()
        { 
            string[] teams = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        
            Console.WriteLine("Einmalige Spielpaarungen:");
        
                for (int i = 0; i < teams.Length; i++)
                {
                    for (int j = i + 1; j < teams.Length; j++)
                    {
                            Console.WriteLine($"{teams[i]} gegen {teams[j]}");
                    }
                } 
        }
    }
}
