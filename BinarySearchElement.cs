// Problem: Search in Rotated Sorted Array
// LeetCode: 33

// Description:
// You are given an integer array nums sorted in ascending order,
// but possibly rotated at an unknown pivot.
// Given a target value, return its index if found, otherwise return -1.

// Approach (Modified Binary Search):
// 1. Use binary search with two pointers (low, high).
// 2. Find mid and check if nums[mid] is the target.
// 3. Determine which half (left or right) is sorted.
// 4. Check if target lies within the sorted half.
// 5. Narrow the search space accordingly.

// Example:
// Input: nums = [4,5,6,7,0,1,2], target = 0
// Output: 4

// Time Complexity: O(log n)
// Space Complexity: O(1)

using System;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            // 1️⃣ If mid is target
            if (nums[mid] == target)
            {
                return mid;
            }

            // 2️⃣ Left half is sorted
            if (nums[low] <= nums[mid])
            {
                // 3️⃣ Target lies in left half
                if (nums[low] <= target && target < nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            else
            {
                // 4️⃣ Right half is sorted
                if (nums[mid] < target && target <= nums[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }

        return -1;
    }
}
