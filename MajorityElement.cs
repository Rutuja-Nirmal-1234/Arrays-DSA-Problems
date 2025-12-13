// Problem: Find Majority Element (Moore's Voting Algorithm)

// Description:
// Given an integer array nums, find the majority element.
// The majority element is the element that appears more than ⌊n / 2⌋ times.
// If no such element exists, return -1.

// Approach:
// Moore’s Voting Algorithm works in two phases:
// 1. Find a candidate by canceling out different elements.
// 2. Verify whether the candidate is actually the majority element.

// Example:
// Input:  nums = [2, 2, 1, 1, 1, 2, 2]
// Output: 2

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Program
{
    public static int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        // Step 1: Find potential candidate
        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        // Step 2: Verify candidate
        count = 0;
        foreach (int num in nums)
        {
            if (num == candidate)
                count++;
        }

        if (count > nums.Length / 2)
            return candidate;

        return -1; // No majority element
    }

    public static void Main()
    {
        int[] nums = {2, 2, 1, 1, 1, 2, 2};
        Console.WriteLine(MajorityElement(nums));
    }
}
