// Problem: Pair With Given Sum

// Question:
// Write a C# program to find a pair of numbers in an array 
// whose sum is equal to a given target value.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)
// Next line contains target sum

// Output:
// Print the pair of elements whose sum equals the target
// If no pair exists, print "Not found"

// Example:
// Input: n = 4, arr = [1, 2, 4, 5], target = 6
// Output: Pair = 2 4

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(n)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 4, 5}; 
        int target = 90;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (map.ContainsKey(complement))
            {
                Console.Write(complement + " " + arr[i]);
                return;
            }

            if (!map.ContainsKey(arr[i]))
            {
                map.Add(arr[i], i);
            }
        }

        Console.Write("Not found");

        Console.ReadKey();
    }
}
