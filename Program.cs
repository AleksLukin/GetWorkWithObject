
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
            MyClass myOne = new();
            MyClass myTwo = new();

            myOne.x = 1;
            myTwo.x = 2;

            Console.WriteLine(myOne.x);

            myOne = myTwo;
            myTwo.x = 12;

            Console.WriteLine(myOne.x);
            Console.WriteLine(myTwo.x);
        }
    }
    class MyClass
    {
        public int x;
    }
}
