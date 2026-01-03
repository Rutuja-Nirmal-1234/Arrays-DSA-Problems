// LeetCode 1480 - Running Sum of 1d Array
// https://leetcode.com/problems/running-sum-of-1d-array/

// Problem:
// Given an array nums, return the running sum of nums.

// Approach:
// Iterate over the array, keep adding current element to previous running sum.

// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution {
    public int[] RunningSum(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        res[0] = nums[0];
        for (int i = 1; i < n; i++) {
            res[i] = res[i - 1] + nums[i];
        }
        return res;
    }
}
