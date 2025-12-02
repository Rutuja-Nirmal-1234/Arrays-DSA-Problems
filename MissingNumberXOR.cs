// Problem: Find the Missing Number from 1 to N Using XOR

// Question:
// Write a C# program to find the missing number in an array containing 
// numbers from 1 to N with exactly one number missing using XOR operation.

// Input:
// First line contains size of array `n` (which is N-1)
// Next line contains `n` integers (array elements)

// Output:
// Print the missing number

// Example:
// Input: n = 4, arr = [1, 2, 4, 5]
// Output: Missing Number = 3

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class MissingNumberXOR
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 4, 5};
        int n = arr.Length + 1;
        int XOR1 = 0;
        int XOR2 = 0;

        for (int i = 1; i <= n; i++) {
            XOR1 ^= i;
        }
        foreach (int num in arr) {
            XOR2 ^= num;
        }

        int missing = XOR1 ^ XOR2;
        Console.Write(missing);

        Console.ReadKey();
    }
}
