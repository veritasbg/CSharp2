using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());  //input array length
            int[] arr = new int[length];                
                  

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int s = int.Parse(Console.ReadLine());// input sum s


            for (int i = 0; i < length; i++)
            {
                int sum = 0;

                /* The second loop sums the elements from the starting index to the right 
                 * until this partial sum reaches or is greater than S. */
                for (int j = i; j < length; j++)
                {
                    sum = sum + arr[j];

                    if (sum > s)
                    {
                        sum = 0;
                        break;
                    }

                    // If the sum is equal to S, we remember the starting index (from the first loop) and the ending index (from the second loop).
                    if (sum == s)
                    {
                        for (int index = i; index <= j; index++)
                        {
                            Console.Write(index != j ? arr[index] + ", " : arr[index] + "\n");
                        }
                    }
                }
            }
        }
    }
}