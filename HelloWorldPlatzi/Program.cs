using System;
using System.Collections.Generic;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] pricesArray;

            pricesArray = new float[10];
            pricesArray[0] = 1.5f;
            pricesArray[1] = 2.5f;
            pricesArray[2] = 3f;
            pricesArray[3] = 5f;

            Random random = new Random();
            Console.WriteLine("Hello world, of random numbers!");
            Console.WriteLine($"{random.Next(1,10)}");

        }
    }
}
