using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using System.Threading;

namespace MatrixConsole
{
    class Program
    {
        public static List<char> matrix = new List<char>();
        public static int[] posy = new int[40];
        public static Random r = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Timer t = new Timer(25);
            t.Elapsed += T_Elapsed;
            t.Start();
            while (true)
            {
                List<char> cs = new List<char>();
                for (int i = 0; i<40; i++)
                {
                    cs.Add((char)r.Next(200));
                }
                matrix = cs;
            }
        }

        private static void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            for(int i = 0; i<matrix.Count; i+=r.Next(1,4))
            {
                Console.SetCursorPosition(i, posy[i]);
                Console.Write(matrix[i]);
                posy[i] ++;
                if(posy[i] > 40)
                {
                    posy[i] = 0;
                }
            }
        }
    }
}
