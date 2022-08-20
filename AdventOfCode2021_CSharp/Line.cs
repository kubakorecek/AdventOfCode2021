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

        public LineType Type { get; } = LineType.OTHER;

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

            
                       
            if (Start.x > End.x || (Start.x == End.x && Start.y > End.y))
            {
                Point tmp;
                tmp = End;
                End = Start;
                Start = tmp;
            }

            



            

            Points.Add(Start);
            if (Start.x == End.x)
            {
                Gradient = double.PositiveInfinity;
                Const = double.NegativeInfinity;
                addYPoints();
                Type = LineType.VERTICAL;

            }
            else if (Start.y == End.y)
            {
                Const = Start.y;
                Gradient = 0;
                addXPoints();
                Type = LineType.HORIZONTAL;
            }else 
            {
                Const = Start.y - Start.x * Gradient;
                Gradient = (Start.y - End.y) / (Start.x - End.x);
                addOtherPoints();
                Type = LineType.OTHER;
            }

            Points.Add(End);

        }

        private void addXPoints() 
        {
            int startX = Start.x + 1;
            int y = (int)Const;
            while (startX < End.x) 
            {                
                Points.Add(new Point(startX, y));
                startX++;
            }
        }

        private void addYPoints()
        {
            int starty = Start.y + 1;
            while (starty < End.y)
            {
               
                Points.Add(new Point(Start.x,starty));
                starty++;
            }
        }

        private void addOtherPoints()
        {
            int startX = Start.x + 1;
            
            while (startX < End.x)
            {
                var y = (int)(Gradient * startX + Const);
                Points.Add(new Point(startX, y));
                startX++;
            }
        }


    }
}
