using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A
{
    class Program
    {
        static void Main()
        {
            Class1 cl1 = new Class1();

            cl1.encoder("Task1.txt", "Task1_new.txt");
            cl1.counter("Task2.txt");

            System.Console.WriteLine("Ready");
            System.Console.ReadKey();
        }
    }
}
