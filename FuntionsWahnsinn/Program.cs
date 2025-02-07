namespace FuntionsWahnsinn
{

    class Program
    {
        static int Funktion1(int x)
        {
            x += 1;
            int y = Funktion2(x);
            return x + y;
        }

        static int Funktion2(int x)
        {
            x += 2;
            int y = Funktion3(x);
            return x + y;
        }

        static int Funktion3(int x)
        {
            x += 3;
            int y = Funktion4(x);
            return x + y;
        }

        static int Funktion4(int x)
        {
            x += 4;
            return x;
        }

        static void Main()
        {
            int x = 42;
            int y = Funktion1(x);
            int result = x + y;
            Console.WriteLine(result); 
        }
    }
}