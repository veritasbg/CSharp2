using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(arr);

            for (int i = 0; i < length; i++)
            {
                 Console.WriteLine(arr[i]);
            }

        }
    }
}
