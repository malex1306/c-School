using System;

namespace school
{
    class HelloWorld
    { 
        static void MyMethod()
        {
            
            
            Console.Write("Geben sie diem Länge an: ");
            int userInputL = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben sie die Breite an: ");
            int userInputB = Convert.ToInt32(Console.ReadLine());
            int Flaecheninhalt = userInputL * userInputB;
            int Umfang= (2*userInputL)+(2*userInputB);
            Console.Write("Der Flächeninhalt ist " + Flaecheninhalt  + " un der Umfang ist " + Umfang);
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}