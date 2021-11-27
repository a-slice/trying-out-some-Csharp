using System;

namespace csharpProblems
{
    class Trik
    {
        static void Main(string[] args)
        {
            String moves = Console.ReadLine();
            int location = 1;
            foreach(char move in moves)
                {switch (location)
                {
                    case 1:
                        switch (move)
                        {
                            case 'A':
                                location++;
                                break;
                            case 'C':
                                location += 2;
                                break;
                        }
                        break;
                    case 2:
                        switch (move)
                        {
                            case 'A':
                                location--;
                                break;
                            case 'B':
                                location++;
                                break;
                        }
                        break;
                    case 3:
                        switch (move)
                        {
                            case 'B':
                                location--;
                                break;
                            case 'C':
                                location -= 2;
                                break;
                        }
                        break;
                }

                }
            Console.WriteLine(location);
        }
    }
}
