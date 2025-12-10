// Problem: Find Intersection of Two Arrays Using HashSet

// Question:
// Write a C# program to find the intersection of two arrays using HashSet,
// printing unique common elements.

// Input:
// First line contains size of first array `n1`
// Next line contains `n1` integers (first array elements)
// First line contains size of second array `n2`
// Next line contains `n2` integers (second array elements)

// Output:
// Print unique elements that are common in both arrays

// Example:
// Input: arr1 = [1, 2, 2, 3], arr2 = [2, 2, 4]
// Output: Intersection: 2

// Complexity:
// Time Complexity: O(n1 + n2)
// Space Complexity: O(n1)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] nums1 = {1, 2, 2, 3};
        int[] nums2 = {2, 2, 4};

        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> result = new HashSet<int>();

        foreach (int num in nums2)
        {
            if (set1.Contains(num))
            {
                result.Add(num);
            }
        }

        Console.WriteLine("Intersection: " + string.Join(", ", result));
    }
}
