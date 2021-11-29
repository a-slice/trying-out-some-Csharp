using System;

namespace Traingle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            float theight = float.Parse(input[0]);
            float tbase = float.Parse(input[1]);
            float area = (theight * tbase) / 2;
            Console.WriteLine(area);
        }
    }
}
