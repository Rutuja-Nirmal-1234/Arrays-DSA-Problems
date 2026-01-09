// LeetCode 1752 - Check if Array Is Sorted and Rotated
// https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/

// Problem:
// Given an array nums, return true if the array was originally sorted in
// non-decreasing order, then rotated some number of positions.
// Otherwise, return false.

// Approach:
// Count the number of places where nums[i] > nums[i + 1] (circularly).
// For a sorted and rotated array, this can happen at most once.

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public bool Check(int[] nums) {
        int count = 0;
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            if (nums[i] > nums[(i + 1) % n]) {
                count++;
            }

            if (count > 1) {
                return false;
            }
        }

        return true;
    }
}
