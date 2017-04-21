using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Number
    {
        public  int Sort(int[] numbers)
        {

            numbers = numbers.OrderBy(x => x.ToString().Length)
                .ThenByDescending(x => x.ToString().Length > 1 ? x.ToString().Substring(1, 1) : x.ToString())
                .ToArray();
            var result = string.Join("", numbers);
            return int.Parse(result);
        }
    }
}
