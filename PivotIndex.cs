// LeetCode 724 - Find Pivot Index
// https://leetcode.com/problems/find-pivot-index/

// Problem:
// Given an array of integers nums, calculate the pivot index of this array.
// The pivot index is the index where the sum of the numbers to the left
// is equal to the sum of the numbers to the right.
// If no such index exists, return -1.

// Approach:
// 1. Calculate total sum of the array.
// 2. Iterate through the array while maintaining leftSum.
// 3. rightSum = totalSum - leftSum - nums[i].
// 4. If leftSum == rightSum, return current index.

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;

        // Calculate total sum
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }

        int leftSum = 0;

        // Find pivot index
        for (int i = 0; i < nums.Length; i++) {
            int rightSum = sum - leftSum - nums[i];

            if (leftSum == rightSum) {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}
