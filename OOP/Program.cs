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

            List<Point> lPoint = new List<Point>();
            lPoint.Add(p1);
            lPoint.Add(p2);
            lPoint.Add(p3);
            lPoint.Add(p4);
            lPoint.Add(p5);
            lPoint.Add(p6);

            foreach (Point i in lPoint) {
                i.Draw();
                //Console.WriteLine(i);
            }

            Console.ReadLine();
        }

    }
}
