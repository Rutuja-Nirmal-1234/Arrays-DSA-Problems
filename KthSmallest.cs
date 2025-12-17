// Problem: Find Kth Smallest Element in an Array

// Description:
// Given an integer array nums and an integer k,
// return the kth smallest element in the array.

// Approach (Max Heap):
// 1. Use a Max Heap of size k by pushing elements with negative priority.
// 2. Insert elements into the heap.
// 3. If heap size exceeds k, remove the largest element.
// 4. At the end, the top of the heap is the kth smallest element.

// Example:
// Input: nums = [3,2,1,5,6,4], k = 2
// Output: 2

// Time Complexity: O(n log k)
// Space Complexity: O(k)

using System;
using System.Collections.Generic;

public class Solution
{
    public int FindKthSmallest(int[] nums, int k)
    {
        // Max Heap using negative priority trick
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            // negative priority for max heap behavior
            maxHeap.Enqueue(num, -num);

            // If heap size exceeds k, remove the largest element
            if (maxHeap.Count > k)
            {
                maxHeap.Dequeue();
            }
        }

        // Top of max heap is the kth smallest element
        return maxHeap.Peek();
    }
}
