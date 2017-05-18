using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point
    {

        public int x, y;
        public char sym;

        //вывод символа на экран по указанной позиции
        public void Draw(int xP, int yP, char symP)
        {
            Console.SetCursorPosition(xP, yP);
            Console.Write(symP);
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

}
