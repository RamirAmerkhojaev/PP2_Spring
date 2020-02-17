using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    class Program
    {
        public static int x1 = 0;
        public static int x2 = 0;
        public static int y1 = 0;
        public static int y2 = 1;

        static void Main(string[] args)
        {
            Timer timer = new Timer(225);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            Timer timer2 = new Timer(500);
            timer2.Elapsed += Timer2_Elapsed;
            timer2.Start();

            ConsoleKeyInfo key = Console.ReadKey();
            if(key.Key == ConsoleKey.Spacebar)
            {
                timer.Stop();
                timer2.Stop();
            }            
            Console.ReadKey();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.SetCursorPosition(x1, y1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("-");
            x1++;
        }

        private static void Timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.SetCursorPosition(x2, y2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-");          
            x2++;
        }       
    }
}
