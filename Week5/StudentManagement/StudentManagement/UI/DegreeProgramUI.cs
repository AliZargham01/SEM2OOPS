using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.BL;

namespace StudentManagement.UI
{
    class DegreeProgramUI
    {
        public void addDegree()
        {
            Console.Write("Enter Degree Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Degree Duration : ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter How Many Subects To Enter : ");
            int num = int.Parse(Console.ReadLine());
            for(int x = 0; x < num; x++)
            {
                Subjects s = SubjectUI.addSubject();
            }

        }
    }
}
