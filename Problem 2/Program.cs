using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var finder = new Finder();
            var array = new int[] { 1,2,0};
            var result = finder.FindInteger(array);

            Console.WriteLine("The result for 1,2,0");
            Console.WriteLine(result);

            Console.WriteLine("The result for [3,4,-1,1]");
            Console.WriteLine(finder.FindInteger(new int[] { 3, 4, -1, 1 }));

            Console.WriteLine("The result for [-8, -7, -6]");
            Console.WriteLine(finder.FindInteger(new int[] { -8, -7, -6 }));

            Console.WriteLine("The result for [1]");
            Console.WriteLine(finder.FindInteger(new int[] { 1 }));

            Console.Read();

        }
    }
}
