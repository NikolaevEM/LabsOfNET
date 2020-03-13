using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class A
    {
        public int start()
        {
            String num;
            int sum = 0;

            num = Console.ReadLine();

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
                sum += Convert.ToInt16(num[i]-'0');
            }

            Console.WriteLine("Сумма цифр = " + Convert.ToString(sum));

            return sum;
        }

    }
}
