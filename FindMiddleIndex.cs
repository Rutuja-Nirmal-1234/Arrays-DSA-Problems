// LeetCode 1991 - Find the Middle Index in Array
// https://leetcode.com/problems/find-the-middle-index-in-array/

// Problem:
// Given an array of integers nums, find the middle index such that
// the sum of the elements to the left of it is equal to the sum
// of the elements to the right of it.
// If no such index exists, return -1.

// Approach:
// 1. Compute total sum of the array.
// 2. Traverse the array while maintaining leftSum.
// 3. For each index i:
//    rightSum = totalSum - leftSum - nums[i]
//    If leftSum == rightSum, return i.

// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int sum = 0;

        // Calculate total sum
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }

        int leftSum = 0;

        // Find middle index
        for (int i = 0; i < nums.Length; i++) {
            int rightSum = sum - nums[i] - leftSum;

            if (leftSum == rightSum) {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}
