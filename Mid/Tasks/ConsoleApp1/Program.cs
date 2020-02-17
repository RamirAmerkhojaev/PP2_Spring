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
    class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Salary { get; set; }

        public Employee() { }
        public Employee(string name, string id, int salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }
        public void Increase()
        {
            Console.WriteLine(Name + " " + ID + " " + Salary);
            Salary += 50;
        }
        public override string ToString()
        {
            return Name+" "+ID+" "+Salary;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alex";
            string id = "18BD110311";
            int salary = 500;
            Employee employee = new Employee(name, id, salary);           

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.Enter)
                {
                    employee.Increase();
                }
                else if(key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            using (FileStream fs = new FileStream("work.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, employee);
            }
            using(FileStream fs2 = new FileStream("work.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xs2 = new XmlSerializer(typeof(Employee));
                Employee newemployee = (Employee)xs2.Deserialize(fs2);
            }
            Console.WriteLine(employee);
        }
    }
}
