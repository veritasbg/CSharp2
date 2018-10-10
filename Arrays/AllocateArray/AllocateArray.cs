using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = 5 * i;
                Console.WriteLine(array[i]);
                string.Join(" ", array[i]);
            }
        }
    }
}
