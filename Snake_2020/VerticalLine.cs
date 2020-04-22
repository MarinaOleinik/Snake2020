using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_2020
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yLeft, int yReight, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yReight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
