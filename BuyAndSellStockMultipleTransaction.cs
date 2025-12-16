// Problem: Best Time to Buy and Sell Stock II (Multiple Transactions)

// Description:
// You are given an array prices where prices[i] is the price of a given stock on day i.
// You may complete as many transactions as you like (buy one and sell one share multiple times).
// You cannot hold more than one stock at a time.

// Approach:
// If today's price is higher than yesterday's price,
// add the difference to profit.
// This captures all increasing segments (greedy approach).

// Example:
// Input:  prices = [7, 1, 5, 3, 6, 4]
// Output: 7
// Explanation:
// Buy at 1 → sell at 5 (profit = 4)
// Buy at 3 → sell at 6 (profit = 3)
// Total profit = 7

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Program
{
    public static int MaxProfit(int[] prices)
    {
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }
        }

        return profit;
    }

    public static void Main()
    {
        int[] prices = {7, 1, 5, 3, 6, 4};
        Console.WriteLine(MaxProfit(prices)); // Output: 7
    }
}
