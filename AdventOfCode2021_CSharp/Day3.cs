using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day3 : ILoader
    {
        public string FileContent { get; }
        public List<string> Binaries { get; set; }
        public Day3(string fileContent)
        {
            FileContent = fileContent;
        }

        public bool Load()
        {
            Binaries = FileContent.Split('\n').ToList();
            return true;
        }
    }
}
