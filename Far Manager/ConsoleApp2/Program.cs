using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApp2
{  
    class Layer
    {
        public FileSystemInfo[] Content
        {
            get;
            set;
        }

        public int Cursor;        
      
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for(int i=1; i<Content.Length; i++)
            {
                if (i == Cursor && Cursor<=5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(i== Cursor && Cursor > 5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if(i!=Cursor && i<=5)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(i!=Cursor && i > 5)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(i+". " + Content[i].Name);
            }
        }
    }
    
    enum FarMode
    {
        DirectoryView,
        FileView
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(@"C:\Users\Dell\Documents");
            Stack<Layer> history = new Stack<Layer>();
            FarMode farMode = FarMode.DirectoryView;

            history.Push(new Layer { Content = root.GetFileSystemInfos(), Cursor = 0 });


            while (true)
            {
                if (farMode == FarMode.DirectoryView)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo key = Console.ReadKey();
                switch(key.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().Cursor--;
                        if(history.Peek().Cursor < 0)
                            history.Peek().Cursor = history.Peek().Content.Length-1;
                        break;

                    case ConsoleKey.DownArrow:
                        history.Peek().Cursor++;
                        if (history.Peek().Cursor == history.Peek().Content.Length)
                            history.Peek().Cursor = 0;
                        break;

                    case ConsoleKey.RightArrow:
                        int rx = history.Peek().Cursor;
                        FileSystemInfo fileSystemInfo1 = history.Peek().Content[rx];
                        if (fileSystemInfo1.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo dir = fileSystemInfo1 as DirectoryInfo;
                            history.Push(new Layer { Content = dir.GetFileSystemInfos(), Cursor = 0 });
                        }
                        else
                        {
                            farMode = FarMode.FileView;
                            using (FileStream fs = new FileStream(fileSystemInfo1.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (farMode == FarMode.DirectoryView)
                        {
                            history.Pop();
                            history.Peek().Cursor = 0;

                        }
                        else if (farMode == FarMode.FileView)
                        {
                            farMode = FarMode.DirectoryView;
                            Console.BackgroundColor = ConsoleColor.White;
                            history.Peek().Cursor = 0;
                        }
                        break;

                    case ConsoleKey.Enter:
                        int x = history.Peek().Cursor;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];
                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo dir = fileSystemInfo as DirectoryInfo;
                            history.Push(new Layer { Content = dir.GetFileSystemInfos(), Cursor = 0 });
                        }
                        else
                        {
                            farMode = FarMode.FileView;
                            using (FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using(StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (farMode == FarMode.DirectoryView)
                        {
                            history.Pop();
                            history.Peek().Cursor = 0;
                           
                        }
                        else if(farMode == FarMode.FileView)
                        {
                            farMode = FarMode.DirectoryView;
                            Console.BackgroundColor = ConsoleColor.White;
                            history.Peek().Cursor = 0;
                        }
                        break;
                    case ConsoleKey.Delete:
                        int y = history.Peek().Cursor;
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[y];
                        if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo dir = fileSystemInfo2 as DirectoryInfo;
                            Directory.Delete(fileSystemInfo2.FullName, true);
                            history.Peek().Content = dir.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo f = fileSystemInfo2 as FileInfo;
                            File.Delete(fileSystemInfo2.FullName);
                            history.Peek().Content = f.Directory.GetFileSystemInfos();
                        }
                        history.Peek().Cursor--;
                        break;

                    case ConsoleKey.Insert:
                        int z = history.Peek().Cursor;
                        FileSystemInfo fileSystemInfo3 = history.Peek().Content[z];
                        if (fileSystemInfo3.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo dir = fileSystemInfo3 as DirectoryInfo;
                            Console.Clear();
                            Console.WriteLine("Enter name: ");
                            string newnameFolder = Console.ReadLine();

                            try
                            {
                                dir.MoveTo(Path.Combine(dir.Parent.FullName, newnameFolder));
                                history.Peek().Content = dir.Parent.GetFileSystemInfos();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                return;
                            }                                        
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Enter name: ");
                            FileInfo f = fileSystemInfo3 as FileInfo;
                            string newnameFile = Console.ReadLine();

                            try
                            {
                                File.Move(fileSystemInfo3.FullName, fileSystemInfo3.FullName.Replace(fileSystemInfo3.Name, newnameFile));
                                history.Peek().Content = f.Directory.GetFileSystemInfos();
                            }
                            catch(Exception w)
                            {
                                Console.WriteLine(w.Message);
                                return;
                            }
                        }
                        break;
                }   
            }
        }
    }
}
