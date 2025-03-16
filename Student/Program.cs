using System;

namespace Student
{
    class Student
    {
        public string Name;
        public int Age;
        public double GPA;

        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, {Age} years old with a GPA of {GPA}.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alice", 21, 3.8);
            Student s2 = new Student("Bob", 22, 3.5);

            s1.Introduce();
            s2.Introduce();
        }
    }
}
