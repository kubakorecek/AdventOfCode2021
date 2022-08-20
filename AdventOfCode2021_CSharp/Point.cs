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
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            Console.WriteLine("Point will be initialized as origin ( 0, 0 )");

        }

        // https://en.wikipedia.org/wiki/Pairing_function#Cantor_pairing_function
        // (a + b) * (a + b + 1) / 2 + a; where a, b >= 0
        public static int CantorHashing(Point a)
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
                return (this.GetHashCode() == ((Point)obj).GetHashCode());
            }
        }

        public override int GetHashCode() => CantorHashing(this);
        
    }
}
