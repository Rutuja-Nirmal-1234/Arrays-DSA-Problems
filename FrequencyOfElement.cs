// Problem: Count Frequency of Each Element in an Array

// Question:
// Write a C# program to count how many times each element appears in an array.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print each element along with its frequency

// Example:
// Input: n = 8, arr = [1, 2, 2, 3, 3, 3, 5, 5]
// Output:
// 1 → 1
// 2 → 2
// 3 → 3
// 5 → 2

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(n)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 2, 3, 3, 3, 5, 5};

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq[num] = 1;
            }
        }

        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " → " + item.Value);
        }

        Console.ReadLine();
    }
}
