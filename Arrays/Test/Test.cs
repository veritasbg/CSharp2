using System;

namespace _06.Maximal_K_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            //initialize array and variable
            int[] arr = new int[n];
            int result = 0;

            //input array elements
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", arr));

            //some magic (wink)
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));


            Array.Clear(arr, 0, n - k);
            Console.WriteLine(string.Join(" ", arr));


            //result
            for (int i = 0; i < n; i++)
            {
                result += arr[i];
            }

            Console.WriteLine(result);
        }
    }
}