using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BL
{
    class Subjects
    {
        public string code;
        public int cr;
        public string subjectType;
        public int fee;
        public Subjects(string code, int cr, string subjectType, int fee)
        {
            this.code = code;
            this.cr = cr;
            this.subjectType = subjectType;
            this.fee = fee;
        }
    }
}
