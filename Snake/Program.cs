using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        { 
            Wall wall = new Wall(70, 24);
            wall.Draw();
		
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 2, Dir.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(70, 24, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();
        }


        static void WriteGameOver()
        {
            Console.SetCursorPosition(25, 12);
            Console.BackgroundColor = (ConsoleColor)(100%16);
            Console.WriteLine("GAME OVER =(");
        }
    }
}