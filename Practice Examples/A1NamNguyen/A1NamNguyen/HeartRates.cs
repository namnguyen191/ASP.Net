using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A1NamNguyen
{
    public class HeartRates
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Yob { get; set; }
        public string Gender { get; set; }

        public HeartRates(string fname, string lname, int yob)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Yob = yob;
        }

       public int Age()
        {
            int age = DateTime.Now.Year - this.Yob;
            return age;
        }

        public int MaxHeartRate()
        {
            int mhr;
            if (this.Gender == "Male") mhr = 220 - Age();
            else mhr = 226 - Age();
            return mhr;
        }

        public int TargetMax()
        {
            int tgm = MaxHeartRate() * 70 / 100;
            return tgm;
        }

        public int TargetMin()
        {
            int tgmin = MaxHeartRate() * 55 / 100;
            return tgmin;
        }

    }
}