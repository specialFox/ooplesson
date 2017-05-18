using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //вывод символа на экран по указанной позиции
    class Point
    {

        public int x, y;
        public char sym;

        public Point()
        {
            //Console.Write("constructor");
        }

        public Point(int _x,int _y, char _sym) {
            x = _x;
            y = _y;
            sym = _sym;
            //Console.Write("constructor");
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        
        public void Draw(int _x, int _y, char _sym)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }
    }

}
