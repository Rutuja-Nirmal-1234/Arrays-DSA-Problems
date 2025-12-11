// Problem: Find Intersection of Two Arrays

// Question:
// Write a C# program to find the intersection of two arrays, i.e., 
// elements that appear in both arrays, considering their frequency.

// Input:
// First line contains size of first array `n1`
// Next line contains `n1` integers (first array elements)
// First line contains size of second array `n2`
// Next line contains `n2` integers (second array elements)

// Output:
// Print the elements that are common in both arrays

// Example:
// Input: arr1 = [1, 2, 2, 3], arr2 = [2, 2, 4]
// Output: Intersection: 2, 2

// Complexity:
// Time Complexity: O(n1 + n2)
// Space Complexity: O(n1)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


// Interviewer: Which is better for finding the intersection of two arrays — HashSet or Dictionary? Why?

// Best Approachs:
// “For finding the intersection where I just need to know the unique elements present in both arrays, I prefer using a HashSet because it offers fast O(1) average-time membership checks and inherently stores unique values. This keeps the code simple and efficient.

// However, if the problem requires tracking the frequency of elements — like how many times each number appears — then a Dictionary is more suitable, as it allows storing key-value pairs, where keys are elements and values are their counts.

// So, HashSet is best for uniqueness and membership, and Dictionary is best for frequency counting. Both have O(1) average lookup time, so I pick based on the problem’s need.”


using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] arr1 = {1, 2, 2, 3};
        int[] arr2 = {2, 2, 4};

        List<int> result = new List<int>();
        Dictionary<int, int> freq = new Dictionary<int, int>();

        // Count frequency of arr1
        foreach (int num in arr1)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        // Check arr2 and match frequency
        foreach (int num in arr2)
        {
            if (freq.ContainsKey(num) && freq[num] > 0)
            {
                result.Add(num);
                freq[num]--;
            }
        }

        Console.WriteLine("Intersection: " + string.Join(", ", result));
    }
}
