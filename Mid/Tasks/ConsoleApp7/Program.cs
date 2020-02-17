using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        public static int y;
        public static int dy;
        public static int x;
        public static int dx;
        public static int y1;
        public static int dy1;
        public static int x1;
        public static int dx1;
        public static Random r = new Random();
        public static Random r1 = new Random();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            y = r.Next(0, 0);
            dy = 1;
            x = r.Next(0, Console.WindowWidth);
            dx = 1;
            Thread thread = new Thread(Move);

            y1= r1.Next(0, 0);
            dy1 = 1;
            x1 = r1.Next(0, Console.WindowWidth);
            dx1 = 1;
            Thread thread1 = new Thread(Move2);

            while (true)
            {
                Move();                               
                Move2();
                Thread.Sleep(200);
            }
        }

        private static void Move2()
        {
            y += dy;
            if (y < 0)
            {
                y = 0;
                dy = 1;
            }
            Console.SetCursorPosition(x1, y1);
            Console.Write("I");
            Console.SetCursorPosition(x1, y1 - 1);
            Console.Write(" ");
        }

        private static void Move()
        {
            y += dy;
            if (y < 0)
            {              
                y = 0;
                dy = 1;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("I");
            Console.SetCursorPosition(x, y - 1);
            Console.Write(" ");            
        }
    }
}
