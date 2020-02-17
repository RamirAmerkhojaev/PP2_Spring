using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Hodit
{
    class Program
    {
        static Point[] a, a1;
        public static List<Point> ls = new List<Point>();
        public static List<Point> ls1 = new List<Point>();
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"..\..\..\a.txt");
            int x = 0, y = 0;
            for(int i =0; i < s.Length; i++)
            {
                x++;
                if (s[i] == '\n')
                {
                        x = 0;
                    y++;
                    i++;
                }
                if(s[i] == '*')
                {
                    ls.Add(new Point(x, y));
                    ls1.Add(new Point(x, y + 10));
                }
            }
            Console.CursorVisible = false;
            a = ls.ToArray();
            a1 = ls1.ToArray();
            Timer t = new Timer(300);
            Timer t1 = new Timer(190);
            t.Elapsed += T_Elapsed;
            t1.Elapsed += T1_Elapsed;
            t.Start();
            System.Threading.Thread.Sleep(73);
            t1.Start();
            while (true) ;
        }

        private static void T1_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            for (int i = 0; i < a1.Length; i++)
            {
                Console.SetCursorPosition(a1[i].X, a1[i].Y);
                Console.Write("*");
                a1[i].X++;
            }
        }

        private static void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                Console.SetCursorPosition(a[i].X, a[i].Y);
                Console.Write("*");
                a[i].X++;
            }
        }
    }
}
