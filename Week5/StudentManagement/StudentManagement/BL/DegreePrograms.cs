using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BL
{
    class DegreePrograms
    {
        public string title;
        public float duration;
        public int rooms;
        public List<Subjects> subjects = new List<Subjects>();

        public DegreePrograms(string title, float duration,int rooms, List<Subjects> subjects)
        {
            this.title = title;
            this.duration = duration;
            this.rooms = rooms;
            this.subjects = subjects;
        }
    }
}
