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

            for (int x = xLeft; x <= xRight; x++) {
                pLine.Add(new Point(x, y, sum));
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
