namespace AdventOfCode2021_CSharp
{
    public class Day4
    {
        public string FileContent { get; }

        public List<int> Numbers { get; private set; } = new List<int>();

        public List<Board> Boards { get; private set; } = new List<Board>();


        public Day4(string fileContent)
        {
            FileContent = fileContent;

        }

        public bool Load()
        {
            var blocks = FileContent.Split("\r\n\r\n");
            Numbers = blocks.First().Split(',').Select(int.Parse).ToList();
            Boards = blocks.Skip(1).Select(block => new Board(block)).ToList();
            return true;
        }

        public int PartOne()
        {
            foreach (var number in Numbers)
            {
                foreach (var board in Boards)
                {
                    board.RemoveElement(number);
                    if (board.IsWinner()) 
                    {
                        return number * board.Sum();
                    }
                };
            }
            return -1;
        }

        public int PartTwo()
        {
            int win = -1;
            foreach (var number in Numbers)
            {
                foreach (var board in Boards)
                {
                    board.RemoveElement(number);
                    if (board.IsWinner())
                    {
                        win = number * board.Sum();
                    }
                };
            }
            return win;
        }
    }
}