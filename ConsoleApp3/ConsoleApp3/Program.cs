using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;

namespace ConsoleApp3
{
    class Program
    {


        public static object MessageBox { get; private set; }
        
        

        public static void Properties()
        {
            Console.SetCursorPosition(7, 31);
            Console.Write("SNAKE GAME -- Author: Ramir");
            Console.SetCursorPosition(15, 33);
            Console.Write("YOU DIED!");
            Console.SetCursorPosition(2, 37);
            Console.WriteLine("Press R to reset a game");
            Console.SetCursorPosition(2, 38);
            Console.WriteLine("Press ESC to end a game");
           
            ConsoleKeyInfo consoleKey = Console.ReadKey();

            switch (consoleKey.Key)
            {
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.R:
                    Console.Clear();                
                    break;
            }
        }
            
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter your name: ");
            Console.ReadLine();

            Console.CursorVisible = false; 
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);        

            Worm worm = new Worm('O');
            Food food = new Food('@');
            Wall wall = new Wall('#');
            Console.ForegroundColor = ConsoleColor.Green;           

            while (true)
            {
              
                worm.Draw();
                wall.Draw();
                food.Draw();

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        worm.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        worm.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        worm.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        worm.Move(1, 0);
                        break;
                }

                CheckEmpty();
                CheckColision();

                if (worm.body.Count == 5 )
                {
                    Console.Clear();
                    wall.body.Clear();
                    wall.LoadLevel(2);
                    Console.SetCursorPosition(2, 35);
                    Console.WriteLine("Your score is: {0}", worm.body.Count - 1);
                }
                else if(worm.body.Count == 10)
                {
                    Console.Clear();
                    wall.body.Clear();
                    wall.LoadLevel(3);
                    Console.SetCursorPosition(2, 35);
                    Console.WriteLine("Your score is: {0}", worm.body.Count - 1);
                   
                }
                
            }
            void CheckColision()
            {
                if (worm.CheckIntersection(food.body) == true)
                {

                    food.Generate(wall.body, worm.body);
                    worm.Eat(food.body);                  
       
                }
                else if(worm.CheckColision(worm.body) == true)
                {
                    Properties();
                }
                else if (worm.CheckColision2(wall.body) == true)
                {
                    Properties();
                }
            }
            void CheckEmpty()
            {
                if (food.Empty(food.body) == true || food.Empty2(wall.body) == true)
                {
                    food.Generate(wall.body, worm.body);
                }
            }          
        }
    }
}
