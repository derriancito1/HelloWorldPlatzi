using System;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 3;
            int value2 = 18;
            int value3 = -18;

            bool result0 = value1 == value2;
            bool result1 = value1 != value2;
            bool result2 = value1 > value2;
            bool result3 = value1 < value2;
            bool result4 = value1 >= value2;
            bool result5 = value1 <= value2;

            Console.WriteLine("The result of " + value1 + " == " + value2 + " is: " + result0);
            Console.WriteLine("The result of " + value1 + " != " + value2 + " is: " + result1);
            Console.WriteLine("The result of " + value1 + " > " + value2 + " is: " + result2);
            Console.WriteLine("The result of " + value1 + " < " + value2 + " is: " + result3);
            Console.WriteLine("The result of " + value1 + " >= " + value2 + " is: " + result4);
            Console.WriteLine("The result of " + value1 + " <= " + value2 + " is: " + result5);

            /*
             *  == igual a
             *  != no ingual a 
             *  > mayor que 
             *  < menor que 
             *  >= mayor o igual que 
             *  <= menor o igual que 
             */


        }
    }
}
