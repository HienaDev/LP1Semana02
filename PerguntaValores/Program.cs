using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.1415926f;

            Console.WriteLine("Whats the height of the cylinder? \n ");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nWhats the radius of the cylinder? \n ");
            float radius = Convert.ToSingle(Console.ReadLine());

            float volume = pi * (radius * radius) * height;
            float surface_area = 2 * pi * radius * (radius + height);

            Console.WriteLine($"\nVolume: {volume}");
            Console.WriteLine($"Surface Area: {surface_area}");
        }
    }
}
