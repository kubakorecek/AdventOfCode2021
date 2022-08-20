using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day5 : ILoader
    {
        public List<Line> Lines { get; set; }

        public Day5(string fileContent)
        {
            FileContent = fileContent;
        }

        public string FileContent { get; }

        public bool Load()
        {
            Lines = FileContent.Split("\r\n").ToList().Select(x => x.Split("-> ")).ToList()
               .Select(
                x =>
                new Line(

                new Point(int.Parse(x.ElementAt(0).Split(",").ToList().ElementAt(0).ToString())
                       , int.Parse(x.ElementAt(0).Split(",").ToList().ElementAt(1).ToString())

                ),
                   new Point(int.Parse(x.ElementAt(1).Split(",").ToList().ElementAt(0).ToString())
                       , int.Parse(x.ElementAt(1).Split(",").ToList().ElementAt(1).ToString()))

                )

                ).ToList();
            return true;
        }

        public void Part1()
    }
}
