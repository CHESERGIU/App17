using System;

namespace App17
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            double first = Convert.ToSingle(inputData);
            inputData = Console.ReadLine();
            double second = Convert.ToSingle(inputData);
            double price = second < 14 ? (first / 2) : first;
            Console.WriteLine(price);
        }
    }
}
