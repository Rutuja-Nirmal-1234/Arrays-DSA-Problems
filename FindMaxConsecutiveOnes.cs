// LeetCode 485 - Max Consecutive Ones
// https://leetcode.com/problems/max-consecutive-ones/

// Problem:
// Given a binary array nums, return the maximum number of consecutive 1's in the array.

// Approach:
// Traverse the array and count current consecutive 1s.
// Reset count when 0 appears and keep track of maximum.

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxLen = 0;
        int current = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                current++;
                maxLen = Math.Max(maxLen, current);
            } else {
                current = 0;
            }
        }

        return maxLen;
    }
}
