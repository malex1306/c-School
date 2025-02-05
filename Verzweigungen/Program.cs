using System;

namespace Verzweigungen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double zahl = 0.0;
                
                Console.Write("Bitte geben Sie eine Zahl ein ");
                zahl = double.Parse(Console.ReadLine());
                
                //Selection
                
                if (zahl > 0)
                {
                    Console.WriteLine("Die eingegeben Zahl ist Positiv");
                }
                else
                {
                    Console.WriteLine("Die Zahl ist Negativ");
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