

namespace ArrayMerge
{
    class Program
    {
        static int[] ArrayMerge(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;
            
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                    mergedArray[k++] = array1[i++];
                else
                    mergedArray[k++] = array2[j++];
            }
            
            while (i < array1.Length)
                mergedArray[k++] = array1[i++];
            
            while (j < array2.Length)
                mergedArray[k++] = array2[j++];
            
            return mergedArray;
        }

        static void Main()
        {
            int[] array1 = { 1, 3, 5, 7 };
            int[] array2 = { 2, 4 };
            
            int[] result = ArrayMerge(array1, array2);
            
            Console.WriteLine("Erzeugtes Array:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

