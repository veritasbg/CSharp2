using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            // input array
            //Console.WriteLine("Please enter a sequence of numbers, separated by space: ");
            char[] delimiter = new char[] { ' ', ' ' };
            int[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(LargerThanN(arr));
        }

        static int LargerThanN (int[] arr)
        {
            int counter = 0;

            for (int i = 1; i < arr.Length-1; i++)
            {
                
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    counter++;
                }
                
            }
            return counter;
        }

    }
}