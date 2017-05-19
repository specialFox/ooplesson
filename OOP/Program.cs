using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(120,30);

            HorizontalLine hLineUp = new HorizontalLine(0,78,0,'+');
            HorizontalLine hLineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine vLineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine vLineRight = new VerticalLine(0, 24, 78, '+');

            hLineUp.Draw();
            hLineDown.Draw();
            vLineLeft.Draw();
            vLineRight.Draw();

            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80,25,'@');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true) {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            Console.ReadLine();
        }

    }
}
