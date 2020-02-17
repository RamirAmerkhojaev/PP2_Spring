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
    public class Person
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
        public Person()
        {

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
            Person person = new Person("Ramir", 17);
            XmlSerializer xml = new XmlSerializer(typeof(Person));

            using(FileStream fs = new FileStream("person111.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, person);
            }

            using(FileStream fs = new FileStream("person111.xml", FileMode.OpenOrCreate))
            {
                Person newperson = (Person)xml.Deserialize(fs);

                Console.WriteLine("Object is deserialized");
                Console.WriteLine("Name: {0}   Age: {1}", newperson.Name, newperson.Year);
            }
        }
    }
}
