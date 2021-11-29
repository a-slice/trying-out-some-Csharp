using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int mb = x;
            int count = 0;
            while (count < n)
            {
                int used = int.Parse(Console.ReadLine());
                mb -= used;
                count += 1;
                mb += x;
            }
            Console.WriteLine(mb);
        }
    }
}
