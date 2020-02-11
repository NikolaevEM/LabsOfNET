using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A
{
    class Class1
    {
        public int encoder(string path1, string path2)
        {
            StreamReader file1 = new StreamReader(path1, Encoding.GetEncoding(866));
            string text = file1.ReadToEnd();
            string ntext = text.Replace("old", "new");
            file1.Close();

            StreamWriter file2 = new StreamWriter(path2, false, Encoding.GetEncoding(1251));
            file2.Write(ntext);
            file2.Flush();
            file2.Close();

            return 1;
        }

        public int counter(string path)
        {
            StreamReader file1 = new StreamReader(path, Encoding.GetEncoding(1251));
            string text = file1.ReadToEnd();
            string[] text1 = text.Split(' ');
            file1.Close();
            Console.WriteLine("В тексте " + text1.Length + " слов");

            int s = 0;
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == 'о' || text[i] == 'О')
                {
                    s++;
                }
            }

            Console.WriteLine("В тексте " + s + " букв о");

            return 1;
        }

        public int direct(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            DirectoryInfo[] diArr = di.GetDirectories();
            Console.WriteLine("\nКаталог " + di + ":");

            Console.WriteLine("= Подкаталоги:");
            foreach (DirectoryInfo i in diArr)
                Console.WriteLine("  - " + i.Name);
            Console.WriteLine("= Файлы:");
            foreach (FileInfo i in fi)
                Console.WriteLine("  - " + i.Name);

            return 1;
        }

    }
}
