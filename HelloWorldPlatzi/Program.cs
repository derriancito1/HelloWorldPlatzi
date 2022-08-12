using System;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's you name? Please write your full name");
            string fullUserName = Console.ReadLine();
            Console.WriteLine("Hello!! " + fullUserName + ", Welcome to platzi");

        }
    }
}
