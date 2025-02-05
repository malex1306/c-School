using System;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               /* for(int i= 1; i <=5; i++)
                {
                    Console.WriteLine(i);
                }*/

                int i = 0;
                while (i <= 4)
                {
                    i ++;
                    Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie eine gültige Zahl ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten: " + ex.Message);
            }
        }
    }
}