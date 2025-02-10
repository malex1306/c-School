using System;

namespace FalscheMuenze
{
    class Program
    {
        // Methode, um die falsche Münze zu finden
        static int FindFakeCoin(int[] coins, int left, int right)
        {
            if (right == left)
            {
                return coins[left]; // Nur eine Münze übrig, also ist sie falsch
            }

            // Anzahl der Münzen in der aktuellen Gruppe
            int length = right - left + 1;

            // Wenn nur noch 3 Münzen übrig sind, dann vergleichen wir sie direkt
            if (length == 3)
            {
                int sumLeft = coins[left];
                int sumMiddle = coins[left + 1];
                int sumRight = coins[left + 2];

                if (sumLeft == sumMiddle) return coins[left + 2];
                if (sumLeft == sumRight) return coins[left + 1];
                return coins[left];
            }

            // Teilen in zwei Gruppen (dies verhindert das Problem mit der Rekursion)
            int mid = (left + right) / 2;

            // Berechne die Summe der beiden Hälften
            int sumLeftGroup = SumGroup(coins, left, mid);
            int sumRightGroup = SumGroup(coins, mid + 1, right);

            if (sumLeftGroup == sumRightGroup)
            {
                // Falsche Münze muss in der verbleibenden Mitte sein
                return FindFakeCoin(coins, mid + 1, right);
            }
            else if (sumLeftGroup > sumRightGroup)
            {
                // Falsche Münze ist in der linken Gruppe
                return FindFakeCoin(coins, left, mid);
            }
            else
            {
                // Falsche Münze ist in der rechten Gruppe
                return FindFakeCoin(coins, mid + 1, right);
            }
        }

        // Methode zur Berechnung der Summe einer Gruppe von Münzen
        static int SumGroup(int[] coins, int left, int right)
        {
            int sum = 0;
            for (int i = left; i <= right; i++)
            {
                sum += coins[i];
            }
            return sum;
        }

        // Hauptprogramm
        static void Main(string[] args)
        {
            // Beispiel: 1 ist die falsche Münze, und sie ist leichter
            int[] coins = new int[] { 10, 10, 10, 10, 5, 10, 10 }; // 5 ist die falsche Münze

            int fakeCoin = FindFakeCoin(coins, 0, coins.Length - 1);
            Console.WriteLine("Die falsche Münze hat den Wert: " + fakeCoin);
        }
    }
}
 