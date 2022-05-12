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

        public List<int> result { get; set; } = new List<int>() ;
        public Day2(string fileContent)
        {
            FileContent = fileContent;
        }

        public bool Load()
        {
            foreach (var line in FileContent.Split('\n').ToList().Select(x => x.Split(' ')).ToList())
            {
                var tpl = new Tuple<string, int>(line[0], int.Parse(line[1]));
                Instructions.Add(tpl);
            }
            return true;
        }

        public int Part1()
        {
            return result[0] * result[1];
        }

        public int Part2()
        {
            return result[0] * result[2] ;
        }

        public List<int> Calculate()
        {
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;
            foreach(var tpl in Instructions) 
            {
                switch (tpl.Item1)
                {
                    case "forward":
                        horizontalPosition += tpl.Item2;
                        depth += aim * tpl.Item2;
                        break;

                    case "down":
                        aim += tpl.Item2;
                        break;

                    case "up":
                        aim -= tpl.Item2;
                        break;

                    default:
                        Console.WriteLine("wrong data!!!!!!");
                        throw new Exception(tpl.Item1);

                }
            }
            result.Add(horizontalPosition);
            result.Add(aim);
            result.Add(depth);
            return result;
        }
    }
}
