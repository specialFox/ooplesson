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
        const int mapWidght = 120;
        const int mapHeight = 30;

        static void Main(string[] args)
        {

            Console.SetBufferSize(120,30);            
            Walls walls = new Walls(mapWidght,mapHeight);
            walls.Draw();


            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(mapWidght,mapHeight,'@');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true) {
                if (walls.IsHit(snake) || snake.HitHisTail()){
                //if (walls.IsHit(snake))
                //{
                    Console.WriteLine("You LOOOSE");
                    break;
                }

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
