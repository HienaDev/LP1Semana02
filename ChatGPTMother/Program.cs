using System;
using System.Text;

namespace ChatGPTMother
{
    class Program
    {
        // This program asks for user input and responds according to the
        // user's input
        static void Main(string[] args)
        {
            // This line allows for more complex characters to be displayed
            // on the cmd line
            Console.OutputEncoding = Encoding.UTF8;

            while(true)
            {
                string question;
                
                // Asks for user input
                Console.Write("\nAsk me anything:\n\n");
                question = Console.ReadLine();
                
                //Decides what to do based on the user's input
                string response = question switch
                {
                    "Hello" => "Hi there! How are you?",
                    "I'm good, you?" => "Im great =)",
                    "What do you think about elephants?" => "They are heavy",
                    "Make me a tree" => "tree",
                    "Add 2 numbers" => "sum",
                    "How many eggs do I need for a cake?" => "At least 2",
                    "EXIT" => "exit",
                    _ => "I don't understand your question",
                };

                // Responds to the questions

                // Stops the program if the user inputs EXIT
                if (response == "exit")
                    break;
                // Draws a tree if the user asked for it
                else if(response == "tree")
                {
                    // Asks how big the tree should be and gets user input
                    Console.Write("How big is the tree?\n");
                    int size = int.Parse(Console.ReadLine());

                    Console.Write("\n");
                    
                    // This cycle happens size times
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
                else if (response == "sum")
                {
                    Console.Write("Yes! What numbers?\n");
                    Console.Write("N1: ");

                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("N2: ");

                    int n2 = int.Parse(Console.ReadLine());

        
                    Console.Write($"The sum of {n1} and {n2} is {n1 + n2}");
                }
                else 
                    Console.WriteLine(response);
            }
        }
    }
}
