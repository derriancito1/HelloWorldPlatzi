using System;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the side a of A the rectangle, yo can use decimals");
            float sideA = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the side a of B the rectangle, yo can use decimals");
            float sideB = float.Parse(Console.ReadLine());

            float area = sideA * sideB;

            Console.WriteLine("The rectangule area is: " + area);

        }
    }
}
