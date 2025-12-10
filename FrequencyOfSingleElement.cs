// Problem: Find Frequency of a Given Number in an Array

// Question:
// Write a C# program to count how many times a specific number appears in an array.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)
// Next line contains target number whose frequency is to be found

// Output:
// Print the frequency of the target number

// Example:
// Input: n = 8, arr = [1, 2, 2, 3, 3, 3, 5, 5], target = 3
// Output: Frequency of 3 = 3

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

        int target = 3;

        if (freq.ContainsKey(target))
        {
            Console.WriteLine($"Frequency of {target} = {freq[target]}");
        }
        else
        {
            Console.WriteLine($"{target} not present in array");
        }

        Console.ReadLine();
    }
}
