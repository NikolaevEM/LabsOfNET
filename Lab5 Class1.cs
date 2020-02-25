using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5NET
{
    class Class1
    {
        private int x;
        public Class1(int _x)
        {
            x = _x;
        }
        public static Class1 operator -(Class1 pl1, Class1 pl2)
        {
            Class1 newClass1 = new Class1(pl1.x + pl2.x);
            return newClass1;
        }
        public int Read
        {
            get { return x; }
        }
    }

    class Solar
    {
        private int r;
        private string name;
        private Solar[] sArray;

        public Solar(int len)
        {
            sArray = new Solar[len];
        }
        public Solar(string _name, int _r)
        {
            name = _name;
            r = _r;
        }

        public Solar this[int pos]
        {
            get { return sArray[pos]; }
            set { sArray[pos] = value; }
        }

        public int getR
        {
            get { return this.r; }
        }
        public string getName
        {
            get { return this.name; }
        }

    }

}
