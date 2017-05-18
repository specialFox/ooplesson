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
            
            Draw(1, 3, '*');
            Draw(4, 5, '#');

            Console.ReadLine();
        }

        //вывод символа на экран по указанной позиции
        static void Draw(int x, int y, char sym) {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
