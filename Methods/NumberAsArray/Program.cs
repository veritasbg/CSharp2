using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int size0 = input[0];
            //int size1 = input[1];
            //int one = 0;
            //int[] result = new int[Math.Max(size0, size1) + 1];
            int[] arr0 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
        static int NumberAsArr(int[] arr0,int[]arr1)
        {
            Array.Reverse(arr0);
            Array.Reverse(arr1);



            for (int i = 0; i < arr0.Length; i++)
			{
                for (int j = 0; j < length; j++)
                {

                }
			}
         }
    }
}
