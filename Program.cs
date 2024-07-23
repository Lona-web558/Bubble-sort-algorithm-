using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }
}