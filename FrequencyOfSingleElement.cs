using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 2, 3, 3, 3, 5, 5};

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq[num] = 1;
            }
        }

        int target = 3; // find frequency of this number

        if (freq.ContainsKey(target))
        {
            Console.WriteLine($"Frequency of {target} = {freq[target]}");
        }
        else
        {
            Console.WriteLine($"{target} not present in array");
        }

        Console.ReadLine();
    }
}
