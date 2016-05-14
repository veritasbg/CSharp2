using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class SayHello
    {        
        static void Main()
        {
            //Console.WriteLine("Enter your name");
            string inputName = Console.ReadLine();
            PrintName(inputName);
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
            
        }
    }
}
