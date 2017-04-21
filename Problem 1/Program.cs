using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = new Word();
            var result = word.Reverse("I have a big cow");
            Console.WriteLine(result);
            Console.Read();

        }

       
    }
}
