using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            // input array
            //Console.WriteLine("Please enter a sequence of numbers, separated by space: ");
            char[] delimiter = new char[] { ' ', ' ' };
            int[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(FirstLargerThanN(arr));
        }

        static int FirstLargerThanN(int[] arr)
        {
            int index = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }

            return index;
        }
    }
}