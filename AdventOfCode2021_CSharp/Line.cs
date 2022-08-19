using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Line
    {
        public Point Start { get; set; } = new Point();

        public Point End { get; set; } = new Point();

        public double Gradient { get; }

        public double Const { get; }

        public List<Point> Points { get; set; } = new List<Point>();

        public Line() 
        {
            throw new ArgumentException("Line is defined by TWO points!!!");
        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
            Gradient = (Start.y - End.y) / (Start.x - End.x);

            if (Start.x > End.x || (Start.x == End.x && Start.y > End.y))
            {
                Point tmp;
                tmp = End;
                End = Start;
                Start = tmp;
            }

            Const = Start.y - Start.x * Gradient;
            _addPoints(Start , End);



        }

        private void _addPoints(Point start, Point end) 
        {
            Points.Add(start);
            int startX = start.x + 1;
            while (startX < end.x) 
            {
                int y = (int)(startX * Gradient + Const);
                Points.Add(new Point(startX, y));
                startX++;
            }


            Points.Add(end);
        }


    }
}
