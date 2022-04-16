
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetWorkWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "12";
            int number = 123;

            DoWork(str);
            DoAnotherWork(number);

            Console.WriteLine(str);
            Console.WriteLine(number);
        }

        static void DoWork(string referenceStr)
        {
            referenceStr = "12345";
        }
        static void DoAnotherWork(int valueInteger)
        {
            valueInteger = 1234;
        }
    }
}
