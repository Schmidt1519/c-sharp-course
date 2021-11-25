using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 17; x < 27; x = x + 1)
            {
                Console.WriteLine("The value of x: {0}", x);
            }
            Console.ReadLine();
        }
    }
}
