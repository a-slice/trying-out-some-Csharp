using System;

namespace csharpProblems
{
    class OddEcho
    {
        static void Main(string[] args)
        {
            while (Console.ReadLine() != null) {
                String word = Console.ReadLine();
                int count = 0;
                if (count % 2 == 0)
                    {
                        Console.WriteLine(word);
                    }
                count++;
            }

        }
    }
}
