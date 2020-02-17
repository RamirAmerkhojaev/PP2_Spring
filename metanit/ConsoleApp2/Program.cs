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
            Thread thread = new Thread(new ThreadStart(Count));
           
            thread.Start();

            for (int i = 1; i<10; i++)
            {
                Console.WriteLine("Main thread: ");
                Console.WriteLine(i * i);
                Thread.Sleep(500);
            }
        }
        public static void Count()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Fuck you");
                Thread.Sleep(900);
            }
        }
    }
}
