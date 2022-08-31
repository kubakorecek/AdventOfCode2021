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
            Lines = FileContent.Split("\r\n").Select(s => s.Replace(" -> ", ",")
                .Split(",").Select(Int32.Parse).ToList())
                .Select(n => new Line(
                 new Point(n[0], n[1]), new Point(n[2], n[3]))).ToList();
            return true;
        }

        public int Part1()
        {

            Dictionary<Point, int> board = new();

            foreach (var item in Lines)
            {
                if (item.Type == LineType.HORIZONTAL || item.Type == LineType.VERTICAL)
                {
                    foreach (var p in item.Points)
                    {
                        if (board.ContainsKey(p))
                        {
                            board[p] += 1;
                        }
                        else
                        {
                            board.Add(p, 1);
                        }


                    }


                }
                
            }
            var t = board.Where(x => x.Value > 1).Count();
            return t;
        }

        public int Part2()
        {

            Dictionary<Point, int> board = new();

            foreach (var item in Lines)
            {
                foreach (var p in item.Points)
                    {
                        if (board.ContainsKey(p))
                        {
                            board[p] += 1;
                        }
                        else
                        {
                            board.Add(p, 1);
                        }


                    }


                

            }
            var t = board.Where(x => x.Value > 1).Count();
            return t;
        }
    }
}
