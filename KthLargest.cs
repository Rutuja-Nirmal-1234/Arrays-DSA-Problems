// Problem: Find Kth Largest Element in an Array
// LeetCode: 215

// Description:
// Given an integer array nums and an integer k,
// return the kth largest element in the array.
// Note: It is the kth largest element in sorted order, not the kth distinct.

// Approach (Min Heap):
// 1. Use a Min Heap of size k.
// 2. Insert elements into the heap.
// 3. If heap size exceeds k, remove the smallest element.
// 4. At the end, the top of the heap is the kth largest element.

// Example:
// Input: nums = [3,2,1,5,6,4], k = 2
// Output: 5

// Time Complexity: O(n log k)
// Space Complexity: O(k)

using System;
using System.Collections.Generic;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // Min Heap using PriorityQueue
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            // Add element to heap
            minHeap.Enqueue(num, num);

            // If heap size exceeds k, remove smallest
            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        // Top of min heap is the kth largest element
        return minHeap.Peek();
    }
}
