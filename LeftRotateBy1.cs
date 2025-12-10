using System;

public class LeftRotateByOne
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};

        int first = arr[0];  // store first element

        for (int i = 1; i < arr.Length; i++)
        {
            arr[i - 1] = arr[i];  // shift elements left
        }

        arr[arr.Length - 1] = first;  // put first at end

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }
}
