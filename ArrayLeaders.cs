// Problem: Array Leaders

// Description:
// An element is called a leader if it is greater than all the elements
// to its right side. The rightmost element is always a leader.

// Approach:
// Traverse the array from right to left.
// Keep track of the maximum element seen so far.
// If the current element is greater than the maximum, it is a leader.

// Example:
// Input:  arr = [16, 17, 4, 3, 5, 2]
// Output: 2 5 17
// (Order may vary depending on printing direction)

// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class Program
{
    public static void FindLeaders(int[] arr)
    {
        int n = arr.Length;
        int maxFromRight = arr[n - 1];

        // Rightmost element is always a leader
        Console.Write(maxFromRight + " ");

        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] > maxFromRight)
            {
                Console.Write(arr[i] + " ");
                maxFromRight = arr[i];
            }
        }
    }

    public static void Main()
    {
        int[] arr = {16, 17, 4, 3, 5, 2};
        FindLeaders(arr);
    }
}
