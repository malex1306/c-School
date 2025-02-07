namespace LuhnAlgorithmus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Ihre Kartennummer ein:");
            string cardNo = Console.ReadLine();
            
            if (checkLuhn(cardNo))
                Console.WriteLine("Die Karte ist gültig");
            else
                Console.WriteLine("Die Karte ist nicht gültig");
        }

        static bool checkLuhn(string cardNo)
        {
            int nZiffer = cardNo.Length; //nZiffer speichert die Anzahl der Ziffern
            int nSum = 0; //speichert die berechnete Summe
            bool isSecond = false; //verdoppelt jede zeite ziffer

            for (int i = nZiffer - 1; i >= 0; i--) //Rückwerts
            {
                if (!char.IsDigit(cardNo[i])) //Prüft ob es nur zahlen sind
                    return false;
                
                int ziffer = cardNo[i] - '0'; //umwandlung zeichen zu zahl
                
                if (isSecond)
                    ziffer *= 2; //2 Ziffer verdoppelt wenn über 9 dann zerlegen

                nSum += ziffer / 10; //bsp 8 bleibt 8
                nSum += ziffer % 10; // wenn über neun z.B 12 dann 1+2 =3
                
                isSecond = !isSecond;
            }
            return nSum % 10 == 0; // wenn die Summe durch 10 teilbar = Karte gültig
        }
    }
}