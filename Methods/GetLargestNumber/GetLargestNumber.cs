using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            char[] delimiter = new char[] { ' ', ' ' };
            int[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine( GetMax(arr));
        }

        static int GetMax(int[] arr)
        {
            int maxnumber = Math.Max(Math.Max(arr[0], arr[1]),arr[2]);
            return maxnumber;
           
        }
    }
}
