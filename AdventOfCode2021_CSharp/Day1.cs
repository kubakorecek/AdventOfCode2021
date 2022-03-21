using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day1 :  ILoader
    {
        public string FileContent { get; }
        public List<int> Numbers { get; set; }
        public Day1(string fileContent) 
        {
            FileContent = fileContent;
        }

        public bool Load()
        {
            Numbers = FileContent.Split('\n').Select(int.Parse).ToList();
            return true;

        }

        public int Part1() 
        {

            int len = Numbers.Count;
            int second, first = int.MinValue, result = 0;
            for (int i = 1; i < len; i++)
            {
                second = Numbers[i - 1];
                if (second > first) { result++; }
                first = second;
            }

            return result;
        }
    }
}
