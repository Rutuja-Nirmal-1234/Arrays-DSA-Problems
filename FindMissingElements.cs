// Problem: Find Missing Elements in a Range

// Description:
// You are given an integer array nums consisting of unique integers.
// Originally, nums contained every integer within a certain range.
// Some integers might be missing.
// The smallest and largest integers of the original range are still present.
// Return a sorted list of all missing integers in this range.

// Approach (HashSet):
// 1. Find minimum and maximum values in the array.
// 2. Store all elements in a HashSet for O(1) lookup.
// 3. Iterate from min + 1 to max - 1.
// 4. Add numbers not present in the set to the result list.

// Example:
// Input: nums = [1, 4, 2, 5]
// Output: [3]

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> FindMissingElements(int[] nums)
    {
        int min = nums.Min();
        int max = nums.Max();

        HashSet<int> set = new HashSet<int>(nums);
        List<int> result = new List<int>();

        for (int i = min + 1; i < max; i++)
        {
            if (!set.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
