using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread thread = new Thread(GreenMove);
            Thread thread2 = new Thread(RedMove);
            thread.Start();
            Thread.Sleep(13);
            thread2.Start();

            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                if(key.Key == ConsoleKey.Spacebar)
                {
                    thread.Abort();
                    thread2.Abort();
                }
                Console.ReadKey();
                break;
            }
        }

        private static void RedMove()
        {
            int x = 0;
            while (x < Console.WindowWidth)
            {
                Console.SetCursorPosition(x, 0);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("-");
                x++;
                Thread.Sleep(125);
            }
        }

        private static void GreenMove()
        {
            int x = 0;
            while (x < Console.WindowWidth)
            {
                Console.SetCursorPosition(x, 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("-");
                x++;
                Thread.Sleep(225);
            }
        }
    }
}
