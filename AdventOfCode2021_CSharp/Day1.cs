﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day1 : ILoader
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
                second = Numbers.WindowSlidder(i, 1).Sum();
                if (second > first) { result++; }
                first = second;
            }

            return result;
        }

        public int Part2()
        {
            int len = Numbers.Count;
            int second, first = int.MinValue, result = -1;
            for (int i = 0; i < len; i++)
            {
                second = Numbers.WindowSlidder(i, 3).Sum();
                if (second > first) { result++; }
                first = second;
            }

            return result;
        }
    }
}
