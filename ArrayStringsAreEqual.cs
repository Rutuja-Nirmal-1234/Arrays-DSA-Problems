// Problem: Check If Two String Arrays are Equivalent
// LeetCode: 1662

// Description:
// Given two string arrays word1 and word2,
// return true if the two arrays represent the same string.

// Approach (String Concatenation):
// 1. Concatenate all strings in word1 into a single string.
// 2. Concatenate all strings in word2 into a single string.
// 3. Compare the final strings.

// Example:
// Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
// Output: true

// Time Complexity: O(n + m)
// Space Complexity: O(n + m)

using System;

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string s1 = "";
        string s2 = "";

        foreach (string w in word1)
        {
            s1 += w;
        }

        foreach (string w in word2)
        {
            s2 += w;
        }

        return s1 == s2;
    }
}
