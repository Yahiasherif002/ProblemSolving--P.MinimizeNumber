using System;

internal class Program
{
   static long minmizeNumber(long [] arr)
    {
        int minOdd = int.MaxValue;

        foreach (int num in arr)
        {
            if (num % 2 != 0)
            {
                return 0; // If there's an odd number, return 0 operations
            }
            else
            {
                int operations = 0;
                int temp = num;
                while (temp % 2 == 0)
                {
                    temp /= 2;
                    operations++;
                }
                minOdd = Math.Min(minOdd, operations);
            }
        }

        return minOdd;
    }
   

    private static void Main(string[] args)
    {
        long size = Convert.ToInt32(Console.ReadLine());
        long[] array = new long[size];
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        for (int k = 0; k < inputArray.Length; k++)
        {
            if (int.TryParse(inputArray[k], out int value))
            {
                array[k] = value;
            }
            else
            {
                Console.WriteLine($"Invalid input: '{inputArray[k]}' is not a valid integer.");
                return;
            }
        }
        long result = minmizeNumber(array);
        Console.WriteLine(result);
    }
}