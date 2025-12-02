// Problem: Find the 3rd Largest Element in an Array

// Question:
// Write a C# program to find the third largest DISTINCT element in an array.
// If 3rd largest doesn't exist, return the largest element.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the 3rd largest element

// Example:
// Input: n = 7, arr = [10, 20, 4, 45, 99, 99, 20]
// Output: 45

// Explanation:
// Distinct sorted (desc): [99, 45, 20, 10, 4]
// 3rd largest = 20

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

using System;

public class ThirdLargestElement
{
    static int FindThirdLargest(int[] arr)
    {
        int first = int.MinValue;
        int second = int.MinValue;
        int third = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)
            {
                third = second;
                second = first;
                first = num;
            }
            else if (num < first && num > second)
            {
                third = second;
                second = num;
            }
            else if (num < second && num > third)
            {
                third = num;
            }
        }

        return third == int.MinValue ? first : third;
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

        int thirdLargest = FindThirdLargest(arr);

        Console.WriteLine("Third largest element: " + thirdLargest);
    }
}
