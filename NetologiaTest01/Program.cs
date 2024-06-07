using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetologiaTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Go!");

            var a = 1;
            var b = 0;
            var c = 1;

            if (a & b || a & (a || b || c))
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False"); 
            }















        }
    }
}
