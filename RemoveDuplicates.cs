// Problem: Remove Duplicates from an Unsorted Array

// Question:
// Write a C# program to remove duplicate elements from an unsorted array 
// and print the unique elements.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the array after removing duplicates

// Example:
// Input: n = 9, arr = [2, 3, 3, 7, 7, 3, 8, 8, 10]
// Output: Unique Elements = 2 3 7 8 10

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(n)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class RemoveDuplicates
{
    public static void Main(string[] args)
    {
        int[] arr = {2, 3, 3, 7, 7, 3, 8, 8, 10}; 
        HashSet<int> unique = new HashSet<int>();

        for(int j = 0; j < arr.Length; j++){
            unique.Add(arr[j]);
        }
        
        foreach(int num in unique){
            Console.Write(num + " ");
        }
        
        Console.ReadKey();
    }
}
