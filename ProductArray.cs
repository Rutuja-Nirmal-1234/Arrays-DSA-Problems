// Problem: Product of Array Except Self
// LeetCode: 238

// Description:
// Given an integer array nums, return an array answer such that
// answer[i] is the product of all the elements of nums except nums[i].
// Do NOT use division.

// Approach:
// 1. Create a result array where result[i] stores the product of all
//    elements to the left of index i.
// 2. Traverse from right and maintain a variable `right` that stores
//    the product of all elements to the right.
// 3. Multiply left product and right product for final result.

// Example:
// Input:  [1, 2, 3, 4]
// Output: [24, 12, 8, 6]

// Time Complexity: O(n)
// Space Complexity: O(1) (excluding output array)

using System;

public class HelloWorld
{
    public static int[] ProductExceptSelf(int[] arr)
    {
        int n = arr.Length;
        int[] result = new int[n];

        // Step 1: Left products
        result[0] = 1;
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * arr[i - 1];
        }

        // Step 2: Right products
        int right = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] = result[i] * right;
            right = right * arr[i];
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4 };
        Console.WriteLine(string.Join(", ", ProductExceptSelf(arr)));
    }
}
