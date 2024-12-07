using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello";
            Console.WriteLine(myString[1]);

            Console.WriteLine(myString.IndexOf("e"));

            string name = "John Doe";
            int charPos = name.IndexOf("D");
            string lastName = name.Substring(charPos);
            Console.WriteLine(lastName);
        }
    }
}