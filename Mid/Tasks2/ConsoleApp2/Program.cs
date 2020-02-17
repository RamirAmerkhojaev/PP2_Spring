using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Draw);
            thread.Start();
            Thread.Sleep(1000);
            Thread thread2 = new Thread(Draw2);
            thread2.Start();
            Thread.Sleep(1000);
            Thread thread3 = new Thread(Draw3);
            thread3.Start();
            Thread.Sleep(1000);
            Thread thread4 = new Thread(Draw4);
            thread4.Start();
            Thread.Sleep(1000);
            Thread thread5 = new Thread(Draw5);
            thread5.Start();
            Thread.Sleep(1000);
            Thread thread6 = new Thread(Draw6);
            thread6.Start();
            Thread.Sleep(1000);
            Thread thread7 = new Thread(Draw7);
            thread7.Start();
            Thread.Sleep(1000);
            Thread thread8 = new Thread(Draw8);
            thread8.Start();
            Thread.Sleep(1000);
            Thread thread9 = new Thread(Draw9);
            thread9.Start();
            Thread.Sleep(1000);
        }

        private static void Draw9()
        {
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("*******");
        }

        private static void Draw8()
        {
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("* * * *");
        }

        private static void Draw7()
        {
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("* * * *");
        }

        private static void Draw5()
        {

            Console.SetCursorPosition(5, 4);
            Console.WriteLine("*   *");
        }
        private static void Draw6()
        {

            Console.SetCursorPosition(4, 5);
            Console.WriteLine("* *** *");
        }

        private static void Draw4()
        {
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("*******");
        }
    

        private static void Draw3()
        {
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("*   *");
        }

        private static void Draw2()
        {
            Console.SetCursorPosition(6, 1);
            Console.WriteLine("* *");
        }

        private static void Draw()
        {
            Console.SetCursorPosition(7, 0);
            Console.WriteLine("*");
        }

    }
}
