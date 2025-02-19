using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Linq
{
    class CompareWithNonCaseSensitive : IComparer<string>
    {

        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, true);
        }

    }
}
