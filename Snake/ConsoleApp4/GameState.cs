using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    class GameState
    {
        public int Score = 1;

        System.Timers.Timer timer = new System.Timers.Timer(120);
        System.Timers.Timer gameTime = new System.Timers.Timer(1000);
        Worm worm = new Worm('O');
        Food food = new Food('@');
        Wall wall = new Wall('#');

        public GameState()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            food.Generate(wall.body, worm.body);
        }

        public void Run()
        {
            ThreadStart action = new ThreadStart(ChangeFrame);
            Thread task = new Thread(action);
            task.Start();
            food.Draw();
            wall.Draw();
        }

        public void Run2()
        {
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            gameTime.Elapsed += GameTime_Elapsed;
            gameTime.Start();


            food.Draw();
            wall.Draw();
        }

        private void GameTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            ShowStatusBar2(DateTime.Now.Second.ToString());
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            worm.Clear();
            worm.Move();
            worm.Draw();
            CheckEmpty();
            CheckColision();
           
            ShowStatusBar(worm.body.Count.ToString());
        }

        private void ChangeFrame()
        {
            while (true)
            {
                worm.Clear();
                worm.Move();
                worm.Draw();
                CheckColision();
                Checkcolision2();
                CheckEmpty();
                Thread.Sleep(400);
            }
        }

        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Dx = 0;
                    worm.Dy = -1;
                    break;
                case ConsoleKey.DownArrow:
                    worm.Dx = 0;
                    worm.Dy = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Dx = -1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.RightArrow:
                    worm.Dx = 1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.Spacebar:
                    timer.Enabled = !timer.Enabled;                                        
                    break;
            }
                        
            CheckEmpty();
            CheckColision();
            Checkcolision2();

           if(Score == 5)
           {
                Console.Clear();
                wall.body.Clear();
                wall.LoadLevel(2);
                wall.Draw();
                food.Draw();
                Console.SetCursorPosition(2, 35);
                Console.WriteLine("Your score is: {0}", worm.body.Count - 1);
           }
            
           else if (Score == 10)
           {
                Console.Clear();
                wall.body.Clear();
                wall.LoadLevel(3);
                wall.Draw();
                food.Draw();
                Console.SetCursorPosition(2, 35);
                Console.WriteLine("Your score is: {0}", worm.body.Count - 1);
            }
        }

        void ShowStatusBar(string message)
        {          
        }

        void ShowStatusBar2(string message)
        {  
        }

        void CheckColision()
        {            
            if (worm.CheckIntersection(food.body) == true)
            {
                Console.SetCursorPosition(2, 35);
                Console.WriteLine("Your score is: {0}", Score);
                Score++;
                worm.Eat(food.body);
                food.Generate(wall.body, worm.body);
                food.Draw();
                
            }           
        }
        void Checkcolision2()
        {
            if (worm.CheckColision2(wall.body) == true)
            {
                timer.Enabled = !timer.Enabled;
                Console.SetCursorPosition(7, 31);
                Console.Write("SNAKE GAME -- Author: Ramir");
                Console.SetCursorPosition(15, 33);
                Console.Write("YOU DIED!");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("Press ESC to end a game");

                ConsoleKeyInfo consoleKey = Console.ReadKey();
                switch (consoleKey.Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;                   
                }
                
            }

            else if (worm.CheckColision(worm.body) == true)
            {
                timer.Enabled = !timer.Enabled;
                Console.SetCursorPosition(7, 31);
                Console.Write("SNAKE GAME -- Author: Ramir");
                Console.SetCursorPosition(15, 33);
                Console.Write("YOU DIED!");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("Press ESC to end a game");

                ConsoleKeyInfo consoleKey2 = Console.ReadKey();
                switch (consoleKey2.Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }

            }            
        }
        void CheckEmpty()
        {
            if (food.Empty(worm.body) == true || food.Empty2(wall.body) == true)
            {
                food.Generate(wall.body, worm.body);
                food.Draw();
            }
        }
    }
}