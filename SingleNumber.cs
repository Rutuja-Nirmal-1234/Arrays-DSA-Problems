// Problem: Find the Single Number

// Question:
// You are given an integer array where every element appears exactly twice,
// except for one element which appears only once.
// Find and return that single element.

// Example:
// Input: arr = [4, 1, 2, 1, 2]
// Output: 4

// Explanation:
// XOR cancels out duplicate numbers:  
// 4 ^ 1 ^ 2 ^ 1 ^ 2 = 4  
// Because (a ^ a = 0) and (0 ^ b = b)

// Approach:
// Use XOR to cancel out all pairs.
// The remaining value is the single non-duplicate number.

// Time Complexity: O(n)
// Space Complexity: O(1)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Program
{
    public static void Main()
    {
        int[] arr = {4, 1, 2, 1, 2};
        int result = 0;

        foreach (int num in arr)
        {
            result ^= num;  // XOR cancels duplicates
        }

        Console.WriteLine("Single number is: " + result);
    }
}
