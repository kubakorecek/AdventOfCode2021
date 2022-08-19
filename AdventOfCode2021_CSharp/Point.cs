using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Int64 CantorPair {get; } 
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.CantorPair = Point.CantorHashing(this);
        }

        public Point()
        {

        }

        // https://en.wikipedia.org/wiki/Pairing_function#Cantor_pairing_function
        // (a + b) * (a + b + 1) / 2 + a; where a, b >= 0
        public static Int64 CantorHashing(Point a)
        {
            return ((a.y + a.x) * (a.y + a.x + 1) / 2) + a.y;
        }

        // a >= b ? a * a + a + b : a + b * b;  where a, b >= 0

        public override bool Equals(object? obj)
        {
            {
                // If the passed object is null
                if (obj == null)
                {
                    return false;
                }
                if (!(obj is Point))
                {
                    return false;
                }
                return (this.CantorPair == ((Point)obj).CantorPair);
            }
        }
    }
}
