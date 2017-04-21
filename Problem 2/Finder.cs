using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Finder
    {
        public int FindInteger(int[] array)
        {
            var onlyPositivesArray = array.Where(x => x > 0).Select(z=>z).OrderBy(o=>o).ToArray();
            var firstPositive = array.FirstOrDefault(z => z > 0) == 0 ? 1 : array.First(z => z > 0);
            foreach (int t in onlyPositivesArray)
            {
                if (t != firstPositive)
                {
                    return firstPositive - 1;
                }
                firstPositive++;
            }
            return firstPositive;
        }
    }
}
