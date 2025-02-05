using System;

namespace school
{
    class HelloWorld
    {
        static void MyMethod()
        {
          
            
            Console.WriteLine("Geben sie die temperatur in Celsius an");
            double userInput = Convert.ToDouble(Console.ReadLine());
            userInput = (userInput * 9 / 5) + 32;
            Console.WriteLine("Temperatur in Fahrenheit ist " + "Fahrenheit " + userInput);
        }
            
        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}