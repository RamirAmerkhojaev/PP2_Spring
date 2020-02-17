using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            void myNum(int number = 20)
            {
                number = 20;
                Console.Write(num);
            }
            myNum(num);
        }
    }
}
