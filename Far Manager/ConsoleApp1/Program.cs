using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {
            var key = Console.ReadKey();

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Dell\Documents\Work");

            var dirs = dir.GetDirectories();

            foreach(var d in dirs)
            {
                int cnt = F(d, key.KeyChar);
                Console.WriteLine(string.Format("{0} ({1})",d.Name, cnt));
            }
        }
        public static int F(DirectoryInfo d, char c)
        {
            int res = 0;       

            try
            {
               var files = d.GetFiles();
                foreach(var f in files)
                {
                    if (f.Name[0] == c)
                    {
                        res++;
                    }
                }
            }
            catch(Exception e)
            {
             
                Console.WriteLine(e.Message);
            }
            return res;
        } 
        
    }
}
