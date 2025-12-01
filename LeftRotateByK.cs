// Problem: Left Rotate Array by K Positions

// Question:
// Write a C# program to left rotate an array by K positions.

// Input:
// First line contains size of array `n`
// Second line contains `n` integers (array elements)
// Third line contains integer `k` (number of rotations)

// Output:
// Print the array after rotating it left by K positions

// Example:
// Input: n = 6, arr = [1, 2, 3, 4, 5, 6], k = 2
// Output: [3, 4, 5, 6, 1, 2]

// Explanation:
// Rotating left by k means:
// - First k elements move to the end
// - Remaining elements shift left

// Technique Used: Reverse method
// Steps:
// 1. Reverse first k elements
// 2. Reverse remaining n-k elements
// 3. Reverse whole array

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class LeftRotateByK
{
    // Function to reverse a portion of array
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

    // Main function to rotate array left by K
    static void LeftRotate(int[] arr, int k)
    {
        k = k % arr.Length; // handle cases where k > n
        
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, arr.Length - 1);
        Reverse(arr, 0, arr.Length - 1);
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

        // Perform left rotation
        LeftRotate(arr, k);

        // Output rotated array
        Console.WriteLine($"Array after left rotation by {k}:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
