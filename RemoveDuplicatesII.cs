// LeetCode 80 - Remove Duplicates from Sorted Array II
// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/

// Problem:
// Given a sorted array nums, remove duplicates in-place such that
// each unique element appears at most twice.
// Return the new length.

// Approach:
// Two Pointers
// Allow first two elements by default.
// From index 2 onwards, compare current element with element at (write - 2).
// If different, it can be placed in the array.

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 2) {
            return nums.Length;
        }

        int write = 2;

        for (int i = 2; i < nums.Length; i++) {
            if (nums[i] != nums[write - 2]) {
                nums[write] = nums[i];
                write++;
            }
        }

        return write;
    }
}
