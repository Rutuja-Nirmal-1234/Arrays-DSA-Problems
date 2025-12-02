// Problem: Remove Duplicates from a Sorted Array

// Question:
// Write a C# program to remove duplicate elements from a sorted array 
// and print the unique elements.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (sorted array elements)

// Output:
// Print the array after removing duplicates

// Example:
// Input: n = 9, arr = [1, 1, 2, 2, 2, 3, 4, 4, 5]
// Output: Unique Elements = 1 2 3 4 5

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class RemoveDuplicates
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 1, 2, 2, 2, 3, 4, 4, 5};

        int i = 0;

        for (int j = 1; j < arr.Length; j++)
        {
            if (arr[j] != arr[i])
            {
                i++;
                arr[i] = arr[j];
            }
        }

        int uniqueLength = i + 1;

        Console.WriteLine("Unique elements:");
        for (int k = 0; k < uniqueLength; k++)
        {
            Console.Write(arr[k] + " ");
        }

        Console.ReadLine();
    }
}
