using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(DoIt);
            Thread thread2 = new Thread(DoIt2);
            Thread thread3 = new Thread(DoIt3);

            thread.Start();
            thread2.Start();
            thread3.Start();
        }
        public static void DoIt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*");
            Console.WriteLine("Wait!");            
            
        }
        public static void DoIt2()
        {
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*");
            Console.WriteLine("Prepare");           
        }
        public static void DoIt3()
        {
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*");
            Console.WriteLine("Go");
            Thread.Sleep(10000);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
