using System;

namespace school
{
    class HelloWorld
    {
        static void MyMethod()
        {
            int x = 5;
            int y = 7;

            int temp =
                x;
            x = y;
            y = temp;
            
            Console.WriteLine($"x = {x}, y = {y}");
        }
            
        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}