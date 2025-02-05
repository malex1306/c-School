

namespace teiler
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geben Sie die Obergrenze an:");
            int obergrenze = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die Untergrenze an:");
            int untergrenze = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie den Teiler an:");
            int teiler = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Zahlen zwischen {obergrenze} und {untergrenze}, die durch {teiler} teilbar sind:");
            
            bool last = true;
            for (int i = obergrenze; i >= untergrenze; i--)  
            {
                if (i % teiler == 0)
                {
                    if (!last)
                        Console.Write(", ");
        
                    Console.Write(i);
                    last = false; 
                }
            }
        }
    }
}