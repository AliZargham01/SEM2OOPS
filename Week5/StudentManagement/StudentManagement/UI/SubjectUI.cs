using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.BL;

namespace StudentManagement.UI
{
    class SubjectUI
    {
        public static Subjects addSubject()
        {
            Console.Write("Enter Degree Code : ");
            string name = Console.ReadLine();
            Console.Write("Enter Type : ");
            string type = Console.ReadLine();
            Console.Write("Enter Credit Hours : ");
            int cr = int.Parse(Console.ReadLine());
            Console.Write("Enter Fee : ");
            int fee = int.Parse(Console.ReadLine());
            Subjects s = new Subjects(name, cr, type, fee);
            return s;
        }
    }
}
