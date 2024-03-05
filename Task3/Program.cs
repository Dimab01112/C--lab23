using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayX = new int[11] { 5, 2, 7, 1, 9, 3, 8, 4, 6, 11, 10 };

        Console.WriteLine("Array X:");
        PrintArray(arrayX);

        int minValue = FindMinValue(arrayX);
        Console.WriteLine($"Min: {minValue}");

        int maxValue = FindMaxValue(arrayX);
        Console.WriteLine($"Max: {maxValue}");

        Console.ReadLine();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int FindMinValue(int[] arr)
    {
        int minValue = arr[0];
        foreach (int element in arr)
        {
            if (element < minValue)
            {
                minValue = element;
            }
        }
        return minValue;
    }

    static int FindMaxValue(int[] arr)
    {
        int maxValue = arr[0];
        foreach (int element in arr)
        {
            if (element > maxValue)
            {
                maxValue = element;
            }
        }
        return maxValue;
    }
}
