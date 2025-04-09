using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Clocktype
    {
        public int h;
        public int m;
        public int s;
        public Clocktype()
        {

        }
        public Clocktype(int h, int m, int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }
        public int ElapsedTime(Clocktype t)
        {
            int s = (t.h*3600) + (t.m*60) + t.s;
            return s;
        }
        public int remainingTime(Clocktype t)
        {
            int sec = (24 * 3600)-((t.h * 3600) + (t.m * 60) + t.s) ;
            return sec;
        }
        public void timePassed(Clocktype time,int h, int m, int s)
        {
            int hour = 0;
            int min = 0;
            int sec = 0;
            if (time.h > h)
            {
                hour = time.h - h;
            }
            else
            {
                 hour = h - time.h;
            }
            if (time.s > s)
            {
                 sec = time.s - s;
            }
            else
            {
                 sec = s - time.s;
            }
            if (time.h > h)
            {
                 min = time.m - m;
            }
            else
            {
                 min = m - time.m;
            }
            Console.WriteLine($"{hour} : {min} : {sec}");
        }
    }
}
