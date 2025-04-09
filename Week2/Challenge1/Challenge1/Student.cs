using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Student
    {
        static List<Student> students = new List<Student>();
        public string name;
        public float matricmarks;
        public float fscmarks;
        public float ecatmarks;

        public Student()
        {

        }
        public Student(string name, float matricmarks, float fscmarks, float ecatmarks)
        {
            this.name = name;
            this.matricmarks = matricmarks;
            this.fscmarks = fscmarks;
            this.ecatmarks = ecatmarks;
        }
        public void AddStudent(Student s)
        {
            students.Add(s);
        }
        public static void ShowStudents()
        {
            for(int i = 0;i<students.Count;i++)
            {
                Console.WriteLine(students[i].name);
                Console.WriteLine(students[i].ecatmarks);
                Console.WriteLine(students[i].fscmarks);
                Console.WriteLine(students[i].ecatmarks);
            }
        }
        public void CalculateAggregate(string name)
        {
            float aggregate;
            for(int i = 0;i<students.Count;i++)
            {
                if (students[i].name == name)
                {
                    aggregate = ((students[i].matricmarks + students[i].fscmarks + students[i].ecatmarks) / 3);
                    Console.WriteLine($"Aggregate : {aggregate}");
                    break;
                }
            }
        }
    }
}
