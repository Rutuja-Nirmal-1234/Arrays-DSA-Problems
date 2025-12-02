// Problem: Find the Missing Number from 1 to N Using Sum Calculation

// Question:
// Write a C# program to find the missing number in an array containing 
// numbers from 1 to N with exactly one number missing.

// Input:
// First line contains size of array `n` (which is N-1)
// Next line contains `n` integers (array elements)

// Output:
// Print the missing number

// Example:
// Input: n = 4, arr = [1, 2, 4, 5]
// Output: Missing Number = 3

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class MissingNumber
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 4, 5};
        int n = arr.Length + 1;
        int total = n * (n + 1) / 2;
        int sum = 0;

        for (int j = 0; j < arr.Length; j++)
        {
            sum += arr[j];
        }

        int missing = total - sum;
        Console.Write(missing);

        Console.ReadKey();
    }
}
