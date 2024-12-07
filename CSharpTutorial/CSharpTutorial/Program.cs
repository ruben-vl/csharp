using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");

            Console.WriteLine(3 + 3);

            Console.Write("Hello World! ");
            Console.WriteLine("I will print on the same line.");

            string name = "John";
            Console.WriteLine("Hello " + name);

            const int myNum = 15;
            // myNum = 20;
            Console.WriteLine(myNum);

            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(a + b + c);
        }
    }
}