// Problem: Union of Two Arrays

// Question:
// Write a C# program to find the union of two arrays using HashSet.
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

public class UnionOfArrays
{
    public static void Main(string[] args)
    {
        int[] arr1 = {1, 2, 2, 3};
        int[] arr2 = {2, 3, 4};

        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr1)
        {
            set.Add(num);
        }

        foreach (int num in arr2)
        {
            set.Add(num);
        }

        foreach (int num in set)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }
}
