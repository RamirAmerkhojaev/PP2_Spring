using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [Serializable]
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        } 
        public Person(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Rem", 17);
            Person person2 = new Person("Isa", 19);

            Person[] people = new Person[] { person1, person2 };

            BinaryFormatter bin = new BinaryFormatter();

            using (FileStream fs = new FileStream("people.txt", FileMode.OpenOrCreate))
            {
                bin.Serialize(fs, people);
                Console.WriteLine("Object is serialized");
            }
            
            using(FileStream fs = new FileStream("people.txt", FileMode.OpenOrCreate))
            {
                Person[] desu = (Person[])bin.Deserialize(fs);

                foreach(Person p in desu)
                {
                    Console.WriteLine("Name: {0}   Age:{1}", p.Name, p.Year);
                }
            }
        }
    }
}
