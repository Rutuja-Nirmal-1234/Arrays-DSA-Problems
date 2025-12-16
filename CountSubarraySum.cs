// Problem: Count Subarrays with Sum Equals K

// Description:
// Given an integer array nums and an integer k,
// return the total number of continuous subarrays whose sum equals k.

// Approach:
// Use Prefix Sum + HashMap (Dictionary).
// - Store the frequency of prefix sums.
// - If (prefixSum - k) exists in the map, it means a subarray with sum k ends here.
// - Base case: map[0] = 1 to handle subarrays starting from index 0.


//Trick
//“Positive numbers → Sliding window
//Negative allowed  → Prefix sum + HashMap”

// Example:
// Input:  nums = [1, 1, 1], k = 2
// Output: 2
// Explanation: Subarrays [1,1] at indices (0,1) and (1,2)

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;
using System.Collections.Generic;

public class Program
{
    public static int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        map[0] = 1;   // Base case

        int prefixSum = 0;
        int count = 0;

        foreach (int num in nums)
        {
            prefixSum += num;

            if (map.ContainsKey(prefixSum - k))
            {
                count += map[prefixSum - k];
            }

            if (map.ContainsKey(prefixSum))
                map[prefixSum]++;
            else
                map[prefixSum] = 1;
        }

        return count;
    }

    public static void Main()
    {
        int[] nums = {1, 1, 1};
        int k = 2;

        Console.WriteLine(SubarraySum(nums, k)); // Output: 2
    }
}
