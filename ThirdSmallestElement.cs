// Problem: Find the 3rd Smallest Element in an Array

// Question:
// Write a C# program to find the third smallest distinct element in an array.
// If the 3rd smallest does not exist, return the smallest element.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the third smallest element

// Example:
// Input: n = 6, arr = [10, 4, 2, 8, 6, 2]
// Output: 6

// Explanation:
// Sorted distinct = [2, 4, 6, 8, 10]
// 3rd smallest = 6

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class ThirdSmallestElement
{
    static int FindThirdSmallest(int[] arr)
    {
        int first = int.MaxValue;
        int second = int.MaxValue;
        int third = int.MaxValue;

        foreach (int num in arr)
        {
            if (num < first)
            {
                third = second;
                second = first;
                first = num;
            }
            else if (num > first && num < second)
            {
                third = second;
                second = num;
            }
            else if (num > second && num < third)
            {
                third = num;
            }
        }

        return third == int.MaxValue ? first : third;
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

        // Find 3rd smallest element
        int thirdSmallest = FindThirdSmallest(arr);

        // Output result
        Console.WriteLine("Third smallest element: " + thirdSmallest);
    }
}
