using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    public class Game
    {
        public string Name { get; set; }      
       
        public Field Field { get; set; }

        public List<Figure> Figures { get; set; }

        public Game() { }
        public Game(string name,Field field, List<Figure> f)
        {
            Name = name;
            Figures = f;
            Field = field;
        }
    }
  
    public class Field
    {
        public int Height { get; set; }
        public int Width { get; set; }
        
        public Field() { }
        public Field(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
  
    public class Figure
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Figure() { }
        public Figure(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ramir";
            Field field = new Field(17, 70);
            List<Figure> figure = new List<Figure>();

            figure.Add(new Figure("Name", 12, 56));

            
            Game game = new Game(name, field, figure);

            using (FileStream fs = new FileStream("C:/Users/Dell/Desktop/Mid/Tasks2/ConsoleApp1/bin/Debug/game.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Game));
                xs.Serialize(fs, game);
            }
            using(FileStream fs2 = new FileStream("C:/Users/Dell/Desktop/Mid/Tasks2/ConsoleApp1/bin/Debug/game.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xs2 = new XmlSerializer(typeof(Game));
                Game newgame = (Game)xs2.Deserialize(fs2);
               
            }
        }
    }
}
