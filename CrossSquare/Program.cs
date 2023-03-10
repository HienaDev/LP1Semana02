using System;

namespace CrossSquare
{
    class Program
    {
        // This program receives an argument that is the height and length
        // of a square and prints a square to the screen with a cross
        // made of crosses in the middle
        static void Main(string[] args)
        {
            // Gets the argument and converts it into an integer
            int size = int.Parse(args[0]);

            // Cycles size times to write each line
            for(int i = 1; i <= size; i++)
            {   
                // If we are on the 1st or last line it prints '#' size times
                if (i == 1 || i == size)
                {
                    string line = new String('#', size);
                    Console.WriteLine(line);
                }
                // Else it writes '#' for the 1st character of the line, 
                // then it writes either 'X' if we are at 
                // height - 1 position, and if we are on size - 1 position
                // or ' ' at every other position, then it finishes with
                // another '#'
                else
                {
                    // Writes '#' on the first position
                    Console.Write('#');

                    // Writes every other line
                    for (int x = 1; x <= size - 2; x++)
                    {
                        if (x == i - 1 || x == size - i ) 
                            Console.Write('X');
                        else
                            Console.Write(' ');
                    }

                    // Writes '#' on the last position
                    Console.WriteLine('#');
                }
            }
        }
    }
}
