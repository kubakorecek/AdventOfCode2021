namespace AdventOfCode.Day3
{
    public class Excercise
    {

        private string FilePath;
        string[] File;
        private int Result;

        public Excercise(string filePath)
        {

            FilePath = filePath;
            Result = 0;
        }


        private void _readLines(string filePath)
        {
            File = System.IO.File.ReadAllLines(filePath);

        }
        private void _calculate()
        {
            string data = "";
            double HalfLenght = Math.Ceiling((double)(File.Length / 2));
            int[] Counter = new int[File.First().Length];

            Array.Fill(Counter, 0);
            for (int i = 0; i < File.Length; i++)
            {
                data = File[i];
                for (int j = 0; j < File.First().Length; j++)
                {
                    if (data[j] == '1') { Counter[j] += 1; }
                }
            }
            int gamma = 0;
            int epsilon = 0;
            for (int j = 0; j < File.First().Length; j++)
            {
                
                if (Counter[j] > HalfLenght) {
                    gamma = gamma + (int)(Math.Pow(2, (11 - j)));
                } else
                {
                    epsilon = epsilon + (int)(Math.Pow(2, (11 - j)));
                }
            }


            Result = epsilon * gamma;
        }
        public void _calculate_2() { }
        public int calc()
        {
            _readLines(FilePath);
            _calculate();
            Console.WriteLine(Result);
            return Result;
        }
    }
}