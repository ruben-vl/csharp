using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            string[] temp;
            temp = new string[] {"Volvo", "BMW", "Ford"};
        }
    }
}