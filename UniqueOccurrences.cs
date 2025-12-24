// LeetCode 1207 - Unique Number of Occurrences
// https://leetcode.com/problems/unique-number-of-occurrences/

// Problem:
// Given an array of integers arr,
// return true if the number of occurrences of each value in the array is unique.

// Approach:
// 1. Use Dictionary to count frequency of each number
// 2. Use HashSet to check if frequencies are unique

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;

public class Solution {
    public bool UniqueOccurrences(int[] arr) {

        Dictionary<int, int> freq = new Dictionary<int, int>();

        // Step 1: Count frequencies
        foreach (int num in arr) {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        // Step 2: Check uniqueness of frequencies
        HashSet<int> seen = new HashSet<int>();

        foreach (int count in freq.Values) {
            if (seen.Contains(count))
                return false;

            seen.Add(count);
        }

        return true;
    }
}
