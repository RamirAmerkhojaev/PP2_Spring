using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Example2
{
    public class Student
    {

        public string Name
        {
            get;
            set;
        }
        public string Gpa
        {
            get;
            set;
        }
        public Student()
        {

        }      
        public Student(string name, string gpa)
        {
            Gpa = gpa;
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            F1();
        }

        private static void F1()
        {
            string name = "Alex";
            string gpa = "3.7";
            Student student = new Student(name, gpa);
            

            XmlSerializer xs = new XmlSerializer(typeof(Student));

            using(FileStream fs = new FileStream("student.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                xs.Serialize(fs, student);
            }
            using(FileStream fs2 = new FileStream("student.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                Student newstudent = (Student)xs.Deserialize(fs2);
                Console.WriteLine("Student's name: {0}", name);
                Console.WriteLine("Student's gpa: {0}", gpa);
            }
        }
    }
}