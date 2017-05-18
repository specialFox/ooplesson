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

            Console.SetBufferSize(120,30);


            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(6, 4, '@');
            Point p4 = new Point(8, 6, '$');
            Point p5 = new Point(9, 8, '%');
            Point p6 = new Point(12, 7, '^');

            HorizontalLine hLineUp = new HorizontalLine(0,78,0,'+');
            HorizontalLine hLineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine vLineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine vLineRight = new VerticalLine(0, 24, 78, '+');

            hLineUp.Draw();
            hLineDown.Draw();
            vLineLeft.Draw();
            vLineRight.Draw();

            Console.ReadLine();
        }

    }
}
