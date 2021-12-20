namespace AdventOfCode.Day3
{
    public class Excercise
    {

        private string FilePath;
        string[] File;

        private int[] Counts = new int[8];

        public Excercise(string filePath)
        {
            
            FilePath = filePath;
            
        }


        private void _readLines(string filePath)
        {
            File = System.IO.File.ReadAllLines(filePath);

        }
        private void _calculate()
        {
            string data = "";
            double len = Math.Ceiling((double)(File.Length + 1) / 2);
            int[] Counter = new int[8] {0,0,0,0,0,0,0,0};
            for (int i = 0; i < len; i++) 
            {
                data = File[i];
                for (int j = 0; j < 8; j++) 
                {
                    if(data[j] == '1') { Counter[j] += 1; }
                }
            }

            for (int j = 0; j < 8; j++)
            {
                Console.WriteLine(Counter[j]);
                if(Counter[j] > len) { }
            }


        }

        public int calc()
        {
            _readLines(FilePath);
            _calculate();
            return 0;
        }
    }
}