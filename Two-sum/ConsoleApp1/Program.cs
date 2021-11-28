using System;

namespace Twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[1]);
            int total = first + second;
            Console.WriteLine(total);
        }
    }
}
