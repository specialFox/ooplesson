using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(6, 4, '@');
            Point p4 = new Point(8, 6, '$');
            Point p5 = new Point(9, 8, '%');
            Point p6 = new Point(12, 7, '^');

            HorizontalLine horLine = new HorizontalLine(4,20,7,'&');
            horLine.Draw();

            VerticalLine vLine = new VerticalLine(7, 23, 4, '&');
            vLine.Draw();

            Console.ReadLine();
        }

    }
}
