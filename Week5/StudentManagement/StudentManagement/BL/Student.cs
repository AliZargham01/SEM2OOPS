using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BL
{
    class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public string registeredProgram;
        public List<string> programs = new List<string>();
        public Student(string name, int age, double fscMarks, double ecatMarks, List<string> programs, string registeredProgram)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.programs = programs;
            calculateMerit();
        }
        public Student()
        {

        }
        public void calculateMerit()
        {
            this.merit = ((fscMarks* .50) + (0.50*ecatMarks)) * 100 ;
        }
        public void regSubject(Student s)
        {

        }
    }
}
