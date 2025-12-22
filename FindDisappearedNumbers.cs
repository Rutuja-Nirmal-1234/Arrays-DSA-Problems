// Problem: Find All Numbers Disappeared in an Array
// LeetCode: 448

// Description:
// Given an array nums of length n where
// 1 ≤ nums[i] ≤ n, some elements appear twice and others appear once.
// Find all the integers from 1 to n that do not appear in nums.

// Approach (HashSet):
// 1. Store all elements of nums in a HashSet.
// 2. Iterate from 1 to n.
// 3. If a number is not present in the set, add it to the result list.

// Example:
// Input: nums = [4,3,2,7,8,2,3,1]
// Output: [5,6]

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        List<int> result = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
