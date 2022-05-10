using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day2 : ILoader
    {
        public string FileContent { get; }

        public List<Tuple<string, int>> Instructions { get; set; } = new List<Tuple<string, int>>();
        public Day2(string fileContent)
        {
            FileContent = fileContent;
        }

        public bool Load()
        {
            return true;
        }
    }
}
