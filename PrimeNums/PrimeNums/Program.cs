using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <=100; counter++)
            {
                bool flag = true;
                for (int prime = 2; prime <= counter - 1; prime++)
                {
                    if (counter % prime == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(counter);
                }
            }
            Console.ReadLine();
        }
    }
}
