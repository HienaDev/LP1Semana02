using System;
using System.Text;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            while(true)
            {
                string question;

                Console.Write("\nAsk me anything:\n\n");
                question = Console.ReadLine();

                string response = question switch
                {
                    "Hello" => "Hi there! How are you?",
                    "I'm good, you?" => "Im great =)",
                    "What do you think about elephants?" => "They are heavy",
                    "Make me a tree" => "tree",
                    "EXIT" => "exit",
                    _ => "I don't understand your question",
                };

                // Responder adequadamente
                if (response == "exit")
                    break;
                else if(response == "tree")
                {
                    Console.Write("How big is the tree?\n");
                    int size = int.Parse(Console.ReadLine());

                    int max_size = size + size - 1;

                    Console.Write("\n");
                    
                    for (int i = 1; i <= size; i++)
                    {
                        int checker = i + i - 1;

                        for (int x = 0; x < size - i; x++)
                            Console.Write(" ");
                        for (int x = 0; x < checker; x++)
                            if (i == 1)
                                Console.Write("\u2605");
                            else
                                Console.Write("*");
                        for (int x = 0; x < size - i; x++)
                            Console.Write(" ");

                        Console.Write("\n");
                    }
                }
                else 
                    Console.WriteLine(response);
            }
        }
    }
}
