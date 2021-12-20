﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day2
{
    public class Excercise
    {
        private int Depth;

        private int Horizontal;

        private int Aim;

        private string FilePath;

        private int[] Result;

        string[] File;




        public Excercise(string filePath)
        {
            Depth = 0;
            Horizontal = 0;
            Aim = 0;
            FilePath = filePath;
            Result = new int[2];
        }

        private void _readLines(string filePath)
        {
            File = System.IO.File.ReadAllLines(filePath);

        }
        private void _calculate()
        {
            int len = File.Length;
            for (int i = 0; i < len; i++)
            {
                var words = File[i].Split(" ");
                if (words[0] == "forward")
                {
                    Horizontal += int.Parse(words[1]);
                    Depth += Aim * int.Parse(words[1]);
                }
                else if (words[0] == "down")
                {
                    Aim += int.Parse(words[1]);
                }
                else if (words[0] == "up")
                {
                    Aim -= int.Parse(words[1]);
                }
                else
                {
                    Console.WriteLine("wrong data!!!!!!");
                }
            }

            Result[0] = Aim * Horizontal;
            Result[1] = Depth * Horizontal;
        }

        public int[] calc()
        {
            _readLines(FilePath);
            _calculate();
            Console.WriteLine(Result[0] + " and " + Result[1]);
            return Result;
        }
    }



}
