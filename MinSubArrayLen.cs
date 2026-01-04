// LeetCode 209 - Minimum Size Subarray Sum
// https://leetcode.com/problems/minimum-size-subarray-sum/

// Problem:
// Given an array of positive integers nums and a positive integer target,
// return the minimal length of a contiguous subarray of which the sum ≥ target.
// If there is no such subarray, return 0.

// Approach:
// Sliding Window (Two Pointers)
// Expand the window by moving right pointer.
// Shrink the window from left while sum >= target to find minimum length.

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minLength = int.MaxValue;
        int sum = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            sum += nums[right];

            while (sum >= target) {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}
