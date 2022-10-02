namespace AdventOfCode2021_CSharp
{
    public class Day6 : ILoader
    {
        private string fileContent;

        List<List<int>> fishTimer = new();

        public Day6(string fileContent)
        {
            this.fileContent = fileContent;
        }

        public bool Load()
        {
            fishTimer = fileContent
                .Split("\r\n")
                .Select(x => x.Split(":")[1].Split(",")
                .Select(int.Parse).ToList()).ToList();
            return true;
        }

        public int Part1Niave(int days)
        {
            for (int i = 1; i < days+1; i++) 
            {
                var curRow = fishTimer[i - 1];
                var nextRow = new List<int>();
                for (int j = 0; j < curRow.Count; j++)
                {
                    if (curRow[j] == 0) 
                    {
                        nextRow.Add(6);
                        nextRow.Add(8);
                    }
                    else 
                    {
                        nextRow.Add(curRow[j]-1);
                    }

                    
                }
                fishTimer.Add(nextRow);
            }
        return fishTimer[days].Count;
        }
    }
}