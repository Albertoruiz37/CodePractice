using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var arr = new int[,] { { 0, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 } };
            
            var result= new Counter().CountBiggestIsland(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
