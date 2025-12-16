// Problem: Best Time to Buy and Sell Stock (Single Transaction)

// Description:
// Given an array prices where prices[i] is the price of a given stock on day i,
// find the maximum profit you can achieve from one transaction (buy one and sell one share).
// You must buy before you sell.

// Approach:
// Track the minimum price seen so far.
// For each price, calculate potential profit by subtracting minPrice.
// Update maxProfit if this profit is higher.

// Example:
// Input:  prices = [7, 1, 5, 3, 6, 4]
// Output: 5
// Explanation: Buy at price 1 and sell at price 6.

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Program
{
    public static int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else if (price - minPrice > maxProfit)
            {
                maxProfit = price - minPrice;
            }
        }

        return maxProfit;
    }

    public static void Main()
    {
        int[] prices = {7, 1, 5, 3, 6, 4};
        Console.WriteLine("Max Profit: " + MaxProfit(prices));
    }
}
