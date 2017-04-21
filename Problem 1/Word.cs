using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Word
    {
        public string Reverse(string word)
        {
            var words = word.Split(' ');
            for (var i = 0; i < words.Length / 2; i++)
            {
                var tmp = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = tmp;
            }

            return string.Join(" ", words);
        }

    }
}
