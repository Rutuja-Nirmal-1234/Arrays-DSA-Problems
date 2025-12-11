// Problem: Union of Two Arrays Using Dictionary

// Question:
// Write a C# program to find the union of two arrays using a Dictionary.
// Union means all unique elements present in either of the arrays.

// Input:
// First line contains size of array `n1`
// Next line contains `n1` integers (first array elements)
// Next line contains size of array `n2`
// Next line contains `n2` integers (second array elements)

// Output:
// Print the union of both arrays

// Example:
// Input: arr1 = [1, 2, 2, 3], arr2 = [2, 3, 4]
// Output: Union = 1 2 3 4

// Complexity:
// Time Complexity: O(n1 + n2)
// Space Complexity: O(n1 + n2)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class UnionUsingDictionary
{
    public static void Main(string[] args)
    {
        int[] arr1 = {1, 2, 2, 3};
        int[] arr2 = {2, 3, 4};

        Dictionary<int, bool> map = new Dictionary<int, bool>();

        foreach (int num in arr1)
        {
            if (!map.ContainsKey(num))
                map[num] = true;
        }

        foreach (int num in arr2)
        {
            if (!map.ContainsKey(num))
                map[num] = true;
        }

        foreach (var item in map.Keys)
        {
            Console.Write(item + " ");
        }

        Console.ReadLine();
    }
}
