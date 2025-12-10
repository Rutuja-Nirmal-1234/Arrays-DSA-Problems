// Problem: Left Rotate an Array by One Position

// Question:
// Write a C# program to left rotate an array by one position.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the array after left rotation by one position

// Example:
// Input: n = 5, arr = [1, 2, 3, 4, 5]
// Output: [2, 3, 4, 5, 1]

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class LeftRotateByOne
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};

        int first = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            arr[i - 1] = arr[i];
        }

        arr[arr.Length - 1] = first;

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }
}
