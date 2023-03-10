using System;

namespace Triangle
{
    class Program
    {
        // This program receives 2 arguments, the size of the triangle
        // and the character to draw the triangle with
        static void Main(string[] args)
        {

            int size = int.Parse(args[0]);
            
            // Goes through each line of the triangle
            for(int i = 1; i <= size ; i++)
            {
                // Prints the selected character every line,
                // incrementing once each time
                string line = new String(char.Parse(args[1]), i);
                Console.WriteLine(line);
            }
        }
    }
}
