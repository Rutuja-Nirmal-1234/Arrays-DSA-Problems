// Problem: Find the 2nd Largest Element in an Array

// Question:
// Write a C# program to find the second largest DISTINCT element in an array.
// If the second largest does not exist, return the largest element.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the second largest element

// Example:
// Input: n = 6, arr = [12, 35, 1, 10, 34, 1]
// Output: 34

// Explanation:
// Distinct sorted = [35, 34, 12, 10, 1]
// Second largest = 34

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class SecondLargestElement
{
    static int FindSecondLargest(int[] arr)
    {
        int first = int.MinValue;
        int second = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num < first && num > second)
            {
                second = num;
            }
        }

        return second == int.MinValue ? first : second;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int secondLargest = FindSecondLargest(arr);

        Console.WriteLine("Second largest element: " + secondLargest);
    }
}
