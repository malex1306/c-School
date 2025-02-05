using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 4, 7, 9, 13, 17, 18, 19, 23, 26, 30 };
        Console.Write("Geben Sie die zu suchende Zahl ein: ");
        int target = int.Parse(Console.ReadLine());

        int index = BinarySearch(array, target);

        if (index != -1)
        {
            Console.WriteLine($"Die Zahl {target} wurde an Position {index} gefunden.");
        }
        else
        {
            Console.WriteLine($"Die Zahl {target} wurde nicht gefunden.");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int lower = 0;
        int upper = array.Length - 1;

        while (lower <= upper)
        {
            int mid = (lower + upper) / 2;

            if (array[mid] == target)
                return mid; // gefunden

            if (array[mid] < target)
                lower = mid + 1; // Suche in der oberen Hälfte weiter
            else
                upper = mid - 1; // Suche in der unteren Hälfte weiter
        }

        return -1; // nicht gefunden
    }
}