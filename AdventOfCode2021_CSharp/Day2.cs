using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{   
    public struct Measures 
    {
        public Measures(int depth, int aim, int horizontalPosition)
        {
            Depth = depth;
            Aim = aim;
            HorizontalPositionl = horizontalPosition;

        }
        public int Depth { get; init; }
        public int Aim { get; init; }
        public int HorizontalPositionl { get; init; }



    }
    public class Day2 : ILoader
    {
        public string FileContent { get; }

        public List<(string Instruction, int Value)> Instructions { get; set; } = new List<(string Instruction, int Value)>();

        public Measures Result { get; set; } = new Measures() ;
        public Day2(string fileContent)
        {
            FileContent = fileContent;
        }

        public bool Load()
        {
            foreach (var line in FileContent.Split('\n').ToList().Select(x => x.Split(' ')).ToList())
            {
                var tpl = (Instruction : line[0], Value : int.Parse(line[1]));
                Instructions.Add(tpl);
            }
            return true;
        }

        public int Part1()
        {
            return Result.Aim * Result.HorizontalPositionl;
        }

        public int Part2()
        {
            return Result.Depth * Result.HorizontalPositionl;
        }

        public bool Calculate()
        {
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;
            foreach(var tpl in Instructions) 
            {
                switch (tpl.Instruction)
                {
                    case "forward":
                        horizontalPosition += tpl.Value;
                        depth += aim * tpl.Value;
                        break;

                    case "down":
                        aim += tpl.Value;
                        break;

                    case "up":
                        aim -= tpl.Value;
                        break;

                    default:
                        Console.WriteLine("wrong data!!!!!!");
                        throw new Exception(tpl.Instruction);

                }
            }
            Result = new Measures(depth, aim, horizontalPosition);
            return true;
        }
    }
}
