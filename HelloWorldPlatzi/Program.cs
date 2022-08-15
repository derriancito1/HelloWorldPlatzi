using System;
using System.Collections.Generic;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        class MisMetodos
        {
            public void IntegerAddition(int a, int b)
            {
                int Addition = a + b;
                Console.WriteLine("El resultado es " + Addition);
            }

            public int IntegerMultiplicacion(int a, int b)
            {
                int Multiplication = a * b;
                return Multiplication;
            }

            public float IntegerDivision(int a, int b)
            {
                float Division = a / b;
                return Division;
            }
        }
        static void Main(string[] args)
        {
            MisMetodos myprogram = new MisMetodos();
            myprogram.IntegerAddition(3, 9);
            Console.WriteLine("El resultado de la multiplicacion es: " + myprogram.IntegerMultiplicacion(3, 9));
            Console.WriteLine("El resultado de la division es: " + myprogram.IntegerDivision(18, 9));

        }
    }
}
