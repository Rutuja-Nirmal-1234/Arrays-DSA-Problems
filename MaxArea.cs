// Problem: Container With Most Water
// LeetCode: 11

// Description:
// You are given an integer array height where height[i]
// represents the height of a vertical line at index i.
// Find two lines that together with the x-axis form a container,
// such that the container contains the most water.

// Approach (Two Pointers):
// 1. Initialize two pointers: left at start, right at end.
// 2. Calculate area using:
//    width = right - left
//    height = min(height[left], height[right])
// 3. Update maximum water.
// 4. Move the pointer pointing to the smaller height,
//    since moving the larger one cannot increase area.

// Example:
// Input: height = [1,8,6,2,5,4,8,3,7]
// Output: 49

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxWater = 0;

        while (left < right)
        {
            int width = right - left;
            int h = Math.Min(height[left], height[right]);
            int water = width * h;

            maxWater = Math.Max(maxWater, water);

            // Move pointer with smaller height
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxWater;
    }
}
