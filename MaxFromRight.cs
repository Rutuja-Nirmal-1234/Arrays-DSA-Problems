// Problem: Replace Elements with Greatest Element on Right Side
// LeetCode: 1299

// Description:
// Given an array arr, replace every element with the greatest element
// among the elements to its right, and replace the last element with -1.

// Approach:
// 1. Traverse the array from right to left.
// 2. Keep track of the maximum element seen so far (maxRight).
// 3. Replace current element with maxRight.
// 4. Update maxRight using the original current value.

// Example:
// Input:  [17, 18, 5, 4, 6, 1]
// Output: [18, 6, 6, 6, 1, -1]

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class HelloWorld
{
    public static void ReplaceElements(int[] arr)
    {
        int maxRight = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int current = arr[i];
            arr[i] = maxRight;
            maxRight = Math.Max(maxRight, current);
        }

        Console.WriteLine(string.Join(" ", arr));
    }

    public static void Main(string[] args)
    {
        int[] arr = { 17, 18, 5, 4, 6, 1 };
        ReplaceElements(arr);
    }
}
