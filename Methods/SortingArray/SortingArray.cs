using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        //Console.ReadLine();
        int[] array = Console.ReadLine().Split('\n').Select(int.Parse).ToArray();

        Array.Sort(array);

        Console.WriteLine(string.Join(" ", array));
    }
}

