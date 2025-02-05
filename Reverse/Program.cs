namespace Reverse
{



    class Program
    {
        static void Main()
        {
            Console.Write("Eingabe: ");
            string eingabe = Console.ReadLine();
            string umgekehrt = ReverseString(eingabe);
            Console.WriteLine($"Ausgabe: {umgekehrt}");
        }

        static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            int n = chars.Length;

            for (int i = 0; i < n / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[n - i - 1];
                chars[n - i - 1] = temp;
            }

            return new string(chars);
        }
    }
}