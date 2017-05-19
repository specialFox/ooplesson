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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction) {
            if (direction == Direction.RIGHT) {
                x = x + offset;
                }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }

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

        public void Clear() {
            sym = ' ';
            Draw();
        }
    }

}
