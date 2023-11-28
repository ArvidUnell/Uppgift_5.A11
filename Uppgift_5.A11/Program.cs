using System;
namespace Uppgift_5_A11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 61, 51414, -1321, 312345, 61123, -56223, 5601 };

            List<int> inputList = input.ToList();

            while (inputList.Count > input.Length/2 + 1)
            {
                inputList.Remove(inputList.Min());
            }

            Console.WriteLine($"Medianen är {inputList.Min()}");

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}