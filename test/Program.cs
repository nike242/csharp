using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int goodnumcount = 0;
            int minnum = 1;
            int maxnum = 1000000000;
            int temp;
            int testnum;

            for (int num = minnum; num <= maxnum; num++)
            {
                temp = 0;
                testnum = num;
                while (testnum != 0)
                {
                    temp += testnum % 10;
                    testnum /= 10;
                }
                if (num % temp == 0)
                {
                    Console.WriteLine(num);
                    goodnumcount++;
                }
            }
            Console.WriteLine(goodnumcount);
        }
    }
}
