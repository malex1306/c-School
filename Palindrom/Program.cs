namespace Palinfrom
{



    class Program
    {
        static void Main()
        {
            Console.Write("Gib ein Wort oder eine Zahl ein: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
                Console.WriteLine("Es ist ein Palindrom!");
            else
                Console.WriteLine("Es ist kein Palindrom.");
        }

        static bool IsPalindrome(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            // Zeichen normalisieren: Kleinbuchstaben, keine Sonderzeichen oder Leerzeichen
            string cleaned = new string(text.ToLower().Where(char.IsLetterOrDigit).ToArray());

            // Umgekehrten Text erstellen
            string reversed = new string(cleaned.Reverse().ToArray());

            return cleaned == reversed;
        }
    }
}