// Problem: Find Peak Element
// LeetCode: 162

// Description:
// A peak element is an element that is strictly greater than its neighbors.
// Given an integer array nums, find a peak element and return its index.
// You may assume nums[-1] = nums[n] = -∞.

// Approach (Binary Search):
// 1. Use binary search to compare mid element with mid+1.
// 2. If nums[mid] < nums[mid+1], peak lies on the right side.
// 3. Else, peak lies on the left side (including mid).
// 4. Continue until low == high, which will be a peak index.

// Example:
// Input: nums = [1, 2, 3, 1]
// Output: 2  (index of element 3)

// Time Complexity: O(log n)
// Space Complexity: O(1)

using System;

public class HelloWorld
{
    public static int FindPeakElement(int[] nums)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] < nums[mid + 1])
            {
                low = mid + 1;   // move right
            }
            else
            {
                high = mid;      // move left
            }
        }

        // low == high → peak index
        return low;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 1 };
        Console.Write(FindPeakElement(arr));
    }
}
