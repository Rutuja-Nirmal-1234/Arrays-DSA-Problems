// Problem: Find Repeating Numbers in an Array

// Question:
// You are given an integer array where some numbers may appear more than once.
// Print all numbers that repeat exactly twice (or more).

// Example:
// Input:  arr = {1, 2, 3, 4, 2, 1, 3, 8}
// Output: 2, 1, 3

// Approach:
// Use a Dictionary<int, int> to count frequencies of each number.
// Whenever the frequency becomes 2 → add it to the result list.

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;

public class Solution {
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 2, 1, 3, 8};

        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> result = new List<int>();

        foreach (int num in arr)
        {
            if (!dict.ContainsKey(num))
                dict[num] = 0;

            dict[num]++;

            // Add when frequency becomes exactly 2
            if (dict[num] == 2)
                result.Add(num);
        }

        Console.WriteLine("Repeating numbers: " + string.Join(", ", result));
        Console.ReadKey();
    }
}
