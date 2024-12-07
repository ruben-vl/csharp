using System;
using System.Linq;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }

        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
    }
}