using System;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Mustang";
            myCar.Year = 2010;
            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}
