﻿using System;

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
            // bool myBool = true;
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

            long myLong = 1500000000L;
            Console.WriteLine(myLong);

            float myFloat = 5.75F;
            Console.WriteLine(myFloat);

            // double myDouble = 19.99D;
            // Console.WriteLine(myDouble);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            char myGrade = 'B';
            Console.WriteLine(myGrade);

            string greeting = "Hello World";
            Console.WriteLine(greeting);

            // int myInt = 9;
            // double myDouble = myInt;
            // Console.WriteLine(myInt);
            // Console.WriteLine(myDouble);

            // double myDouble = 9.78;
            // int myInt = (int) myDouble;
            // Console.WriteLine(myDouble);
            // Console.WriteLine(myInt);

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}