using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day5 : ILoader
    {
        public List<Tuple<Line>> Lines { get; set; }
        public Day5(string fileContent)
        {
            FileContent = fileContent;
        }

        public string FileContent { get; }

        public bool Load()
        {
            throw new NotImplementedException();
        }
    }
}
