// Problem: Find the Largest Element in an Array

// Question:
// Write a C# program to find the largest element in an array.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the largest element in the array

// Example:
// Input: n = 5, arr = [10, 25, 3, 89, 45]
// Output: Largest = 89

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class LargestElement
{
    static int FindLargest(int[] arr)
    {
        int largest = arr[0];

        foreach (int num in arr)
        {
            if (num > largest)
                largest = num;
        }

        return largest;
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

        int largest = FindLargest(arr);

        Console.WriteLine("Largest element in array: " + largest);
    }
}
