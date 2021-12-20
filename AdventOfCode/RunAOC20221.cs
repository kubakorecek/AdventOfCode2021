using DAY2.src;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2021.src
{
    class RunAOC20221
    {
        public static void Main(string[] Args) 
        {
            string filepath = @"C:\Users\kubak\source\repos\AdventOfCode\AdventOfCode.Day1\input.txt";
            if (File.Exists(filepath))
            {
                Console.WriteLine("File exists...");
                Excercise1 st = new Excercise1(filepath);
                st.calc();
            }
            else
            {
                Console.WriteLine("File does not exist in the current directory!");
            }


            filepath = @"C:\Users\kubak\source\repos\AdventOfCode\AdventOfCode.Day2\input.txt";

            if (File.Exists(filepath))
            {
                Console.WriteLine("File exists...");
                Excercise st = new Excercise(filepath);
                st.calc();
            }
            else
            {
                Console.WriteLine("File does not exist in the current directory!");
            }

        }
    }
}
