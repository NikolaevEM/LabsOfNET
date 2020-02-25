using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 pt1 = new Class1(10);
            Class1 pt2 = new Class1(25);

            Class1 pt3 = pt1 - pt2;
            Console.WriteLine(pt3.Read);
            Console.ReadKey();
            Console.Clear();

            int n = 9;
            Solar planet = new Solar(n);
            planet[0] = new Solar("Mercury", 2);
            planet[1] = new Solar("Venera", 6);
            planet[2] = new Solar("Earth", 7);
            planet[3] = new Solar("Mars", 3);
            planet[4] = new Solar("Jupiter", 71);
            planet[5] = new Solar("Saturn", 60);
            planet[6] = new Solar("Uran", 26);
            planet[7] = new Solar("Neptun", 25);
            planet[8] = new Solar("Pluton", 1);

            for (int i = 0; i < n; i++)
            {
                if (planet[i].getR > planet[2].getR)
                {
                    Console.Write(planet[i].getName + " ");
                    Console.WriteLine(planet[i].getR);
                }
            }

            Console.ReadKey();
        }
    }
}
