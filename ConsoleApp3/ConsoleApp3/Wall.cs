using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Wall:GameObject
    { 

        public Wall(char sign): base(sign)
        {
            
            LoadLevel(1);
        }

        
        public void LoadLevel(int lvl)
        {
           
            string name = string.Format("C:/Users/Dell/source/repos/ConsoleApp3/ConsoleApp3/Lvls/TextFile{0}.txt", lvl);
            using(StreamReader reader = new StreamReader(name))
            {
                int r = 0;
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    for (int c = 0; c < line.Length; c++)
                    {
                        if (line[c] == '#')
                        {
                            body.Add(new Point { X = c, Y = r });
                        }
                        
                    }   
                    r++;                   
                }
            }           
        }
    }
}
