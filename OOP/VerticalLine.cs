using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class VerticalLine
    {
        List<Point> pointList;
        public VerticalLine(int yTop,int yBottom,int x, char sym) {
            pointList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++) {
                pointList.Add(new Point(x, y, sym));
            }
        }

        public void Draw() {
            foreach (Point p in pointList) {
                p.Draw();
            }
        }

    }
}
