using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class HorizontalLine
    {
        List<Point> pLine;
        public HorizontalLine(int xLeft,int xRight, int y,char sum) {

            pLine = new List<Point>();
            for (int x = xLeft; x <= xRight; x++) {
                Point p = new Point(x, y, sum);
                pLine.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pLine) {
                p.Draw();
            }
        }
    }
}
