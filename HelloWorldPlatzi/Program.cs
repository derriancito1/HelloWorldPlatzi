using System;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int result;

            Console.WriteLine("What's you name? Please write your full name");
            string fullUserName = Console.ReadLine();
                        
            Console.WriteLine("Input the first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            result = number1 + number2;
            Console.WriteLine("Hello!! " + fullUserName + ", Welcome to platzi, the result is: " + result);

        }
    }
}
