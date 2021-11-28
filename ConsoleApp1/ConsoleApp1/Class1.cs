using System;
using System.Collections.Generic;
using System.Text;

namespace csharpProblems
{
    static class Class1
    {
        public static void Switch<T>(this IList<T> array, int index1, int index2)
        {
            var temp = array[index1 - 1];
            array[index1 - 1] = array[index2 - 1];
            array[index2 - 1] = temp;
        }

        public static void Trik()
        {
            String moves = Console.ReadLine();
            int[] cups = { 1, 2, 3 };

            foreach (char move in moves)
            {
                switch (move)
                {
                    case 'A':
                        Switch(cups, 1, 2);
                        break;
                    case 'B':
                        Switch(cups, 2, 3);
                        break;
                    case 'C':
                        Switch(cups, 1, 3);
                        break;
                }
            }
            Console.WriteLine(Array.IndexOf(cups, 1) + 1);
        }
    }
}
