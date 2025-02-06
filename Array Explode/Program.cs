
namespace Array_Explode
{
    class Program
    {
        static int[] ArrayExplode(int zahl)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= zahl; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    list.Add(i); 
                }
            }

            return list.ToArray();
        }

        static void Main()
        {
            Console.Write("Geben Sie eine Zahl ein: ");
            int zahl = int.Parse(Console.ReadLine());

            int[] result = ArrayExplode(zahl);

            Console.WriteLine("Erzeugtes Array:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
