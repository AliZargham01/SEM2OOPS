using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.BL;

namespace StudentManagement.DL
{
    class DegreeProgramDL
    {
        public List<DegreePrograms> programs = new List<DegreePrograms>();

        public void addDegree(DegreePrograms d)
        {
            programs.Add(d);
        }
    }
}
