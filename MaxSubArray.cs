// Problem: Maximum Subarray Sum (Kadane's Algorithm)

// Description:
// Given an integer array nums, find the contiguous subarray 
// (containing at least one number) which has the largest sum
// and return its sum.

// Approach:
// Kadane’s Algorithm keeps track of:
// - currentSum: maximum sum ending at the current index
// - maxSum: maximum sum found so far
// At each step, decide whether to start a new subarray or extend the existing one.

// Example:
// Input:  nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
// Output: 6
// Explanation: Subarray [4, -1, 2, 1] has the largest sum = 6

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Program
{
    public static int MaxSubArray(int[] nums)
    {
        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }

    public static void Main()
    {
        int[] nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        Console.WriteLine(MaxSubArray(nums)); // Output: 6
    }
}
