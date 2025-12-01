// Problem: Right Rotate Array by K Positions

// Question:
// Write a C# program to right rotate an array by K positions.

// Input:
// First line contains size of array `n`
// Second line contains `n` integers (array elements)
// Third line contains integer `k` (number of rotations)

// Output:
// Print the array after rotating it right by K positions

// Example:
// Input: n = 6, arr = [1, 2, 3, 4, 5, 6], k = 2
// Output: [5, 6, 1, 2, 3, 4]

// Explanation:
// Rotating right by k means:
// - Last k elements move to the front
// - Remaining elements shift right

// Technique Used: Reverse method
// Steps:
// 1. Reverse entire array
// 2. Reverse first k elements
// 3. Reverse remaining n-k elements

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class RightRotateByK
{
    // Function to reverse a section of array
    static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    // Main right rotation logic
    static void RightRotate(int[] arr, int k)
    {
        k = k % arr.Length; // handle cases where k > n
        
        // Step 1: Reverse whole array
        Reverse(arr, 0, arr.Length - 1);

        // Step 2: Reverse first k elements
        Reverse(arr, 0, k - 1);

        // Step 3: Reverse remaining elements
        Reverse(arr, k, arr.Length - 1);
    }

    public static void Main(string[] args)
    {
        // Input: size of array
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        // Input: array elements
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Input: number of rotations
        Console.Write("Enter k (number of rotations): ");
        int k = Convert.ToInt32(Console.ReadLine());

        // Perform right rotation
        RightRotate(arr, k);

        // Output result
        Console.WriteLine($"Array after right rotation by {k}:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
