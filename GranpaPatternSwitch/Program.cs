using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            string response = question switch
            {
                "How are you?" => "I'm fine, thank you",
                "What's your name?" => "Gran'pa",
                "What's your mission?" => "Destroy mankind!",
                _ => "You got me, I'm not THAT smart!",
            };

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
