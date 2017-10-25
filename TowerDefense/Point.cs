using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Double DistanceTo(int x, int y)
        {
            return Math.Sqrt(Math.Pow(Convert.ToDouble(x - X), 2) + Math.Pow(Convert.ToDouble(y - Y), 2));
        }
    }
}
