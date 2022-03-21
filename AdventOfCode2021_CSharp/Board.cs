using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Board
    {

        public List<List<int>> Data { get; private set; } = new();

        public Board(string block)
        {
            Block = block;
            Load();
        }

        public string Block { get; }

        internal void Load()
        {
            Data = Block.Split(Environment.NewLine).Select(line => ParseLine(line)).ToList();
        }

        private static List<int> ParseLine(string line)
        {
            return line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        }

        public bool RemoveElement(int element)
        {
            foreach (var line in Data)
            {
                if (line.Remove(element))
                {
                    return true;
                };
            }
            return false;
        }

        public bool IsWinner()
        {
            return Data.Any(line => !line.Any());
        }

        public int Sum()
        {
            return Data.Sum(line => line.Sum());
        }
    }
}
