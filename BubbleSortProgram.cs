// Problem: Sort an Array Using Bubble Sort

// Question:
// Write a C# program to sort an array in ascending order using Bubble Sort.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the sorted array

// Example:
// Input: n = 5, arr = [5, 3, 1, 4, 2]
// Output: [1, 2, 3, 4, 5]

// Complexity:
// Time Complexity: O(n^2)
// Space Complexity: O(1)

using System;

public class BubbleSortProgram
{
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        BubbleSort(arr);

        Console.WriteLine("Array after Bubble Sort:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
