// Problem: Move All Zeros to the End of an Array

// Question:
// Write a C# program to move all zeros in an array to the end 
// while maintaining the order of non-zero elements.

// Input:
// First line contains size of array `n`
// Next line contains `n` integers (array elements)

// Output:
// Print the array after moving all zeros to the end

// Example:
// Input: n = 8, arr = [2, 0, 3, 0, 7, 0, 8, 0]
// Output: [2, 3, 7, 8, 0, 0, 0, 0]

// Complexity:
// Time Complexity: O(n)
// Space Complexity: O(1)

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class MoveZeroAtEnd
{
    public static void Main(string[] args)
    {
        int[] arr = {2, 0, 3, 0, 7, 0, 8, 0}; 
        int i = 0;

        for(int j = 0; j < arr.Length; j++){
            if(arr[j] != 0){
                arr[i] = arr[j];
                i++;
            }
        }

        while(i < arr.Length){
            arr[i] = 0;
            i++;
        }

        foreach(int num in arr){
            Console.Write(num + " ");
        }

        Console.ReadKey();
    }
}
