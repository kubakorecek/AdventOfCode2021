namespace AdventOfCode.Run
{
    class RunAOC2021
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


            filepath = @"C:\Users\kubak\source\repos\AdventOfCode\AdventOfCode.Day3\input.txt";

            if (File.Exists(filepath))
            {
                Console.WriteLine("File exists...");
                Day3.Excercise st = new Day3.Excercise(filepath);
                st.calc();
                string t = "TEST@";
                Console.WriteLine(t.Substring(4));
            }
            else
            {
                Console.WriteLine("File does not exist in the current directory!");
            }
        }
    }
}
