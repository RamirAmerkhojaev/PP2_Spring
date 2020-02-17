using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    class Layer
    {

        public FileSystemInfo[] Content
        {
            get;
            set;
        }

        public int selectedItem;

        public int SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (value < 0)
                {
                    selectedItem = Content.Length - 1;
                }
                else if (value == Content.Length)
                {
                    selectedItem = 0;
                }
                else
                {
                    selectedItem = value;
                }
            }
        }
        public void adress()
        {
            Console.Clear(); 
            for (int i = 0; i < Content.Length; i++)
            {
                if(i == selectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(Content[i].Name);
            }
        }
        public void adress1()
        {
            Console.Clear();
            for (int i = Content.Length-1; i>= 0; i--)
            {
                if (i == selectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(Content[i].Name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Dell\Documents\Work");

            Layer lay = new Layer
            {
                Content = dir.GetFileSystemInfos(),
                selectedItem = 0
            };

            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.F1)
            {


                while (true)
                {
                    lay.adress();

                    ConsoleKeyInfo key1 = Console.ReadKey();
                    switch (key1.Key)
                    {

                        case ConsoleKey.DownArrow:

                            lay.SelectedItem++;
                            break;
                        case ConsoleKey.UpArrow:

                            lay.SelectedItem--;
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }
            }

                 else if (key.Key == ConsoleKey.F2)
                 {

                

                      while (true)
                      {
                            lay.adress1();

                          ConsoleKeyInfo key1 = Console.ReadKey();
                          switch (key1.Key)
                          {
                            case ConsoleKey.UpArrow:
                            lay.SelectedItem++;
                            break;
                            case ConsoleKey.DownArrow:
                            lay.SelectedItem--;
                            break;
                            case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                          }

                      }
                 }    
        } 
    }
}
