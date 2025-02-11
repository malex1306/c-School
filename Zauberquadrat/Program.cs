using System;

class Program
{
    // Funktion zur Überprüfung, ob es sich um ein magisches Quadrat handelt
    static bool IstMagischesQuadrat(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        
        // Berechne die Summe der ersten Zeile (Annahme: n >= 1)
        int summeReferenz = 0;
        for (int j = 0; j < n; j++)
        {
            summeReferenz += matrix[0, j];
        }
        
        // Überprüfe jede Zeile
        for (int i = 1; i < n; i++)
        {
            int summeZeile = 0;
            for (int j = 0; j < n; j++)
            {
                summeZeile += matrix[i, j];
            }
            if (summeZeile != summeReferenz)
            {
                return false;
            }
        }
        
        // Überprüfe jede Spalte
        for (int j = 0; j < n; j++)
        {
            int summeSpalte = 0;
            for (int i = 0; i < n; i++)
            {
                summeSpalte += matrix[i, j];
            }
            if (summeSpalte != summeReferenz)
            {
                return false;
            }
        }
        
        // Überprüfe die Hauptdiagonale
        int summeHauptdiagonale = 0;
        for (int i = 0; i < n; i++)
        {
            summeHauptdiagonale += matrix[i, i];
        }
        if (summeHauptdiagonale != summeReferenz)
        {
            return false;
        }
        
        // Überprüfe die Nebendiagonale
        int summeNebendiagonale = 0;
        for (int i = 0; i < n; i++)
        {
            summeNebendiagonale += matrix[i, n - 1 - i];
        }
        if (summeNebendiagonale != summeReferenz)
        {
            return false;
        }
        
        return true;
    }

    static void Main()
    {
        // Beispiel-Matrix
        int[,] matrix = {
            {2, 7, 6},
            {9, 5, 1},
            {4, 3, 8}
        };

        // Testen der Funktion
        if (IstMagischesQuadrat(matrix))
        {
            Console.WriteLine("Die Matrix ist ein magisches Quadrat.");
        }
        else
        {
            Console.WriteLine("Die Matrix ist kein magisches Quadrat.");
        }
    }
}