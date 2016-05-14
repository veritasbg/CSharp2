using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());

            //initialize both arrays
            int[] firstArray = new int[n];

            int[] secondArray = new int[n];

            //input elements for firstArray
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            //input elements for secondArray
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            //calculation
            bool areEqual = true;

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }

            //result
            if (areEqual == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}