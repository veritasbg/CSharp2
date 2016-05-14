using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        // input array
        //Console.WriteLine("Please enter a sequence of numbers, separated by space: ");
        char[] delimiter = new char[] { ' ', ' ' };
        int[] array = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        //Console.Write("Please, enter a number to search for: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(AppCount(array, num));
    }

    static int AppCount(int[] arr, int number)
    {
        // counting how many times number appears in the input array
        int result = arr.Count(n => n == number);
        
        return result;
    }
}