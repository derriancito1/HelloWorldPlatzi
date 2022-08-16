using System;
using System.Collections.Generic;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyValue = 14;
            string message = "";
            if (anyValue == 7)
            {
                message = "OMG it's a miracle the value is 7";
            }else if (anyValue==14){
                message = "OMG, it's a double miracle the value is 14";
            }
            else
            {
                message = "Puff, the value wasn't 7";
            }
            Console.WriteLine($"The answer is> {message}");

        }
    }
}
