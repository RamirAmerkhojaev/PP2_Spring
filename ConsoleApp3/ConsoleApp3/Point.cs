using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Point
    {
        int x;
        int y;

        int Filter1(int v)
        {
            if (v < 0) v = 39;
            else if (v >= 40) v = 0;
            return v;
        }

        int Filter2(int v)
        {
            if (v < 0) v = 29;
            else if (v >= 30) v = 0;
            return v;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = Filter1(value);
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = Filter2(value);
            }
        }
        public Point()
        {
        }
    }
}
