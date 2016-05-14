using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            //string number = Console.ReadLine();
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            string num = inputNumber.ToString();

            Console.WriteLine(ReverseString(num));
        }

        static string ReverseString(string num)
        {

            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

