﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Number();
            var result = number.Sort(new int[] { 3, 30, 34, 5, 9 });
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
