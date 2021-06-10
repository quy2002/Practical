using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Student
    {
        public string name;
        public int age;

        public Student()
        {
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Ten SV: " + name);
            Console.WriteLine("Tuoi: " + age);
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello..");
        }
    }
}
