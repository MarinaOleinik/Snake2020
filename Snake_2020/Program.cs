using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Snake_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";
            Console.SetWindowSize(101, 26);
            Random rand = new Random();
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(Convert.ToString(rand.Next(Enum.GetNames(typeof(ConsoleColor)).Length)));
            //ConsoleColor.(ConsoleColor(rand.Next(Enum.GetNames(typeof(ConsoleColor)).Length));

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Params settings = new Params();
            Sound sound = new Sound(settings.GetResourceFolder());
            sound.Play();
            Sound soundeat = new Sound(settings.GetResourceFolder());

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(101, 26, '¤');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    soundeat.PlayEat();
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

            //Console.ReadLine();
        }
    }
}
