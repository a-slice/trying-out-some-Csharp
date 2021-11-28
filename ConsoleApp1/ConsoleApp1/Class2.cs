using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace csharpProblems
{
    static class Class2
    {
        static void Switch<T>(this IList<T> array, int index1, int index2)
        {
            var temp = array[index1 - 1];
            array[index1 - 1] = array[index2 - 1];
            array[index2 - 1] = temp;
        }
        static void Main(string[] args) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

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
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}

