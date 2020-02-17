using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        public static int i = 7;
      
        static void Main(string[] args)
        {
            Thread thread = new Thread(Draw);
            Console.WriteLine("######");
            Console.WriteLine("##");
            Console.WriteLine("##");


            ConsoleKeyInfo key = Console.ReadKey();
           
            if(key.Key == ConsoleKey.Spacebar)
            {
                thread.Start();
            }
           
        }      
         
        private static void Draw()
        {
            for(int j=0; j<33; j++) {
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(i, 0);
                    Console.Write("$");
                    Console.SetCursorPosition(i - 1, 0);
                    Console.Write(" ");
                    i++;
                    Thread.Sleep(20);
                }
            }   
        }
    }
}
