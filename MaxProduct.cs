// LeetCode 1464 - Maximum Product of Two Elements in an Array
// https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/

// Problem:
// Given the array of integers nums, choose two different indices i and j
// such that (nums[i] - 1) * (nums[j] - 1) is maximized.
// Return the maximum value.

// Approach:
// Single pass to find the two largest elements.
// Keep track of max1 (largest) and max2 (second largest).

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public int MaxProduct(int[] nums) {
        int max1 = 0;
        int max2 = 0;

        foreach (int num in nums) {
            if (num > max1) {
                max2 = max1;
                max1 = num;
            } else if (num > max2) {
                max2 = num;
            }
        }

        return (max1 - 1) * (max2 - 1);
    }
}
