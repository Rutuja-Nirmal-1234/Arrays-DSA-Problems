// Problem: Trapping Rain Water
// LeetCode: 42

// Description:
// Given n non-negative integers representing an elevation map 
// where the width of each bar is 1, compute how much water it can trap after raining.

// Approach (Two Pointers):
// 1. Use two pointers: left and right.
// 2. Track leftMax and rightMax — max height seen so far from left and right respectively.
// 3. Move pointers inward:
//    - If height[left] < height[right], update leftMax or add trapped water.
//    - Else, update rightMax or add trapped water.

// Example:
// Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
// Output: 6

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Solution
{
    public int Trap(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;

        int leftMax = 0;
        int rightMax = 0;

        int water = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    water += leftMax - height[left];
                }
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    water += rightMax - height[right];
                }
                right--;
            }
        }

        return water;
    }
}
