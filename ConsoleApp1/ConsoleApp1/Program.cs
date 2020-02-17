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
    public class University
    {
        public string Name
        {
            get;
            set;
        }
        public int Number
        {
            get;
            set;
        }
        public University()
        {

        }
        public University(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public void AddStudent()
        {
            Console.WriteLine(Name + " " + Number);
            Number++;           
        }
        public override string ToString()
        {
            return Name + " " + Number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harvard";
            int number = 3000;
      
            List<University> newlist = new List<University>();
            newlist.Add(new University(name, number));

            University unik = new University(name, number);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    unik.AddStudent();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            using (FileStream fs = new FileStream("univer.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xs = new XmlSerializer(typeof(University));
                xs.Serialize(fs, newlist);
            }
            using(FileStream fs2 = new FileStream("univer.txt", FileMode.OpenOrCreate , FileAccess.ReadWrite))
            {
                XmlSerializer xs2 = new XmlSerializer(typeof(University));
                University newunik = (University)xs2.Deserialize(fs2); 
            }            
        }
    }
}
