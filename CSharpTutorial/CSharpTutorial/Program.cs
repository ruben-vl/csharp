﻿using System;
using System.IO;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
        }
    }
}