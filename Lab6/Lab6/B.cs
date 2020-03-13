using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab6
{
    class B
    {

        public string revers(string s)
        {
            for (int i = s.Length; i > 0; i--)
            {

            }
        }

        public string start()
        {
            string[] predlogs;
            StreamReader sr = new StreamReader("predlogs.txt",Encoding.GetEncoding(866));
            predlogs = sr.ReadToEnd().Split('\n');

            string[] s = Console.ReadLine().Split(' ');
            bool chet = false;

            foreach (string i in s)
            {
                if (!predlogs.Contains(i))
                {
                    if (chet)
                    {
                        Console.Write(revers(i) + ' ');
                        chet = false;
                    }
                    else
                    {
                        Console.Write(i + ' ');
                        chet = true;
                    }
                } 
            }



            return "1";
        }
    }
}
