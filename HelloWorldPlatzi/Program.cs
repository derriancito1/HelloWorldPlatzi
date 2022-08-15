using System;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] coffeTypes;
            float[] coffePrices;

            coffeTypes = new string[] {"Express", "Largo", "Filtrado", "Latte"};
            coffePrices = new float[] { 1.2f, 1.5f, 5.0f, 5.5f};

            coffeTypes[1] = "Lungo";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(coffeTypes[i] + " Coffe $" + coffePrices[i]);
            }

        }
    }
}
