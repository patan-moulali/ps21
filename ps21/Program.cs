using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            int num2 = 100;
            int biggestnum;
            Console.WriteLine("number 1 : " + num1);
            Console.WriteLine("number 2 : " + num2);
            if (num1 > num2)
            {

                biggestnum = num1;

            }
            else
            {
                biggestnum = num2;
            }

            Console.WriteLine("biggest number is : " + biggestnum);
            Console.Read();

        }



        
    }
}
