using System;

public class MaximalIncreasingSequence
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        arr[0] = int.Parse(Console.ReadLine());
        int maxIncreasingSequence = 0;
        int currentSequence = 1;

        for (int i = 1; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] > arr[i - 1])
            {
                currentSequence += 1;
                maxIncreasingSequence = Math.Max(maxIncreasingSequence, currentSequence);
            }
            else
            {
                currentSequence = 1;
            }
        }

        Console.WriteLine(maxIncreasingSequence);
    }
}