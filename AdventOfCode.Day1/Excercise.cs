namespace AdventOfCode.Day1
{
    public class Excercise
    {
        public string FilePath;
        private string[] Numbers;
        private int FirstNumber;
        private int SecondNumber;
        private int Result;
        public Excercise(string fn)
        {
            FirstNumber = int.MinValue;
            SecondNumber = int.MinValue;
            Result = 0;
            FilePath = fn;
            Numbers = File.ReadAllLines(FilePath);
        }

        private void _calculate()
        {
            int len = Numbers.Length;
            for (int i = 1; i < len; i++)
            {
                SecondNumber = int.Parse(Numbers[i - 1]);
                if (SecondNumber > FirstNumber) { Result++; }
                FirstNumber = SecondNumber;
            }
        }

        private void _calculate_sliding_window()
        {

            int len = Numbers.Length;
            for (int i = 3; i < len; i++)
            {
                SecondNumber = int.Parse(Numbers[i - 3]) + int.Parse(Numbers[i - 2]) + int.Parse(Numbers[i - 1]);
                if (SecondNumber > FirstNumber) { Result++; }
                FirstNumber = SecondNumber;
            }
        }

        public int calc()
        {
            _calculate();
            Console.WriteLine(Result);
            Result = 0;
            _calculate_sliding_window();
            Console.WriteLine(Result);
            return Result;
        }


    }
}
