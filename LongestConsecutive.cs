// Problem: Longest Consecutive Sequence
// LeetCode: 128

// Description:
// Given an unsorted array of integers nums,
// return the length of the longest consecutive elements sequence.
// The algorithm must run in O(n) time.

// Approach (HashSet):
// 1. Insert all elements into a HashSet for O(1) lookups.
// 2. Iterate through the set.
// 3. If current number is the start of a sequence (num - 1 not present),
//    expand the sequence by checking num + 1, num + 2, ...
// 4. Track the maximum length.

// Example:
// Input: nums = [0,3,7,2,5,8,4,6,0,1]
// Output: 9

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in set)
        {
            // Check if it's the start of a sequence
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int length = 1;

                // Expand the sequence
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
        Console.Write(LongestConsecutive(arr));
    }
}
