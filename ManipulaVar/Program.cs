using System;

namespace ManipulaVar
{ 
    class Program
    {
        // This program receives an argument and prints the value after and 
        // before itself
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);

            x++;

            Console.WriteLine(x);

            x = int.Parse(args[0]);

            --x;
            
            Console.WriteLine(x);
        }
    }
}
