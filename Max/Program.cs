using System;
using System.Runtime.CompilerServices;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double zahl1 = 0.0;
                double zahl2= 0.0;
                
                
                Console.Write("Bitte geben Sie eine Zahl an ");
                zahl1 = double.Parse(Console.ReadLine());
                Console.Write("Bitte geben Sie einen zweite zahl ein ");
                zahl2 = double.Parse(Console.ReadLine());
                //Selection
                
                if (zahl1 > zahl2)
                {
                    Console.Write("Die groessere Zahl ist " + zahl1);
                }
                else if (zahl1 < zahl2)
                {
                    Console.Write("Die groessere Zahl ist " + zahl2);
                }
                else 
                {
                    Console.Write("Die zahlen sind gleich gross");
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte geben Sie eine gültige Zahl ein. ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten: " + ex.Message);
            }
        }
    }
}