// LeetCode 977 - Squares of a Sorted Array
// https://leetcode.com/problems/squares-of-a-sorted-array/

// Problem:
// Given an integer array nums sorted in non-decreasing order,
// return an array of the squares of each number sorted in non-decreasing order.

// Approach:
// 1. Square each element of the array.
// 2. Sort the resulting array.

// Time Complexity: O(n log n)  (due to sorting)
// Space Complexity: O(n)

public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] square = new int[n];

        for (int i = 0; i < n; i++) {
            square[i] = nums[i] * nums[i];
        }

        Array.Sort(square);
        return square;
    }
}
