using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Run
{
    class RunAOC20221
    {
        public static void Main(string[] Args)
        {
            string filepath = @"C:\Users\kubak\source\repos\AdventOfCode\AdventOfCode.Day1\input.txt";
            if (File.Exists(filepath))
            {
                Console.WriteLine("File exists...");
                Day1.Excercise st = new Day1.Excercise(filepath);
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
                Day2.Excercise st = new Day2.Excercise(filepath);
                st.calc();
            }
            else
            {
                Console.WriteLine("File does not exist in the current directory!");
            }

        }
    }
}
