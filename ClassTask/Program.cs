using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Program
    {
        class Student
        {
            public string name { get; private set; }
            public int age { get; private set; }
            public List<int> grades { get; private set; }

            public Student(string name, int age, List<int> grades)
            {
                this.name = name;
                this.age = age;
                this.grades = grades;
            }
            public double Average()
            {
                double numberOfGrades = this.grades.Count();
                double helper = 0;
                foreach (var grade in this.grades)
                {
                    helper += grade;
                   
                }
                return Math.Round(helper / numberOfGrades, 2);
                
            }    
                  
        }
        static void Main(string[] args)
        {
            Student first = new Student("Julika", 16, new List<int> {2,4,5 } );
            Student second = new Student("Dezső", 15, new List<int> { 5, 2, 5 });
            Student third = new Student("János", 17, new List<int> { 3, 4, 5 });
            Student fourth = new Student("Dávid", 16, new List<int> { 1, 2, 5 });
            Student fifth = new Student("József", 18, new List<int> { 3, 4, 5 });

            List<Student> students = new List<Student>();
            students.Add(first);
            students.Add(second);
            students.Add(third);
            students.Add(fourth);
            students.Add(fifth);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name}, {student.age} éves, az átlaga: {student.Average()} ");
            }

            Console.ReadKey();
        }
    }
}
