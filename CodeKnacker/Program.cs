namespace CodeKnacker
{
    class CodeCracker
    {
        static string secretCode = "1P3!5#"; //  Geheimer Code
        static string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~ "; // Erweiterte Zeichen
        static volatile bool found = false; // Beendet Parallel-Threads, wenn Code gefunden wurde
        static string crackedCode = null; // Speichert den gefundenen Code

        static void Main()
        {
            Console.WriteLine("🔍 Starte Code-Knacker Algorithmus...");

            // Schritt 1: Zeichen im Code herausfinden
            char[] possibleChars = FindCharacters();

            // Schritt 2: Parallel Brute-Force
            BruteForceCrack(possibleChars);

            Console.WriteLine($" Geheimer Code geknackt: {crackedCode ?? "Code konnte nicht geknackt werden"}");
        }

        // Prüft, wie viele Stellen in einer Eingabe mit dem Geheimcode übereinstimmen
        static int CheckCode(string attempt)
        {
            int correct = 0;
            for (int i = 0; i < Math.Min(secretCode.Length, attempt.Length); i++)
            {
                if (secretCode[i] == attempt[i])
                {
                    correct++;
                }
            }
            return correct;
        }

        // Schritt 1: Bestimmen, welche Zeichen im Code vorkommen
        static char[] FindCharacters()
        {
            Console.WriteLine(" Ermittlung der enthaltenen Zeichen...");
            List<char> foundChars = new List<char>();

            foreach (char c in characters)
            {
                string testCode = new string(c, secretCode.Length);
                int matches = CheckCode(testCode);

                if (matches > 0)
                {
                    foundChars.Add(c);
                    Console.WriteLine($" Zeichen '{c}' ist enthalten ({matches}x)");
                }
            }

            return foundChars.ToArray();
        }

        // Schritt 2: Multi-Threaded Brute-Force mit Parallel.ForEach
        static void BruteForceCrack(char[] chars)
        {
            Console.WriteLine("🔄 Parallel Brute-Force gestartet...");

            int maxLength = secretCode.Length;
            int totalCombinations = (int)Math.Pow(chars.Length, maxLength);

            Parallel.For(0, totalCombinations, (i, state) =>
            {
                if (found) state.Break(); // Stoppt alle Threads, wenn Code gefunden wurde

                char[] attemptArr = new char[maxLength];
                int num = i;

                for (int j = 0; j < maxLength; j++)
                {
                    attemptArr[j] = chars[num % chars.Length];
                    num /= chars.Length;
                }

                string attempt = new string(attemptArr);
                int matches = CheckCode(attempt);

                if (matches == secretCode.Length)
                {
                    Interlocked.Exchange(ref crackedCode, attempt); // Thread-sicher speichern
                    found = true; // Stoppt weitere Berechnungen
                    state.Break();
                }
            });
        }
    }
}
