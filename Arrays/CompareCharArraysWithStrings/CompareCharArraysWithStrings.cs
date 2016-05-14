using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArraysWithStrings
{
    class CompareCharArraysWithStrings
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            //public int CompareTo(String strB);
            int compare = first.CompareTo(second);

            if (compare == -1)
            {
                // the first is lexicographically smaller (comes earlier)
                Console.WriteLine("<");
            }
            else if (compare == 0)
            {
                // first and second are equal
                Console.WriteLine("=");
            }
            else if (compare == 1)
            {
                // the second is lexicographically smaller(comes earlier)
                Console.WriteLine(">");
            }

        }
    }
}