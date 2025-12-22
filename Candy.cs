// Problem: Candy
// LeetCode: 135

// Description:
// There are n children standing in a line.
// Each child is assigned a rating value.
// You are giving candies to these children subject to the following requirements:
//
// 1. Each child must have at least one candy.
// 2. Children with a higher rating get more candies than their neighbors.
//
// Return the minimum number of candies you need to distribute.

// Approach (Two Pass Greedy):
// 1. Initialize all candies to 1 (minimum requirement).
// 2. Left to Right pass:
//    - If current rating > previous rating,
//      give current child more candies than previous.
// 3. Right to Left pass:
//    - If current rating > next rating,
//      ensure current child has more candies than next.
//      Use Math.Max to avoid breaking left pass result.
// 4. Sum all candies.

// Example:
// Input: ratings = [1,0,2]
// Output: 5
// Explanation: candies = [2,1,2]

// Time Complexity: O(n)
// Space Complexity: O(n)

using System;

public class Solution
{
    public int Candy(int[] ratings)
    {
        int n = ratings.Length;
        int[] candies = new int[n];

        // Step 1: Each child gets at least 1 candy
        for (int i = 0; i < n; i++)
        {
            candies[i] = 1;
        }

        // Step 2: Left → Right
        for (int i = 1; i < n; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

        // Step 3: Right → Left
        for (int i = n - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }

        // Step 4: Sum total candies
        int totalCandies = 0;
        for (int i = 0; i < n; i++)
        {
            totalCandies += candies[i];
        }

        return totalCandies;
    }
}
