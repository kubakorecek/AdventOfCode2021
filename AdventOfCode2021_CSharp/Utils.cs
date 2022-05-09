using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public static class Utils
    {
        public static IEnumerable<int> WindowSlidder(this List<int> numbers, int window, int size)
        {
            return numbers.Skip(window).Take(size);
        }
    }
}
