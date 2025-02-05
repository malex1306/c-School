using System;
using System.Runtime.CompilerServices;

namespace Rabatt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double einkaufsWert = 0.0;
                double rabatt= 0.0;
                double preis = 0.0;
                
                Console.Write("Bitte geben Sie ihren Einkaufswert an ");
                einkaufsWert = double.Parse(Console.ReadLine());
                Console.Write("Bitte geben Sie einen Rabatt ein ");
                rabatt = double.Parse(Console.ReadLine());
                //Selection
                
                if (rabatt > 25)
                {
                   rabatt = 25;
                }
                
                preis = (einkaufsWert * rabatt) / 100;
                preis = einkaufsWert - preis;
                Console.WriteLine("Der Rabatt ist " + preis);
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
