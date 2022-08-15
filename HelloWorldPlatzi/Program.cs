using System;
using System.Collections.Generic;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tacoShippingList = new List<string>();

            tacoShippingList.Add("Cinco tacos de suadero");
            tacoShippingList.Add("Cuatro tacos de tripa");
            tacoShippingList.Add("Cinco tacos de pastor");
            tacoShippingList.Add("Cuatro Coca Colas");

            for (int i = 0; i < tacoShippingList.Count; i++)
            {
                Console.WriteLine(tacoShippingList[i]);
            }

            tacoShippingList.Remove("Cinco tacos de suadero");
            //tacoShippingList.RemoveAt(0);
            Console.WriteLine("Segunda lista \n");

            for (int i = 0; i < tacoShippingList.Count; i++)
            {
                Console.WriteLine(tacoShippingList[i]);
            }

        }
    }
}
