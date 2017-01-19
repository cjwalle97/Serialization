using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serialization
{
    class Student
    {
        private string mName;
        private int mAge;
        private string mID;

        public Student() { }
        public Student(string n, int a, string i)
        {
            mName = n;
            mAge = a;
            mID = i;
        }
        public string NAME
        {
            get
            {
                return mName;
            }
            set
            {
                mName = null;
            }
        }

        public int AGE
        {
            get
            {
                return mAge;
            }
            set
            {
                mAge = 0;
            }
        }
        public string ID;
    }
}